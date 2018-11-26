namespace AutoZap.view
{
    partial class WhatsAppTeste
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
            this.components = new System.ComponentModel.Container();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlog = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.sendMessage = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Image = global::AutoZap.Properties.Resources.cancel;
            this.btnSair.Location = new System.Drawing.Point(367, 260);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número Telefone Contato (informe o 55 no caso do Brasil)";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(15, 35);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(90, 20);
            this.txtTel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Log";
            // 
            // txtlog
            // 
            this.txtlog.BackColor = System.Drawing.Color.Black;
            this.txtlog.ForeColor = System.Drawing.Color.Yellow;
            this.txtlog.Location = new System.Drawing.Point(12, 74);
            this.txtlog.Multiline = true;
            this.txtlog.Name = "txtlog";
            this.txtlog.ReadOnly = true;
            this.txtlog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtlog.Size = new System.Drawing.Size(430, 180);
            this.txtlog.TabIndex = 4;
            this.txtlog.WordWrap = false;
            // 
            // btnSend
            // 
            this.btnSend.Image = global::AutoZap.Properties.Resources.connect;
            this.btnSend.Location = new System.Drawing.Point(111, 32);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Enviar";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // sendMessage
            // 
            this.sendMessage.Interval = 5000;
            this.sendMessage.Tick += new System.EventHandler(this.sendMessage_Tick);
            // 
            // WhatsAppTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 295);
            this.ControlBox = false;
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtlog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WhatsAppTeste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WhatsApp Teste Comunicação";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WhatsAppTeste_FormClosing);
            this.Load += new System.EventHandler(this.WhatsAppTeste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlog;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Timer sendMessage;
    }
}