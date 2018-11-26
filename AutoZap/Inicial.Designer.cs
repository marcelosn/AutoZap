namespace AutoZap
{
    partial class Inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicial));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gatilhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuConsole = new System.Windows.Forms.Button();
            this.btnMenuOpcoes = new System.Windows.Forms.Button();
            this.btnMenuGatilhos = new System.Windows.Forms.Button();
            this.btnMenuGrupos = new System.Windows.Forms.Button();
            this.btnMenuUsuario = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(385, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contatosToolStripMenuItem,
            this.gruposToolStripMenuItem,
            this.gatilhoToolStripMenuItem,
            this.toolStripSeparator1,
            this.opçõesToolStripMenuItem,
            this.consoleToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.arquivoToolStripMenuItem.Text = "Definições";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // contatosToolStripMenuItem
            // 
            this.contatosToolStripMenuItem.Name = "contatosToolStripMenuItem";
            this.contatosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contatosToolStripMenuItem.Text = "Contatos";
            this.contatosToolStripMenuItem.Click += new System.EventHandler(this.contatosToolStripMenuItem_Click);
            // 
            // gruposToolStripMenuItem
            // 
            this.gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            this.gruposToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.gruposToolStripMenuItem.Text = "Grupos";
            this.gruposToolStripMenuItem.Click += new System.EventHandler(this.gruposToolStripMenuItem_Click);
            // 
            // gatilhoToolStripMenuItem
            // 
            this.gatilhoToolStripMenuItem.Name = "gatilhoToolStripMenuItem";
            this.gatilhoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.gatilhoToolStripMenuItem.Text = "Gatilho";
            this.gatilhoToolStripMenuItem.Click += new System.EventHandler(this.gatilhoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.opçõesToolStripMenuItem.Text = "Opções";
            this.opçõesToolStripMenuItem.Click += new System.EventHandler(this.opçõesToolStripMenuItem_Click);
            // 
            // consoleToolStripMenuItem
            // 
            this.consoleToolStripMenuItem.Name = "consoleToolStripMenuItem";
            this.consoleToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.consoleToolStripMenuItem.Text = "Console";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem1,
            this.registroToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // ajudaToolStripMenuItem1
            // 
            this.ajudaToolStripMenuItem1.Name = "ajudaToolStripMenuItem1";
            this.ajudaToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.ajudaToolStripMenuItem1.Text = "Ajuda";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // btnMenuConsole
            // 
            this.btnMenuConsole.Image = global::AutoZap.Properties.Resources.terminal;
            this.btnMenuConsole.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenuConsole.Location = new System.Drawing.Point(305, 30);
            this.btnMenuConsole.Name = "btnMenuConsole";
            this.btnMenuConsole.Padding = new System.Windows.Forms.Padding(2);
            this.btnMenuConsole.Size = new System.Drawing.Size(75, 58);
            this.btnMenuConsole.TabIndex = 6;
            this.btnMenuConsole.Text = "Console";
            this.btnMenuConsole.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuConsole.UseVisualStyleBackColor = true;
            // 
            // btnMenuOpcoes
            // 
            this.btnMenuOpcoes.Image = global::AutoZap.Properties.Resources.cog;
            this.btnMenuOpcoes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenuOpcoes.Location = new System.Drawing.Point(230, 30);
            this.btnMenuOpcoes.Name = "btnMenuOpcoes";
            this.btnMenuOpcoes.Padding = new System.Windows.Forms.Padding(2);
            this.btnMenuOpcoes.Size = new System.Drawing.Size(75, 58);
            this.btnMenuOpcoes.TabIndex = 5;
            this.btnMenuOpcoes.Text = "Opções";
            this.btnMenuOpcoes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuOpcoes.UseVisualStyleBackColor = true;
            this.btnMenuOpcoes.Click += new System.EventHandler(this.btnMenuOpcoes_Click);
            // 
            // btnMenuGatilhos
            // 
            this.btnMenuGatilhos.Image = global::AutoZap.Properties.Resources.lightning;
            this.btnMenuGatilhos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenuGatilhos.Location = new System.Drawing.Point(155, 30);
            this.btnMenuGatilhos.Name = "btnMenuGatilhos";
            this.btnMenuGatilhos.Padding = new System.Windows.Forms.Padding(2);
            this.btnMenuGatilhos.Size = new System.Drawing.Size(75, 58);
            this.btnMenuGatilhos.TabIndex = 4;
            this.btnMenuGatilhos.Text = "Gatilhos";
            this.btnMenuGatilhos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuGatilhos.UseVisualStyleBackColor = true;
            this.btnMenuGatilhos.Click += new System.EventHandler(this.btnMenuGatilhos_Click);
            // 
            // btnMenuGrupos
            // 
            this.btnMenuGrupos.Image = global::AutoZap.Properties.Resources.group;
            this.btnMenuGrupos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenuGrupos.Location = new System.Drawing.Point(80, 30);
            this.btnMenuGrupos.Name = "btnMenuGrupos";
            this.btnMenuGrupos.Padding = new System.Windows.Forms.Padding(2);
            this.btnMenuGrupos.Size = new System.Drawing.Size(75, 58);
            this.btnMenuGrupos.TabIndex = 3;
            this.btnMenuGrupos.Text = "Grupos";
            this.btnMenuGrupos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuGrupos.UseVisualStyleBackColor = true;
            this.btnMenuGrupos.Click += new System.EventHandler(this.btnMenuGrupos_Click);
            // 
            // btnMenuUsuario
            // 
            this.btnMenuUsuario.Image = global::AutoZap.Properties.Resources.user;
            this.btnMenuUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenuUsuario.Location = new System.Drawing.Point(5, 30);
            this.btnMenuUsuario.Name = "btnMenuUsuario";
            this.btnMenuUsuario.Padding = new System.Windows.Forms.Padding(2);
            this.btnMenuUsuario.Size = new System.Drawing.Size(75, 58);
            this.btnMenuUsuario.TabIndex = 2;
            this.btnMenuUsuario.Text = "Contatos";
            this.btnMenuUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuUsuario.UseVisualStyleBackColor = true;
            this.btnMenuUsuario.Click += new System.EventHandler(this.btnMenuUsuario_Click);
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 95);
            this.Controls.Add(this.btnMenuConsole);
            this.Controls.Add(this.btnMenuOpcoes);
            this.Controls.Add(this.btnMenuGatilhos);
            this.Controls.Add(this.btnMenuGrupos);
            this.Controls.Add(this.btnMenuUsuario);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoZap 1.0.0 Beta";
            this.Load += new System.EventHandler(this.Inicial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gatilhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem consoleToolStripMenuItem;
        private System.Windows.Forms.Button btnMenuUsuario;
        private System.Windows.Forms.Button btnMenuGrupos;
        private System.Windows.Forms.Button btnMenuGatilhos;
        private System.Windows.Forms.Button btnMenuOpcoes;
        private System.Windows.Forms.Button btnMenuConsole;
    }
}