namespace AutoZap.view
{
    partial class EditGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGrupo));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNomeGrupo = new System.Windows.Forms.TextBox();
            this.txtCodGrupo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAlerta = new System.Windows.Forms.GroupBox();
            this.lblInstrucaoWhatsApp = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvGrupo = new System.Windows.Forms.DataGridView();
            this.Excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.Apelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddUserGroup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxContatos = new System.Windows.Forms.ComboBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpAlerta.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(324, 314);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.txtNomeGrupo);
            this.tabPage1.Controls.Add(this.txtCodGrupo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.grpAlerta);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(316, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Grupo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::AutoZap.Properties.Resources.disk;
            this.btnSave.Location = new System.Drawing.Point(7, 112);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 26);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Salvar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNomeGrupo
            // 
            this.txtNomeGrupo.Location = new System.Drawing.Point(7, 84);
            this.txtNomeGrupo.Name = "txtNomeGrupo";
            this.txtNomeGrupo.Size = new System.Drawing.Size(201, 20);
            this.txtNomeGrupo.TabIndex = 5;
            // 
            // txtCodGrupo
            // 
            this.txtCodGrupo.Location = new System.Drawing.Point(7, 38);
            this.txtCodGrupo.Name = "txtCodGrupo";
            this.txtCodGrupo.Size = new System.Drawing.Size(201, 20);
            this.txtCodGrupo.TabIndex = 4;
            this.txtCodGrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodGrupo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome do Grupo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grupo Código";
            // 
            // grpAlerta
            // 
            this.grpAlerta.Controls.Add(this.lblInstrucaoWhatsApp);
            this.grpAlerta.Location = new System.Drawing.Point(9, 171);
            this.grpAlerta.Name = "grpAlerta";
            this.grpAlerta.Size = new System.Drawing.Size(298, 109);
            this.grpAlerta.TabIndex = 1;
            this.grpAlerta.TabStop = false;
            this.grpAlerta.Text = "Observação";
            // 
            // lblInstrucaoWhatsApp
            // 
            this.lblInstrucaoWhatsApp.AutoSize = true;
            this.lblInstrucaoWhatsApp.Location = new System.Drawing.Point(8, 21);
            this.lblInstrucaoWhatsApp.Name = "lblInstrucaoWhatsApp";
            this.lblInstrucaoWhatsApp.Size = new System.Drawing.Size(281, 78);
            this.lblInstrucaoWhatsApp.TabIndex = 0;
            this.lblInstrucaoWhatsApp.Text = resources.GetString("lblInstrucaoWhatsApp.Text");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvGrupo);
            this.tabPage2.Controls.Add(this.btnAddUserGroup);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cboxContatos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(316, 288);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contatos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvGrupo
            // 
            this.dgvGrupo.AllowUserToAddRows = false;
            this.dgvGrupo.AllowUserToDeleteRows = false;
            this.dgvGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excluir,
            this.Apelido,
            this.username});
            this.dgvGrupo.Location = new System.Drawing.Point(10, 54);
            this.dgvGrupo.Name = "dgvGrupo";
            this.dgvGrupo.ReadOnly = true;
            this.dgvGrupo.RowHeadersVisible = false;
            this.dgvGrupo.Size = new System.Drawing.Size(296, 228);
            this.dgvGrupo.TabIndex = 3;
            this.dgvGrupo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupo_CellContentClick);
            // 
            // Excluir
            // 
            this.Excluir.FillWeight = 30F;
            this.Excluir.HeaderText = "      ";
            this.Excluir.Image = global::AutoZap.Properties.Resources.cross;
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Width = 30;
            // 
            // Apelido
            // 
            this.Apelido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apelido.DataPropertyName = "Name";
            this.Apelido.HeaderText = "Apelido";
            this.Apelido.Name = "Apelido";
            this.Apelido.ReadOnly = true;
            // 
            // username
            // 
            this.username.DataPropertyName = "Id";
            this.username.HeaderText = "username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Visible = false;
            // 
            // btnAddUserGroup
            // 
            this.btnAddUserGroup.Image = global::AutoZap.Properties.Resources.plus_octagon;
            this.btnAddUserGroup.Location = new System.Drawing.Point(275, 22);
            this.btnAddUserGroup.Name = "btnAddUserGroup";
            this.btnAddUserGroup.Size = new System.Drawing.Size(31, 26);
            this.btnAddUserGroup.TabIndex = 2;
            this.btnAddUserGroup.UseVisualStyleBackColor = true;
            this.btnAddUserGroup.Click += new System.EventHandler(this.btnAddUserGroup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Contatos";
            // 
            // cboxContatos
            // 
            this.cboxContatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxContatos.FormattingEnabled = true;
            this.cboxContatos.Location = new System.Drawing.Point(10, 25);
            this.cboxContatos.Name = "cboxContatos";
            this.cboxContatos.Size = new System.Drawing.Size(259, 21);
            this.cboxContatos.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Image = global::AutoZap.Properties.Resources.cancel;
            this.btnSair.Location = new System.Drawing.Point(261, 332);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // EditGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 362);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditGrupo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditGrupo";
            this.Load += new System.EventHandler(this.EditGrupo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpAlerta.ResumeLayout(false);
            this.grpAlerta.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNomeGrupo;
        private System.Windows.Forms.TextBox txtCodGrupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpAlerta;
        private System.Windows.Forms.Label lblInstrucaoWhatsApp;
        private System.Windows.Forms.Button btnAddUserGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxContatos;
        private System.Windows.Forms.DataGridView dgvGrupo;
        private System.Windows.Forms.DataGridViewImageColumn Excluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
    }
}