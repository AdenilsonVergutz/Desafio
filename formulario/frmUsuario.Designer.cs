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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idUsuarioLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label repitaSenhaLabel;
            System.Windows.Forms.Label nivelAcessoLabel;
            System.Windows.Forms.Label dataDiaLabel;
            System.Windows.Forms.Label cadastradorPorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.tbUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicoDataSet = new Desafio.ServicoDataSet();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.repitaSenhaTextBox = new System.Windows.Forms.TextBox();
            this.nivelAcessoComboBox = new System.Windows.Forms.ComboBox();
            this.dataDiaTextBox = new System.Windows.Forms.TextBox();
            this.cadastradorPorTextBox = new System.Windows.Forms.TextBox();
            this.tbUsuarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbUsuarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbmFiltrar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbUsuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbUsuarioTableAdapter = new Desafio.ServicoDataSetTableAdapters.tbUsuarioTableAdapter();
            idUsuarioLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            repitaSenhaLabel = new System.Windows.Forms.Label();
            nivelAcessoLabel = new System.Windows.Forms.Label();
            dataDiaLabel = new System.Windows.Forms.Label();
            cadastradorPorLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingNavigator)).BeginInit();
            this.tbUsuarioBindingNavigator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.Location = new System.Drawing.Point(6, 33);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new System.Drawing.Size(46, 13);
            idUsuarioLabel.TabIndex = 0;
            idUsuarioLabel.Text = "Código: ";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(256, 33);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(46, 13);
            usuarioLabel.TabIndex = 2;
            usuarioLabel.Text = "Usuário ";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(6, 59);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(44, 13);
            senhaLabel.TabIndex = 4;
            senhaLabel.Text = "Senha: ";
            // 
            // repitaSenhaLabel
            // 
            repitaSenhaLabel.AutoSize = true;
            repitaSenhaLabel.Location = new System.Drawing.Point(256, 59);
            repitaSenhaLabel.Name = "repitaSenhaLabel";
            repitaSenhaLabel.Size = new System.Drawing.Size(87, 13);
            repitaSenhaLabel.TabIndex = 6;
            repitaSenhaLabel.Text = "Repita a Senha: ";
            // 
            // nivelAcessoLabel
            // 
            nivelAcessoLabel.AutoSize = true;
            nivelAcessoLabel.Location = new System.Drawing.Point(6, 81);
            nivelAcessoLabel.Name = "nivelAcessoLabel";
            nivelAcessoLabel.Size = new System.Drawing.Size(92, 13);
            nivelAcessoLabel.TabIndex = 8;
            nivelAcessoLabel.Text = "Nível de Acesso: ";
            // 
            // dataDiaLabel
            // 
            dataDiaLabel.AutoSize = true;
            dataDiaLabel.Location = new System.Drawing.Point(256, 81);
            dataDiaLabel.Name = "dataDiaLabel";
            dataDiaLabel.Size = new System.Drawing.Size(102, 13);
            dataDiaLabel.TabIndex = 10;
            dataDiaLabel.Text = "Data do Cadastrado";
            // 
            // cadastradorPorLabel
            // 
            cadastradorPorLabel.AutoSize = true;
            cadastradorPorLabel.Location = new System.Drawing.Point(6, 108);
            cadastradorPorLabel.Name = "cadastradorPorLabel";
            cadastradorPorLabel.Size = new System.Drawing.Size(85, 13);
            cadastradorPorLabel.TabIndex = 12;
            cadastradorPorLabel.Text = "Cadastrado por: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(idUsuarioLabel);
            this.groupBox1.Controls.Add(this.idUsuarioTextBox);
            this.groupBox1.Controls.Add(usuarioLabel);
            this.groupBox1.Controls.Add(this.usuarioTextBox);
            this.groupBox1.Controls.Add(senhaLabel);
            this.groupBox1.Controls.Add(this.senhaTextBox);
            this.groupBox1.Controls.Add(repitaSenhaLabel);
            this.groupBox1.Controls.Add(this.repitaSenhaTextBox);
            this.groupBox1.Controls.Add(nivelAcessoLabel);
            this.groupBox1.Controls.Add(this.nivelAcessoComboBox);
            this.groupBox1.Controls.Add(dataDiaLabel);
            this.groupBox1.Controls.Add(this.dataDiaTextBox);
            this.groupBox1.Controls.Add(cadastradorPorLabel);
            this.groupBox1.Controls.Add(this.cadastradorPorTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Usuário";
            // 
            // idUsuarioTextBox
            // 
            this.idUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "idUsuario", true));
            this.idUsuarioTextBox.Enabled = false;
            this.idUsuarioTextBox.Location = new System.Drawing.Point(104, 26);
            this.idUsuarioTextBox.Name = "idUsuarioTextBox";
            this.idUsuarioTextBox.Size = new System.Drawing.Size(121, 20);
            this.idUsuarioTextBox.TabIndex = 1;
            // 
            // tbUsuarioBindingSource
            // 
            this.tbUsuarioBindingSource.DataMember = "tbUsuario";
            this.tbUsuarioBindingSource.DataSource = this.servicoDataSet;
            // 
            // servicoDataSet
            // 
            this.servicoDataSet.DataSetName = "ServicoDataSet";
            this.servicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "usuario", true));
            this.usuarioTextBox.Location = new System.Drawing.Point(364, 26);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(146, 20);
            this.usuarioTextBox.TabIndex = 3;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(104, 52);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '●';
            this.senhaTextBox.Size = new System.Drawing.Size(121, 20);
            this.senhaTextBox.TabIndex = 5;
            // 
            // repitaSenhaTextBox
            // 
            this.repitaSenhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "repitaSenha", true));
            this.repitaSenhaTextBox.Location = new System.Drawing.Point(364, 52);
            this.repitaSenhaTextBox.Name = "repitaSenhaTextBox";
            this.repitaSenhaTextBox.PasswordChar = '●';
            this.repitaSenhaTextBox.Size = new System.Drawing.Size(146, 20);
            this.repitaSenhaTextBox.TabIndex = 7;
            // 
            // nivelAcessoComboBox
            // 
            this.nivelAcessoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.nivelAcessoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "nivelAcesso", true));
            this.nivelAcessoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nivelAcessoComboBox.FormattingEnabled = true;
            this.nivelAcessoComboBox.Items.AddRange(new object[] {
            "",
            "Administrador",
            "Operador"});
            this.nivelAcessoComboBox.Location = new System.Drawing.Point(104, 78);
            this.nivelAcessoComboBox.Name = "nivelAcessoComboBox";
            this.nivelAcessoComboBox.Size = new System.Drawing.Size(146, 21);
            this.nivelAcessoComboBox.TabIndex = 9;
            // 
            // dataDiaTextBox
            // 
            this.dataDiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "dataDia", true));
            this.dataDiaTextBox.Enabled = false;
            this.dataDiaTextBox.Location = new System.Drawing.Point(364, 78);
            this.dataDiaTextBox.Name = "dataDiaTextBox";
            this.dataDiaTextBox.Size = new System.Drawing.Size(146, 20);
            this.dataDiaTextBox.TabIndex = 11;
            // 
            // cadastradorPorTextBox
            // 
            this.cadastradorPorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "cadastradorPor", true));
            this.cadastradorPorTextBox.Enabled = false;
            this.cadastradorPorTextBox.Location = new System.Drawing.Point(104, 105);
            this.cadastradorPorTextBox.Name = "cadastradorPorTextBox";
            this.cadastradorPorTextBox.Size = new System.Drawing.Size(193, 20);
            this.cadastradorPorTextBox.TabIndex = 13;
            // 
            // tbUsuarioBindingNavigator
            // 
            this.tbUsuarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbUsuarioBindingNavigator.BindingSource = this.tbUsuarioBindingSource;
            this.tbUsuarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbUsuarioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbUsuarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbUsuarioBindingNavigatorSaveItem});
            this.tbUsuarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbUsuarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbUsuarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbUsuarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbUsuarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbUsuarioBindingNavigator.Name = "tbUsuarioBindingNavigator";
            this.tbUsuarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbUsuarioBindingNavigator.Size = new System.Drawing.Size(565, 25);
            this.tbUsuarioBindingNavigator.TabIndex = 1;
            this.tbUsuarioBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar Registro";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total de Registro";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir Registro";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover para o Primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição Atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover para o Próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover para o Último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbUsuarioBindingNavigatorSaveItem
            // 
            this.tbUsuarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbUsuarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbUsuarioBindingNavigatorSaveItem.Image")));
            this.tbUsuarioBindingNavigatorSaveItem.Name = "tbUsuarioBindingNavigatorSaveItem";
            this.tbUsuarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbUsuarioBindingNavigatorSaveItem.Text = "Salvar Registro";
            this.tbUsuarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbUsuarioBindingNavigatorSaveItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar por:";
            // 
            // cbmFiltrar
            // 
            this.cbmFiltrar.FormattingEnabled = true;
            this.cbmFiltrar.Items.AddRange(new object[] {
            "",
            "Código",
            "Usuário"});
            this.cbmFiltrar.Location = new System.Drawing.Point(65, 30);
            this.cbmFiltrar.Name = "cbmFiltrar";
            this.cbmFiltrar.Size = new System.Drawing.Size(121, 21);
            this.cbmFiltrar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "=";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.AcceptsReturn = true;
            this.txtPesquisar.Location = new System.Drawing.Point(211, 30);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(132, 20);
            this.txtPesquisar.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(349, 28);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.txtPesquisar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbmFiltrar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 69);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisar Usuário";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tbUsuarioDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(12, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(537, 247);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Usuário(s)";
            // 
            // tbUsuarioDataGridView
            // 
            this.tbUsuarioDataGridView.AutoGenerateColumns = false;
            this.tbUsuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.tbUsuarioDataGridView.DataSource = this.tbUsuarioBindingSource;
            this.tbUsuarioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUsuarioDataGridView.Location = new System.Drawing.Point(3, 16);
            this.tbUsuarioDataGridView.Name = "tbUsuarioDataGridView";
            this.tbUsuarioDataGridView.Size = new System.Drawing.Size(531, 228);
            this.tbUsuarioDataGridView.TabIndex = 0;
            this.tbUsuarioDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbUsuarioDataGridView_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idUsuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "usuario";
            this.dataGridViewTextBoxColumn2.HeaderText = "Usuário";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nivelAcesso";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nível de Acesso";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dataDia";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cadastrado no Dia";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "cadastradorPor";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cadastrado Por";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 110;
            // 
            // tbUsuarioTableAdapter
            // 
            this.tbUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 517);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbUsuarioBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingNavigator)).EndInit();
            this.tbUsuarioBindingNavigator.ResumeLayout(false);
            this.tbUsuarioBindingNavigator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ServicoDataSet servicoDataSet;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource;
        private Desafio.ServicoDataSetTableAdapters.tbUsuarioTableAdapter tbUsuarioTableAdapter;
        private System.Windows.Forms.BindingNavigator tbUsuarioBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbUsuarioBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idUsuarioTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox repitaSenhaTextBox;
        private System.Windows.Forms.ComboBox nivelAcessoComboBox;
        private System.Windows.Forms.TextBox dataDiaTextBox;
        private System.Windows.Forms.TextBox cadastradorPorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmFiltrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView tbUsuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}