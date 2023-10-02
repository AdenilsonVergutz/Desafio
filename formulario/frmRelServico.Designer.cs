namespace Desafio
{
    partial class frmRelServico
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelServico));
            this.tbServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ServicoDataSet = new Desafio.ServicoDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbServicoTableAdapter = new Desafio.ServicoDataSetTableAdapters.tbServicoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbServicoBindingSource
            // 
            this.tbServicoBindingSource.DataMember = "tbServico";
            this.tbServicoBindingSource.DataSource = this.ServicoDataSet;
            // 
            // ServicoDataSet
            // 
            this.ServicoDataSet.DataSetName = "ServicoDataSet";
            this.ServicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ServicoDataSet_tbServico";
            reportDataSource1.Value = this.tbServicoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Desafio.formulario.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(746, 388);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbServicoTableAdapter
            // 
            this.tbServicoTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 388);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Serviço";
            this.Load += new System.EventHandler(this.frmRelServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbServicoBindingSource;
        private ServicoDataSet ServicoDataSet;
        private Desafio.ServicoDataSetTableAdapters.tbServicoTableAdapter tbServicoTableAdapter;
    }
}