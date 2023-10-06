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
            usuárioToolStripMenuItem = new ToolStripMenuItem();
            AutorToolStripMenuItem = new ToolStripMenuItem();
            serviçoToolStripMenuItem = new ToolStripMenuItem();
            ordemDeServiçoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            relatórioToolStripMenuItem = new ToolStripMenuItem();
            AutorToolStripMenuItem1 = new ToolStripMenuItem();
            serviçoToolStripMenuItem1 = new ToolStripMenuItem();
            ordemDeServiçoToolStripMenuItem1 = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tsslUsuario = new ToolStripStatusLabel();
            tsslIP = new ToolStripStatusLabel();
            tsslNomePC = new ToolStripStatusLabel();
            tsslData = new ToolStripStatusLabel();
            tsslHora = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            tsbAutor = new ToolStripButton();
            tsbCategoria = new ToolStripButton();
            tsbPost = new ToolStripButton();
            tsbLogoff = new ToolStripButton();
            timer1 = new System.Windows.Forms.Timer(components);
            tsbTag = new ToolStripButton();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.InactiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, relatórioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1185, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuárioToolStripMenuItem, AutorToolStripMenuItem, serviçoToolStripMenuItem, ordemDeServiçoToolStripMenuItem, sairToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // usuárioToolStripMenuItem
            // 
            usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            usuárioToolStripMenuItem.Size = new Size(127, 22);
            usuárioToolStripMenuItem.Text = "Usuário";
            usuárioToolStripMenuItem.Click += usuárioToolStripMenuItem_Click;
            // 
            // AutorToolStripMenuItem
            // 
            AutorToolStripMenuItem.Name = "AutorToolStripMenuItem";
            AutorToolStripMenuItem.Size = new Size(127, 22);
            AutorToolStripMenuItem.Text = "Autor";
            AutorToolStripMenuItem.Click += AutorToolStripMenuItem_Click;
            // 
            // serviçoToolStripMenuItem
            // 
            serviçoToolStripMenuItem.Name = "serviçoToolStripMenuItem";
            serviçoToolStripMenuItem.Size = new Size(127, 22);
            serviçoToolStripMenuItem.Text = "Categoria";
            serviçoToolStripMenuItem.Click += serviçoToolStripMenuItem_Click;
            // 
            // ordemDeServiçoToolStripMenuItem
            // 
            ordemDeServiçoToolStripMenuItem.Name = "ordemDeServiçoToolStripMenuItem";
            ordemDeServiçoToolStripMenuItem.Size = new Size(127, 22);
            ordemDeServiçoToolStripMenuItem.Text = "Postagem";
            ordemDeServiçoToolStripMenuItem.Click += PostToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(127, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // relatórioToolStripMenuItem
            // 
            relatórioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AutorToolStripMenuItem1, serviçoToolStripMenuItem1, ordemDeServiçoToolStripMenuItem1 });
            relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            relatórioToolStripMenuItem.Size = new Size(66, 20);
            relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // AutorToolStripMenuItem1
            // 
            AutorToolStripMenuItem1.Name = "AutorToolStripMenuItem1";
            AutorToolStripMenuItem1.Size = new Size(125, 22);
            AutorToolStripMenuItem1.Text = "Autor";
            AutorToolStripMenuItem1.Click += AutorToolStripMenuItem1_Click;
            // 
            // serviçoToolStripMenuItem1
            // 
            serviçoToolStripMenuItem1.Name = "serviçoToolStripMenuItem1";
            serviçoToolStripMenuItem1.Size = new Size(125, 22);
            serviçoToolStripMenuItem1.Text = "Categoria";
            serviçoToolStripMenuItem1.Click += categoriaToolStripMenuItem1_Click;
            // 
            // ordemDeServiçoToolStripMenuItem1
            // 
            ordemDeServiçoToolStripMenuItem1.Name = "ordemDeServiçoToolStripMenuItem1";
            ordemDeServiçoToolStripMenuItem1.Size = new Size(125, 22);
            ordemDeServiçoToolStripMenuItem1.Text = "Post";
            ordemDeServiçoToolStripMenuItem1.Click += PostToolStripMenuItem1_Click;
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
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbAutor, tsbCategoria, tsbTag, tsbPost, tsbLogoff });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1185, 46);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbAutor
            // 
            tsbAutor.Image = Properties.Resources.group;
            tsbAutor.ImageScaling = ToolStripItemImageScaling.None;
            tsbAutor.ImageTransparentColor = Color.Magenta;
            tsbAutor.Name = "tsbAutor";
            tsbAutor.Size = new Size(41, 43);
            tsbAutor.Text = "Autor";
            tsbAutor.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbAutor.Click += tsbAutor_Click;
            // 
            // tsbCategoria
            // 
            tsbCategoria.Image = Properties.Resources.applications;
            tsbCategoria.ImageScaling = ToolStripItemImageScaling.None;
            tsbCategoria.ImageTransparentColor = Color.Magenta;
            tsbCategoria.Name = "tsbCategoria";
            tsbCategoria.Size = new Size(62, 43);
            tsbCategoria.Text = "Categoria";
            tsbCategoria.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbCategoria.Click += tsbCategoria_Click;
            // 
            // tsbPost
            // 
            tsbPost.Image = Properties.Resources.paste;
            tsbPost.ImageScaling = ToolStripItemImageScaling.None;
            tsbPost.ImageTransparentColor = Color.Magenta;
            tsbPost.Name = "tsbPost";
            tsbPost.Size = new Size(34, 43);
            tsbPost.Text = "Post";
            tsbPost.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbPost.Click += tsbPost_Click;
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
            // tsbTag
            // 
            tsbTag.Image = (Image)resources.GetObject("tsbTag.Image");
            tsbTag.ImageScaling = ToolStripItemImageScaling.None;
            tsbTag.ImageTransparentColor = Color.Magenta;
            tsbTag.Name = "tsbTag";
            tsbTag.Size = new Size(29, 43);
            tsbTag.Text = "Tag";
            tsbTag.TextDirection = ToolStripTextDirection.Horizontal;
            tsbTag.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbTag.Click += tsbTag_Click;

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
        private ToolStripMenuItem usuárioToolStripMenuItem;
        private ToolStripMenuItem AutorToolStripMenuItem;
        private ToolStripMenuItem serviçoToolStripMenuItem;
        private ToolStripMenuItem ordemDeServiçoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem relatórioToolStripMenuItem;
        private ToolStripMenuItem AutorToolStripMenuItem1;
        private ToolStripMenuItem serviçoToolStripMenuItem1;
        private ToolStripMenuItem ordemDeServiçoToolStripMenuItem1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslUsuario;
        private ToolStripStatusLabel tsslIP;
        private ToolStripStatusLabel tsslNomePC;
        private ToolStripStatusLabel tsslData;
        private ToolStripStatusLabel tsslHora;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbAutor;
        private ToolStripButton tsbCategoria;
        private ToolStripButton tsbPost;
        private ToolStripButton tsbLogoff;
        private System.Windows.Forms.Timer timer1;
        private ToolStripButton tsbTag;
    }
}