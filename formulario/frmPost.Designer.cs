namespace Desafio
{
    partial class frmPost
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
            Label idOrdemLabel;
            Label idClienteLabel;
            Label idServicoLabel;
            Label dataDiaLabel;
            Label cadastradorPorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPost));
            groupBox1 = new GroupBox();
            cadastradorPorTextBox = new TextBox();
            tbOrdemServicoBindingSource = new BindingSource(components);
            servicoDataSet = new ServicoDataSet();
            dataDiaTextBox = new TextBox();
            idServicoComboBox = new ComboBox();
            tbServicoBindingSource = new BindingSource(components);
            idClienteComboBox = new ComboBox();
            tbClienteBindingSource = new BindingSource(components);
            idOrdemTextBox = new TextBox();
            tbOrdemServicoTableAdapter = new ServicoDataSetTableAdapters.tbOrdemServicoTableAdapter();
            tbOrdemServicoBindingNavigator = new BindingNavigator(components);
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
            tbOrdemServicoBindingNavigatorSaveItem = new ToolStripButton();
            label1 = new Label();
            cbmFiltrar = new ComboBox();
            label2 = new Label();
            btnPesquisar = new Button();
            txtPesquisar = new MaskedTextBox();
            groupBox2 = new GroupBox();
            tbOrdemServicoDataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            tbClienteTableAdapter = new ServicoDataSetTableAdapters.tbClienteTableAdapter();
            tbServicoTableAdapter = new ServicoDataSetTableAdapters.tbServicoTableAdapter();
            idOrdemLabel = new Label();
            idClienteLabel = new Label();
            idServicoLabel = new Label();
            dataDiaLabel = new Label();
            cadastradorPorLabel = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbOrdemServicoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)servicoDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbServicoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbClienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbOrdemServicoBindingNavigator).BeginInit();
            tbOrdemServicoBindingNavigator.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbOrdemServicoDataGridView).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // idOrdemLabel
            // 
            idOrdemLabel.AutoSize = true;
            idOrdemLabel.Location = new Point(8, 25);
            idOrdemLabel.Margin = new Padding(4, 0, 4, 0);
            idOrdemLabel.Name = "idOrdemLabel";
            idOrdemLabel.Size = new Size(67, 15);
            idOrdemLabel.TabIndex = 0;
            idOrdemLabel.Text = "C�digo POST:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new Point(8, 70);
            idClienteLabel.Margin = new Padding(4, 0, 4, 0);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new Size(93, 15);
            idClienteLabel.TabIndex = 2;
            idClienteLabel.Text = "Nome do Autor:";
            // 
            // idServicoLabel
            // 
            idServicoLabel.AutoSize = true;
            idServicoLabel.Location = new Point(8, 118);
            idServicoLabel.Margin = new Padding(4, 0, 4, 0);
            idServicoLabel.Name = "idServicoLabel";
            idServicoLabel.Size = new Size(61, 15);
            idServicoLabel.TabIndex = 4;
            idServicoLabel.Text = "Categoria:";
            // 
            // dataDiaLabel
            // 
            dataDiaLabel.AutoSize = true;
            dataDiaLabel.Location = new Point(426, 209);
            dataDiaLabel.Margin = new Padding(4, 0, 4, 0);
            dataDiaLabel.Name = "dataDiaLabel";
            dataDiaLabel.Size = new Size(101, 15);
            dataDiaLabel.TabIndex = 6;
            dataDiaLabel.Text = "Data do Cadastro:";
            // 
            // cadastradorPorLabel
            // 
            cadastradorPorLabel.AutoSize = true;
            cadastradorPorLabel.Location = new Point(10, 209);
            cadastradorPorLabel.Margin = new Padding(4, 0, 4, 0);
            cadastradorPorLabel.Name = "cadastradorPorLabel";
            cadastradorPorLabel.Size = new Size(94, 15);
            cadastradorPorLabel.TabIndex = 8;
            cadastradorPorLabel.Text = "Cadastrado Por: ";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(cadastradorPorLabel);
            groupBox1.Controls.Add(cadastradorPorTextBox);
            groupBox1.Controls.Add(dataDiaLabel);
            groupBox1.Controls.Add(dataDiaTextBox);
            groupBox1.Controls.Add(idServicoLabel);
            groupBox1.Controls.Add(idServicoComboBox);
            groupBox1.Controls.Add(idClienteLabel);
            groupBox1.Controls.Add(idClienteComboBox);
            groupBox1.Controls.Add(idOrdemLabel);
            groupBox1.Controls.Add(idOrdemTextBox);
            groupBox1.Location = new Point(14, 31);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(638, 263);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do Post";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cadastradorPorTextBox
            // 
            cadastradorPorTextBox.DataBindings.Add(new Binding("Text", tbOrdemServicoBindingSource, "cadastradorPor", true));
            cadastradorPorTextBox.Enabled = false;
            cadastradorPorTextBox.Location = new Point(14, 227);
            cadastradorPorTextBox.Margin = new Padding(4, 3, 4, 3);
            cadastradorPorTextBox.Name = "cadastradorPorTextBox";
            cadastradorPorTextBox.Size = new Size(185, 23);
            cadastradorPorTextBox.TabIndex = 9;
            // 
            // tbOrdemServicoBindingSource
            // 
            tbOrdemServicoBindingSource.DataMember = "tbOrdemServico";
            tbOrdemServicoBindingSource.DataSource = servicoDataSet;
            // 
            // servicoDataSet
            // 
            servicoDataSet.DataSetName = "ServicoDataSet";
            servicoDataSet.Namespace = "http://tempuri.org/ServicoDataSet.xsd";
            servicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataDiaTextBox
            // 
            dataDiaTextBox.DataBindings.Add(new Binding("Text", tbOrdemServicoBindingSource, "dataDia", true));
            dataDiaTextBox.Enabled = false;
            dataDiaTextBox.Location = new Point(430, 227);
            dataDiaTextBox.Margin = new Padding(4, 3, 4, 3);
            dataDiaTextBox.Name = "dataDiaTextBox";
            dataDiaTextBox.Size = new Size(185, 23);
            dataDiaTextBox.TabIndex = 7;
            // 
            // idServicoComboBox
            // 
            idServicoComboBox.DataBindings.Add(new Binding("Text", tbOrdemServicoBindingSource, "idServico", true));
            idServicoComboBox.DataBindings.Add(new Binding("SelectedValue", tbOrdemServicoBindingSource, "idServico", true));
            idServicoComboBox.DataSource = tbServicoBindingSource;
            idServicoComboBox.DisplayMember = "idServico";
            idServicoComboBox.FormattingEnabled = true;
            idServicoComboBox.Location = new Point(12, 136);
            idServicoComboBox.Margin = new Padding(4, 3, 4, 3);
            idServicoComboBox.Name = "idServicoComboBox";
            idServicoComboBox.Size = new Size(321, 23);
            idServicoComboBox.TabIndex = 5;
            idServicoComboBox.ValueMember = "idServico";
            // 
            // tbServicoBindingSource
            // 
            tbServicoBindingSource.DataMember = "tbServico";
            tbServicoBindingSource.DataSource = servicoDataSet;
            // 
            // idClienteComboBox
            // 
            idClienteComboBox.DataBindings.Add(new Binding("Text", tbOrdemServicoBindingSource, "idCliente", true));
            idClienteComboBox.DataBindings.Add(new Binding("SelectedValue", tbOrdemServicoBindingSource, "idCliente", true));
            //idClienteComboBox.DataBindings.Add(new Binding("Text", tbOrdemServicoBindingSource, "nome", true));
            //idClienteComboBox.DataBindings.Add(new Binding("SelectedValue", tbOrdemServicoBindingSource, "nome", true));
            idClienteComboBox.DataSource = tbClienteBindingSource;
            idClienteComboBox.DisplayMember = "idCliente";
            idClienteComboBox.FormattingEnabled = true;
            idClienteComboBox.Location = new Point(12, 89);
            idClienteComboBox.Margin = new Padding(4, 3, 4, 3);
            idClienteComboBox.Name = "idClienteComboBox";
            idClienteComboBox.Size = new Size(321, 23);
            idClienteComboBox.TabIndex = 3;
            idClienteComboBox.ValueMember = "idCliente";
            idClienteComboBox.SelectedIndexChanged += idClienteComboBox_SelectedIndexChanged;
            // 
            // tbClienteBindingSource
            // 
            tbClienteBindingSource.DataMember = "tbCliente";
            tbClienteBindingSource.DataSource = servicoDataSet;
            // 
            // idOrdemTextBox
            // 
            idOrdemTextBox.DataBindings.Add(new Binding("Text", tbOrdemServicoBindingSource, "idOrdem", true));
            idOrdemTextBox.Enabled = false;
            idOrdemTextBox.Location = new Point(12, 44);
            idOrdemTextBox.Margin = new Padding(4, 3, 4, 3);
            idOrdemTextBox.Name = "idOrdemTextBox";
            idOrdemTextBox.Size = new Size(116, 23);
            idOrdemTextBox.TabIndex = 1;
            // 
            // tbOrdemServicoTableAdapter
            // 
            tbOrdemServicoTableAdapter.ClearBeforeFill = true;
            // 
            // tbOrdemServicoBindingNavigator
            // 
            tbOrdemServicoBindingNavigator.AddNewItem = bindingNavigatorAddNewItem;
            tbOrdemServicoBindingNavigator.BackColor = SystemColors.ButtonFace;
            tbOrdemServicoBindingNavigator.BindingSource = tbOrdemServicoBindingSource;
            tbOrdemServicoBindingNavigator.CountItem = bindingNavigatorCountItem;
            tbOrdemServicoBindingNavigator.DeleteItem = bindingNavigatorDeleteItem;
            tbOrdemServicoBindingNavigator.Items.AddRange(new ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, tbOrdemServicoBindingNavigatorSaveItem });
            tbOrdemServicoBindingNavigator.Location = new Point(0, 0);
            tbOrdemServicoBindingNavigator.MoveFirstItem = bindingNavigatorMoveFirstItem;
            tbOrdemServicoBindingNavigator.MoveLastItem = bindingNavigatorMoveLastItem;
            tbOrdemServicoBindingNavigator.MoveNextItem = bindingNavigatorMoveNextItem;
            tbOrdemServicoBindingNavigator.MovePreviousItem = bindingNavigatorMovePreviousItem;
            tbOrdemServicoBindingNavigator.Name = "tbOrdemServicoBindingNavigator";
            tbOrdemServicoBindingNavigator.PositionItem = bindingNavigatorPositionItem;
            tbOrdemServicoBindingNavigator.Size = new Size(666, 25);
            tbOrdemServicoBindingNavigator.TabIndex = 3;
            tbOrdemServicoBindingNavigator.Text = "bindingNavigator1";
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
            // tbOrdemServicoBindingNavigatorSaveItem
            // 
            tbOrdemServicoBindingNavigatorSaveItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbOrdemServicoBindingNavigatorSaveItem.Image = (Image)resources.GetObject("tbOrdemServicoBindingNavigatorSaveItem.Image");
            tbOrdemServicoBindingNavigatorSaveItem.Name = "tbOrdemServicoBindingNavigatorSaveItem";
            tbOrdemServicoBindingNavigatorSaveItem.Size = new Size(23, 22);
            tbOrdemServicoBindingNavigatorSaveItem.Text = "Save Data";
            tbOrdemServicoBindingNavigatorSaveItem.Click += tbOrdemServicoBindingNavigatorSaveItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 6;
            label1.Text = "Filtrar por:";
            // 
            // cbmFiltrar
            // 
            cbmFiltrar.FormattingEnabled = true;
            cbmFiltrar.Items.AddRange(new object[] { "", "POST", "Autor", "categoria" });
            cbmFiltrar.Location = new Point(76, 33);
            cbmFiltrar.Margin = new Padding(4, 3, 4, 3);
            cbmFiltrar.Name = "cbmFiltrar";
            cbmFiltrar.Size = new Size(140, 23);
            cbmFiltrar.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 37);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 8;
            label2.Text = "=";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(407, 31);
            btnPesquisar.Margin = new Padding(4, 3, 4, 3);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(88, 27);
            btnPesquisar.TabIndex = 9;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(246, 33);
            txtPesquisar.Margin = new Padding(4, 3, 4, 3);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(153, 23);
            txtPesquisar.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(txtPesquisar);
            groupBox2.Controls.Add(btnPesquisar);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cbmFiltrar);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(14, 301);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(638, 91);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Posts";
            // 
            // tbOrdemServicoDataGridView
            // 
            tbOrdemServicoDataGridView.AllowUserToAddRows = false;
            tbOrdemServicoDataGridView.AllowUserToDeleteRows = false;
            tbOrdemServicoDataGridView.AutoGenerateColumns = false;
            tbOrdemServicoDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            tbOrdemServicoDataGridView.DataSource = tbOrdemServicoBindingSource;
            tbOrdemServicoDataGridView.Dock = DockStyle.Fill;
            tbOrdemServicoDataGridView.Location = new Point(4, 19);
            tbOrdemServicoDataGridView.Margin = new Padding(4, 3, 4, 3);
            tbOrdemServicoDataGridView.Name = "tbOrdemServicoDataGridView";
            tbOrdemServicoDataGridView.ReadOnly = true;
            tbOrdemServicoDataGridView.Size = new Size(634, 247);
            tbOrdemServicoDataGridView.TabIndex = 0;
            tbOrdemServicoDataGridView.MouseDoubleClick += tbOrdemServicoDataGridView_MouseDoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "idOrdem";
            dataGridViewTextBoxColumn1.HeaderText = "Post";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "idCliente";
            dataGridViewTextBoxColumn2.HeaderText = "C�digo Autor";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "idServico";
            dataGridViewTextBoxColumn3.HeaderText = "C�digo Categoria";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "dataDia";
            dataGridViewTextBoxColumn4.HeaderText = "Data do Cadastro";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "cadastradorPor";
            dataGridViewTextBoxColumn5.HeaderText = "Cadastrado Por";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(tbOrdemServicoDataGridView);
            groupBox3.Location = new Point(10, 399);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(642, 269);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Post(s)";
            // 
            // tbClienteTableAdapter
            // 
            tbClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tbServicoTableAdapter
            // 
            tbServicoTableAdapter.ClearBeforeFill = true;
            // 
            // frmPost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 688);
            Controls.Add(tbOrdemServicoBindingNavigator);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmPost";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inserir Post";
            Load += frmOS_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbOrdemServicoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)servicoDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbServicoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbClienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbOrdemServicoBindingNavigator).EndInit();
            tbOrdemServicoBindingNavigator.ResumeLayout(false);
            tbOrdemServicoBindingNavigator.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbOrdemServicoDataGridView).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ServicoDataSet servicoDataSet;
        private BindingSource tbOrdemServicoBindingSource;
        private Desafio.ServicoDataSetTableAdapters.tbOrdemServicoTableAdapter tbOrdemServicoTableAdapter;
        private BindingNavigator tbOrdemServicoBindingNavigator;
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
        private ToolStripButton tbOrdemServicoBindingNavigatorSaveItem;
        private TextBox cadastradorPorTextBox;
        private TextBox dataDiaTextBox;
        private ComboBox idServicoComboBox;
        private ComboBox idClienteComboBox;
        private TextBox idOrdemTextBox;
        private Label label1;
        private ComboBox cbmFiltrar;
        private Label label2;
        private Button btnPesquisar;
        private MaskedTextBox txtPesquisar;
        private GroupBox groupBox2;
        private DataGridView tbOrdemServicoDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private GroupBox groupBox3;
        private BindingSource tbClienteBindingSource;
        private Desafio.ServicoDataSetTableAdapters.tbClienteTableAdapter tbClienteTableAdapter;
        private BindingSource tbServicoBindingSource;
        private Desafio.ServicoDataSetTableAdapters.tbServicoTableAdapter tbServicoTableAdapter;
    }
}