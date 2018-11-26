namespace AutoZap.view
{
    partial class Grupo
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
            this.dgvGrupo = new System.Windows.Forms.DataGridView();
            this.Excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpserver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Grupos";
            // 
            // dgvGrupo
            // 
            this.dgvGrupo.AllowUserToAddRows = false;
            this.dgvGrupo.AllowUserToDeleteRows = false;
            this.dgvGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excluir,
            this.Edit,
            this.groupname,
            this.tpserver,
            this.groupid});
            this.dgvGrupo.Location = new System.Drawing.Point(12, 21);
            this.dgvGrupo.Name = "dgvGrupo";
            this.dgvGrupo.ReadOnly = true;
            this.dgvGrupo.RowHeadersVisible = false;
            this.dgvGrupo.Size = new System.Drawing.Size(380, 297);
            this.dgvGrupo.TabIndex = 4;
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
            // Edit
            // 
            this.Edit.FillWeight = 30F;
            this.Edit.HeaderText = "      ";
            this.Edit.Image = global::AutoZap.Properties.Resources.pencil;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 30;
            // 
            // groupname
            // 
            this.groupname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.groupname.DataPropertyName = "groupname";
            this.groupname.HeaderText = "Grupo";
            this.groupname.Name = "groupname";
            this.groupname.ReadOnly = true;
            this.groupname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.groupname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tpserver
            // 
            this.tpserver.DataPropertyName = "tpserver";
            this.tpserver.HeaderText = "tpserver";
            this.tpserver.Name = "tpserver";
            this.tpserver.ReadOnly = true;
            this.tpserver.Visible = false;
            // 
            // groupid
            // 
            this.groupid.DataPropertyName = "groupid";
            this.groupid.HeaderText = "groupid";
            this.groupid.Name = "groupid";
            this.groupid.ReadOnly = true;
            this.groupid.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::AutoZap.Properties.Resources.group_add;
            this.btnAdd.Location = new System.Drawing.Point(12, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 25);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Novo Grupo";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Image = global::AutoZap.Properties.Resources.cancel;
            this.btnSair.Location = new System.Drawing.Point(317, 324);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 25);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // Grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 358);
            this.ControlBox = false;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGrupo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Grupo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Grupos";
            this.Load += new System.EventHandler(this.Grupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGrupo;
        private System.Windows.Forms.DataGridViewImageColumn Excluir;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupname;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpserver;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupid;
    }
}