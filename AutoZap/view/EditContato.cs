using SQLiteBAL.Common.DataShapes;
using SQLiteBAL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoZap.view
{
    public partial class EditContato : Form
    {
        TbContatos tbcontatos;
        ContatosService cs;

        public enum EditOption
        {
            New,
            Update
        }

        public EditOption Actions { get; set; }
        public bool TpServer { get; set; }
        public string Username { get; set; }

        public EditContato()
        {
            InitializeComponent();
        }

        private void EditContato_Load(object sender, EventArgs e)
        {
            cs = new ContatosService();

            switch (Actions)
            {
                case EditOption.New:
                    this.Text = "Novo Contato";
                    break;
                case EditOption.Update:
                    this.Text = "Editar Contato";
                    tbcontatos = cs.GetSingle(TpServer, Username);
                    if(tbcontatos != null){
                        txtNickname.Text = tbcontatos.nickname;
                        txtUsername.Text = tbcontatos.username;
                        txtUsername.ReadOnly = true;
                    }
                    break;                             
            }

            if (!TpServer)
                lblUsername.Text = "Telefone (Adicione o 55 código do Brasil)";
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!TpServer)
            {
                if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                    e.Handled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            tbcontatos = new TbContatos() { username = txtUsername.Text,
                                             nickname = txtNickname.Text, 
                                             tpserver = TpServer };

            if (String.IsNullOrEmpty(tbcontatos.nickname) || String.IsNullOrEmpty(tbcontatos.username))
            {
                MessageBox.Show("Todos os campos são obrigatórios", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            try
            {
                if (Actions == EditOption.New)
                    cs.Insert(tbcontatos);
                else
                    cs.Update(tbcontatos);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

       
    }
}
