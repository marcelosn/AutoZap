namespace AutoZap.view
{
    partial class Opcoes
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
            this.grpTpServer = new System.Windows.Forms.GroupBox();
            this.rdoXMPP = new System.Windows.Forms.RadioButton();
            this.rdoWhatsApp = new System.Windows.Forms.RadioButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.btnWhatsapp = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblNickname = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.lblServidor = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAutoResponse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHttpPort = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmailReg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpresaReg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnServico = new System.Windows.Forms.Button();
            this.grpTpServer.SuspendLayout();
            this.grpLogin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTpServer
            // 
            this.grpTpServer.Controls.Add(this.rdoXMPP);
            this.grpTpServer.Controls.Add(this.rdoWhatsApp);
            this.grpTpServer.Location = new System.Drawing.Point(12, 12);
            this.grpTpServer.Name = "grpTpServer";
            this.grpTpServer.Size = new System.Drawing.Size(228, 51);
            this.grpTpServer.TabIndex = 0;
            this.grpTpServer.TabStop = false;
            this.grpTpServer.Text = "Tipo Servidor";
            // 
            // rdoXMPP
            // 
            this.rdoXMPP.AutoSize = true;
            this.rdoXMPP.Location = new System.Drawing.Point(106, 19);
            this.rdoXMPP.Name = "rdoXMPP";
            this.rdoXMPP.Size = new System.Drawing.Size(107, 17);
            this.rdoXMPP.TabIndex = 1;
            this.rdoXMPP.TabStop = true;
            this.rdoXMPP.Text = "XMPP (OpenFire)";
            this.rdoXMPP.UseVisualStyleBackColor = true;
            // 
            // rdoWhatsApp
            // 
            this.rdoWhatsApp.AutoSize = true;
            this.rdoWhatsApp.Location = new System.Drawing.Point(6, 19);
            this.rdoWhatsApp.Name = "rdoWhatsApp";
            this.rdoWhatsApp.Size = new System.Drawing.Size(75, 17);
            this.rdoWhatsApp.TabIndex = 1;
            this.rdoWhatsApp.TabStop = true;
            this.rdoWhatsApp.Text = "WhatsApp";
            this.rdoWhatsApp.UseVisualStyleBackColor = true;
            this.rdoWhatsApp.CheckedChanged += new System.EventHandler(this.rdoWhatsApp_CheckedChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 66);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(43, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Usuário";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(6, 82);
            this.txtUsername.MaxLength = 255;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(207, 20);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.btnWhatsapp);
            this.grpLogin.Controls.Add(this.btnTest);
            this.grpLogin.Controls.Add(this.lblNickname);
            this.grpLogin.Controls.Add(this.txtNickname);
            this.grpLogin.Controls.Add(this.lblPort);
            this.grpLogin.Controls.Add(this.txtPorta);
            this.grpLogin.Controls.Add(this.lblServidor);
            this.grpLogin.Controls.Add(this.txtServidor);
            this.grpLogin.Controls.Add(this.lblPassword);
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.Controls.Add(this.lblUsername);
            this.grpLogin.Controls.Add(this.txtUsername);
            this.grpLogin.Location = new System.Drawing.Point(12, 69);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(228, 235);
            this.grpLogin.TabIndex = 3;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Configuracao Servidor";
            // 
            // btnWhatsapp
            // 
            this.btnWhatsapp.Image = global::AutoZap.Properties.Resources.whatsapp;
            this.btnWhatsapp.Location = new System.Drawing.Point(6, 199);
            this.btnWhatsapp.Name = "btnWhatsapp";
            this.btnWhatsapp.Size = new System.Drawing.Size(133, 30);
            this.btnWhatsapp.TabIndex = 15;
            this.btnWhatsapp.Text = "WhatsApp Registro";
            this.btnWhatsapp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWhatsapp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWhatsapp.UseVisualStyleBackColor = true;
            this.btnWhatsapp.Click += new System.EventHandler(this.btnWhatsapp_Click);
            // 
            // btnTest
            // 
            this.btnTest.Image = global::AutoZap.Properties.Resources.connect;
            this.btnTest.Location = new System.Drawing.Point(145, 199);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(68, 30);
            this.btnTest.TabIndex = 13;
            this.btnTest.Text = "Teste";
            this.btnTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Location = new System.Drawing.Point(3, 26);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(42, 13);
            this.lblNickname.TabIndex = 9;
            this.lblNickname.Text = "Apelido";
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(6, 42);
            this.txtNickname.MaxLength = 50;
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(207, 20);
            this.txtNickname.TabIndex = 2;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(152, 148);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(32, 13);
            this.lblPort.TabIndex = 7;
            this.lblPort.Text = "Porta";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(155, 164);
            this.txtPorta.MaxLength = 4;
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(58, 20);
            this.txtPorta.TabIndex = 6;
            this.txtPorta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorta_KeyPress);
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(3, 148);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(46, 13);
            this.lblServidor.TabIndex = 5;
            this.lblServidor.Text = "Servidor";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(6, 164);
            this.txtServidor.MaxLength = 255;
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(143, 20);
            this.txtServidor.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(3, 107);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(6, 123);
            this.txtPassword.MaxLength = 255;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(207, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // txtAutoResponse
            // 
            this.txtAutoResponse.Location = new System.Drawing.Point(255, 28);
            this.txtAutoResponse.MaxLength = 255;
            this.txtAutoResponse.Multiline = true;
            this.txtAutoResponse.Name = "txtAutoResponse";
            this.txtAutoResponse.Size = new System.Drawing.Size(229, 64);
            this.txtAutoResponse.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mensagem em caso de interação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "WS HTTP Port";
            // 
            // txtHttpPort
            // 
            this.txtHttpPort.Location = new System.Drawing.Point(255, 111);
            this.txtHttpPort.MaxLength = 4;
            this.txtHttpPort.Name = "txtHttpPort";
            this.txtHttpPort.Size = new System.Drawing.Size(58, 20);
            this.txtHttpPort.TabIndex = 10;
            this.txtHttpPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHttpPort_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmailReg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEmpresaReg);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(255, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 118);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // txtEmailReg
            // 
            this.txtEmailReg.Location = new System.Drawing.Point(9, 81);
            this.txtEmailReg.MaxLength = 255;
            this.txtEmailReg.Name = "txtEmailReg";
            this.txtEmailReg.Size = new System.Drawing.Size(203, 20);
            this.txtEmailReg.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "E-Mail";
            // 
            // txtEmpresaReg
            // 
            this.txtEmpresaReg.Location = new System.Drawing.Point(9, 35);
            this.txtEmpresaReg.MaxLength = 255;
            this.txtEmpresaReg.Name = "txtEmpresaReg";
            this.txtEmpresaReg.Size = new System.Drawing.Size(203, 20);
            this.txtEmpresaReg.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Empresa";
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Image = global::AutoZap.Properties.Resources.disk;
            this.btnGravar.Location = new System.Drawing.Point(320, 264);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 30);
            this.btnGravar.TabIndex = 14;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::AutoZap.Properties.Resources.cancel;
            this.btnCancelar.Location = new System.Drawing.Point(401, 264);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 30);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnServico
            // 
            this.btnServico.Location = new System.Drawing.Point(364, 111);
            this.btnServico.Name = "btnServico";
            this.btnServico.Size = new System.Drawing.Size(120, 23);
            this.btnServico.TabIndex = 15;
            this.btnServico.Text = "btn";
            this.btnServico.UseVisualStyleBackColor = true;
            this.btnServico.Click += new System.EventHandler(this.btnServico_Click);
            // 
            // Opcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 307);
            this.ControlBox = false;
            this.Controls.Add(this.btnServico);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHttpPort);
            this.Controls.Add(this.txtAutoResponse);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.grpTpServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Opcoes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Opcoes";
            this.Load += new System.EventHandler(this.Opcoes_Load);
            this.grpTpServer.ResumeLayout(false);
            this.grpTpServer.PerformLayout();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTpServer;
        private System.Windows.Forms.RadioButton rdoXMPP;
        private System.Windows.Forms.RadioButton rdoWhatsApp;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAutoResponse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHttpPort;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmailReg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmpresaReg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnWhatsapp;
        private System.Windows.Forms.Button btnServico;
    }
}