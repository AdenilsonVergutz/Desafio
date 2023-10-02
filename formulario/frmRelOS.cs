using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desafio
{
    public partial class frmRelOS : Form
    {
        public frmRelOS()
        {
            InitializeComponent();
        }

        private void frmRelOS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ServicoDataSet.tbOrdemServico' table. You can move, or remove it, as needed.
            this.tbOrdemServicoTableAdapter.Fill(this.ServicoDataSet.tbOrdemServico);

            this.reportViewer1.RefreshReport();
        }
    }
}