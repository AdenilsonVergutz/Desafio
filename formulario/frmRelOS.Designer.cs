namespace Desafio
{
    partial class frmRelOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelOS));
            this.tbOrdemServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ServicoDataSet = new Desafio.ServicoDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbOrdemServicoTableAdapter = new Desafio.ServicoDataSetTableAdapters.tbOrdemServicoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOrdemServicoBindingSource
            // 
            this.tbOrdemServicoBindingSource.DataMember = "tbOrdemServico";
            this.tbOrdemServicoBindingSource.DataSource = this.ServicoDataSet;
            // 
            // ServicoDataSet
            // 
            this.ServicoDataSet.DataSetName = "ServicoDataSet";
            this.ServicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ServicoDataSet_tbOrdemServico";
            reportDataSource1.Value = this.tbOrdemServicoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Desafio.formulario.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(703, 354);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbOrdemServicoTableAdapter
            // 
            this.tbOrdemServicoTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 354);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Ordem de Serviço";
            this.Load += new System.EventHandler(this.frmRelOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbOrdemServicoBindingSource;
        private ServicoDataSet ServicoDataSet;
        private Desafio.ServicoDataSetTableAdapters.tbOrdemServicoTableAdapter tbOrdemServicoTableAdapter;
    }
}