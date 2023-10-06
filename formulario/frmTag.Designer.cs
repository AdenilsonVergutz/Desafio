namespace Desafio.formulario
{
    partial class FrmTag
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
            TagGroupBox = new GroupBox();
            TagLabel = new Label();
            nomeTagLabel = new Label();
            idTagTextBox = new TextBox();
            nomeTagTextBox = new TextBox();
            TagGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // TagGroupBox
            // 
            TagGroupBox.Controls.Add(nomeTagTextBox);
            TagGroupBox.Controls.Add(idTagTextBox);
            TagGroupBox.Controls.Add(nomeTagLabel);
            TagGroupBox.Controls.Add(TagLabel);
            TagGroupBox.Location = new Point(22, 49);
            TagGroupBox.Name = "TagGroupBox";
            TagGroupBox.Size = new Size(374, 193);
            TagGroupBox.TabIndex = 0;
            TagGroupBox.TabStop = false;
            TagGroupBox.Text = "Cadastre sua Tag";
            // 
            // TagLabel
            // 
            TagLabel.AutoSize = true;
            TagLabel.Location = new Point(13, 41);
            TagLabel.Name = "TagLabel";
            TagLabel.Size = new Size(49, 15);
            TagLabel.TabIndex = 0;
            TagLabel.Text = "Código:";
            // 
            // nomeTagLabel
            // 
            nomeTagLabel.AutoSize = true;
            nomeTagLabel.Location = new Point(12, 90);
            nomeTagLabel.Name = "nomeTagLabel";
            nomeTagLabel.Size = new Size(43, 15);
            nomeTagLabel.TabIndex = 1;
            nomeTagLabel.Text = "Nome:";
            // 
            // idTagTextBox
            // 
            //idTagTextBox.DataBindings.Add(new Binding("Text", tbTagBindingSource, "Id", true));
            idTagTextBox.Location = new Point(67, 37);
            idTagTextBox.Enabled = false;
            idTagTextBox.Name = "idTagTextBox";
            idTagTextBox.Size = new Size(100, 23);
            idTagTextBox.TabIndex = 2;
            // 
            // nomeTagTextBox
            // 
            nomeTagTextBox.Location = new Point(63, 87);
            nomeTagTextBox.Name = "nomeTagTextBox";
            nomeTagTextBox.Size = new Size(141, 23);
            nomeTagTextBox.TabIndex = 3;
            // 
            // FrmTag
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 362);
            Controls.Add(TagGroupBox);
            Name = "FrmTag";
            Text = "Cadastro de Tag";
            TagGroupBox.ResumeLayout(false);
            TagGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox TagGroupBox;
        private Label TagLabel;
        private TextBox nomeTagTextBox;
        private TextBox idTagTextBox;
        private Label nomeTagLabel;


        private BindingSource tbTagBindingSource;

    }
}