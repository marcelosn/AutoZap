namespace AutoZap.view
{
    partial class Gatilho
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGatilho = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PalavraChave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gatilhoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGatilho)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gatilhos";
            // 
            // dgvGatilho
            // 
            this.dgvGatilho.AllowUserToAddRows = false;
            this.dgvGatilho.AllowUserToDeleteRows = false;
            this.dgvGatilho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGatilho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excluir,
            this.Editar,
            this.Tipo,
            this.PalavraChave,
            this.gatilhoid});
            this.dgvGatilho.Location = new System.Drawing.Point(12, 25);
            this.dgvGatilho.Name = "dgvGatilho";
            this.dgvGatilho.ReadOnly = true;
            this.dgvGatilho.RowHeadersVisible = false;
            this.dgvGatilho.Size = new System.Drawing.Size(569, 321);
            this.dgvGatilho.TabIndex = 3;
            this.dgvGatilho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGatilho_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::AutoZap.Properties.Resources.lightning_add;
            this.btnAdd.Location = new System.Drawing.Point(12, 352);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Novo Gatilho";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::AutoZap.Properties.Resources.cancel;
            this.btnCancelar.Location = new System.Drawing.Point(506, 352);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Sair";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Excluir
            // 
            this.Excluir.FillWeight = 30F;
            this.Excluir.HeaderText = "     ";
            this.Excluir.Image = global::AutoZap.Properties.Resources.cross;
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Excluir.Width = 30;
            // 
            // Editar
            // 
            this.Editar.FillWeight = 30F;
            this.Editar.HeaderText = "    ";
            this.Editar.Image = global::AutoZap.Properties.Resources.pencil;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 30;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "tpgatilho";
            this.Tipo.FillWeight = 80F;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Visible = false;
            this.Tipo.Width = 80;
            // 
            // PalavraChave
            // 
            this.PalavraChave.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PalavraChave.DataPropertyName = "palavrachave";
            this.PalavraChave.HeaderText = "Palavra Chave";
            this.PalavraChave.Name = "PalavraChave";
            this.PalavraChave.ReadOnly = true;
            // 
            // gatilhoid
            // 
            this.gatilhoid.DataPropertyName = "id";
            this.gatilhoid.HeaderText = "gatilhoid";
            this.gatilhoid.Name = "gatilhoid";
            this.gatilhoid.ReadOnly = true;
            this.gatilhoid.Visible = false;
            // 
            // Gatilho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 387);
            this.ControlBox = false;
            this.Controls.Add(this.dgvGatilho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Gatilho";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gatilhos";
            this.Load += new System.EventHandler(this.Gatilho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGatilho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGatilho;
        private System.Windows.Forms.DataGridViewImageColumn Excluir;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PalavraChave;
        private System.Windows.Forms.DataGridViewTextBoxColumn gatilhoid;
    }
}