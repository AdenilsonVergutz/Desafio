using Desafio;

namespace Desafio
{
    partial class frmCliente
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
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label dataDiaLabel;
            System.Windows.Forms.Label cadastradoPorLabel;
            System.Windows.Forms.Label estadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.tbClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicoDataSet = new ServicoDataSet();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.dataDiaTextBox = new System.Windows.Forms.TextBox();
            this.cadastradoPorTextBox = new System.Windows.Forms.TextBox();
            this.tbClienteTableAdapter = new Desafio.ServicoDataSetTableAdapters.tbClienteTableAdapter();
            this.tbClienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tbClienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPesquisar = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbmFiltrar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbClienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbOrdemServicoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbOrdemServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbOrdemServicoTableAdapter = new Desafio.ServicoDataSetTableAdapters.tbOrdemServicoTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            idClienteLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            dataDiaLabel = new System.Windows.Forms.Label();
            cadastradoPorLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingNavigator)).BeginInit();
            this.tbClienteBindingNavigator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteDataGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(9, 16);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(43, 13);
            idClienteLabel.TabIndex = 0;
            idClienteLabel.Text = "Código:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(113, 16);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Location = new System.Drawing.Point(9, 55);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(33, 13);
            cpfLabel.TabIndex = 4;
            cpfLabel.Text = "CPF: ";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(152, 55);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(55, 13);
            telefoneLabel.TabIndex = 6;
            telefoneLabel.Text = "Telefone: ";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(9, 94);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(59, 13);
            enderecoLabel.TabIndex = 8;
            enderecoLabel.Text = "Endereço: ";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(9, 133);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(40, 13);
            bairroLabel.TabIndex = 10;
            bairroLabel.Text = "Bairro: ";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(206, 133);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(46, 13);
            cidadeLabel.TabIndex = 12;
            cidadeLabel.Text = "Cidade: ";
            // 
            // dataDiaLabel
            // 
            dataDiaLabel.AutoSize = true;
            dataDiaLabel.Location = new System.Drawing.Point(12, 172);
            dataDiaLabel.Name = "dataDiaLabel";
            dataDiaLabel.Size = new System.Drawing.Size(96, 13);
            dataDiaLabel.TabIndex = 16;
            dataDiaLabel.Text = "Data do Cadastro: ";
            // 
            // cadastradoPorLabel
            // 
            cadastradoPorLabel.AutoSize = true;
            cadastradoPorLabel.Location = new System.Drawing.Point(162, 172);
            cadastradoPorLabel.Name = "cadastradoPorLabel";
            cadastradoPorLabel.Size = new System.Drawing.Size(86, 13);
            cadastradoPorLabel.TabIndex = 18;
            cadastradoPorLabel.Text = "Cadastrado Por: ";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(335, 133);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(46, 13);
            estadoLabel.TabIndex = 19;
            estadoLabel.Text = "Estado: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(estadoLabel);
            this.groupBox1.Controls.Add(this.estadoComboBox);
            this.groupBox1.Controls.Add(idClienteLabel);
            this.groupBox1.Controls.Add(this.idClienteTextBox);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Controls.Add(this.nomeTextBox);
            this.groupBox1.Controls.Add(cpfLabel);
            this.groupBox1.Controls.Add(this.cpfMaskedTextBox);
            this.groupBox1.Controls.Add(telefoneLabel);
            this.groupBox1.Controls.Add(this.telefoneMaskedTextBox);
            this.groupBox1.Controls.Add(enderecoLabel);
            this.groupBox1.Controls.Add(this.enderecoTextBox);
            this.groupBox1.Controls.Add(bairroLabel);
            this.groupBox1.Controls.Add(this.bairroTextBox);
            this.groupBox1.Controls.Add(cidadeLabel);
            this.groupBox1.Controls.Add(this.cidadeTextBox);
            this.groupBox1.Controls.Add(dataDiaLabel);
            this.groupBox1.Controls.Add(this.dataDiaTextBox);
            this.groupBox1.Controls.Add(cadastradoPorLabel);
            this.groupBox1.Controls.Add(this.cadastradoPorTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "estado", true));
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "",
            "DF",
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.estadoComboBox.Location = new System.Drawing.Point(338, 149);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(78, 21);
            this.estadoComboBox.TabIndex = 20;
            // 
            // tbClienteBindingSource
            // 
            this.tbClienteBindingSource.DataMember = "tbCliente";
            this.tbClienteBindingSource.DataSource = this.servicoDataSet;
            // 
            // servicoDataSet
            // 
            this.servicoDataSet.DataSetName = "ServicoDataSet";
            this.servicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "idCliente", true));
            this.idClienteTextBox.Enabled = false;
            this.idClienteTextBox.Location = new System.Drawing.Point(12, 32);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.idClienteTextBox.TabIndex = 1;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(118, 32);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(298, 20);
            this.nomeTextBox.TabIndex = 3;
            // 
            // cpfMaskedTextBox
            // 
            this.cpfMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cpf", true));
            this.cpfMaskedTextBox.Location = new System.Drawing.Point(12, 71);
            this.cpfMaskedTextBox.Mask = "000,000,000-00";
            this.cpfMaskedTextBox.Name = "cpfMaskedTextBox";
            this.cpfMaskedTextBox.Size = new System.Drawing.Size(137, 20);
            this.cpfMaskedTextBox.TabIndex = 5;
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "telefone", true));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(155, 71);
            this.telefoneMaskedTextBox.Mask = "(00)0000-0000";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(140, 20);
            this.telefoneMaskedTextBox.TabIndex = 7;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(12, 110);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(404, 20);
            this.enderecoTextBox.TabIndex = 9;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(12, 149);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(188, 20);
            this.bairroTextBox.TabIndex = 11;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(206, 149);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(126, 20);
            this.cidadeTextBox.TabIndex = 13;
            // 
            // dataDiaTextBox
            // 
            this.dataDiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "dataDia", true));
            this.dataDiaTextBox.Enabled = false;
            this.dataDiaTextBox.Location = new System.Drawing.Point(12, 188);
            this.dataDiaTextBox.Name = "dataDiaTextBox";
            this.dataDiaTextBox.Size = new System.Drawing.Size(147, 20);
            this.dataDiaTextBox.TabIndex = 17;
            // 
            // cadastradoPorTextBox
            // 
            this.cadastradoPorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cadastradoPor", true));
            this.cadastradoPorTextBox.Enabled = false;
            this.cadastradoPorTextBox.Location = new System.Drawing.Point(165, 188);
            this.cadastradoPorTextBox.Name = "cadastradoPorTextBox";
            this.cadastradoPorTextBox.Size = new System.Drawing.Size(167, 20);
            this.cadastradoPorTextBox.TabIndex = 19;
            // 
            // tbClienteTableAdapter
            // 
            this.tbClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tbClienteBindingNavigator
            // 
            this.tbClienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbClienteBindingNavigator.BindingSource = this.tbClienteBindingSource;
            this.tbClienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbClienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbClienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbClienteBindingNavigatorSaveItem});
            this.tbClienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbClienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbClienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbClienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbClienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbClienteBindingNavigator.Name = "tbClienteBindingNavigator";
            this.tbClienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbClienteBindingNavigator.Size = new System.Drawing.Size(951, 25);
            this.tbClienteBindingNavigator.TabIndex = 2;
            this.tbClienteBindingNavigator.Text = "bindingNavigator1";
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
            // tbClienteBindingNavigatorSaveItem
            // 
            this.tbClienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbClienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbClienteBindingNavigatorSaveItem.Image")));
            this.tbClienteBindingNavigatorSaveItem.Name = "tbClienteBindingNavigatorSaveItem";
            this.tbClienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbClienteBindingNavigatorSaveItem.Text = "Save Data";
            this.tbClienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbClienteBindingNavigatorSaveItem_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(440, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 69);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisar Cliente";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(211, 30);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(132, 20);
            this.txtPesquisar.TabIndex = 5;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "=";
            // 
            // cbmFiltrar
            // 
            this.cbmFiltrar.FormattingEnabled = true;
            this.cbmFiltrar.Items.AddRange(new object[] {
            "",
            "Código",
            "Nome",
            "CPF"});
            this.cbmFiltrar.Location = new System.Drawing.Point(65, 30);
            this.cbmFiltrar.Name = "cbmFiltrar";
            this.cbmFiltrar.Size = new System.Drawing.Size(121, 21);
            this.cbmFiltrar.TabIndex = 1;
            this.cbmFiltrar.SelectedIndexChanged += new System.EventHandler(this.cbmFiltrar_SelectedIndexChanged);
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
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tbClienteDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(440, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(499, 441);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente(s)";
            // 
            // tbClienteDataGridView
            // 
            this.tbClienteDataGridView.AllowUserToAddRows = false;
            this.tbClienteDataGridView.AllowUserToDeleteRows = false;
            this.tbClienteDataGridView.AutoGenerateColumns = false;
            this.tbClienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.tbClienteDataGridView.DataSource = this.tbClienteBindingSource;
            this.tbClienteDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbClienteDataGridView.Location = new System.Drawing.Point(3, 16);
            this.tbClienteDataGridView.Name = "tbClienteDataGridView";
            this.tbClienteDataGridView.ReadOnly = true;
            this.tbClienteDataGridView.Size = new System.Drawing.Size(493, 422);
            this.tbClienteDataGridView.TabIndex = 0;
            this.tbClienteDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbClienteDataGridView_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idCliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cpf";
            this.dataGridViewTextBoxColumn3.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "telefone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "endereco";
            this.dataGridViewTextBoxColumn5.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "bairro";
            this.dataGridViewTextBoxColumn6.HeaderText = "Bairro";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "cidade";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn8.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "dataDia";
            this.dataGridViewTextBoxColumn9.HeaderText = "Data do Cadastro";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "cadastradoPor";
            this.dataGridViewTextBoxColumn10.HeaderText = "Cadastrado Por";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.tbOrdemServicoDataGridView);
            this.groupBox4.Location = new System.Drawing.Point(12, 276);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(422, 272);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Serviço(s) Prestados: ";
            // 
            // tbOrdemServicoDataGridView
            // 
            this.tbOrdemServicoDataGridView.AllowUserToAddRows = false;
            this.tbOrdemServicoDataGridView.AllowUserToDeleteRows = false;
            this.tbOrdemServicoDataGridView.AutoGenerateColumns = false;
            this.tbOrdemServicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.tbOrdemServicoDataGridView.DataSource = this.tbOrdemServicoBindingSource;
            this.tbOrdemServicoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOrdemServicoDataGridView.Location = new System.Drawing.Point(3, 16);
            this.tbOrdemServicoDataGridView.Name = "tbOrdemServicoDataGridView";
            this.tbOrdemServicoDataGridView.ReadOnly = true;
            this.tbOrdemServicoDataGridView.Size = new System.Drawing.Size(416, 253);
            this.tbOrdemServicoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "idOrdem";
            this.dataGridViewTextBoxColumn11.HeaderText = "Código OS";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 50;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "idServico";
            this.dataGridViewTextBoxColumn13.HeaderText = "Código Serviço";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 50;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "dataDia";
            this.dataGridViewTextBoxColumn14.HeaderText = "Data do Cadastro";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 120;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "cadastradorPor";
            this.dataGridViewTextBoxColumn15.HeaderText = "Cadastrado Por";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 120;
            // 
            // tbOrdemServicoBindingSource
            // 
            this.tbOrdemServicoBindingSource.DataMember = "FK_tbOrdemServico_tbCliente_idCliente";
            this.tbOrdemServicoBindingSource.DataSource = this.tbClienteBindingSource;
            // 
            // tbOrdemServicoTableAdapter
            // 
            this.tbOrdemServicoTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 563);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbClienteBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingNavigator)).EndInit();
            this.tbClienteBindingNavigator.ResumeLayout(false);
            this.tbClienteBindingNavigator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteDataGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ServicoDataSet servicoDataSet;
        private System.Windows.Forms.BindingSource tbClienteBindingSource;
        private Desafio.ServicoDataSetTableAdapters.tbClienteTableAdapter tbClienteTableAdapter;
        private System.Windows.Forms.BindingNavigator tbClienteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbClienteBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.MaskedTextBox cpfMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox dataDiaTextBox;
        private System.Windows.Forms.TextBox cadastradoPorTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbmFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView tbClienteDataGridView;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.BindingSource tbOrdemServicoBindingSource;
        private Desafio.ServicoDataSetTableAdapters.tbOrdemServicoTableAdapter tbOrdemServicoTableAdapter;
        private System.Windows.Forms.DataGridView tbOrdemServicoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.MaskedTextBox txtPesquisar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox estadoComboBox;
    }
}