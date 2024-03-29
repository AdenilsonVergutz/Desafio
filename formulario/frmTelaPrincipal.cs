using Desafio.formulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Desafio
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        {

            //N�vel de Acesso: Ser o usuario for Operador o formulario estara invisivel
            if (frmLogin.NivelAcesso == "Operador")
            {
                //N�vel de Operador n�o podera cadastrar usu�rio
                usu�rioToolStripMenuItem.Visible = false;
            }

            //Mostrar o usu�rio conectado
            tsslUsuario.Text = "Usu�rio: " + frmLogin.usuarioConectado;

            //Mostrar o nome do PC
            string myHost = System.Net.Dns.GetHostName();
            tsslNomePC.Text = "Nome do PC: " + myHost;

            //Mostrar o IP do usu�rio

            System.Net.IPHostEntry myIPs = System.Net.Dns.GetHostEntry(myHost);
            foreach (System.Net.IPAddress myIP in myIPs.AddressList)
            {
                //Mostar o IP
                tsslIP.Text = "IP: " + myIP;

            }
            //Mostrar a Data
            tsslData.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Mostrar a Hora
            tsslHora.Text = DateTime.Now.ToString("HH:mm");

        }

        private void usu�rioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                formulario.frmUsuario usuario = null; // form a ser aberto

                //procura form na rela��o de forms filhos
                foreach (Form frm in this.MdiChildren)
                {
                    //se encontrou inicializa instancia de frmUsuario com o form ja aberto
                    if (frm is formulario.frmUsuario)
                    {
                        usuario = (formulario.frmUsuario)frm;
                        break;
                    }
                }
                // se n�o encontrou na rela��o, instancia objeto, "seta"  form pai e exibe form
                if (usuario == null)
                {
                    usuario = new formulario.frmUsuario();
                    usuario.MdiParent = this;
                    usuario.Show();
                }
                //garante que ele fique em foco caso haja outros forms abertos
                usuario.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("N�o foi poss�vel ser conectar ao formul�rio devido ao erro: " + ex.Message,
                    "Aviso",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }


        }

        private void AutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAutor autor = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmAutor)
                    {
                        autor = (frmAutor)frm;
                        break;
                    }
                }
                if (autor == null)
                {
                    autor = new frmAutor();
                    autor.MdiParent = this;
                    autor.Show();
                }

                autor.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("N�o foi poss�vel ser conectar ao formul�rio devido ao erro: " + ex.Message,
                    "Aviso",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }

        }

        private void servi�oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                formulario.frmCategoria servico = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is formulario.frmCategoria)
                    {
                        servico = (formulario.frmCategoria)frm;
                        break;
                    }
                }
                if (servico == null)
                {
                    servico = new formulario.frmCategoria();
                    servico.MdiParent = this;
                    servico.Show();
                }

                servico.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("N�o foi poss�vel ser conectar ao formul�rio devido ao erro: " + ex.Message,
                    "Aviso",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }

        }

        private void PostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPost os = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmPost)
                    {
                        os = (frmPost)frm;
                        break;
                    }
                }
                if (os == null)
                {
                    os = new frmPost();
                    os.MdiParent = this;
                    os.Show();
                }

                os.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("N�o foi poss�vel ser conectar ao formul�rio devido ao erro: " + ex.Message,
                    "Aviso",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmTelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void AutorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmRelAutor relAutor = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmRelAutor)
                    {
                        relAutor = (frmRelAutor)frm;
                        break;
                    }
                }
                if (relAutor == null)
                {
                    relAutor = new frmRelAutor();
                    relAutor.MdiParent = this;
                    relAutor.Show();
                }

                relAutor.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("N�o foi poss�vel ser conectar ao formul�rio devido ao erro: " + ex.Message,
                    "Aviso",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
        }

        private void frmTelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmRelCategoria relCategoria = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmRelCategoria)
                    {
                        relCategoria = (frmRelCategoria)frm;
                        break;
                    }
                }
                if (relCategoria == null)
                {
                    relCategoria = new frmRelCategoria();
                    relCategoria.MdiParent = this;
                    relCategoria.Show();
                }

                relCategoria.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("N�o foi poss�vel ser conectar ao formul�rio devido ao erro: " + ex.Message,
                    "Aviso",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }

        }

        private void PostToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmRelPost relPost = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmRelPost)
                    {
                        relPost = (frmRelPost)frm;
                        break;
                    }
                }
                if (relPost == null)
                {
                    relPost = new frmRelPost();
                    relPost.MdiParent = this;
                    relPost.Show();
                }

                relPost.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("N�o foi poss�vel ser conectar ao formul�rio devido ao erro: " + ex.Message,
                    "Aviso",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
        }

        private void tsbAutor_Click(object sender, EventArgs e)
        {
            try
            {
                frmAutor autor = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmAutor)
                    {
                        autor = (frmAutor)frm;
                        break;
                    }
                }
                if (autor == null)
                {
                    autor = new frmAutor();
                    autor.MdiParent = this;
                    autor.Show();
                }

                autor.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("N�o foi poss�vel ser conectar ao formul�rio devido ao erro: " + ex.Message,
                    "Aviso",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }

        }

        private void tsbCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                formulario.frmCategoria categoria = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is formulario.frmCategoria)
                    {
                        categoria = (formulario.frmCategoria)frm;
                        break;
                    }
                }
                if (categoria == null)
                {
                    categoria = new formulario.frmCategoria();
                    categoria.MdiParent = this;
                    categoria.Show();
                }

                categoria.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("N�o foi poss�vel ser conectar ao formul�rio devido ao erro: " + ex.Message,
                    "Aviso",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }

        }


        private void tsbTag_Click(object sender, EventArgs e)
        {
            try
            {
                frmTag tag = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmTag)
                    {
                        tag = (frmTag)frm;
                        break;
                    }
                }
                if (tag == null)
                {
                    tag = new frmTag();
                    tag.MdiParent = this;
                    tag.Show();
                }

                tag.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("N�o foi poss�vel ser conectar ao formul�rio devido ao erro: " + ex.Message,
                    "Aviso",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }

        }




        private void tsbPost_Click(object sender, EventArgs e)
        {
            try
            {
                frmPost post = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmPost)
                    {
                        post = (frmPost)frm;
                        break;
                    }
                }
                if (post == null)
                {
                    post = new frmPost();
                    post.MdiParent = this;
                    post.Show();
                }

                post.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("N�o foi poss�vel ser conectar ao formul�rio devido ao erro: " + ex.Message,
                    "Aviso",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }

        }

        private void tsbLogoff_Click(object sender, EventArgs e)
        {
            string mensagem = "Que realmente fazer Logoff?";
            if (MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.Show();

            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}