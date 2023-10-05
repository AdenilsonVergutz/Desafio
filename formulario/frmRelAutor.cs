using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desafio
{
    public partial class frmRelAutor : Form
    {
        public frmRelAutor()
        {
            InitializeComponent();
        }

        private void frmRelAutor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ServicoDataSet.tbAutor' table. You can move, or remove it, as needed.
            this.tbAutorTableAdapter.Fill(this.ServicoDataSet.tbAutor);

            this.reportViewer1.RefreshReport();
        }
    }
}