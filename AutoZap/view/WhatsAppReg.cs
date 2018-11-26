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
    public partial class WhatsAppReg : Form
    {
        public string PhoneNum { get; set; }

        public WhatsAppReg()
        {
            InitializeComponent();
        }

        private void WhatsAppReg_Load(object sender, EventArgs e)
        {
            txtTelefone.Text = PhoneNum;
        }

        private void btnRequisitar_Click(object sender, EventArgs e)
        {
            var _ret = (new WhatsAppService()).RequestCode(txtTelefone.Text);

            if (_ret.Contains("Error"))
            {
                MessageBox.Show(_ret, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_ret.Contains("Info"))
            {
                MessageBox.Show(_ret, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (_ret.Contains("Password"))
            {
                txtPassword.Text = _ret;
            }
            else { MessageBox.Show(_ret, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }

        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            var _ret = (new WhatsAppService()).ConfimCode(txtCode.Text, txtTelefone.Text);

            if (_ret.Contains("Error"))
            {
                MessageBox.Show(_ret, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_ret.Contains("Info"))
            {
                MessageBox.Show(_ret, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (_ret.Contains("Password"))
            {
                txtPassword.Text = _ret;
            }
            else { MessageBox.Show(_ret, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
        }
    }
}
