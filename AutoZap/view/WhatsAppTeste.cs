using SQLiteBAL.Common.DataShapes;
using SQLiteBAL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WhatsAppApi.Account;
using WhatsAppApi.Helper;
using WhatsAppApi.Parser;
using WhatsAppApi.Response;
using WhatsAppApi;

namespace AutoZap.view
{
    public partial class WhatsAppTeste : Form
    {
        public TbConfig TbConfig { get; set; }
        WhatsAppService ws = null;

        public WhatsAppTeste()
        {
            InitializeComponent();
            WhatsEventHandler.MessageRecievedEvent += WhatsEventHandlerOnMessageRecievedEvent;
           
            
        }

        private void WhatsEventHandlerOnMessageRecievedEvent(WhatsAppApi.Parser.FMessage mess)
        {
            this.log(String.Format("{0}: {1}", mess.identifier_key.remote_jid, mess.data));
        }

        private void WhatsAppTeste_Load(object sender, EventArgs e)
        {
            ws = new WhatsAppService();

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(TbConfig.username) || String.IsNullOrEmpty(TbConfig.password) || String.IsNullOrEmpty(TbConfig.nickname))
            { 
                MessageBox.Show(String.Format("Ocorreu uma falha:\n{0}", "Favor parametrizar todos os campos de conexão."), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(txtTel.Text) || !Regex.IsMatch(txtTel.Text, "^[0-9]*$"))
            {
                MessageBox.Show(String.Format("Ocorreu uma falha:\n{0}", "Informe o numero do telefone de um usuário WhatsApp para que possa ser enviado uma mensagem."), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                ws.Conect(TbConfig.username, TbConfig.password, TbConfig.nickname);

                if (ws.Status == WhatsAppService.CONNECTION_STATUS.CONNECTED || ws.Status == WhatsAppService.CONNECTION_STATUS.LOGGEDIN)
                    log("Conectado.");
                
                if (ws.Status == WhatsAppService.CONNECTION_STATUS.UNAUTHORIZED)
                {
                    log(String.Format("{0}: Não autorizado - reveja o número ou a senha.", TbConfig.username));
                    return;
                }

                if (ws.Status == WhatsAppService.CONNECTION_STATUS.DISCONNECTED)
                {
                    log("Desconectado");
                    return;
                }

               

                //ws.UpdateListUser();
                //ws.UpdateListGroup();

                sendMessage.Enabled = true;

            }
            catch (Exception ex) {
                
                if (ws.Status == WhatsAppService.CONNECTION_STATUS.CONNECTED || ws.Status == WhatsAppService.CONNECTION_STATUS.LOGGEDIN)
                    ws.Desconectar();

                MessageBox.Show(String.Format("Ocorreu uma falha:\n{0}", ex.Message), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void log(string _txt)
        {

            this.txtlog.AppendText(string.Format("{0}{1}", _txt, Environment.NewLine));
           
        }

        private void WhatsAppTeste_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ws.Status == WhatsAppService.CONNECTION_STATUS.CONNECTED || ws.Status == WhatsAppService.CONNECTION_STATUS.LOGGEDIN)
            {
                ws.Desconectar();
            }

            sendMessage.Enabled = false;
        }

        private void sendMessage_Tick(object sender, EventArgs e)
        {
            if (ws.Status == WhatsAppService.CONNECTION_STATUS.CONNECTED || ws.Status == WhatsAppService.CONNECTION_STATUS.LOGGEDIN)
            {
                ws.EnviarMensagem(new WhatsAppService.WhatsAppUser() { Nickname = "Cliente", Username = txtTel.Text }, "Oi! agora são " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));

                if (ws.Instance.HasMessages())
                {
                    //ws.Instance.                  
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }
    }
}
