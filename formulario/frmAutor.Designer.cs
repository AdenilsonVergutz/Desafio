using Desafio;

namespace Desafio
{
    partial class frmAutor
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
            Label idAutorLabel;
            Label nomeLabel;
            Label cpfLabel;
            Label telefoneLabel;
            Label enderecoLabel;
            Label bairroLabel;
            Label cidadeLabel;
            Label dataDiaLabel;
            Label cadastradoPorLabel;
            Label estadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutor));
            groupBox1 = new GroupBox();
            estadoComboBox = new ComboBox();
            tbAutorBindingSource = new BindingSource(components);
            servicoDataSet = new ServicoDataSet();
            idAutorTextBox = new TextBox();
            nomeTextBox = new TextBox();
            cpfMaskedTextBox = new MaskedTextBox();
            telefoneMaskedTextBox = new MaskedTextBox();
            enderecoTextBox = new TextBox();
            bairroTextBox = new TextBox();
            cidadeTextBox = new TextBox();
            dataDiaTextBox = new TextBox();
            cadastradoPorTextBox = new TextBox();
            tbAutorTableAdapter = new ServicoDataSetTableAdapters.tbAutorTableAdapter();
            tbAutorBindingNavigator = new BindingNavigator(components);
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
            tbAutorBindingNavigatorSaveItem = new ToolStripButton();
            groupBox2 = new GroupBox();
            txtPesquisar = new MaskedTextBox();
            btnPesquisar = new Button();
            label2 = new Label();
            cbmFiltrar = new ComboBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            tbAutorDataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            tbPostDataGridView = new DataGridView();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            tbPostBindingSource = new BindingSource(components);
            tbPostTableAdapter = new ServicoDataSetTableAdapters.tbPostTableAdapter();
            timer1 = new System.Windows.Forms.Timer(components);
            idAutorLabel = new Label();
            nomeLabel = new Label();
            cpfLabel = new Label();
            telefoneLabel = new Label();
            enderecoLabel = new Label();
            bairroLabel = new Label();
            cidadeLabel = new Label();
            dataDiaLabel = new Label();
            cadastradoPorLabel = new Label();
            estadoLabel = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbAutorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)servicoDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbAutorBindingNavigator).BeginInit();
            tbAutorBindingNavigator.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbAutorDataGridView).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbPostDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbPostBindingSource).BeginInit();
            SuspendLayout();
            // 
            // idAutorLabel
            // 
            idAutorLabel.AutoSize = true;
            idAutorLabel.Location = new Point(10, 18);
            idAutorLabel.Margin = new Padding(4, 0, 4, 0);
            idAutorLabel.Name = "idAutorLabel";
            idAutorLabel.Size = new Size(49, 15);
            idAutorLabel.TabIndex = 0;
            idAutorLabel.Text = "Código:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new Point(132, 18);
            nomeLabel.Margin = new Padding(4, 0, 4, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new Size(43, 15);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Location = new Point(10, 63);
            cpfLabel.Margin = new Padding(4, 0, 4, 0);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new Size(34, 15);
            cpfLabel.TabIndex = 4;
            cpfLabel.Text = "CPF: ";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new Point(177, 63);
            telefoneLabel.Margin = new Padding(4, 0, 4, 0);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new Size(57, 15);
            telefoneLabel.TabIndex = 6;
            telefoneLabel.Text = "Telefone: ";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new Point(10, 108);
            enderecoLabel.Margin = new Padding(4, 0, 4, 0);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new Size(62, 15);
            enderecoLabel.TabIndex = 8;
            enderecoLabel.Text = "Endereço: ";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new Point(10, 153);
            bairroLabel.Margin = new Padding(4, 0, 4, 0);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new Size(44, 15);
            bairroLabel.TabIndex = 10;
            bairroLabel.Text = "Bairro: ";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new Point(240, 153);
            cidadeLabel.Margin = new Padding(4, 0, 4, 0);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new Size(50, 15);
            cidadeLabel.TabIndex = 12;
            cidadeLabel.Text = "Cidade: ";
            // 
            // dataDiaLabel
            // 
            dataDiaLabel.AutoSize = true;
            dataDiaLabel.Location = new Point(14, 215);
            dataDiaLabel.Margin = new Padding(4, 0, 4, 0);
            dataDiaLabel.Name = "dataDiaLabel";
            dataDiaLabel.Size = new Size(104, 15);
            dataDiaLabel.TabIndex = 16;
            dataDiaLabel.Text = "Data do Cadastro: ";
            // 
            // cadastradoPorLabel
            // 
            cadastradoPorLabel.AutoSize = true;
            cadastradoPorLabel.Location = new Point(189, 215);
            cadastradoPorLabel.Margin = new Padding(4, 0, 4, 0);
            cadastradoPorLabel.Name = "cadastradoPorLabel";
            cadastradoPorLabel.Size = new Size(94, 15);
            cadastradoPorLabel.TabIndex = 18;
            cadastradoPorLabel.Text = "Cadastrado Por: ";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new Point(391, 153);
            estadoLabel.Margin = new Padding(4, 0, 4, 0);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new Size(48, 15);
            estadoLabel.TabIndex = 19;
            estadoLabel.Text = "Estado: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(estadoLabel);
            groupBox1.Controls.Add(estadoComboBox);
            groupBox1.Controls.Add(idAutorLabel);
            groupBox1.Controls.Add(idAutorTextBox);
            groupBox1.Controls.Add(nomeLabel);
            groupBox1.Controls.Add(nomeTextBox);
            groupBox1.Controls.Add(cpfLabel);
            groupBox1.Controls.Add(cpfMaskedTextBox);
            groupBox1.Controls.Add(telefoneLabel);
            groupBox1.Controls.Add(telefoneMaskedTextBox);
            groupBox1.Controls.Add(enderecoLabel);
            groupBox1.Controls.Add(enderecoTextBox);
            groupBox1.Controls.Add(bairroLabel);
            groupBox1.Controls.Add(bairroTextBox);
            groupBox1.Controls.Add(cidadeLabel);
            groupBox1.Controls.Add(cidadeTextBox);
            groupBox1.Controls.Add(dataDiaLabel);
            groupBox1.Controls.Add(dataDiaTextBox);
            groupBox1.Controls.Add(cadastradoPorLabel);
            groupBox1.Controls.Add(cadastradoPorTextBox);
            groupBox1.Location = new Point(14, 40);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(492, 271);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Pessoais";
            // 
            // estadoComboBox
            // 
            estadoComboBox.DataBindings.Add(new Binding("Text", tbAutorBindingSource, "estado", true));
            estadoComboBox.FormattingEnabled = true;
            estadoComboBox.Items.AddRange(new object[] { "", "DF", "AC", "AL", "AP", "AM", "BA", "CE", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            estadoComboBox.Location = new Point(394, 172);
            estadoComboBox.Margin = new Padding(4, 3, 4, 3);
            estadoComboBox.Name = "estadoComboBox";
            estadoComboBox.Size = new Size(90, 23);
            estadoComboBox.TabIndex = 20;
            // 
            // tbAutorBindingSource
            // 
            tbAutorBindingSource.DataMember = "tbAutor";
            tbAutorBindingSource.DataSource = servicoDataSet;
            // 
            // servicoDataSet
            // 
            servicoDataSet.DataSetName = "ServicoDataSet";
            servicoDataSet.Namespace = "http://tempuri.org/ServicoDataSet.xsd";
            servicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idAutorTextBox
            // 
            idAutorTextBox.DataBindings.Add(new Binding("Text", tbAutorBindingSource, "Id", true));
            idAutorTextBox.Enabled = false;
            idAutorTextBox.Location = new Point(14, 37);
            idAutorTextBox.Margin = new Padding(4, 3, 4, 3);
            idAutorTextBox.Name = "idAutorTextBox";
            idAutorTextBox.Size = new Size(116, 23);
            idAutorTextBox.TabIndex = 1;
            // 
            // nomeTextBox
            // 
            nomeTextBox.DataBindings.Add(new Binding("Text", tbAutorBindingSource, "nome", true));
            nomeTextBox.Location = new Point(138, 37);
            nomeTextBox.Margin = new Padding(4, 3, 4, 3);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.Size = new Size(347, 23);
            nomeTextBox.TabIndex = 3;
            // 
            // cpfMaskedTextBox
            // 
            cpfMaskedTextBox.DataBindings.Add(new Binding("Text", tbAutorBindingSource, "cpf", true));
            cpfMaskedTextBox.Location = new Point(14, 82);
            cpfMaskedTextBox.Margin = new Padding(4, 3, 4, 3);
            cpfMaskedTextBox.Mask = "000,000,000-00";
            cpfMaskedTextBox.Name = "cpfMaskedTextBox";
            cpfMaskedTextBox.Size = new Size(159, 23);
            cpfMaskedTextBox.TabIndex = 5;
            // 
            // telefoneMaskedTextBox
            // 
            telefoneMaskedTextBox.DataBindings.Add(new Binding("Text", tbAutorBindingSource, "telefone", true));
            telefoneMaskedTextBox.Location = new Point(181, 82);
            telefoneMaskedTextBox.Margin = new Padding(4, 3, 4, 3);
            telefoneMaskedTextBox.Mask = "(00)00000-0000";
            telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            telefoneMaskedTextBox.Size = new Size(163, 23);
            telefoneMaskedTextBox.TabIndex = 7;
            // 
            // enderecoTextBox
            // 
            enderecoTextBox.DataBindings.Add(new Binding("Text", tbAutorBindingSource, "endereco", true));
            enderecoTextBox.Location = new Point(14, 127);
            enderecoTextBox.Margin = new Padding(4, 3, 4, 3);
            enderecoTextBox.Name = "enderecoTextBox";
            enderecoTextBox.Size = new Size(471, 23);
            enderecoTextBox.TabIndex = 9;
            // 
            // bairroTextBox
            // 
            bairroTextBox.DataBindings.Add(new Binding("Text", tbAutorBindingSource, "bairro", true));
            bairroTextBox.Location = new Point(14, 172);
            bairroTextBox.Margin = new Padding(4, 3, 4, 3);
            bairroTextBox.Name = "bairroTextBox";
            bairroTextBox.Size = new Size(219, 23);
            bairroTextBox.TabIndex = 11;
            // 
            // cidadeTextBox
            // 
            cidadeTextBox.DataBindings.Add(new Binding("Text", tbAutorBindingSource, "cidade", true));
            cidadeTextBox.Location = new Point(240, 172);
            cidadeTextBox.Margin = new Padding(4, 3, 4, 3);
            cidadeTextBox.Name = "cidadeTextBox";
            cidadeTextBox.Size = new Size(146, 23);
            cidadeTextBox.TabIndex = 13;
            // 
            // dataDiaTextBox
            // 
            dataDiaTextBox.DataBindings.Add(new Binding("Text", tbAutorBindingSource, "dataDia", true));
            dataDiaTextBox.Enabled = false;
            dataDiaTextBox.Location = new Point(14, 234);
            dataDiaTextBox.Margin = new Padding(4, 3, 4, 3);
            dataDiaTextBox.Name = "dataDiaTextBox";
            dataDiaTextBox.Size = new Size(171, 23);
            dataDiaTextBox.TabIndex = 17;
            // 
            // cadastradoPorTextBox
            // 
            cadastradoPorTextBox.DataBindings.Add(new Binding("Text", tbAutorBindingSource, "cadastradoPor", true));
            cadastradoPorTextBox.Enabled = false;
            cadastradoPorTextBox.Location = new Point(192, 234);
            cadastradoPorTextBox.Margin = new Padding(4, 3, 4, 3);
            cadastradoPorTextBox.Name = "cadastradoPorTextBox";
            cadastradoPorTextBox.Size = new Size(194, 23);
            cadastradoPorTextBox.TabIndex = 19;
            // 
            // tbAutorTableAdapter
            // 
            tbAutorTableAdapter.ClearBeforeFill = true;
            // 
            // tbAutorBindingNavigator
            // 
            tbAutorBindingNavigator.AddNewItem = bindingNavigatorAddNewItem;
            tbAutorBindingNavigator.BindingSource = tbAutorBindingSource;
            tbAutorBindingNavigator.CountItem = bindingNavigatorCountItem;
            tbAutorBindingNavigator.DeleteItem = bindingNavigatorDeleteItem;
            tbAutorBindingNavigator.Items.AddRange(new ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, tbAutorBindingNavigatorSaveItem });
            tbAutorBindingNavigator.Location = new Point(0, 0);
            tbAutorBindingNavigator.MoveFirstItem = bindingNavigatorMoveFirstItem;
            tbAutorBindingNavigator.MoveLastItem = bindingNavigatorMoveLastItem;
            tbAutorBindingNavigator.MoveNextItem = bindingNavigatorMoveNextItem;
            tbAutorBindingNavigator.MovePreviousItem = bindingNavigatorMovePreviousItem;
            tbAutorBindingNavigator.Name = "tbAutorBindingNavigator";
            tbAutorBindingNavigator.PositionItem = bindingNavigatorPositionItem;
            tbAutorBindingNavigator.Size = new Size(1110, 25);
            tbAutorBindingNavigator.TabIndex = 2;
            tbAutorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            bindingNavigatorAddNewItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bindingNavigatorAddNewItem.Image = (Image)resources.GetObject("bindingNavigatorAddNewItem.Image");
            bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorAddNewItem.Size = new Size(23, 22);
            bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new Size(37, 22);
            bindingNavigatorCountItem.Text = "de {0}";
            bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            bindingNavigatorDeleteItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bindingNavigatorDeleteItem.Image = (Image)resources.GetObject("bindingNavigatorDeleteItem.Image");
            bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorDeleteItem.Size = new Size(23, 22);
            bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            bindingNavigatorMoveFirstItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveFirstItem.Image = (Image)resources.GetObject("bindingNavigatorMoveFirstItem.Image");
            bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveFirstItem.Size = new Size(23, 22);
            bindingNavigatorMoveFirstItem.Text = "Move first";
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
            bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = (Image)resources.GetObject("bindingNavigatorMoveLastItem.Image");
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new Size(23, 22);
            bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new Size(6, 25);
            // 
            // tbAutorBindingNavigatorSaveItem
            // 
            tbAutorBindingNavigatorSaveItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbAutorBindingNavigatorSaveItem.Image = (Image)resources.GetObject("tbAutorBindingNavigatorSaveItem.Image");
            tbAutorBindingNavigatorSaveItem.Name = "tbAutorBindingNavigatorSaveItem";
            tbAutorBindingNavigatorSaveItem.Size = new Size(23, 22);
            tbAutorBindingNavigatorSaveItem.Text = "Save Data";
            tbAutorBindingNavigatorSaveItem.Click += tbAutorBindingNavigatorSaveItem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(txtPesquisar);
            groupBox2.Controls.Add(btnPesquisar);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cbmFiltrar);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(513, 40);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(579, 80);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pesquisar Autor";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(246, 35);
            txtPesquisar.Margin = new Padding(4, 3, 4, 3);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(153, 23);
            txtPesquisar.TabIndex = 5;
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
            // cbmFiltrar
            // 
            cbmFiltrar.FormattingEnabled = true;
            cbmFiltrar.Items.AddRange(new object[] { "", "Código", "Nome", "CPF" });
            cbmFiltrar.Location = new Point(76, 35);
            cbmFiltrar.Margin = new Padding(4, 3, 4, 3);
            cbmFiltrar.Name = "cbmFiltrar";
            cbmFiltrar.Size = new Size(140, 23);
            cbmFiltrar.TabIndex = 1;
            cbmFiltrar.SelectedIndexChanged += cbmFiltrar_SelectedIndexChanged;
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
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(tbAutorDataGridView);
            groupBox3.Location = new Point(513, 127);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(582, 509);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Autor";
            // 
            // tbAutorDataGridView
            // 
            tbAutorDataGridView.AllowUserToAddRows = false;
            tbAutorDataGridView.AllowUserToDeleteRows = false;
            tbAutorDataGridView.AutoGenerateColumns = false;
            tbAutorDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            tbAutorDataGridView.DataSource = tbAutorBindingSource;
            tbAutorDataGridView.Dock = DockStyle.Fill;
            tbAutorDataGridView.Location = new Point(4, 19);
            tbAutorDataGridView.Margin = new Padding(4, 3, 4, 3);
            tbAutorDataGridView.Name = "tbAutorDataGridView";
            tbAutorDataGridView.ReadOnly = true;
            tbAutorDataGridView.Size = new Size(574, 487);
            tbAutorDataGridView.TabIndex = 0;
            tbAutorDataGridView.MouseDoubleClick += tbAutorDataGridView_MouseDoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Código";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            dataGridViewTextBoxColumn2.HeaderText = "Nome";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "cpf";
            dataGridViewTextBoxColumn3.HeaderText = "CPF";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "telefone";
            dataGridViewTextBoxColumn4.HeaderText = "Telefone";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "endereco";
            dataGridViewTextBoxColumn5.HeaderText = "Endereço";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "bairro";
            dataGridViewTextBoxColumn6.HeaderText = "Bairro";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "cidade";
            dataGridViewTextBoxColumn7.HeaderText = "Cidade";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "estado";
            dataGridViewTextBoxColumn8.HeaderText = "Estado";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "dataDia";
            dataGridViewTextBoxColumn9.HeaderText = "Data do Cadastro";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "cadastradoPor";
            dataGridViewTextBoxColumn10.HeaderText = "Cadastrado Por";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox4.Controls.Add(tbPostDataGridView);
            groupBox4.Location = new Point(14, 318);
            groupBox4.Margin = new Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 3, 4, 3);
            groupBox4.Size = new Size(492, 314);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Posts realizados: ";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // tbPostDataGridView
            // 
            tbPostDataGridView.AllowUserToAddRows = false;
            tbPostDataGridView.AllowUserToDeleteRows = false;
            tbPostDataGridView.AutoGenerateColumns = false;
            tbPostDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15 });
            tbPostDataGridView.DataSource = tbPostBindingSource;
            tbPostDataGridView.Dock = DockStyle.Fill;
            tbPostDataGridView.Location = new Point(4, 19);
            tbPostDataGridView.Margin = new Padding(4, 3, 4, 3);
            tbPostDataGridView.Name = "tbPostDataGridView";
            tbPostDataGridView.ReadOnly = true;
            tbPostDataGridView.Size = new Size(484, 292);
            tbPostDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "idOrdem";
            dataGridViewTextBoxColumn11.HeaderText = "Código POST";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Width = 50;
            // 

            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.DataPropertyName = "dataDia";
            dataGridViewTextBoxColumn14.HeaderText = "Data do Cadastro";
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.ReadOnly = true;
            dataGridViewTextBoxColumn14.Width = 120;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.DataPropertyName = "cadastradorPor";
            dataGridViewTextBoxColumn15.HeaderText = "Cadastrado Por";
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.ReadOnly = true;
            dataGridViewTextBoxColumn15.Width = 120;
            // 
            // tbPostBindingSource
            // 
            tbPostBindingSource.DataMember = "FK_tbPost_tbAutor_id";
            tbPostBindingSource.DataSource = tbAutorBindingSource;
            // 
            // tbPostTableAdapter
            // 
            tbPostTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // frmAutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 650);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(tbAutorBindingNavigator);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmAutor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Autor";
            Load += frmAutor_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbAutorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)servicoDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbAutorBindingNavigator).EndInit();
            tbAutorBindingNavigator.ResumeLayout(false);
            tbAutorBindingNavigator.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbAutorDataGridView).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbPostDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbPostBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ServicoDataSet servicoDataSet;
        private BindingSource tbAutorBindingSource;
        private Desafio.ServicoDataSetTableAdapters.tbAutorTableAdapter tbAutorTableAdapter;
        private BindingNavigator tbAutorBindingNavigator;
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
        private ToolStripButton tbAutorBindingNavigatorSaveItem;
        private TextBox idAutorTextBox;
        private TextBox nomeTextBox;
        private MaskedTextBox cpfMaskedTextBox;
        private MaskedTextBox telefoneMaskedTextBox;
        private TextBox enderecoTextBox;
        private TextBox bairroTextBox;
        private TextBox cidadeTextBox;
        private TextBox dataDiaTextBox;
        private TextBox cadastradoPorTextBox;
        private GroupBox groupBox2;
        private Button btnPesquisar;
        private Label label2;
        private ComboBox cbmFiltrar;
        private Label label1;
        private GroupBox groupBox3;
        private DataGridView tbAutorDataGridView;
        private GroupBox groupBox4;
        private BindingSource tbPostBindingSource;
        private Desafio.ServicoDataSetTableAdapters.tbPostTableAdapter tbPostTableAdapter;
        private DataGridView tbPostDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private MaskedTextBox txtPesquisar;
        private System.Windows.Forms.Timer timer1;
        private ComboBox estadoComboBox;
    }
}