using Desafio.Properties;
using Desafio.ServicoDataSetTableAdapters;

namespace Desafio.formulario
{
    partial class frmTag
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

            tagDataDiaLabel = new Label();
            nomeTagLabel = new Label();
            TagLabel = new Label();
            igualLabel = new Label();
            filtrarPorTagLabel = new Label();
            usuarioCadastroTagLabel = new Label();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTag));
            TagGroupBox = new GroupBox();
            dataCadastroTagTextBox = new TextBox();
            tbTagBindingSource = new BindingSource(components);
            usuarioCadastroTagTextBox = new TextBox();
            nomeTagTextBox = new TextBox();
            idTagTextBox = new TextBox();
            tagDataGridView = new DataGridView();
            tagGroupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            txtPesquisar = new TextBox();
            cbmFiltrarTag = new ComboBox();
            btnPesquisarTag = new Button();
            tbTagTableAdapter = new tbTagTableAdapter();
            tbTagBindingNavigator = new BindingNavigator(components);
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
            tbTagBindingNavigatorSaveItem = new ToolStripButton();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDiaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cadastradorPorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TagGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbTagBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tagDataGridView).BeginInit();
            tagGroupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbTagBindingNavigator).BeginInit();
            tbTagBindingNavigator.SuspendLayout();
            SuspendLayout();
            // 
            // tagDataDiaLabel
            // 
            tagDataDiaLabel.AutoSize = true;
            tagDataDiaLabel.Location = new Point(185, 148);
            tagDataDiaLabel.Name = "tagDataDiaLabel";
            tagDataDiaLabel.Size = new Size(87, 15);
            tagDataDiaLabel.TabIndex = 4;
            tagDataDiaLabel.Text = "Data Cadastro: ";
            // 
            // nomeTagLabel
            // 
            nomeTagLabel.AutoSize = true;
            nomeTagLabel.Location = new Point(200, 51);
            nomeTagLabel.Name = "nomeTagLabel";
            nomeTagLabel.Size = new Size(43, 15);
            nomeTagLabel.TabIndex = 1;
            nomeTagLabel.Text = "Nome:";
            // 
            // TagLabel
            // 
            TagLabel.AutoSize = true;
            TagLabel.Location = new Point(13, 51);
            TagLabel.Name = "TagLabel";
            TagLabel.Size = new Size(49, 15);
            TagLabel.TabIndex = 0;
            TagLabel.Text = "Código:";
            // 
            // igualLabel
            // 
            igualLabel.AutoSize = true;
            igualLabel.Location = new Point(246, 47);
            igualLabel.Name = "igualLabel";
            igualLabel.Size = new Size(15, 15);
            igualLabel.TabIndex = 4;
            igualLabel.Text = "=";
            // 
            // filtrarPorTagLabel
            // 
            filtrarPorTagLabel.AutoSize = true;
            filtrarPorTagLabel.Location = new Point(11, 49);
            filtrarPorTagLabel.Name = "filtrarPorTagLabel";
            filtrarPorTagLabel.Size = new Size(64, 15);
            filtrarPorTagLabel.TabIndex = 2;
            filtrarPorTagLabel.Text = "Filtrar por: ";
            // 
            // usuarioCadastroTagLabel
            // 
            usuarioCadastroTagLabel.AutoSize = true;
            usuarioCadastroTagLabel.Location = new Point(430, 149);
            usuarioCadastroTagLabel.Name = "usuarioCadastroTagLabel";
            usuarioCadastroTagLabel.Size = new Size(101, 15);
            usuarioCadastroTagLabel.TabIndex = 5;
            usuarioCadastroTagLabel.Text = "Usuário cadastro: ";
            // 
            // TagGroupBox
            // 
            TagGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TagGroupBox.Controls.Add(dataCadastroTagTextBox);
            TagGroupBox.Controls.Add(tagDataDiaLabel);
            TagGroupBox.Controls.Add(usuarioCadastroTagTextBox);
            TagGroupBox.Controls.Add(usuarioCadastroTagLabel);
            TagGroupBox.Controls.Add(nomeTagTextBox);
            TagGroupBox.Controls.Add(nomeTagLabel);
            TagGroupBox.Controls.Add(idTagTextBox);
            TagGroupBox.Controls.Add(TagLabel);
            TagGroupBox.Location = new Point(22, 61);
            TagGroupBox.Margin = new Padding(4, 3, 4, 3);
            TagGroupBox.Name = "TagGroupBox";
            TagGroupBox.Size = new Size(665, 176);
            TagGroupBox.TabIndex = 0;
            TagGroupBox.TabStop = false;
            TagGroupBox.Text = "Cadastre sua Tag";
            // 
            // dataCadastroTagTextBox
            // 
            dataCadastroTagTextBox.DataBindings.Add(new Binding("Text", tbTagBindingSource, "dataDia", true));
            dataCadastroTagTextBox.Location = new Point(278, 144);
            dataCadastroTagTextBox.Name = "dataCadastroTagTextBox";
            dataCadastroTagTextBox.Size = new Size(126, 23);
            dataCadastroTagTextBox.TabIndex = 7;
            //dataCadastroTagTextBox.Visible = false;
            dataCadastroTagTextBox.Enabled = false;

            // 
            // tbTagBindingSource
            // 
            tbTagBindingSource.DataMember = "tbTag";
            tbTagBindingSource.DataSource = typeof(ServicoDataSet);
            // 
            // usuarioCadastroTagTextBox
            // 
            usuarioCadastroTagTextBox.DataBindings.Add(new Binding("Text", tbTagBindingSource, "cadastradorPor", true));
            usuarioCadastroTagTextBox.Location = new Point(529, 143);
            usuarioCadastroTagTextBox.Name = "usuarioCadastroTagTextBox";
            usuarioCadastroTagTextBox.Size = new Size(130, 23);
            usuarioCadastroTagTextBox.TabIndex = 6;
            usuarioCadastroTagTextBox.Enabled = false;

            // 
            // nomeTagTextBox
            // 
            nomeTagTextBox.DataBindings.Add(new Binding("Text", tbTagBindingSource, "nome", true));
            nomeTagTextBox.Location = new Point(251, 46);
            nomeTagTextBox.Name = "nomeTagTextBox";
            nomeTagTextBox.Size = new Size(280, 23);
            nomeTagTextBox.TabIndex = 3;
            // 
            // idTagTextBox
            // 
            idTagTextBox.DataBindings.Add(new Binding("Text", tbTagBindingSource, "Id", true));
            idTagTextBox.Enabled = false;
            idTagTextBox.Location = new Point(67, 47);
            idTagTextBox.Margin = new Padding(4, 3, 4, 3);
            idTagTextBox.Name = "idTagTextBox";
            idTagTextBox.Size = new Size(87, 23);
            idTagTextBox.TabIndex = 2;
            // 
            // tagDataGridView
            // 
            tagDataGridView.AllowUserToAddRows = false;
            tagDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tagDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tagDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tagDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, dataDiaDataGridViewTextBoxColumn, cadastradorPorDataGridViewTextBoxColumn });
            tagDataGridView.DataSource = tbTagBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tagDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            tagDataGridView.Dock = DockStyle.Fill;
            tagDataGridView.Location = new Point(3, 19);
            tagDataGridView.Name = "tagDataGridView";
            tagDataGridView.ReadOnly = true;
            tagDataGridView.RowTemplate.Height = 25;
            tagDataGridView.Size = new Size(659, 210);
            tagDataGridView.TabIndex = 1;
            tagDataGridView.MouseDoubleClick += tbTagDataGridView_MouseDoubleClick;
            // 
            // tagGroupBox2
            // 
            tagGroupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tagGroupBox2.Controls.Add(tagDataGridView);
            tagGroupBox2.Location = new Point(22, 344);
            tagGroupBox2.Name = "tagGroupBox2";
            tagGroupBox2.Size = new Size(665, 232);
            tagGroupBox2.TabIndex = 2;
            tagGroupBox2.TabStop = false;
            tagGroupBox2.Text = "Tag(s):";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(igualLabel);
            groupBox1.Controls.Add(txtPesquisar);
            groupBox1.Controls.Add(filtrarPorTagLabel);
            groupBox1.Controls.Add(cbmFiltrarTag);
            groupBox1.Controls.Add(btnPesquisarTag);
            groupBox1.Location = new Point(29, 249);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(658, 89);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(267, 46);
            txtPesquisar.Multiline = true;
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(151, 23);
            txtPesquisar.TabIndex = 3;
            // 
            // cbmFiltrarTag
            // 
            cbmFiltrarTag.FormattingEnabled = true;
            cbmFiltrarTag.Items.AddRange(new object[] { "", "Código", "Nome" });
            cbmFiltrarTag.Location = new Point(79, 46);
            cbmFiltrarTag.Margin = new Padding(4, 3, 4, 3);
            cbmFiltrarTag.Name = "cbmFiltrarTag";
            cbmFiltrarTag.Size = new Size(157, 23);
            cbmFiltrarTag.TabIndex = 1;
            // 
            // btnPesquisarTag
            // 
            btnPesquisarTag.Location = new Point(454, 43);
            btnPesquisarTag.Name = "btnPesquisarTag";
            btnPesquisarTag.Size = new Size(109, 30);
            btnPesquisarTag.TabIndex = 0;
            btnPesquisarTag.Text = "Pesquisar";
            btnPesquisarTag.UseVisualStyleBackColor = true;
            btnPesquisarTag.Click += btnPesquisar_Click;
            // 
            // tbTagTableAdapter
            // 
            tbTagTableAdapter.ClearBeforeFill = true;
            // 
            // tbTagBindingNavigator
            // 
            tbTagBindingNavigator.AddNewItem = bindingNavigatorAddNewItem;
            tbTagBindingNavigator.BindingSource = tbTagBindingSource;
            tbTagBindingNavigator.CountItem = bindingNavigatorCountItem;
            tbTagBindingNavigator.DeleteItem = bindingNavigatorDeleteItem;
            tbTagBindingNavigator.Items.AddRange(new ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, tbTagBindingNavigatorSaveItem });
            tbTagBindingNavigator.Location = new Point(0, 0);
            tbTagBindingNavigator.MoveFirstItem = bindingNavigatorMoveFirstItem;
            tbTagBindingNavigator.MoveLastItem = bindingNavigatorMoveLastItem;
            tbTagBindingNavigator.MoveNextItem = bindingNavigatorMoveNextItem;
            tbTagBindingNavigator.MovePreviousItem = bindingNavigatorMovePreviousItem;
            tbTagBindingNavigator.Name = "tbTagBindingNavigator";
            tbTagBindingNavigator.PositionItem = bindingNavigatorPositionItem;
            tbTagBindingNavigator.Size = new Size(714, 25);
            tbTagBindingNavigator.TabIndex = 1;
            tbTagBindingNavigator.Text = "bindingNavigatorTag";
            tbTagBindingNavigator.RefreshItems += tbTagBindingNavigator_RefreshItems;
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
            // tbTagBindingNavigatorSaveItem
            // 
            tbTagBindingNavigatorSaveItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbTagBindingNavigatorSaveItem.Image = (Image)resources.GetObject("tbTagBindingNavigatorSaveItem.Image");
            tbTagBindingNavigatorSaveItem.Name = "tbTagBindingNavigatorSaveItem";
            tbTagBindingNavigatorSaveItem.Size = new Size(23, 22);
            tbTagBindingNavigatorSaveItem.Text = "Save Data";
            tbTagBindingNavigatorSaveItem.Click += tbTagBindingNavigatorSaveItem_Click;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Código";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            nomeDataGridViewTextBoxColumn.Width = 180;
            // 
            // dataDiaDataGridViewTextBoxColumn
            // 
            dataDiaDataGridViewTextBoxColumn.DataPropertyName = "dataDia";
            dataDiaDataGridViewTextBoxColumn.HeaderText = "data Criação";
            dataDiaDataGridViewTextBoxColumn.Name = "dataDiaDataGridViewTextBoxColumn";
            dataDiaDataGridViewTextBoxColumn.ReadOnly = true;
            dataDiaDataGridViewTextBoxColumn.Width = 110;
            // 
            // cadastradorPorDataGridViewTextBoxColumn
            // 
            cadastradorPorDataGridViewTextBoxColumn.DataPropertyName = "CadastradorPor";
            cadastradorPorDataGridViewTextBoxColumn.HeaderText = "Usuário criação";
            cadastradorPorDataGridViewTextBoxColumn.Name = "cadastradorPorDataGridViewTextBoxColumn";
            cadastradorPorDataGridViewTextBoxColumn.ReadOnly = true;
            cadastradorPorDataGridViewTextBoxColumn.Width = 200;
            // 
            // frmTag
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 582);
            Controls.Add(tbTagBindingNavigator);
            Controls.Add(groupBox1);
            Controls.Add(tagGroupBox2);
            Controls.Add(TagGroupBox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmTag";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Tag";
            Load += frmTag_Load;
            TagGroupBox.ResumeLayout(false);
            TagGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbTagBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tagDataGridView).EndInit();
            tagGroupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbTagBindingNavigator).EndInit();
            tbTagBindingNavigator.ResumeLayout(false);
            tbTagBindingNavigator.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox TagGroupBox;
        private Label TagLabel;
        private TextBox nomeTagTextBox;
        private TextBox idTagTextBox;
        private Label nomeTagLabel;
        private ServicoDataSet servicoDataSet;
        private Desafio.ServicoDataSetTableAdapters.tbTagTableAdapter tbTagTableAdapter;



        private BindingSource tbTagBindingSource;
        private DataGridView tagDataGridView;
        private GroupBox tagGroupBox2;
        private Label tagDataDiaLabel;
        private TextBox dataCadastroTagTextBox;
        private TextBox usuarioCadastroTagTextBox;
        private Label usuarioCadastroTagLabel;
        private GroupBox groupBox1;
        private Button btnPesquisarTag;
        private ComboBox cbmFiltrarTag;
        private Label filtrarPorTagLabel;
        private TextBox txtPesquisar;
        private Label igualLabel;
        private BindingNavigator tbTagBindingNavigator;


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
        private ToolStripButton tbTagBindingNavigatorSaveItem;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cadastradorPorDataGridViewTextBoxColumn;
    }
}