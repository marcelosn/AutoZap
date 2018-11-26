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
    public partial class Gatilho : Form
    {
        TbConfig tbconfig;
         BindingSource _bind;

        public Gatilho()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using(view.EditGatilho ed = new EditGatilho()){
                ed.Actions = EditGatilho.EditOption.New;
                ed.HttpPort = tbconfig.httpport;
                ed.TpServer = tbconfig.tpserver;
                ed.ShowDialog();
            }

            UpdateGrid();
        }

        private void Gatilho_Load(object sender, EventArgs e)
        {
            tbconfig = (new OpcoesService()).Get();

            _bind = new BindingSource();
            dgvGatilho.DataSource = _bind;

            UpdateGrid();
        }

        private void UpdateGrid()
        {
            _bind.DataSource = (new GatilhoService()).Get();
            _bind.ResetBindings(false);
        }

        private void dgvGatilho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //Excluir
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                var _c = MessageBox.Show(String.Format("Realmente deseja excluir o gatilho '{0}' ?", dgvGatilho.Rows[e.RowIndex].Cells[4].Value.ToString()), this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (_c == System.Windows.Forms.DialogResult.Yes)
                {
                    //MessageBox.Show("Excluir " + gdvContatos.Rows[e.RowIndex].Cells[2].Value.ToString());
                    (new GatilhoService()).Delete(new TbGatilho() { id = long.Parse(dgvGatilho.Rows[e.RowIndex].Cells[2].Value.ToString()) });
                    UpdateGrid();
                }
            }

            //Editar
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                using (view.EditGatilho ed = new EditGatilho())
                {
                    ed.Actions = EditGatilho.EditOption.Update;
                    ed.HttpPort = tbconfig.httpport;
                    ed.TpServer = tbconfig.tpserver;
                    ed.GatilhoId = long.Parse(dgvGatilho.Rows[e.RowIndex].Cells[2].Value.ToString());
                    ed.ShowDialog();
                }

                UpdateGrid();
            } 
        }
    }
}
