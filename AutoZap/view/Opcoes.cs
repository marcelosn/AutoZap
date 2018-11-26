using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SQLiteBAL.Persistence;
using SQLiteBAL.Common.DataShapes;
using SQLiteBAL.Services;
using SQLiteBAL.Common;
using System.ServiceProcess;

namespace AutoZap.view
{
    public partial class Opcoes : Form
    {
        TbConfig tbconfig = null;
        private StatusServico StatusService { get; set; }

        public Opcoes()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Opcoes_Load(object sender, EventArgs e)
        {
            tbconfig = (new OpcoesService()).Get();

            #region "Seleção de Opções"
            
            //TpServer
            rdoWhatsApp.Checked = !tbconfig.tpserver;
            rdoXMPP.Checked = tbconfig.tpserver;

            //Opcoes
            txtNickname.Text = tbconfig.nickname;
            txtUsername.Text = tbconfig.username;
            txtPassword.Text = tbconfig.password;
            txtServidor.Text = tbconfig.server;
            txtPorta.Text = (tbconfig.port == NullValues.NullInt) ? NullValues.NullString : tbconfig.port.ToString();

            
            //Opcoes Adicionais
            txtAutoResponse.Text = tbconfig.autoresponse;
            txtHttpPort.Text = (tbconfig.httpport == NullValues.NullInt) ? NullValues.NullString : tbconfig.httpport.ToString();
            txtEmpresaReg.Text = tbconfig.empresareg;
            txtEmailReg.Text = tbconfig.emailreg;                        
                
            #endregion



            ServicoUpdate();
 

        }

        private void ServicoUpdate()
        {
            /*var ctls = (from sc in ServiceController.GetServices()
                        select new { sc.ServiceName }).ToList();*/

            using (ServiceController ctl = ServiceController.GetServices()
                                    .FirstOrDefault(s => s.ServiceName == "AutoZapService"))
            {
                if (ctl == null)
                {
                    StatusService = StatusServico.NaoInstalado;
                    btnServico.Text = "Instalar Serviço";
                }
                else
                {
                    if (ctl.Status == ServiceControllerStatus.Running)
                    {
                        StatusService = StatusServico.Execucao;
                        btnServico.Text = "Parar Serviço";
                    }
                    else
                    {
                        StatusService = StatusServico.Parado;
                        btnServico.Text = "Iniciar Serviço";
                    }
                }
            }
        }

        enum StatusServico
        {
            NaoInstalado = 0,
            Parado = 1, 
            Execucao =2

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            tbconfig.tpserver = (rdoWhatsApp.Checked) ? false : true;
            tbconfig.nickname = txtNickname.Text;
            tbconfig.username = txtUsername.Text;
            tbconfig.password = txtPassword.Text;
            tbconfig.server = txtServidor.Text;
            tbconfig.port = (String.IsNullOrEmpty(txtPorta.Text))?NullValues.NullInt:int.Parse(txtPorta.Text);
            tbconfig.autoresponse = txtAutoResponse.Text;
            tbconfig.httpport = (String.IsNullOrEmpty(txtHttpPort.Text)) ? NullValues.NullInt : int.Parse(txtHttpPort.Text);
            tbconfig.empresareg = txtEmpresaReg.Text;
            tbconfig.emailreg = txtEmailReg.Text;

            //Salvando dados
            (new OpcoesService()).Post(tbconfig);
        }

        private void txtPorta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtHttpPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void rdoWhatsApp_CheckedChanged(object sender, EventArgs e)
        {
            ChangeUi();
        }

        private void ChangeUi()
        {
            if (rdoWhatsApp.Checked)
            {
                lblUsername.Text = "Telefone";
                txtServidor.Text = "";
                txtPorta.Text = "";
                txtUsername.Text = "";
                txtServidor.Enabled = false;
                txtPorta.Enabled = false;
                btnWhatsapp.Visible = true;

            }
            else
            {
                lblUsername.Text = "Usuário";
                txtServidor.Enabled = true;
                txtPorta.Enabled = true;
                btnWhatsapp.Visible = false;
            }
        }

        private void btnWhatsapp_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Favor digitar o numero do telefone, informando 55 e o numero.", view.Opcoes.ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using(view.WhatsAppReg w = new WhatsAppReg()){
                
                w.PhoneNum = txtUsername.Text;
                
                w.ShowDialog();

            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rdoWhatsApp.Checked)
            {
                if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                    e.Handled = true;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (rdoWhatsApp.Checked)
            {
                using(view.WhatsAppTeste w = new WhatsAppTeste()){
                    w.TbConfig = tbconfig;
                    w.ShowDialog();
                }
            }
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            if (StatusService == StatusServico.NaoInstalado)
            {
                //MessageBox.Show(System.IO.Directory.GetCurrentDirectory());

                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = (new SQLiteBAL.Common.Util()).GetFrameworkDirectory() + "InstallUtil.exe";
                startInfo.Arguments = String.Format("\"{0}\\{1}\"", System.IO.Directory.GetCurrentDirectory(), @"AutoZapService.exe") ;
                process.StartInfo = startInfo;
                process.Start();

                ServicoUpdate();
            }

            if (StatusService == StatusServico.Parado)
            {
                using (ServiceController cs = new ServiceController())
                {
                    cs.ServiceName = "AutoZapService";
                    cs.Start();
                }

                ServicoUpdate();
            }

            if (StatusService == StatusServico.Execucao)
            {
                using (ServiceController cs = new ServiceController())
                {
                    cs.ServiceName = "AutoZapService";
                    cs.Stop();
                }

                ServicoUpdate();
            }
         
        }
    }
}
