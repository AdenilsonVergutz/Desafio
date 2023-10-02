namespace Desafio
{
    partial class frmOS
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
            System.Windows.Forms.Label idOrdemLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label idServicoLabel;
            System.Windows.Forms.Label dataDiaLabel;
            System.Windows.Forms.Label cadastradorPorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOS));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cadastradorPorTextBox = new System.Windows.Forms.TextBox();
            this.tbOrdemServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicoDataSet = new Desafio.ServicoDataSet();
            this.dataDiaTextBox = new System.Windows.Forms.TextBox();
            this.idServicoComboBox = new System.Windows.Forms.ComboBox();
            this.tbServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idClienteComboBox = new System.Windows.Forms.ComboBox();
            this.tbClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idOrdemTextBox = new System.Windows.Forms.TextBox();
            this.tbOrdemServicoTableAdapter = new Desafio.ServicoDataSetTableAdapters.tbOrdemServicoTableAdapter();
            this.tbOrdemServicoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tbOrdemServicoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbmFiltrar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbOrdemServicoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbClienteTableAdapter = new Desafio.ServicoDataSetTableAdapters.tbClienteTableAdapter();
            this.tbServicoTableAdapter = new Desafio.ServicoDataSetTableAdapters.tbServicoTableAdapter();
            idOrdemLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            idServicoLabel = new System.Windows.Forms.Label();
            dataDiaLabel = new System.Windows.Forms.Label();
            cadastradorPorLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoBindingNavigator)).BeginInit();
            this.tbOrdemServicoBindingNavigator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // idOrdemLabel
            // 
            idOrdemLabel.AutoSize = true;
            idOrdemLabel.Location = new System.Drawing.Point(7, 22);
            idOrdemLabel.Name = "idOrdemLabel";
            idOrdemLabel.Size = new System.Drawing.Size(61, 13);
            idOrdemLabel.TabIndex = 0;
            idOrdemLabel.Text = "Código OS:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(7, 61);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(88, 13);
            idClienteLabel.TabIndex = 2;
            idClienteLabel.Text = "Nome do Cliente:";
            // 
            // idServicoLabel
            // 
            idServicoLabel.AutoSize = true;
            idServicoLabel.Location = new System.Drawing.Point(7, 102);
            idServicoLabel.Name = "idServicoLabel";
            idServicoLabel.Size = new System.Drawing.Size(92, 13);
            idServicoLabel.TabIndex = 4;
            idServicoLabel.Text = "Nome do Serviço:";
            // 
            // dataDiaLabel
            // 
            dataDiaLabel.AutoSize = true;
            dataDiaLabel.Location = new System.Drawing.Point(9, 142);
            dataDiaLabel.Name = "dataDiaLabel";
            dataDiaLabel.Size = new System.Drawing.Size(93, 13);
            dataDiaLabel.TabIndex = 6;
            dataDiaLabel.Text = "Data do Cadastro:";
            // 
            // cadastradorPorLabel
            // 
            cadastradorPorLabel.AutoSize = true;
            cadastradorPorLabel.Location = new System.Drawing.Point(9, 181);
            cadastradorPorLabel.Name = "cadastradorPorLabel";
            cadastradorPorLabel.Size = new System.Drawing.Size(86, 13);
            cadastradorPorLabel.TabIndex = 8;
            cadastradorPorLabel.Text = "Cadastrado Por: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(cadastradorPorLabel);
            this.groupBox1.Controls.Add(this.cadastradorPorTextBox);
            this.groupBox1.Controls.Add(dataDiaLabel);
            this.groupBox1.Controls.Add(this.dataDiaTextBox);
            this.groupBox1.Controls.Add(idServicoLabel);
            this.groupBox1.Controls.Add(this.idServicoComboBox);
            this.groupBox1.Controls.Add(idClienteLabel);
            this.groupBox1.Controls.Add(this.idClienteComboBox);
            this.groupBox1.Controls.Add(idOrdemLabel);
            this.groupBox1.Controls.Add(this.idOrdemTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados OS";
            // 
            // cadastradorPorTextBox
            // 
            this.cadastradorPorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOrdemServicoBindingSource, "cadastradorPor", true));
            this.cadastradorPorTextBox.Enabled = false;
            this.cadastradorPorTextBox.Location = new System.Drawing.Point(12, 197);
            this.cadastradorPorTextBox.Name = "cadastradorPorTextBox";
            this.cadastradorPorTextBox.Size = new System.Drawing.Size(159, 20);
            this.cadastradorPorTextBox.TabIndex = 9;
            // 
            // tbOrdemServicoBindingSource
            // 
            this.tbOrdemServicoBindingSource.DataMember = "tbOrdemServico";
            this.tbOrdemServicoBindingSource.DataSource = this.servicoDataSet;
            // 
            // servicoDataSet
            // 
            this.servicoDataSet.DataSetName = "ServicoDataSet";
            this.servicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataDiaTextBox
            // 
            this.dataDiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOrdemServicoBindingSource, "dataDia", true));
            this.dataDiaTextBox.Enabled = false;
            this.dataDiaTextBox.Location = new System.Drawing.Point(12, 158);
            this.dataDiaTextBox.Name = "dataDiaTextBox";
            this.dataDiaTextBox.Size = new System.Drawing.Size(159, 20);
            this.dataDiaTextBox.TabIndex = 7;
            // 
            // idServicoComboBox
            // 
            this.idServicoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOrdemServicoBindingSource, "idServico", true));
            this.idServicoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbOrdemServicoBindingSource, "idServico", true));
            this.idServicoComboBox.DataSource = this.tbServicoBindingSource;
            this.idServicoComboBox.DisplayMember = "idServico";
            this.idServicoComboBox.FormattingEnabled = true;
            this.idServicoComboBox.Location = new System.Drawing.Point(10, 118);
            this.idServicoComboBox.Name = "idServicoComboBox";
            this.idServicoComboBox.Size = new System.Drawing.Size(276, 21);
            this.idServicoComboBox.TabIndex = 5;
            this.idServicoComboBox.ValueMember = "idServico";
            // 
            // tbServicoBindingSource
            // 
            this.tbServicoBindingSource.DataMember = "tbServico";
            this.tbServicoBindingSource.DataSource = this.servicoDataSet;
            // 
            // idClienteComboBox
            // 
            this.idClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOrdemServicoBindingSource, "idCliente", true));
            this.idClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbOrdemServicoBindingSource, "idCliente", true));
            this.idClienteComboBox.DataSource = this.tbClienteBindingSource;
            this.idClienteComboBox.DisplayMember = "idCliente";
            this.idClienteComboBox.FormattingEnabled = true;
            this.idClienteComboBox.Location = new System.Drawing.Point(10, 77);
            this.idClienteComboBox.Name = "idClienteComboBox";
            this.idClienteComboBox.Size = new System.Drawing.Size(276, 21);
            this.idClienteComboBox.TabIndex = 3;
            this.idClienteComboBox.ValueMember = "idCliente";
            // 
            // tbClienteBindingSource
            // 
            this.tbClienteBindingSource.DataMember = "tbCliente";
            this.tbClienteBindingSource.DataSource = this.servicoDataSet;
            // 
            // idOrdemTextBox
            // 
            this.idOrdemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOrdemServicoBindingSource, "idOrdem", true));
            this.idOrdemTextBox.Enabled = false;
            this.idOrdemTextBox.Location = new System.Drawing.Point(10, 38);
            this.idOrdemTextBox.Name = "idOrdemTextBox";
            this.idOrdemTextBox.Size = new System.Drawing.Size(100, 20);
            this.idOrdemTextBox.TabIndex = 1;
            // 
            // tbOrdemServicoTableAdapter
            // 
            this.tbOrdemServicoTableAdapter.ClearBeforeFill = true;
            // 
            // tbOrdemServicoBindingNavigator
            // 
            this.tbOrdemServicoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbOrdemServicoBindingNavigator.BindingSource = this.tbOrdemServicoBindingSource;
            this.tbOrdemServicoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbOrdemServicoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbOrdemServicoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbOrdemServicoBindingNavigatorSaveItem});
            this.tbOrdemServicoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbOrdemServicoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbOrdemServicoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbOrdemServicoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbOrdemServicoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbOrdemServicoBindingNavigator.Name = "tbOrdemServicoBindingNavigator";
            this.tbOrdemServicoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbOrdemServicoBindingNavigator.Size = new System.Drawing.Size(571, 25);
            this.tbOrdemServicoBindingNavigator.TabIndex = 3;
            this.tbOrdemServicoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
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
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbOrdemServicoBindingNavigatorSaveItem
            // 
            this.tbOrdemServicoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbOrdemServicoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbOrdemServicoBindingNavigatorSaveItem.Image")));
            this.tbOrdemServicoBindingNavigatorSaveItem.Name = "tbOrdemServicoBindingNavigatorSaveItem";
            this.tbOrdemServicoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbOrdemServicoBindingNavigatorSaveItem.Text = "Save Data";
            this.tbOrdemServicoBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbOrdemServicoBindingNavigatorSaveItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtrar por:";
            // 
            // cbmFiltrar
            // 
            this.cbmFiltrar.FormattingEnabled = true;
            this.cbmFiltrar.Items.AddRange(new object[] {
            "",
            "Código OS",
            "Código Cliente",
            "Código Serviço"});
            this.cbmFiltrar.Location = new System.Drawing.Point(65, 29);
            this.cbmFiltrar.Name = "cbmFiltrar";
            this.cbmFiltrar.Size = new System.Drawing.Size(121, 21);
            this.cbmFiltrar.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "=";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(349, 27);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(211, 29);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(132, 20);
            this.txtPesquisar.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtPesquisar);
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbmFiltrar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OS(s)";
            // 
            // tbOrdemServicoDataGridView
            // 
            this.tbOrdemServicoDataGridView.AllowUserToAddRows = false;
            this.tbOrdemServicoDataGridView.AllowUserToDeleteRows = false;
            this.tbOrdemServicoDataGridView.AutoGenerateColumns = false;
            this.tbOrdemServicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tbOrdemServicoDataGridView.DataSource = this.tbOrdemServicoBindingSource;
            this.tbOrdemServicoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOrdemServicoDataGridView.Location = new System.Drawing.Point(3, 16);
            this.tbOrdemServicoDataGridView.Name = "tbOrdemServicoDataGridView";
            this.tbOrdemServicoDataGridView.ReadOnly = true;
            this.tbOrdemServicoDataGridView.Size = new System.Drawing.Size(544, 214);
            this.tbOrdemServicoDataGridView.TabIndex = 0;
            this.tbOrdemServicoDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbOrdemServicoDataGridView_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idOrdem";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código OS";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idCliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código Cliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idServico";
            this.dataGridViewTextBoxColumn3.HeaderText = "Código Serviço";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dataDia";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data do Cadastro";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cadastradorPor";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cadastrado Por";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tbOrdemServicoDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(9, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(550, 233);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OS(s)";
            // 
            // tbClienteTableAdapter
            // 
            this.tbClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tbServicoTableAdapter
            // 
            this.tbServicoTableAdapter.ClearBeforeFill = true;
            // 
            // frmOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 596);
            this.Controls.Add(this.tbOrdemServicoBindingNavigator);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar OS";
            this.Load += new System.EventHandler(this.frmOS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoBindingNavigator)).EndInit();
            this.tbOrdemServicoBindingNavigator.ResumeLayout(false);
            this.tbOrdemServicoBindingNavigator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ServicoDataSet servicoDataSet;
        private System.Windows.Forms.BindingSource tbOrdemServicoBindingSource;
        private Desafio.ServicoDataSetTableAdapters.tbOrdemServicoTableAdapter tbOrdemServicoTableAdapter;
        private System.Windows.Forms.BindingNavigator tbOrdemServicoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbOrdemServicoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cadastradorPorTextBox;
        private System.Windows.Forms.TextBox dataDiaTextBox;
        private System.Windows.Forms.ComboBox idServicoComboBox;
        private System.Windows.Forms.ComboBox idClienteComboBox;
        private System.Windows.Forms.TextBox idOrdemTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmFiltrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.MaskedTextBox txtPesquisar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tbOrdemServicoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource tbClienteBindingSource;
        private Desafio.ServicoDataSetTableAdapters.tbClienteTableAdapter tbClienteTableAdapter;
        private System.Windows.Forms.BindingSource tbServicoBindingSource;
        private Desafio.ServicoDataSetTableAdapters.tbServicoTableAdapter tbServicoTableAdapter;
    }
}