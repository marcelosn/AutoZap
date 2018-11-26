namespace AutoZap.view
{
    partial class WhatsAppReg
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRequisitar = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRequisitar);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Passo 1: Requisitar Códigos";
            // 
            // btnRequisitar
            // 
            this.btnRequisitar.Image = global::AutoZap.Properties.Resources.contact_email;
            this.btnRequisitar.Location = new System.Drawing.Point(155, 19);
            this.btnRequisitar.Name = "btnRequisitar";
            this.btnRequisitar.Size = new System.Drawing.Size(100, 29);
            this.btnRequisitar.TabIndex = 3;
            this.btnRequisitar.Text = "Requisitar";
            this.btnRequisitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRequisitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRequisitar.UseVisualStyleBackColor = true;
            this.btnRequisitar.Click += new System.EventHandler(this.btnRequisitar_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(61, 23);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ReadOnly = true;
            this.txtTelefone.Size = new System.Drawing.Size(88, 20);
            this.txtTelefone.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Telefone";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnconfirm);
            this.groupBox2.Controls.Add(this.txtCode);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 58);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Passo 2: Código Confirmação";
            // 
            // btnconfirm
            // 
            this.btnconfirm.Image = global::AutoZap.Properties.Resources.accept;
            this.btnconfirm.Location = new System.Drawing.Point(141, 19);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(113, 28);
            this.btnconfirm.TabIndex = 4;
            this.btnconfirm.Text = "Confirmar Code";
            this.btnconfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnconfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(61, 22);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(64, 20);
            this.txtCode.TabIndex = 3;
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPassword);
            this.groupBox3.Location = new System.Drawing.Point(12, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 97);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Passo 3: Copie o Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(17, 19);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPassword.Size = new System.Drawing.Size(226, 72);
            this.txtPassword.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Image = global::AutoZap.Properties.Resources.cancel;
            this.button2.Location = new System.Drawing.Point(192, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // WhatsAppReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 284);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WhatsAppReg";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WhatsApp Registro";
            this.Load += new System.EventHandler(this.WhatsAppReg_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRequisitar;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnconfirm;
    }
}