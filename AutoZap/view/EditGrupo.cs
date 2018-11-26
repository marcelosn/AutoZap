using SQLiteBAL.Common.DataShapes;
using SQLiteBAL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AutoZap.view
{
    public partial class EditGrupo : Form
    {
        TbGroup tbgroup;
        GrupoService gs;
        BindingSource _bind;

        public enum EditOption
        {
            New,
            Update
        }

       

        public EditOption Actions { get; set; }
        public bool TpServer { get; set; }
        public string GroupId { get; set; }

        public EditGrupo()
        {
            InitializeComponent();
        }

        private void EditGrupo_Load(object sender, EventArgs e)
        {
            gs = new GrupoService();

            switch (Actions)
            {
                case EditOption.New:
                    this.Text = "Novo Grupo";
                    break;
                case EditOption.Update:
                    this.Text = "Editar Grupo";
                    tbgroup = gs.GetSingle(TpServer, GroupId);
                    if (tbgroup != null)
                    {
                        txtCodGrupo.Text = tbgroup.groupid;
                        txtNomeGrupo.Text = tbgroup.groupname;                        
                    }
                    break;
            }

            
            BloqueiaEdicao();

            _bind = new BindingSource();            
            dgvGrupo.DataSource = _bind;
        }

        private void BloqueiaEdicao()
        {
            txtCodGrupo.ReadOnly = (Actions == EditOption.Update);            
            grpAlerta.Visible = !TpServer;
            
            if (!Regex.IsMatch(txtCodGrupo.Text, "^[0-9]*-[0-9]*$"))
            {
                if (!tabControl1.TabPages.Contains(tabPage2))
                    tabControl1.TabPages.Add(tabPage2);
            }
            else
            {
                if (tabControl1.TabPages.Contains(tabPage2))
                    tabControl1.TabPages.Remove(tabPage2);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tbgroup = null;

            tbgroup = new TbGroup()
            {
                groupid = txtCodGrupo.Text,
                groupname = txtNomeGrupo.Text,
                tpserver = TpServer
            };

            if (String.IsNullOrEmpty(tbgroup.groupid) || String.IsNullOrEmpty(tbgroup.groupname))
            {
                MessageBox.Show("Todos os campos são obrigatórios", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (Actions == EditOption.New)
                    gs.Insert(tbgroup);
                else
                    gs.Update(tbgroup);

                Actions = EditOption.Update;
                BloqueiaEdicao();

                MessageBox.Show("Dados Salvos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.None);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtCodGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!TpServer)
            {
                if (!Regex.IsMatch(txtCodGrupo.Text, "^[0-9]*-[0-9]*$"))
                {
                    if (!tabControl1.TabPages.Contains(tabPage2))
                        tabControl1.TabPages.Add(tabPage2);
                }
                else
                {
                    if (tabControl1.TabPages.Contains(tabPage2))
                        tabControl1.TabPages.Remove(tabPage2);
                }
                
            }
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2 && Actions == EditOption.Update)
            {
                cboxContatos.DataSource = gs.GetListaContatos(TpServer, tbgroup.groupid);
                cboxContatos.DisplayMember = "Name";
                cboxContatos.ValueMember = "Id";

                UpdateGrid();
            }
        }

        private void UpdateGrid()
        {
            //Atualizar Grade
            _bind.DataSource = (new GrupoService()).GetContatosGrupo(TpServer, tbgroup.groupid);
            _bind.ResetBindings(false);
        }

        private void btnAddUserGroup_Click(object sender, EventArgs e)
        {
            if (cboxContatos.SelectedIndex >= 0)
            {
                gs.InsertGrupoUsuario(new TbGroupContatos()
                {
                    groupid = tbgroup.groupid,
                    username = (string)cboxContatos.SelectedValue,
                    tpserver = TpServer
                });
   
                tabControl1_SelectedIndexChanged(null, null);
            }

        }

        private void dgvGrupo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Excluir
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                var _c = MessageBox.Show(String.Format("Realmente deseja excluir o usuário '{0}' deste grupo ?", dgvGrupo.Rows[e.RowIndex].Cells[2].Value.ToString()), this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (_c == System.Windows.Forms.DialogResult.Yes)
                {
                    //MessageBox.Show("Excluir " + gdvContatos.Rows[e.RowIndex].Cells[2].Value.ToString());
                    (new GrupoService()).DeleteUsuarioGrupo(new TbGroupContatos() { groupid = GroupId, tpserver = TpServer, username = dgvGrupo.Rows[e.RowIndex].Cells[1].Value.ToString() });
                    tabControl1_SelectedIndexChanged(null, null);
                }
            }
        }
    }
}
