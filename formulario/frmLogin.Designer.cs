namespace Desafio
{
    partial class frmLogin
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
            Label usuarioLabel;
            Label nivelAcessoLabel;
            Label senhaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            groupBox1 = new GroupBox();
            senhaTextBox = new TextBox();
            btnSair = new Button();
            btnConectar = new Button();
            nivelAcessoComboBox = new ComboBox();
            usuarioComboBox = new ComboBox();
            tbUsuarioBindingSource = new BindingSource(components);
            servicoDataSet = new ServicoDataSet();
            tbUsuarioTableAdapter = new ServicoDataSetTableAdapters.tbUsuarioTableAdapter();
            usuarioLabel = new Label();
            nivelAcessoLabel = new Label();
            senhaLabel = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbUsuarioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)servicoDataSet).BeginInit();
            SuspendLayout();
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new Point(54, 34);
            usuarioLabel.Margin = new Padding(4, 0, 4, 0);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new Size(47, 15);
            usuarioLabel.TabIndex = 0;
            usuarioLabel.Text = "Usuário";
            // 
            // nivelAcessoLabel
            // 
            nivelAcessoLabel.AutoSize = true;
            nivelAcessoLabel.Location = new Point(10, 62);
            nivelAcessoLabel.Margin = new Padding(4, 0, 4, 0);
            nivelAcessoLabel.Name = "nivelAcessoLabel";
            nivelAcessoLabel.Size = new Size(96, 15);
            nivelAcessoLabel.TabIndex = 2;
            nivelAcessoLabel.Text = "Nível de Acesso: ";
            nivelAcessoLabel.TextAlign = ContentAlignment.TopCenter;
            nivelAcessoLabel.Click += nivelAcessoLabel_Click;
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new Point(59, 94);
            senhaLabel.Margin = new Padding(4, 0, 4, 0);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new Size(42, 15);
            senhaLabel.TabIndex = 7;
            senhaLabel.Text = "Senha:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(senhaLabel);
            groupBox1.Controls.Add(senhaTextBox);
            groupBox1.Controls.Add(btnSair);
            groupBox1.Controls.Add(btnConectar);
            groupBox1.Controls.Add(nivelAcessoLabel);
            groupBox1.Controls.Add(nivelAcessoComboBox);
            groupBox1.Controls.Add(usuarioLabel);
            groupBox1.Controls.Add(usuarioComboBox);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(7, 83);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(327, 273);
            groupBox1.TabIndex = 1;
            groupBox1.Text = "Login: ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // senhaTextBox
            // 
            senhaTextBox.Location = new Point(104, 88);
            senhaTextBox.Margin = new Padding(4, 3, 4, 3);
            senhaTextBox.Name = "senhaTextBox";
            senhaTextBox.PasswordChar = '●';
            senhaTextBox.Size = new Size(143, 23);
            senhaTextBox.TabIndex = 3;
            senhaTextBox.KeyDown += senhaTextBox_KeyDown;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.RosyBrown;
            btnSair.Location = new Point(132, 239);
            btnSair.Margin = new Padding(4, 3, 4, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(82, 27);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnConectar
            // 
            btnConectar.BackColor = SystemColors.ButtonFace;
            btnConectar.Location = new Point(103, 148);
            btnConectar.Margin = new Padding(4, 3, 4, 3);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(143, 33);
            btnConectar.TabIndex = 4;
            btnConectar.Text = "Entrar";
            btnConectar.UseVisualStyleBackColor = false;
            btnConectar.Click += btnConectar_Click;
            // 
            // nivelAcessoComboBox
            // 
            nivelAcessoComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            nivelAcessoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            nivelAcessoComboBox.FormattingEnabled = true;
            nivelAcessoComboBox.Items.AddRange(new object[] { "", "Administrador", "Operador" });
            nivelAcessoComboBox.Location = new Point(104, 57);
            nivelAcessoComboBox.Margin = new Padding(4, 3, 4, 3);
            nivelAcessoComboBox.Name = "nivelAcessoComboBox";
            nivelAcessoComboBox.Size = new Size(143, 23);
            nivelAcessoComboBox.TabIndex = 2;
            // 
            // usuarioComboBox
            // 
            usuarioComboBox.DataSource = tbUsuarioBindingSource;
            usuarioComboBox.DisplayMember = "usuario";
            usuarioComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            usuarioComboBox.FormattingEnabled = true;
            usuarioComboBox.Location = new Point(104, 26);
            usuarioComboBox.Margin = new Padding(4, 3, 4, 3);
            usuarioComboBox.Name = "usuarioComboBox";
            usuarioComboBox.Size = new Size(142, 23);
            usuarioComboBox.TabIndex = 1;
            usuarioComboBox.ValueMember = "usuario";
            usuarioComboBox.SelectedIndexChanged += usuarioComboBox_SelectedIndexChanged;
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
            // tbUsuarioTableAdapter
            // 
            tbUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(340, 368);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela de Login";
            FormClosed += frmLogin_FormClosed;
            Load += frmLogin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbUsuarioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)servicoDataSet).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private ComboBox nivelAcessoComboBox;
        private ComboBox usuarioComboBox;
        private Button btnSair;
        private Button btnConectar;
        private TextBox senhaTextBox;
        private ServicoDataSet servicoDataSet;
        private BindingSource tbUsuarioBindingSource;
        private Desafio.ServicoDataSetTableAdapters.tbUsuarioTableAdapter tbUsuarioTableAdapter;
    }
}