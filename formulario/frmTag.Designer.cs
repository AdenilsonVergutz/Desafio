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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            TagGroupBox = new GroupBox();
            dataCadastroTagTextBox = new TextBox();
            tbTagBindingSource = new BindingSource(components);
            usuarioCadastroTagTextBox = new TextBox();
            usuarioCadastroTagLabel = new Label();
            tagDataDiaLabel = new Label();
            nomeTagTextBox = new TextBox();
            idTagTextBox = new TextBox();
            nomeTagLabel = new Label();
            TagLabel = new Label();
            tagDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            dataDia = new DataGridViewTextBoxColumn();
            cadastradorPor = new DataGridViewTextBoxColumn();
            tagGroupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            igualLabel = new Label();
            txtPesquisar = new TextBox();
            filtrarPorTagLabel = new Label();
            cbmFiltrarTag = new ComboBox();
            btnPesquisarTag = new Button();
            tbTagBindingNavigator = new BindingNavigator(components);
            TagGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbTagBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tagDataGridView).BeginInit();
            tagGroupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbTagBindingNavigator).BeginInit();
            SuspendLayout();
            // 
            // TagGroupBox
            // 
            TagGroupBox.Controls.Add(dataCadastroTagTextBox);
            TagGroupBox.Controls.Add(usuarioCadastroTagTextBox);
            TagGroupBox.Controls.Add(usuarioCadastroTagLabel);
            TagGroupBox.Controls.Add(tagDataDiaLabel);
            TagGroupBox.Controls.Add(nomeTagTextBox);
            TagGroupBox.Controls.Add(idTagTextBox);
            TagGroupBox.Controls.Add(nomeTagLabel);
            TagGroupBox.Controls.Add(TagLabel);
            TagGroupBox.Location = new Point(22, 61);
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
            dataCadastroTagTextBox.Visible = false;
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
            usuarioCadastroTagTextBox.Visible = false;
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
            // tagDataDiaLabel
            // 
            tagDataDiaLabel.AutoSize = true;
            tagDataDiaLabel.Location = new Point(185, 148);
            tagDataDiaLabel.Name = "tagDataDiaLabel";
            tagDataDiaLabel.Size = new Size(87, 15);
            tagDataDiaLabel.TabIndex = 4;
            tagDataDiaLabel.Text = "Data Cadastro: ";
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
            idTagTextBox.Name = "idTagTextBox";
            idTagTextBox.Size = new Size(87, 23);
            idTagTextBox.TabIndex = 2;
            idTagTextBox.Visible = false;
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
            // tagDataGridView
            // 
            tagDataGridView.AllowUserToAddRows = false;
            tagDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tagDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tagDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tagDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nome, dataDia, cadastradorPor });
            tagDataGridView.DataSource = tbTagBindingSource;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            tagDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            tagDataGridView.Location = new Point(6, 31);
            tagDataGridView.Name = "tagDataGridView";
            tagDataGridView.ReadOnly = true;
            tagDataGridView.RowTemplate.Height = 25;
            tagDataGridView.Size = new Size(653, 195);
            tagDataGridView.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Código";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 80;
            // 
            // nome
            // 
            nome.DataPropertyName = "nome";
            nome.HeaderText = "nome";
            nome.Name = "nome";
            nome.ReadOnly = true;
            nome.Width = 180;
            // 
            // dataDia
            // 
            dataDia.DataPropertyName = "dataDia";
            dataDia.HeaderText = "data Criação";
            dataDia.Name = "dataDia";
            dataDia.ReadOnly = true;
            dataDia.Width = 110;
            // 
            // cadastradorPor
            // 
            cadastradorPor.DataPropertyName = "CadastradorPor";
            cadastradorPor.HeaderText = "Usuário criação";
            cadastradorPor.Name = "cadastradorPor";
            cadastradorPor.ReadOnly = true;
            cadastradorPor.Width = 200;
            // 
            // tagGroupBox2
            // 
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
            groupBox1.Controls.Add(igualLabel);
            groupBox1.Controls.Add(txtPesquisar);
            groupBox1.Controls.Add(filtrarPorTagLabel);
            groupBox1.Controls.Add(cbmFiltrarTag);
            groupBox1.Controls.Add(btnPesquisarTag);
            groupBox1.Location = new Point(29, 249);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(658, 89);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisar:";
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
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(267, 46);
            txtPesquisar.Multiline = true;
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(151, 23);
            txtPesquisar.TabIndex = 3;
            // 
            // filtrarPorTagLabel
            // 
            filtrarPorTagLabel.AutoSize = true;
            filtrarPorTagLabel.Location = new Point(11, 49);
            filtrarPorTagLabel.Name = "filtrarPorTagLabel";
            filtrarPorTagLabel.Size = new Size(64, 15);
            filtrarPorTagLabel.TabIndex = 2;
            filtrarPorTagLabel.Text = "Filtrar por: ";
            filtrarPorTagLabel.Click += filtrarPorTagLabel_Click;
            // 
            // cbmFiltrarTag
            // 
            cbmFiltrarTag.DataSource = tbTagBindingSource;
            cbmFiltrarTag.FormattingEnabled = true;
            cbmFiltrarTag.Location = new Point(79, 46);
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
            // 
            // tbTagBindingNavigator
            // 
            tbTagBindingNavigator.AddNewItem = null;
            tbTagBindingNavigator.BindingSource = tbTagBindingSource;
            tbTagBindingNavigator.CountItem = null;
            tbTagBindingNavigator.DeleteItem = null;
            tbTagBindingNavigator.Location = new Point(0, 0);
            tbTagBindingNavigator.MoveFirstItem = null;
            tbTagBindingNavigator.MoveLastItem = null;
            tbTagBindingNavigator.MoveNextItem = null;
            tbTagBindingNavigator.MovePreviousItem = null;
            tbTagBindingNavigator.Name = "tbTagBindingNavigator";
            tbTagBindingNavigator.PositionItem = null;
            tbTagBindingNavigator.Size = new Size(714, 25);
            tbTagBindingNavigator.TabIndex = 1;
            tbTagBindingNavigator.Text = "bindingNavigatorTag";
            tbTagBindingNavigator.RefreshItems += tbTagBindingNavigator_RefreshItems;
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
            Name = "frmTag";
            Text = "Cadastro de Tag";
            TagGroupBox.ResumeLayout(false);
            TagGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbTagBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tagDataGridView).EndInit();
            tagGroupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbTagBindingNavigator).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox TagGroupBox;
        private Label TagLabel;
        private TextBox nomeTagTextBox;
        private TextBox idTagTextBox;
        private Label nomeTagLabel;


        private BindingSource tbTagBindingSource;
        private DataGridView tagDataGridView;
        private BindingSource tbTagTableAdapter;
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
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn dataDia;
        private DataGridViewTextBoxColumn cadastradorPor;
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


    }
}