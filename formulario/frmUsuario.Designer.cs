namespace Desafio.formulario
{
    partial class frmUsuario
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
            Label idUsuarioLabel;
            Label usuarioLabel;
            Label senhaLabel;
            Label repitaSenhaLabel;
            Label nivelAcessoLabel;
            Label dataDiaLabel;
            Label cadastradorPorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            biolabel = new Label();
            sluglabel = new Label();
            emallabel = new Label();
            groupBox1 = new GroupBox();
            idUsuarioTextBox = new TextBox();
            tbUsuarioBindingSource = new BindingSource(components);
            servicoDataSet = new ServicoDataSet();
            bioTextBox = new TextBox();
            slugTextBox = new TextBox();
            emailTextBox = new TextBox();
            usuarioTextBox = new TextBox();
            senhaTextBox = new TextBox();
            repitaSenhaTextBox = new TextBox();
            nivelAcessoComboBox = new ComboBox();
            dataDiaTextBox = new TextBox();
            cadastradorPorTextBox = new TextBox();
            tbUsuarioBindingNavigator = new BindingNavigator(components);
            bindingNavigatorAddNewItem = new ToolStripButton();
            bindingNavigatorCountItem = new ToolStripLabel();
            bindingNavigatorDeleteItem = new ToolStripButton();
            bindingNavigatorMoveFirstItem = new ToolStripButton();
            bindingNavigatorMovePreviousItem = new ToolStripButton();
            bindingNavigatorSeparator = new ToolStripSeparator();
            bindingNavigatorPositionItem = new ToolStripTextBox();
            bindingNavigatorSeparator1 = new ToolStripSeparator();
            bindingNavigatorMoveNextItem = new ToolStripButton();
            bindingNavigatorMoveLastItem = new ToolStripButton();
            bindingNavigatorSeparator2 = new ToolStripSeparator();
            tbUsuarioBindingNavigatorSaveItem = new ToolStripButton();
            label1 = new Label();
            cbmFiltrar = new ComboBox();
            label2 = new Label();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            tbUsuarioDataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            tbUsuarioTableAdapter = new ServicoDataSetTableAdapters.tbUsuarioTableAdapter();
            idUsuarioLabel = new Label();
            usuarioLabel = new Label();
            senhaLabel = new Label();
            repitaSenhaLabel = new Label();
            nivelAcessoLabel = new Label();
            dataDiaLabel = new Label();
            cadastradorPorLabel = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbUsuarioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)servicoDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbUsuarioBindingNavigator).BeginInit();
            tbUsuarioBindingNavigator.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbUsuarioDataGridView).BeginInit();
            SuspendLayout();
            // 
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.Location = new Point(4, 27);
            idUsuarioLabel.Margin = new Padding(4, 0, 4, 0);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new Size(52, 15);
            idUsuarioLabel.TabIndex = 0;
            idUsuarioLabel.Text = "Código: ";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new Point(131, 29);
            usuarioLabel.Margin = new Padding(4, 0, 4, 0);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new Size(43, 15);
            usuarioLabel.TabIndex = 2;
            usuarioLabel.Text = "Nome:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new Point(8, 61);
            senhaLabel.Margin = new Padding(4, 0, 4, 0);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new Size(45, 15);
            senhaLabel.TabIndex = 4;
            senhaLabel.Text = "Senha: ";
            // 
            // repitaSenhaLabel
            // 
            repitaSenhaLabel.AutoSize = true;
            repitaSenhaLabel.Location = new Point(177, 62);
            repitaSenhaLabel.Margin = new Padding(4, 0, 4, 0);
            repitaSenhaLabel.Name = "repitaSenhaLabel";
            repitaSenhaLabel.Size = new Size(90, 15);
            repitaSenhaLabel.TabIndex = 6;
            repitaSenhaLabel.Text = "Repita a Senha: ";
            // 
            // nivelAcessoLabel
            // 
            nivelAcessoLabel.AutoSize = true;
            nivelAcessoLabel.Location = new Point(342, 29);
            nivelAcessoLabel.Margin = new Padding(4, 0, 4, 0);
            nivelAcessoLabel.Name = "nivelAcessoLabel";
            nivelAcessoLabel.Size = new Size(96, 15);
            nivelAcessoLabel.TabIndex = 8;
            nivelAcessoLabel.Text = "Perfil de Acesso: ";
            // 
            // dataDiaLabel
            // 
            dataDiaLabel.AutoSize = true;
            dataDiaLabel.Location = new Point(333, 177);
            dataDiaLabel.Margin = new Padding(4, 0, 4, 0);
            dataDiaLabel.Name = "dataDiaLabel";
            dataDiaLabel.Size = new Size(114, 15);
            dataDiaLabel.TabIndex = 10;
            dataDiaLabel.Text = "Data do Cadastrado:";
            // 
            // cadastradorPorLabel
            // 
            cadastradorPorLabel.AutoSize = true;
            cadastradorPorLabel.Location = new Point(2, 176);
            cadastradorPorLabel.Margin = new Padding(4, 0, 4, 0);
            cadastradorPorLabel.Name = "cadastradorPorLabel";
            cadastradorPorLabel.Size = new Size(94, 15);
            cadastradorPorLabel.TabIndex = 12;
            cadastradorPorLabel.Text = "Cadastrado por: ";
            // 
            // biolabel
            // 
            biolabel.AutoSize = true;
            biolabel.Location = new Point(11, 100);
            biolabel.Name = "biolabel";
            biolabel.Size = new Size(27, 15);
            biolabel.TabIndex = 19;
            biolabel.Text = "Bio:";
            // 
            // sluglabel
            // 
            sluglabel.AutoSize = true;
            sluglabel.Location = new Point(364, 99);
            sluglabel.Name = "sluglabel";
            sluglabel.Size = new Size(33, 15);
            sluglabel.TabIndex = 18;
            sluglabel.Text = "Slug:";
            sluglabel.Click += label4_Click;
            // 
            // emallabel
            // 
            emallabel.AutoSize = true;
            emallabel.Location = new Point(403, 64);
            emallabel.Name = "emallabel";
            emallabel.Size = new Size(39, 15);
            emallabel.TabIndex = 14;
            emallabel.Text = "Email:";
            emallabel.Click += label3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(biolabel);
            groupBox1.Controls.Add(idUsuarioLabel);
            groupBox1.Controls.Add(sluglabel);
            groupBox1.Controls.Add(idUsuarioTextBox);
            groupBox1.Controls.Add(bioTextBox);
            groupBox1.Controls.Add(slugTextBox);
            groupBox1.Controls.Add(emailTextBox);
            groupBox1.Controls.Add(emallabel);
            groupBox1.Controls.Add(usuarioLabel);
            groupBox1.Controls.Add(usuarioTextBox);
            groupBox1.Controls.Add(senhaLabel);
            groupBox1.Controls.Add(senhaTextBox);
            groupBox1.Controls.Add(repitaSenhaLabel);
            groupBox1.Controls.Add(repitaSenhaTextBox);
            groupBox1.Controls.Add(nivelAcessoLabel);
            groupBox1.Controls.Add(nivelAcessoComboBox);
            groupBox1.Controls.Add(dataDiaLabel);
            groupBox1.Controls.Add(dataDiaTextBox);
            groupBox1.Controls.Add(cadastradorPorLabel);
            groupBox1.Controls.Add(cadastradorPorTextBox);
            groupBox1.Location = new Point(14, 52);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(622, 214);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastrar Usuário";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // idUsuarioTextBox
            // 
            idUsuarioTextBox.DataBindings.Add(new Binding("Text", tbUsuarioBindingSource, "idUsuario", true));
            idUsuarioTextBox.Enabled = false;
            idUsuarioTextBox.Location = new Point(54, 24);
            idUsuarioTextBox.Margin = new Padding(4, 3, 4, 3);
            idUsuarioTextBox.Name = "idUsuarioTextBox";
            idUsuarioTextBox.Size = new Size(76, 23);
            idUsuarioTextBox.TabIndex = 1;
            // 
            // tbUsuarioBindingSource
            // 
            tbUsuarioBindingSource.DataMember = "tbUsuario";
            tbUsuarioBindingSource.DataSource = servicoDataSet;
            // 
            // servicoDataSet
            // 
            servicoDataSet.DataSetName = "ServicoDataSet";
            servicoDataSet.Namespace = "http://tempuri.org/ServicoDataSet.xsd";
            servicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bioTextBox
            // 
            bioTextBox.DataBindings.Add(new Binding("Text", tbUsuarioBindingSource, "bio", true));
            bioTextBox.Location = new Point(8, 117);
            bioTextBox.Multiline = true;
            bioTextBox.Name = "bioTextBox";
            bioTextBox.Size = new Size(304, 51);
            bioTextBox.TabIndex = 17;
            // 
            // slugTextBox
            // 
            slugTextBox.DataBindings.Add(new Binding("Text", tbUsuarioBindingSource, "slug", true));
            slugTextBox.ForeColor = SystemColors.MenuText;
            slugTextBox.Location = new Point(356, 117);
            slugTextBox.Multiline = true;
            slugTextBox.Name = "slugTextBox";
            slugTextBox.Size = new Size(251, 51);
            slugTextBox.TabIndex = 16;
            // 
            // emailTextBox
            // 
            emailTextBox.DataBindings.Add(new Binding("Text", tbUsuarioBindingSource, "email", true));
            emailTextBox.Location = new Point(448, 59);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(159, 23);
            emailTextBox.TabIndex = 15;
            // 
            // usuarioTextBox
            // 
            usuarioTextBox.DataBindings.Add(new Binding("Text", tbUsuarioBindingSource, "usuario", true));
            usuarioTextBox.Location = new Point(176, 25);
            usuarioTextBox.Margin = new Padding(4, 3, 4, 3);
            usuarioTextBox.Name = "usuarioTextBox";
            usuarioTextBox.Size = new Size(163, 23);
            usuarioTextBox.TabIndex = 3;
            // 
            // senhaTextBox
            // 
            senhaTextBox.DataBindings.Add(new Binding("Text", tbUsuarioBindingSource, "senha", true));
            senhaTextBox.Location = new Point(53, 58);
            senhaTextBox.Margin = new Padding(4, 3, 4, 3);
            senhaTextBox.Name = "senhaTextBox";
            senhaTextBox.PasswordChar = '●';
            senhaTextBox.Size = new Size(113, 23);
            senhaTextBox.TabIndex = 5;
            // 
            // repitaSenhaTextBox
            // 
            repitaSenhaTextBox.DataBindings.Add(new Binding("Text", tbUsuarioBindingSource, "repitaSenha", true));
            repitaSenhaTextBox.Location = new Point(267, 59);
            repitaSenhaTextBox.Margin = new Padding(4, 3, 4, 3);
            repitaSenhaTextBox.Name = "repitaSenhaTextBox";
            repitaSenhaTextBox.PasswordChar = '●';
            repitaSenhaTextBox.Size = new Size(116, 23);
            repitaSenhaTextBox.TabIndex = 7;
            // 
            // nivelAcessoComboBox
            // 
            nivelAcessoComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            nivelAcessoComboBox.DataBindings.Add(new Binding("Text", tbUsuarioBindingSource, "nivelAcesso", true));
            nivelAcessoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            nivelAcessoComboBox.FormattingEnabled = true;
            nivelAcessoComboBox.Items.AddRange(new object[] { "", "Administrador", "Operador" });
            nivelAcessoComboBox.Location = new Point(436, 25);
            nivelAcessoComboBox.Margin = new Padding(4, 3, 4, 3);
            nivelAcessoComboBox.Name = "nivelAcessoComboBox";
            nivelAcessoComboBox.Size = new Size(170, 23);
            nivelAcessoComboBox.TabIndex = 9;
            // 
            // dataDiaTextBox
            // 
            dataDiaTextBox.DataBindings.Add(new Binding("Text", tbUsuarioBindingSource, "dataDia", true));
            dataDiaTextBox.Enabled = false;
            dataDiaTextBox.Location = new Point(448, 173);
            dataDiaTextBox.Margin = new Padding(4, 3, 4, 3);
            dataDiaTextBox.Name = "dataDiaTextBox";
            dataDiaTextBox.Size = new Size(159, 23);
            dataDiaTextBox.TabIndex = 11;
            // 
            // cadastradorPorTextBox
            // 
            cadastradorPorTextBox.DataBindings.Add(new Binding("Text", tbUsuarioBindingSource, "cadastradorPor", true));
            cadastradorPorTextBox.Enabled = false;
            cadastradorPorTextBox.Location = new Point(97, 174);
            cadastradorPorTextBox.Margin = new Padding(4, 3, 4, 3);
            cadastradorPorTextBox.Name = "cadastradorPorTextBox";
            cadastradorPorTextBox.Size = new Size(215, 23);
            cadastradorPorTextBox.TabIndex = 13;
            // 
            // tbUsuarioBindingNavigator
            // 
            tbUsuarioBindingNavigator.AddNewItem = bindingNavigatorAddNewItem;
            tbUsuarioBindingNavigator.BindingSource = tbUsuarioBindingSource;
            tbUsuarioBindingNavigator.CountItem = bindingNavigatorCountItem;
            tbUsuarioBindingNavigator.DeleteItem = bindingNavigatorDeleteItem;
            tbUsuarioBindingNavigator.Items.AddRange(new ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, tbUsuarioBindingNavigatorSaveItem });
            tbUsuarioBindingNavigator.Location = new Point(0, 0);
            tbUsuarioBindingNavigator.MoveFirstItem = bindingNavigatorMoveFirstItem;
            tbUsuarioBindingNavigator.MoveLastItem = bindingNavigatorMoveLastItem;
            tbUsuarioBindingNavigator.MoveNextItem = bindingNavigatorMoveNextItem;
            tbUsuarioBindingNavigator.MovePreviousItem = bindingNavigatorMovePreviousItem;
            tbUsuarioBindingNavigator.Name = "tbUsuarioBindingNavigator";
            tbUsuarioBindingNavigator.PositionItem = bindingNavigatorPositionItem;
            tbUsuarioBindingNavigator.Size = new Size(659, 25);
            tbUsuarioBindingNavigator.TabIndex = 1;
            tbUsuarioBindingNavigator.Text = "bindingNavigator1";
            tbUsuarioBindingNavigator.RefreshItems += tbUsuarioBindingNavigator_RefreshItems;
            // 
            // bindingNavigatorAddNewItem
            // 
            bindingNavigatorAddNewItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bindingNavigatorAddNewItem.Image = (Image)resources.GetObject("bindingNavigatorAddNewItem.Image");
            bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorAddNewItem.Size = new Size(23, 22);
            bindingNavigatorAddNewItem.Text = "Adicionar Registro";
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new Size(37, 22);
            bindingNavigatorCountItem.Text = "de {0}";
            bindingNavigatorCountItem.ToolTipText = "Total de Registro";
            // 
            // bindingNavigatorDeleteItem
            // 
            bindingNavigatorDeleteItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bindingNavigatorDeleteItem.Image = (Image)resources.GetObject("bindingNavigatorDeleteItem.Image");
            bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorDeleteItem.Size = new Size(23, 22);
            bindingNavigatorDeleteItem.Text = "Excluir Registro";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            bindingNavigatorMoveFirstItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveFirstItem.Image = (Image)resources.GetObject("bindingNavigatorMoveFirstItem.Image");
            bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveFirstItem.Size = new Size(23, 22);
            bindingNavigatorMoveFirstItem.Text = "Mover para o Primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            bindingNavigatorMovePreviousItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bindingNavigatorMovePreviousItem.Image = (Image)resources.GetObject("bindingNavigatorMovePreviousItem.Image");
            bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMovePreviousItem.Size = new Size(23, 22);
            bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            bindingNavigatorSeparator.Size = new Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            bindingNavigatorPositionItem.AccessibleName = "Position";
            bindingNavigatorPositionItem.AutoSize = false;
            bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            bindingNavigatorPositionItem.Size = new Size(58, 23);
            bindingNavigatorPositionItem.Text = "0";
            bindingNavigatorPositionItem.ToolTipText = "Posição Atual";
            // 
            // bindingNavigatorSeparator1
            // 
            bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            bindingNavigatorSeparator1.Size = new Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            bindingNavigatorMoveNextItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveNextItem.Image = (Image)resources.GetObject("bindingNavigatorMoveNextItem.Image");
            bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveNextItem.Size = new Size(23, 22);
            bindingNavigatorMoveNextItem.Text = "Mover para o Próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = (Image)resources.GetObject("bindingNavigatorMoveLastItem.Image");
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new Size(23, 22);
            bindingNavigatorMoveLastItem.Text = "Mover para o Último";
            // 
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new Size(6, 25);
            // 
            // tbUsuarioBindingNavigatorSaveItem
            // 
            tbUsuarioBindingNavigatorSaveItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbUsuarioBindingNavigatorSaveItem.Image = (Image)resources.GetObject("tbUsuarioBindingNavigatorSaveItem.Image");
            tbUsuarioBindingNavigatorSaveItem.Name = "tbUsuarioBindingNavigatorSaveItem";
            tbUsuarioBindingNavigatorSaveItem.Size = new Size(23, 22);
            tbUsuarioBindingNavigatorSaveItem.Text = "Salvar Registro";
            tbUsuarioBindingNavigatorSaveItem.Click += tbUsuarioBindingNavigatorSaveItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Filtrar por:";
            // 
            // cbmFiltrar
            // 
            cbmFiltrar.FormattingEnabled = true;
            cbmFiltrar.Items.AddRange(new object[] { "", "Código", "Usuário" });
            cbmFiltrar.Location = new Point(76, 35);
            cbmFiltrar.Margin = new Padding(4, 3, 4, 3);
            cbmFiltrar.Name = "cbmFiltrar";
            cbmFiltrar.Size = new Size(140, 23);
            cbmFiltrar.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 38);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 2;
            label2.Text = "=";
            // 
            // txtPesquisar
            // 
            txtPesquisar.AcceptsReturn = true;
            txtPesquisar.Location = new Point(246, 35);
            txtPesquisar.Margin = new Padding(4, 3, 4, 3);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(153, 23);
            txtPesquisar.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(407, 32);
            btnPesquisar.Margin = new Padding(4, 3, 4, 3);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(88, 27);
            btnPesquisar.TabIndex = 4;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(btnPesquisar);
            groupBox2.Controls.Add(txtPesquisar);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cbmFiltrar);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(14, 272);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(622, 69);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pesquisar Usuário";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(tbUsuarioDataGridView);
            groupBox3.Location = new Point(14, 346);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(626, 251);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Usuário(s)";
            // 
            // tbUsuarioDataGridView
            // 
            tbUsuarioDataGridView.AutoGenerateColumns = false;
            tbUsuarioDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            tbUsuarioDataGridView.DataSource = tbUsuarioBindingSource;
            tbUsuarioDataGridView.Dock = DockStyle.Fill;
            tbUsuarioDataGridView.Location = new Point(4, 19);
            tbUsuarioDataGridView.Margin = new Padding(4, 3, 4, 3);
            tbUsuarioDataGridView.Name = "tbUsuarioDataGridView";
            tbUsuarioDataGridView.Size = new Size(618, 229);
            tbUsuarioDataGridView.TabIndex = 0;
            tbUsuarioDataGridView.MouseDoubleClick += tbUsuarioDataGridView_MouseDoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "idUsuario";
            dataGridViewTextBoxColumn1.HeaderText = "Código";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "usuario";
            dataGridViewTextBoxColumn2.HeaderText = "Usuário";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "nivelAcesso";
            dataGridViewTextBoxColumn5.HeaderText = "Nível de Acesso";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "dataDia";
            dataGridViewTextBoxColumn6.HeaderText = "Cadastrado no Dia";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 120;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "cadastradorPor";
            dataGridViewTextBoxColumn7.HeaderText = "Cadastrado Por";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 110;
            // 
            // tbUsuarioTableAdapter
            // 
            tbUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 597);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(tbUsuarioBindingNavigator);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Usuário";
            Load += frmUsuario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbUsuarioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)servicoDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbUsuarioBindingNavigator).EndInit();
            tbUsuarioBindingNavigator.ResumeLayout(false);
            tbUsuarioBindingNavigator.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbUsuarioDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ServicoDataSet servicoDataSet;
        private BindingSource tbUsuarioBindingSource;
        private Desafio.ServicoDataSetTableAdapters.tbUsuarioTableAdapter tbUsuarioTableAdapter;
        private BindingNavigator tbUsuarioBindingNavigator;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ToolStripButton tbUsuarioBindingNavigatorSaveItem;
        private TextBox idUsuarioTextBox;
        private TextBox usuarioTextBox;
        private TextBox senhaTextBox;
        private TextBox repitaSenhaTextBox;
        private ComboBox nivelAcessoComboBox;
        private TextBox dataDiaTextBox;
        private TextBox cadastradorPorTextBox;
        private Label label1;
        private ComboBox cbmFiltrar;
        private Label label2;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView tbUsuarioDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Label emallabel;
        private Label sluglabel;
        private TextBox bioTextBox;
        private TextBox slugTextBox;
        private TextBox emailTextBox;
        private Label biolabel;
    }
}