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
    public partial class EditGatilho : Form
    {
        TbGatilho tbgatilho;
        TbGatilhoGrupo tbgatilhogrupo;
        BindingSource _bind;
        

        GatilhoService gs;

        public enum EditOption
        {
            New,
            Update
        }
        
        public EditOption Actions { get; set; }
        public bool TpServer { get; set; }
        public int HttpPort {get; set;}
        public long GatilhoId { get; set; }

        public EditGatilho()
        {
            InitializeComponent();
        }

        private void EditGatilho_Load(object sender, EventArgs e)
        {
            gs = new GatilhoService();

            _bind = new BindingSource();
            dgvGrupos.DataSource = _bind;

            switch (Actions)
            {
                case EditOption.New:
                    this.Text = "Novo Gatilho";
                    break;
                case EditOption.Update:
                    this.Text = "Editar Gatilho";
                    tbgatilho = gs.GetSingle(GatilhoId);

                    if (tbgatilho != null)
                    {
                        rdoArq.Checked = (tbgatilho.tpgatilho == 0);
                        rdoHttp.Checked = (tbgatilho.tpgatilho == 1);
                        txtPalavraChave.Text = tbgatilho.palavrachave;
                        grpGrupo.Enabled = true;
                    }

                    UpdateList();
                    UpdateGrid();

                    break;
            }

            

            Informacao();
        }

        private void Informacao()
        {
            if (rdoArq.Checked) //Arquivo TXT
                txtInstrucao.Text = String.Format("O Sistema irá disparar mensagens quando o arquivo em formato txt com o nome '{0}.txt' estiver presente na pasta Gatilho.", txtPalavraChave.Text);
            if (rdoHttp.Checked) //Arquivo HTTP
                txtInstrucao.Text = String.Format("O Sistema irá disparar mensagens quando receber requisições no seguinte endereço 'http://<seu ip>:{0}/?key={1}&msg=<sua mensagem>' .", HttpPort, txtPalavraChave.Text);
        }

        private void rdoArq_CheckedChanged(object sender, EventArgs e)
        {
            Informacao();
        }

        private void txtPalavraChave_Leave(object sender, EventArgs e)
        {
            Informacao();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tbgatilho = null;

            tbgatilho = new TbGatilho()
            {    
                id = GatilhoId,
                palavrachave = txtPalavraChave.Text,
                tpgatilho = (rdoArq.Checked) ? 0 : (rdoHttp.Checked)? 1 : 0
            };

            if (String.IsNullOrEmpty(tbgatilho.palavrachave))
            {
                MessageBox.Show("Todos os campos são obrigatórios", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (Actions == EditOption.New)
                    GatilhoId = gs.Insert(tbgatilho);
                else
                    gs.Update(tbgatilho);

                Actions = EditOption.Update;
                grpGrupo.Enabled = true;
                UpdateList();

                MessageBox.Show("Dados Salvos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void UpdateGrid()
        {
            _bind.DataSource = (new GatilhoService()).GetListaGruposSel(TpServer, GatilhoId);
            _bind.ResetBindings(false);
        }

        private void UpdateList()
        {
            cboxGrupos.DataSource = gs.GetListaGrupos(TpServer, GatilhoId);
            cboxGrupos.DisplayMember = "Name";
            cboxGrupos.ValueMember = "Id";
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            if (cboxGrupos.SelectedIndex >= 0)
            {
                gs.InsertGrupoGatilho(new TbGatilhoGrupo()
                {
                   tpserver = TpServer,
                   groupid = (string)cboxGrupos.SelectedValue,
                   gatilho_id = GatilhoId
                });
                
                UpdateList();
                UpdateGrid();
            }
            
        }

        private void dgvGrupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Excluir
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                var _c = MessageBox.Show(String.Format("Realmente deseja excluir o grupo '{0}' deste gatilho ?", dgvGrupos.Rows[e.RowIndex].Cells[2].Value.ToString()), this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (_c == System.Windows.Forms.DialogResult.Yes)
                {
                    //MessageBox.Show("Excluir " + gdvContatos.Rows[e.RowIndex].Cells[2].Value.ToString());
                    (new GatilhoService()).DeleteGrupoGatilho(new TbGatilhoGrupo() { gatilho_id = GatilhoId, groupid = dgvGrupos.Rows[e.RowIndex].Cells[1].Value.ToString(), tpserver = TpServer});
                    UpdateGrid();
                    UpdateList();
                }
            }
        }

    }
}
