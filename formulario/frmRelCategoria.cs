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
            // TODO: This line of code loads data into the 'ServicoDataSet.tbServico' table. You can move, or remove it, as needed.
            this.tbServicoTableAdapter.Fill(this.ServicoDataSet.tbServico);

            this.reportViewer1.RefreshReport();
        }
    }
}