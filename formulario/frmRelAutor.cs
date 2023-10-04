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

        private void frmRelCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ServicoDataSet.tbCliente' table. You can move, or remove it, as needed.
            this.tbClienteTableAdapter.Fill(this.ServicoDataSet.tbCliente);

            this.reportViewer1.RefreshReport();
        }
    }
}