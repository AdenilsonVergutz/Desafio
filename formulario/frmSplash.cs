using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desafio
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Incrementa 1
            progressBar1.Increment(1);

            //Ser a progrresBar 1 for igual a 5
            if (progressBar1.Value == 100)
            {
                //Pare
                timer1.Stop();

            }

        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            //Código responsavel pela opacidade do formulario          
            this.Opacity = 0;
            for (double cont = 0; cont <= 1; cont += 0.1)
            {
                this.Opacity = cont;
                this.Refresh();
                System.Threading.Thread.Sleep(15);


            }

        }
    }
}