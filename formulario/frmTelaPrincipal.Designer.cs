namespace Desafio
{
    partial class frmTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usu�rioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servi�oToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemDeServi�oToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relat�rioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.servi�oToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemDeServi�oToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNomePC = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCliente = new System.Windows.Forms.ToolStripButton();
            this.tsbServico = new System.Windows.Forms.ToolStripButton();
            this.tsbOS = new System.Windows.Forms.ToolStripButton();
            this.tsbLogoff = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.relat�rioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usu�rioToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.servi�oToolStripMenuItem,
            this.ordemDeServi�oToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // usu�rioToolStripMenuItem
            // 
            this.usu�rioToolStripMenuItem.Name = "usu�rioToolStripMenuItem";
            this.usu�rioToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.usu�rioToolStripMenuItem.Text = "Usu�rio";
            this.usu�rioToolStripMenuItem.Click += new System.EventHandler(this.usu�rioToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // servi�oToolStripMenuItem
            // 
            this.servi�oToolStripMenuItem.Name = "servi�oToolStripMenuItem";
            this.servi�oToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.servi�oToolStripMenuItem.Text = "Servi�o";
            this.servi�oToolStripMenuItem.Click += new System.EventHandler(this.servi�oToolStripMenuItem_Click);
            // 
            // ordemDeServi�oToolStripMenuItem
            // 
            this.ordemDeServi�oToolStripMenuItem.Name = "ordemDeServi�oToolStripMenuItem";
            this.ordemDeServi�oToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.ordemDeServi�oToolStripMenuItem.Text = "Ordem de Servi�o";
            this.ordemDeServi�oToolStripMenuItem.Click += new System.EventHandler(this.ordemDeServi�oToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // relat�rioToolStripMenuItem
            // 
            this.relat�rioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.servi�oToolStripMenuItem1,
            this.ordemDeServi�oToolStripMenuItem1});
            this.relat�rioToolStripMenuItem.Name = "relat�rioToolStripMenuItem";
            this.relat�rioToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.relat�rioToolStripMenuItem.Text = "Relat�rio";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // servi�oToolStripMenuItem1
            // 
            this.servi�oToolStripMenuItem1.Name = "servi�oToolStripMenuItem1";
            this.servi�oToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.servi�oToolStripMenuItem1.Text = "Servi�o";
            this.servi�oToolStripMenuItem1.Click += new System.EventHandler(this.servi�oToolStripMenuItem1_Click);
            // 
            // ordemDeServi�oToolStripMenuItem1
            // 
            this.ordemDeServi�oToolStripMenuItem1.Name = "ordemDeServi�oToolStripMenuItem1";
            this.ordemDeServi�oToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.ordemDeServi�oToolStripMenuItem1.Text = "Ordem de Servi�o";
            this.ordemDeServi�oToolStripMenuItem1.Click += new System.EventHandler(this.ordemDeServi�oToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslUsuario,
            this.tsslIP,
            this.tsslNomePC,
            this.tsslData,
            this.tsslHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 729);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1016, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslUsuario
            // 
            this.tsslUsuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslUsuario.Name = "tsslUsuario";
            this.tsslUsuario.Size = new System.Drawing.Size(4, 17);
            // 
            // tsslIP
            // 
            this.tsslIP.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslIP.Name = "tsslIP";
            this.tsslIP.Size = new System.Drawing.Size(4, 17);
            // 
            // tsslNomePC
            // 
            this.tsslNomePC.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslNomePC.Name = "tsslNomePC";
            this.tsslNomePC.Size = new System.Drawing.Size(4, 17);
            // 
            // tsslData
            // 
            this.tsslData.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslData.Name = "tsslData";
            this.tsslData.Size = new System.Drawing.Size(4, 17);
            // 
            // tsslHora
            // 
            this.tsslHora.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslHora.Name = "tsslHora";
            this.tsslHora.Size = new System.Drawing.Size(4, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCliente,
            this.tsbServico,
            this.tsbOS,
            this.tsbLogoff});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1016, 44);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbCliente
            // 
            this.tsbCliente.Image = global::Desafio.Properties.Resources.group;
            this.tsbCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCliente.Name = "tsbCliente";
            this.tsbCliente.Size = new System.Drawing.Size(44, 41);
            this.tsbCliente.Text = "Cliente";
            this.tsbCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCliente.Click += new System.EventHandler(this.tsbCliente_Click);
            // 
            // tsbServico
            // 
            this.tsbServico.Image = global::Desafio.Properties.Resources.applications;
            this.tsbServico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbServico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbServico.Name = "tsbServico";
            this.tsbServico.Size = new System.Drawing.Size(46, 41);
            this.tsbServico.Text = "Servi�o";
            this.tsbServico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbServico.Click += new System.EventHandler(this.tsbServico_Click);
            // 
            // tsbOS
            // 
            this.tsbOS.Image = global::Desafio.Properties.Resources.paste;
            this.tsbOS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbOS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOS.Name = "tsbOS";
            this.tsbOS.Size = new System.Drawing.Size(96, 41);
            this.tsbOS.Text = "Ordem de Servi�o";
            this.tsbOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbOS.Click += new System.EventHandler(this.tsbOS_Click);
            // 
            // tsbLogoff
            // 
            this.tsbLogoff.Image = global::Desafio.Properties.Resources.back;
            this.tsbLogoff.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLogoff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLogoff.Name = "tsbLogoff";
            this.tsbLogoff.Size = new System.Drawing.Size(42, 41);
            this.tsbLogoff.Text = "Logoff";
            this.tsbLogoff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbLogoff.Click += new System.EventHandler(this.tsbLogoff_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1016, 751);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTelaPrincipal_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTelaPrincipal_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTelaPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usu�rioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servi�oToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordemDeServi�oToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relat�rioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem servi�oToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ordemDeServi�oToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tsslIP;
        private System.Windows.Forms.ToolStripStatusLabel tsslNomePC;
        private System.Windows.Forms.ToolStripStatusLabel tsslData;
        private System.Windows.Forms.ToolStripStatusLabel tsslHora;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbCliente;
        private System.Windows.Forms.ToolStripButton tsbServico;
        private System.Windows.Forms.ToolStripButton tsbOS;
        private System.Windows.Forms.ToolStripButton tsbLogoff;
        private System.Windows.Forms.Timer timer1;
    }
}