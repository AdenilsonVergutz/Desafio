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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPrincipal));
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            usu�rioToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            servi�oToolStripMenuItem = new ToolStripMenuItem();
            ordemDeServi�oToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            relat�rioToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem1 = new ToolStripMenuItem();
            servi�oToolStripMenuItem1 = new ToolStripMenuItem();
            ordemDeServi�oToolStripMenuItem1 = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tsslUsuario = new ToolStripStatusLabel();
            tsslIP = new ToolStripStatusLabel();
            tsslNomePC = new ToolStripStatusLabel();
            tsslData = new ToolStripStatusLabel();
            tsslHora = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            tsbCliente = new ToolStripButton();
            tsbServico = new ToolStripButton();
            tsbOS = new ToolStripButton();
            tsbLogoff = new ToolStripButton();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.InactiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, relat�rioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1185, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usu�rioToolStripMenuItem, clienteToolStripMenuItem, servi�oToolStripMenuItem, ordemDeServi�oToolStripMenuItem, sairToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // usu�rioToolStripMenuItem
            // 
            usu�rioToolStripMenuItem.Name = "usu�rioToolStripMenuItem";
            usu�rioToolStripMenuItem.Size = new Size(168, 22);
            usu�rioToolStripMenuItem.Text = "Usu�rio";
            usu�rioToolStripMenuItem.Click += usu�rioToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(168, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // servi�oToolStripMenuItem
            // 
            servi�oToolStripMenuItem.Name = "servi�oToolStripMenuItem";
            servi�oToolStripMenuItem.Size = new Size(168, 22);
            servi�oToolStripMenuItem.Text = "Servi�o";
            servi�oToolStripMenuItem.Click += servi�oToolStripMenuItem_Click;
            // 
            // ordemDeServi�oToolStripMenuItem
            // 
            ordemDeServi�oToolStripMenuItem.Name = "ordemDeServi�oToolStripMenuItem";
            ordemDeServi�oToolStripMenuItem.Size = new Size(168, 22);
            ordemDeServi�oToolStripMenuItem.Text = "Ordem de Servi�o";
            ordemDeServi�oToolStripMenuItem.Click += ordemDeServi�oToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(168, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // relat�rioToolStripMenuItem
            // 
            relat�rioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem1, servi�oToolStripMenuItem1, ordemDeServi�oToolStripMenuItem1 });
            relat�rioToolStripMenuItem.Name = "relat�rioToolStripMenuItem";
            relat�rioToolStripMenuItem.Size = new Size(66, 20);
            relat�rioToolStripMenuItem.Text = "Relat�rio";
            // 
            // clienteToolStripMenuItem1
            // 
            clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            clienteToolStripMenuItem1.Size = new Size(168, 22);
            clienteToolStripMenuItem1.Text = "Cliente";
            clienteToolStripMenuItem1.Click += clienteToolStripMenuItem1_Click;
            // 
            // servi�oToolStripMenuItem1
            // 
            servi�oToolStripMenuItem1.Name = "servi�oToolStripMenuItem1";
            servi�oToolStripMenuItem1.Size = new Size(168, 22);
            servi�oToolStripMenuItem1.Text = "Servi�o";
            servi�oToolStripMenuItem1.Click += servi�oToolStripMenuItem1_Click;
            // 
            // ordemDeServi�oToolStripMenuItem1
            // 
            ordemDeServi�oToolStripMenuItem1.Name = "ordemDeServi�oToolStripMenuItem1";
            ordemDeServi�oToolStripMenuItem1.Size = new Size(168, 22);
            ordemDeServi�oToolStripMenuItem1.Text = "Ordem de Servi�o";
            ordemDeServi�oToolStripMenuItem1.Click += ordemDeServi�oToolStripMenuItem1_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslUsuario, tsslIP, tsslNomePC, tsslData, tsslHora });
            statusStrip1.Location = new Point(0, 845);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1185, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // tsslUsuario
            // 
            tsslUsuario.BorderSides = ToolStripStatusLabelBorderSides.Right;
            tsslUsuario.Name = "tsslUsuario";
            tsslUsuario.Size = new Size(4, 17);
            // 
            // tsslIP
            // 
            tsslIP.BorderSides = ToolStripStatusLabelBorderSides.Right;
            tsslIP.Name = "tsslIP";
            tsslIP.Size = new Size(4, 17);
            // 
            // tsslNomePC
            // 
            tsslNomePC.BorderSides = ToolStripStatusLabelBorderSides.Right;
            tsslNomePC.Name = "tsslNomePC";
            tsslNomePC.Size = new Size(4, 17);
            // 
            // tsslData
            // 
            tsslData.BorderSides = ToolStripStatusLabelBorderSides.Right;
            tsslData.Name = "tsslData";
            tsslData.Size = new Size(4, 17);
            // 
            // tsslHora
            // 
            tsslHora.BorderSides = ToolStripStatusLabelBorderSides.Right;
            tsslHora.Name = "tsslHora";
            tsslHora.Size = new Size(4, 17);
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.InactiveCaption;
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbCliente, tsbServico, tsbOS, tsbLogoff });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1185, 46);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbCliente
            // 
            tsbCliente.Image = Properties.Resources.group;
            tsbCliente.ImageScaling = ToolStripItemImageScaling.None;
            tsbCliente.ImageTransparentColor = Color.Magenta;
            tsbCliente.Name = "tsbCliente";
            tsbCliente.Size = new Size(48, 43);
            tsbCliente.Text = "Cliente";
            tsbCliente.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbCliente.Click += tsbCliente_Click;
            // 
            // tsbServico
            // 
            tsbServico.Image = Properties.Resources.applications;
            tsbServico.ImageScaling = ToolStripItemImageScaling.None;
            tsbServico.ImageTransparentColor = Color.Magenta;
            tsbServico.Name = "tsbServico";
            tsbServico.Size = new Size(49, 43);
            tsbServico.Text = "Servi�o";
            tsbServico.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbServico.Click += tsbServico_Click;
            // 
            // tsbOS
            // 
            tsbOS.Image = Properties.Resources.paste;
            tsbOS.ImageScaling = ToolStripItemImageScaling.None;
            tsbOS.ImageTransparentColor = Color.Magenta;
            tsbOS.Name = "tsbOS";
            tsbOS.Size = new Size(105, 43);
            tsbOS.Text = "Ordem de Servi�o";
            tsbOS.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbOS.Click += tsbOS_Click;
            // 
            // tsbLogoff
            // 
            tsbLogoff.Image = Properties.Resources.back;
            tsbLogoff.ImageScaling = ToolStripItemImageScaling.None;
            tsbLogoff.ImageTransparentColor = Color.Magenta;
            tsbLogoff.Name = "tsbLogoff";
            tsbLogoff.Size = new Size(46, 43);
            tsbLogoff.Text = "Logoff";
            tsbLogoff.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbLogoff.Click += tsbLogoff_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // frmTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1185, 867);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmTelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Principal";
            WindowState = FormWindowState.Maximized;
            FormClosing += frmTelaPrincipal_FormClosing;
            FormClosed += frmTelaPrincipal_FormClosed;
            Load += frmTelaPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem usu�rioToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem servi�oToolStripMenuItem;
        private ToolStripMenuItem ordemDeServi�oToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem relat�rioToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem1;
        private ToolStripMenuItem servi�oToolStripMenuItem1;
        private ToolStripMenuItem ordemDeServi�oToolStripMenuItem1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslUsuario;
        private ToolStripStatusLabel tsslIP;
        private ToolStripStatusLabel tsslNomePC;
        private ToolStripStatusLabel tsslData;
        private ToolStripStatusLabel tsslHora;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbCliente;
        private ToolStripButton tsbServico;
        private ToolStripButton tsbOS;
        private ToolStripButton tsbLogoff;
        private System.Windows.Forms.Timer timer1;
    }
}