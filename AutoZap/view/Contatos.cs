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
    public partial class Contatos : Form
    {
        TbConfig tbconfig;
        
        BindingSource _bind;

        public Contatos()
        {
            InitializeComponent();
        }

        private void Contatos_Load(object sender, EventArgs e)
        {
            tbconfig = (new OpcoesService()).Get();
                 

            _bind = new BindingSource();
            _bind.DataSource = (new ContatosService()).Get(tbconfig.tpserver); 
            gdvContatos.DataSource = _bind;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using(view.EditContato ec = new EditContato()){
                ec.Actions = EditContato.EditOption.New;
                ec.TpServer = tbconfig.tpserver;
                ec.ShowDialog();
            }

            UpdateDataGrid();
        }

        private void gdvContatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Excluir
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                var _c = MessageBox.Show(String.Format("Realmente deseja excluir {0} - {1}?", gdvContatos.Rows[e.RowIndex].Cells[2].Value.ToString(), gdvContatos.Rows[e.RowIndex].Cells[3].Value.ToString()), this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (_c == System.Windows.Forms.DialogResult.Yes)
                {
                    //MessageBox.Show("Excluir " + gdvContatos.Rows[e.RowIndex].Cells[2].Value.ToString());
                    (new ContatosService()).Delete(new TbContatos { username = gdvContatos.Rows[e.RowIndex].Cells[2].Value.ToString() });
                    UpdateDataGrid();
                }
            }

            //Editar
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                using (view.EditContato ec = new EditContato())
                {
                    ec.Actions = EditContato.EditOption.Update;
                    ec.Username = gdvContatos.Rows[e.RowIndex].Cells[2].Value.ToString();
                    ec.TpServer = tbconfig.tpserver;
                    ec.ShowDialog();
                }

                UpdateDataGrid();
            }
        }

        private void UpdateDataGrid()
        {
            _bind.DataSource = (new ContatosService()).Get(tbconfig.tpserver);
            _bind.ResetBindings(false);
        }

    }
}
