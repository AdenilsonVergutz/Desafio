namespace Desafio.formulario
{
    partial class frmCategoria
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
            Label idCategoriaLabel;
            Label nomeLabel;
            Label descricaoLabel;
            Label observacaoLabel;
            Label valorLabel;
            Label dataDiaLabel;
            Label cadastradoPorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            groupBox1 = new GroupBox();
            idCategoriaTextBox = new TextBox();
            tbCategoriaBindingSource = new BindingSource(components);
            servicoDataSet = new ServicoDataSet();
            nomeTextBox = new TextBox();
            descricaoTextBox = new TextBox();
            observacaoTextBox = new TextBox();
            valorTextBox = new TextBox();
            dataDiaTextBox = new TextBox();
            cadastradoPorTextBox = new TextBox();
            tbCategoriaTableAdapter = new ServicoDataSetTableAdapters.tbCategoriaTableAdapter();
            tbServicoBindingNavigator = new BindingNavigator(components);
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
            tbServicoBindingNavigatorSaveItem = new ToolStripButton();
            groupBox2 = new GroupBox();
            btnPesquisar = new Button();
            txtPesquisar = new TextBox();
            label2 = new Label();
            cbmFiltrar = new ComboBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            tbCategoriaDataGridView = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            idCategoriaLabel = new Label();
            nomeLabel = new Label();
            descricaoLabel = new Label();
            observacaoLabel = new Label();
            valorLabel = new Label();
            dataDiaLabel = new Label();
            cadastradoPorLabel = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbCategoriaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)servicoDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbServicoBindingNavigator).BeginInit();
            tbServicoBindingNavigator.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbCategoriaDataGridView).BeginInit();
            SuspendLayout();
            // 
            // idCategoriaLabel
            // 
            idCategoriaLabel.AutoSize = true;
            idCategoriaLabel.Location = new Point(7, 31);
            idCategoriaLabel.Margin = new Padding(4, 0, 4, 0);
            idCategoriaLabel.Name = "idCategoriaLabel";
            idCategoriaLabel.Size = new Size(52, 15);
            idCategoriaLabel.TabIndex = 0;
            idCategoriaLabel.Text = "Código: ";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new Point(131, 31);
            nomeLabel.Margin = new Padding(4, 0, 4, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new Size(46, 15);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome: ";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new Point(7, 76);
            descricaoLabel.Margin = new Padding(4, 0, 4, 0);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new Size(64, 15);
            descricaoLabel.TabIndex = 4;
            descricaoLabel.Text = "Descrição: ";
            // 
            // observacaoLabel
            // 
            observacaoLabel.AutoSize = true;
            observacaoLabel.Location = new Point(4, 147);
            observacaoLabel.Margin = new Padding(4, 0, 4, 0);
            observacaoLabel.Name = "observacaoLabel";
            observacaoLabel.Size = new Size(75, 15);
            observacaoLabel.TabIndex = 6;
            observacaoLabel.Text = "Observação: ";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new Point(7, 217);
            valorLabel.Margin = new Padding(4, 0, 4, 0);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new Size(39, 15);
            valorLabel.TabIndex = 8;
            valorLabel.Text = "Valor: ";
            // 
            // dataDiaLabel
            // 
            dataDiaLabel.AutoSize = true;
            dataDiaLabel.Location = new Point(131, 217);
            dataDiaLabel.Margin = new Padding(4, 0, 4, 0);
            dataDiaLabel.Name = "dataDiaLabel";
            dataDiaLabel.Size = new Size(104, 15);
            dataDiaLabel.TabIndex = 10;
            dataDiaLabel.Text = "Data do Cadastro: ";
            // 
            // cadastradoPorLabel
            // 
            cadastradoPorLabel.AutoSize = true;
            cadastradoPorLabel.Location = new Point(292, 217);
            cadastradoPorLabel.Margin = new Padding(4, 0, 4, 0);
            cadastradoPorLabel.Name = "cadastradoPorLabel";
            cadastradoPorLabel.Size = new Size(94, 15);
            cadastradoPorLabel.TabIndex = 12;
            cadastradoPorLabel.Text = "Cadastrado Por: ";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(idCategoriaLabel);
            groupBox1.Controls.Add(idCategoriaTextBox);
            groupBox1.Controls.Add(nomeLabel);
            groupBox1.Controls.Add(nomeTextBox);
            groupBox1.Controls.Add(descricaoLabel);
            groupBox1.Controls.Add(descricaoTextBox);
            groupBox1.Controls.Add(observacaoLabel);
            groupBox1.Controls.Add(observacaoTextBox);
            groupBox1.Controls.Add(valorLabel);
            groupBox1.Controls.Add(valorTextBox);
            groupBox1.Controls.Add(dataDiaLabel);
            groupBox1.Controls.Add(dataDiaTextBox);
            groupBox1.Controls.Add(cadastradoPorLabel);
            groupBox1.Controls.Add(cadastradoPorTextBox);
            groupBox1.Location = new Point(14, 33);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(817, 265);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Categoria";
            // 
            // idCategoriaTextBox
            // 
            idCategoriaTextBox.DataBindings.Add(new Binding("Text", tbCategoriaBindingSource, "Id", true));
            idCategoriaTextBox.Enabled = false;
            idCategoriaTextBox.Location = new Point(10, 50);
            idCategoriaTextBox.Margin = new Padding(4, 3, 4, 3);
            idCategoriaTextBox.Name = "idCategoriaTextBox";
            idCategoriaTextBox.Size = new Size(116, 23);
            idCategoriaTextBox.TabIndex = 1;
            // 
            // tbCategoriaBindingSource
            // 
            tbCategoriaBindingSource.DataMember = "tbCategoria";
            tbCategoriaBindingSource.DataSource = servicoDataSet;
            // 
            // servicoDataSet
            // 
            servicoDataSet.DataSetName = "ServicoDataSet";
            servicoDataSet.Namespace = "http://tempuri.org/ServicoDataSet.xsd";
            servicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nomeTextBox
            // 
            nomeTextBox.DataBindings.Add(new Binding("Text", tbCategoriaBindingSource, "nome", true));
            nomeTextBox.Location = new Point(134, 50);
            nomeTextBox.Margin = new Padding(4, 3, 4, 3);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.Size = new Size(494, 23);
            nomeTextBox.TabIndex = 3;
            // 
            // descricaoTextBox
            // 
            descricaoTextBox.DataBindings.Add(new Binding("Text", tbCategoriaBindingSource, "descricao", true));
            descricaoTextBox.Location = new Point(7, 95);
            descricaoTextBox.Margin = new Padding(4, 3, 4, 3);
            descricaoTextBox.Multiline = true;
            descricaoTextBox.Name = "descricaoTextBox";
            descricaoTextBox.ScrollBars = ScrollBars.Vertical;
            descricaoTextBox.Size = new Size(616, 48);
            descricaoTextBox.TabIndex = 5;
            // 
            // observacaoTextBox
            // 
            observacaoTextBox.DataBindings.Add(new Binding("Text", tbCategoriaBindingSource, "observacao", true));
            observacaoTextBox.Location = new Point(7, 165);
            observacaoTextBox.Margin = new Padding(4, 3, 4, 3);
            observacaoTextBox.Multiline = true;
            observacaoTextBox.Name = "observacaoTextBox";
            observacaoTextBox.ScrollBars = ScrollBars.Vertical;
            observacaoTextBox.Size = new Size(616, 48);
            observacaoTextBox.TabIndex = 7;
            // 
            // valorTextBox
            // 
            valorTextBox.DataBindings.Add(new Binding("Text", tbCategoriaBindingSource, "valor", true));
            valorTextBox.Location = new Point(10, 235);
            valorTextBox.Margin = new Padding(4, 3, 4, 3);
            valorTextBox.Name = "valorTextBox";
            valorTextBox.Size = new Size(116, 23);
            valorTextBox.TabIndex = 9;
            // 
            // dataDiaTextBox
            // 
            dataDiaTextBox.DataBindings.Add(new Binding("Text", tbCategoriaBindingSource, "dataDia", true));
            dataDiaTextBox.Enabled = false;
            dataDiaTextBox.Location = new Point(134, 235);
            dataDiaTextBox.Margin = new Padding(4, 3, 4, 3);
            dataDiaTextBox.Name = "dataDiaTextBox";
            dataDiaTextBox.Size = new Size(150, 23);
            dataDiaTextBox.TabIndex = 11;
            // 
            // cadastradoPorTextBox
            // 
            cadastradoPorTextBox.DataBindings.Add(new Binding("Text", tbCategoriaBindingSource, "cadastradoPor", true));
            cadastradoPorTextBox.Enabled = false;
            cadastradoPorTextBox.Location = new Point(292, 235);
            cadastradoPorTextBox.Margin = new Padding(4, 3, 4, 3);
            cadastradoPorTextBox.Name = "cadastradoPorTextBox";
            cadastradoPorTextBox.Size = new Size(215, 23);
            cadastradoPorTextBox.TabIndex = 13;
            // 
            // tbCategoriaTableAdapter
            // 
            tbCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // tbServicoBindingNavigator
            // 
            tbServicoBindingNavigator.AddNewItem = bindingNavigatorAddNewItem;
            tbServicoBindingNavigator.BindingSource = tbCategoriaBindingSource;
            tbServicoBindingNavigator.CountItem = bindingNavigatorCountItem;
            tbServicoBindingNavigator.DeleteItem = bindingNavigatorDeleteItem;
            tbServicoBindingNavigator.Items.AddRange(new ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, tbServicoBindingNavigatorSaveItem });
            tbServicoBindingNavigator.Location = new Point(0, 0);
            tbServicoBindingNavigator.MoveFirstItem = bindingNavigatorMoveFirstItem;
            tbServicoBindingNavigator.MoveLastItem = bindingNavigatorMoveLastItem;
            tbServicoBindingNavigator.MoveNextItem = bindingNavigatorMoveNextItem;
            tbServicoBindingNavigator.MovePreviousItem = bindingNavigatorMovePreviousItem;
            tbServicoBindingNavigator.Name = "tbServicoBindingNavigator";
            tbServicoBindingNavigator.PositionItem = bindingNavigatorPositionItem;
            tbServicoBindingNavigator.Size = new Size(845, 25);
            tbServicoBindingNavigator.TabIndex = 1;
            tbServicoBindingNavigator.Text = "bindingNavigator1";
            tbServicoBindingNavigator.RefreshItems += tbServicoBindingNavigator_RefreshItems;
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
            // tbServicoBindingNavigatorSaveItem
            // 
            tbServicoBindingNavigatorSaveItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbServicoBindingNavigatorSaveItem.Image = (Image)resources.GetObject("tbServicoBindingNavigatorSaveItem.Image");
            tbServicoBindingNavigatorSaveItem.Name = "tbServicoBindingNavigatorSaveItem";
            tbServicoBindingNavigatorSaveItem.Size = new Size(23, 22);
            tbServicoBindingNavigatorSaveItem.Text = "Save Data";
            tbServicoBindingNavigatorSaveItem.Click += tbServicoBindingNavigatorSaveItem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(btnPesquisar);
            groupBox2.Controls.Add(txtPesquisar);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cbmFiltrar);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(14, 306);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(817, 76);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pesquisar";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(468, 30);
            btnPesquisar.Margin = new Padding(4, 3, 4, 3);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(88, 27);
            btnPesquisar.TabIndex = 4;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.AcceptsReturn = true;
            txtPesquisar.Location = new Point(246, 32);
            txtPesquisar.Margin = new Padding(4, 3, 4, 3);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(213, 23);
            txtPesquisar.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 36);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 2;
            label2.Text = "=";
            // 
            // cbmFiltrar
            // 
            cbmFiltrar.FormattingEnabled = true;
            cbmFiltrar.Items.AddRange(new object[] { "", "Código", "Nome" });
            cbmFiltrar.Location = new Point(76, 32);
            cbmFiltrar.Margin = new Padding(4, 3, 4, 3);
            cbmFiltrar.Name = "cbmFiltrar";
            cbmFiltrar.Size = new Size(140, 23);
            cbmFiltrar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Filtrar por: ";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(tbCategoriaDataGridView);
            groupBox3.Location = new Point(14, 389);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(817, 306);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Serviço(s)";
            // 
            // tbCategoriaDataGridView
            // 
            tbCategoriaDataGridView.AllowUserToAddRows = false;
            tbCategoriaDataGridView.AllowUserToDeleteRows = false;
            tbCategoriaDataGridView.AutoGenerateColumns = false;
            tbCategoriaDataGridView.Columns.AddRange(new DataGridViewColumn[] { id, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            tbCategoriaDataGridView.DataSource = tbCategoriaBindingSource;
            tbCategoriaDataGridView.Dock = DockStyle.Fill;
            tbCategoriaDataGridView.Location = new Point(4, 19);
            tbCategoriaDataGridView.Margin = new Padding(4, 3, 4, 3);
            tbCategoriaDataGridView.Name = "tbCategoriaDataGridView";
            tbCategoriaDataGridView.ReadOnly = true;
            tbCategoriaDataGridView.Size = new Size(809, 284);
            tbCategoriaDataGridView.TabIndex = 0;
            tbCategoriaDataGridView.MouseDoubleClick += tbServicoDataGridView_MouseDoubleClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "Código";
            id.Name = "id";
            id.ReadOnly = true;
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
            dataGridViewTextBoxColumn3.DataPropertyName = "descricao";
            dataGridViewTextBoxColumn3.HeaderText = "Descrição";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "observacao";
            dataGridViewTextBoxColumn4.HeaderText = "Observação";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "valor";
            dataGridViewTextBoxColumn5.HeaderText = "Valor";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "dataDia";
            dataGridViewTextBoxColumn6.HeaderText = "Data do Cadastro";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "cadastradoPor";
            dataGridViewTextBoxColumn7.HeaderText = "Cadastrado Por";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 710);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(tbServicoBindingNavigator);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de categoria";
            Load += frmCategoria_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbCategoriaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)servicoDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbServicoBindingNavigator).EndInit();
            tbServicoBindingNavigator.ResumeLayout(false);
            tbServicoBindingNavigator.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbCategoriaDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ServicoDataSet servicoDataSet;
        private BindingSource tbCategoriaBindingSource;
        private Desafio.ServicoDataSetTableAdapters.tbCategoriaTableAdapter tbCategoriaTableAdapter;
        private BindingNavigator tbServicoBindingNavigator;
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
        private ToolStripButton tbServicoBindingNavigatorSaveItem;
        private TextBox idCategoriaTextBox;
        private TextBox nomeTextBox;
        private TextBox descricaoTextBox;
        private TextBox observacaoTextBox;
        private TextBox valorTextBox;
        private TextBox dataDiaTextBox;
        private TextBox cadastradoPorTextBox;
        private GroupBox groupBox2;
        private Button btnPesquisar;
        private TextBox txtPesquisar;
        private Label label2;
        private ComboBox cbmFiltrar;
        private Label label1;
        private GroupBox groupBox3;
        private DataGridView tbCategoriaDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}