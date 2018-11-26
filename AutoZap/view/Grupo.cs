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
    public partial class Grupo : Form
    {
        TbConfig tbconfig;
        BindingSource _bind;

        public Grupo()
        {
            InitializeComponent();
        }

        private void Grupo_Load(object sender, EventArgs e)
        {
            tbconfig = (new OpcoesService()).Get();

            _bind = new BindingSource();          
            dgvGrupo.DataSource = _bind;

            UpdateGrid();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using(view.EditGrupo eg = new EditGrupo()){
                eg.Actions = EditGrupo.EditOption.New;
                eg.TpServer = tbconfig.tpserver;
                eg.ShowDialog();
            }

            UpdateGrid();
        }

        private void UpdateGrid()
        {
            _bind.DataSource = (new GrupoService()).Get(tbconfig.tpserver);
            _bind.ResetBindings(false);
        }

        private void dgvGrupo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Excluir
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                var _c = MessageBox.Show(String.Format("Realmente deseja excluir o grupo {0} ?", dgvGrupo.Rows[e.RowIndex].Cells[3].Value.ToString()), this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (_c == System.Windows.Forms.DialogResult.Yes)
                {
                    //MessageBox.Show("Excluir " + gdvContatos.Rows[e.RowIndex].Cells[2].Value.ToString());
                    (new GrupoService()).Delete(new TbGroup() { groupid = dgvGrupo.Rows[e.RowIndex].Cells[2].Value.ToString() });
                    UpdateGrid();
                }
            }

            //Editar
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                using (view.EditGrupo eg = new EditGrupo())
                {
                    eg.Actions = EditGrupo.EditOption.Update;
                    eg.TpServer = tbconfig.tpserver;
                    eg.GroupId = dgvGrupo.Rows[e.RowIndex].Cells[2].Value.ToString();
                    eg.ShowDialog();
                }

                UpdateGrid();
            }
        }
    }
}
