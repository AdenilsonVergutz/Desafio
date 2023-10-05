using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desafio
{
    public partial class frmRelPost : Form
    {
        public frmRelPost()
        {
            InitializeComponent();
        }

        private void frmRelOS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ServicoDataSet.tbPost' table. You can move, or remove it, as needed.
            this.tbPostTableAdapter.Fill(this.ServicoDataSet.tbPost);

            this.reportViewer1.RefreshReport();
        }
    }
}