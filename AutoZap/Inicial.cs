using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SQLiteBAL.Persistence;
using SQLiteBAL.Common;


namespace AutoZap
{
    public partial class Inicial : Form
    {

        SqlDao dao = null;

        public Inicial()
        {
            InitializeComponent();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Inicial_Load(object sender, EventArgs e)
        {
            dao = new SqlDao();
            SQLiteBAL.Persistence.Persisters.CreateStructs createStruts = new SQLiteBAL.Persistence.Persisters.CreateStructs();

            //MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory);

            //Cria banco de dados e atualiza se necessário
            if (createStruts.Create())
                createStruts.Update();                      

        }

        private void opçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(view.Opcoes o = new view.Opcoes()){
                o.ShowDialog();
            }
        }

        private void contatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (view.Contatos c = new view.Contatos())
            {
                c.ShowDialog();
            }
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(view.Grupo g = new view.Grupo()){
                g.ShowDialog();
            }
        }

        private void gatilhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(view.Gatilho g = new view.Gatilho()){
                g.ShowDialog();
            }
        }

        private void btnMenuOpcoes_Click(object sender, EventArgs e)
        {
            opçõesToolStripMenuItem_Click(null, null);
        }

        private void btnMenuUsuario_Click(object sender, EventArgs e)
        {
            contatosToolStripMenuItem_Click(null, null);
        }

        private void btnMenuGrupos_Click(object sender, EventArgs e)
        {
            gruposToolStripMenuItem_Click(null, null);
        }

        private void btnMenuGatilhos_Click(object sender, EventArgs e)
        {
            gatilhoToolStripMenuItem_Click(null, null);
        }
    }
}
