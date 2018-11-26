namespace AutoZap.view
{
    partial class Contatos
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
            this.gdvContatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Usename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpserver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdvContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvContatos
            // 
            this.gdvContatos.AllowUserToAddRows = false;
            this.gdvContatos.AllowUserToDeleteRows = false;
            this.gdvContatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gdvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvContatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excluir,
            this.Edit,
            this.Usename,
            this.nickname,
            this.tpserver});
            this.gdvContatos.Location = new System.Drawing.Point(12, 25);
            this.gdvContatos.MultiSelect = false;
            this.gdvContatos.Name = "gdvContatos";
            this.gdvContatos.ReadOnly = true;
            this.gdvContatos.RowHeadersVisible = false;
            this.gdvContatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gdvContatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvContatos.Size = new System.Drawing.Size(380, 297);
            this.gdvContatos.TabIndex = 0;
            this.gdvContatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvContatos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contatos";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "      ";
            this.dataGridViewImageColumn1.Image = global::AutoZap.Properties.Resources.cross;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::AutoZap.Properties.Resources.user_add;
            this.btnAdd.Location = new System.Drawing.Point(12, 328);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 25);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Novo Contato";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Image = global::AutoZap.Properties.Resources.cancel;
            this.btnSair.Location = new System.Drawing.Point(317, 328);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 25);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // Excluir
            // 
            this.Excluir.FillWeight = 20F;
            this.Excluir.HeaderText = "        ";
            this.Excluir.Image = global::AutoZap.Properties.Resources.cross;
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Width = 30;
            // 
            // Edit
            // 
            this.Edit.FillWeight = 20F;
            this.Edit.HeaderText = "      ";
            this.Edit.Image = global::AutoZap.Properties.Resources.pencil;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 30;
            // 
            // Usename
            // 
            this.Usename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Usename.DataPropertyName = "username";
            this.Usename.FillWeight = 50F;
            this.Usename.HeaderText = "Username";
            this.Usename.MaxInputLength = 255;
            this.Usename.Name = "Usename";
            this.Usename.ReadOnly = true;
            // 
            // nickname
            // 
            this.nickname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nickname.DataPropertyName = "nickname";
            this.nickname.FillWeight = 50F;
            this.nickname.HeaderText = "Apelido";
            this.nickname.MaxInputLength = 255;
            this.nickname.Name = "nickname";
            this.nickname.ReadOnly = true;
            // 
            // tpserver
            // 
            this.tpserver.DataPropertyName = "tpserver";
            this.tpserver.HeaderText = "tpserver";
            this.tpserver.Name = "tpserver";
            this.tpserver.ReadOnly = true;
            this.tpserver.Visible = false;
            // 
            // Contatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 361);
            this.ControlBox = false;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gdvContatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Contatos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contatos";
            this.Load += new System.EventHandler(this.Contatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvContatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdvContatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn Excluir;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usename;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpserver;
    }
}