using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desafio
{
    public partial class frmRelCategoria : Form
    {
        public frmRelCategoria()
        {
            InitializeComponent();
        }

        private void frmRelServico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ServicoDataSet.tbCategoria' table. You can move, or remove it, as needed.
            this.tbCategoriaTableAdapter.Fill(this.ServicoDataSet.tbCategoria);

            this.reportViewer1.RefreshReport();
        }
    }
}