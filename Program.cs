using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Windows.Forms;

namespace Desafio
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.teste
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}



//ALTER TABLE tbUsuario ADD bio VARCHAR(250)
//ALTER TABLE tbUsuario ADD slug VARCHAR(50)
//ALTER TABLE tbUsuario ADD email VARCHAR(50)


//  update tbUsuario set bio = 'Bio teste'
//  update tbUsuario set slug = 'Slug teste'
//  update tbUsuario set email = 'adenilson@teste.com'