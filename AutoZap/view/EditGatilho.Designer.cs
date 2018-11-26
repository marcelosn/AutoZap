namespace AutoZap.view
{
    partial class EditGatilho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpTpGatilho = new System.Windows.Forms.GroupBox();
            this.rdoHttp = new System.Windows.Forms.RadioButton();
            this.rdoArq = new System.Windows.Forms.RadioButton();
            this.txtPalavraChave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtInstrucao = new System.Windows.Forms.TextBox();
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            this.grpGrupo = new System.Windows.Forms.GroupBox();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxGrupos = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.grupoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTpGatilho.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            this.grpGrupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTpGatilho
            // 
            this.grpTpGatilho.Controls.Add(this.rdoHttp);
            this.grpTpGatilho.Controls.Add(this.rdoArq);
            this.grpTpGatilho.Location = new System.Drawing.Point(12, 12);
            this.grpTpGatilho.Name = "grpTpGatilho";
            this.grpTpGatilho.Size = new System.Drawing.Size(150, 68);
            this.grpTpGatilho.TabIndex = 0;
            this.grpTpGatilho.TabStop = false;
            this.grpTpGatilho.Text = "Tipo Gatilho";
            // 
            // rdoHttp
            // 
            this.rdoHttp.AutoSize = true;
            this.rdoHttp.Location = new System.Drawing.Point(6, 42);
            this.rdoHttp.Name = "rdoHttp";
            this.rdoHttp.Size = new System.Drawing.Size(97, 17);
            this.rdoHttp.TabIndex = 1;
            this.rdoHttp.Text = "HTTP Request";
            this.rdoHttp.UseVisualStyleBackColor = true;
            // 
            // rdoArq
            // 
            this.rdoArq.AutoSize = true;
            this.rdoArq.Checked = true;
            this.rdoArq.Location = new System.Drawing.Point(6, 19);
            this.rdoArq.Name = "rdoArq";
            this.rdoArq.Size = new System.Drawing.Size(91, 17);
            this.rdoArq.TabIndex = 0;
            this.rdoArq.TabStop = true;
            this.rdoArq.Text = "Arquivo Texto";
            this.rdoArq.UseVisualStyleBackColor = true;
            this.rdoArq.CheckedChanged += new System.EventHandler(this.rdoArq_CheckedChanged);
            // 
            // txtPalavraChave
            // 
            this.txtPalavraChave.Location = new System.Drawing.Point(180, 31);
            this.txtPalavraChave.Name = "txtPalavraChave";
            this.txtPalavraChave.Size = new System.Drawing.Size(246, 20);
            this.txtPalavraChave.TabIndex = 1;
            this.txtPalavraChave.Leave += new System.EventHandler(this.txtPalavraChave_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Palavra Chave";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.txtInstrucao);
            this.groupBox2.Location = new System.Drawing.Point(12, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 71);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Instruções";
            // 
            // txtInstrucao
            // 
            this.txtInstrucao.BackColor = System.Drawing.SystemColors.Info;
            this.txtInstrucao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInstrucao.Location = new System.Drawing.Point(6, 19);
            this.txtInstrucao.Multiline = true;
            this.txtInstrucao.Name = "txtInstrucao";
            this.txtInstrucao.ReadOnly = true;
            this.txtInstrucao.Size = new System.Drawing.Size(402, 46);
            this.txtInstrucao.TabIndex = 0;
            this.txtInstrucao.TabStop = false;
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.AllowUserToAddRows = false;
            this.dgvGrupos.AllowUserToDeleteRows = false;
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excluir,
            this.grupoid,
            this.Grupo});
            this.dgvGrupos.Location = new System.Drawing.Point(6, 63);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.ReadOnly = true;
            this.dgvGrupos.RowHeadersVisible = false;
            this.dgvGrupos.Size = new System.Drawing.Size(402, 173);
            this.dgvGrupos.TabIndex = 4;
            this.dgvGrupos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupos_CellContentClick);
            // 
            // grpGrupo
            // 
            this.grpGrupo.Controls.Add(this.btnAddGroup);
            this.grpGrupo.Controls.Add(this.label2);
            this.grpGrupo.Controls.Add(this.cboxGrupos);
            this.grpGrupo.Controls.Add(this.dgvGrupos);
            this.grpGrupo.Enabled = false;
            this.grpGrupo.Location = new System.Drawing.Point(12, 163);
            this.grpGrupo.Name = "grpGrupo";
            this.grpGrupo.Size = new System.Drawing.Size(414, 242);
            this.grpGrupo.TabIndex = 5;
            this.grpGrupo.TabStop = false;
            this.grpGrupo.Text = "Grupos do Gatilho";
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Image = global::AutoZap.Properties.Resources.plus_octagon;
            this.btnAddGroup.Location = new System.Drawing.Point(377, 31);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(31, 26);
            this.btnAddGroup.TabIndex = 7;
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Grupos";
            // 
            // cboxGrupos
            // 
            this.cboxGrupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGrupos.FormattingEnabled = true;
            this.cboxGrupos.Location = new System.Drawing.Point(6, 35);
            this.cboxGrupos.Name = "cboxGrupos";
            this.cboxGrupos.Size = new System.Drawing.Size(365, 21);
            this.cboxGrupos.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Image = global::AutoZap.Properties.Resources.cancel;
            this.button1.Location = new System.Drawing.Point(351, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sair";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::AutoZap.Properties.Resources.disk;
            this.btnSave.Location = new System.Drawing.Point(270, 411);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Salvar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Excluir
            // 
            this.Excluir.FillWeight = 30F;
            this.Excluir.HeaderText = "    ";
            this.Excluir.Image = global::AutoZap.Properties.Resources.cross;
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Width = 30;
            // 
            // grupoid
            // 
            this.grupoid.DataPropertyName = "Id";
            this.grupoid.HeaderText = "Grupoid";
            this.grupoid.Name = "grupoid";
            this.grupoid.ReadOnly = true;
            this.grupoid.Visible = false;
            // 
            // Grupo
            // 
            this.Grupo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Grupo.DataPropertyName = "Name";
            this.Grupo.HeaderText = "Grupo";
            this.Grupo.Name = "Grupo";
            this.Grupo.ReadOnly = true;
            // 
            // EditGatilho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 446);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpGrupo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPalavraChave);
            this.Controls.Add(this.grpTpGatilho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditGatilho";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditGatilho";
            this.Load += new System.EventHandler(this.EditGatilho_Load);
            this.grpTpGatilho.ResumeLayout(false);
            this.grpTpGatilho.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            this.grpGrupo.ResumeLayout(false);
            this.grpGrupo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTpGatilho;
        private System.Windows.Forms.RadioButton rdoHttp;
        private System.Windows.Forms.RadioButton rdoArq;
        private System.Windows.Forms.TextBox txtPalavraChave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtInstrucao;
        private System.Windows.Forms.DataGridView dgvGrupos;
        private System.Windows.Forms.GroupBox grpGrupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxGrupos;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewImageColumn Excluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
    }
}