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

            //Nível de Acesso: Ser o usuario for Operador o formulario estara invisivel
            if (frmLogin.NivelAcesso == "Operador")
            {
                //Nível de Operador não podera cadastrar usuário
                usuárioToolStripMenuItem.Visible = false;
            }

            ////Mostrar o usuário conectado
            //tsslUsuario.Text = "Usuário: " + frmLogin.usuarioConectado;

            ////Mostrar o nome do PC
            //string myHost = System.Net.Dns.GetHostName();
            //tsslNomePC.Text = "Nome do PC: " + myHost;

            ////Mostrar o IP do usuário

            //System.Net.IPHostEntry myIPs = System.Net.Dns.GetHostEntry(myHost);
            //foreach (System.Net.IPAddress myIP in myIPs.AddressList)
            //{
            //    //Mostar o IP
            //    tsslIP.Text = "IP: " + myIP;

            //}
            ////Mostrar a Data
            //tsslData.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Mostrar a Hora
            tsslHora.Text = DateTime.Now.ToString("HH:mm");

        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                formulario.frmUsuario usuario = null; // form a ser aberto

                //procura form na relação de forms filhos
                foreach (Form frm in this.MdiChildren)
                {
                    //se encontrou inicializa instancia de frmUsuario com o form ja aberto
                    if (frm is formulario.frmUsuario)
                    {
                        usuario = (formulario.frmUsuario)frm;
                        break;
                    }
                }
                // se não encontrou na relação, instancia objeto, "seta"  form pai e exibe form
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
                MessageBox.Show("Não foi possível ser conectar ao formulário devido ao erro: " + ex.Message,
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
                MessageBox.Show("Não foi possível ser conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }

        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
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
                MessageBox.Show("Não foi possível ser conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }

        }

        private void ordemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
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
                MessageBox.Show("Não foi possível ser conectar ao formulário devido ao erro: " + ex.Message,
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
                MessageBox.Show("Não foi possível ser conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
        }

        private void frmTelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void serviçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmRelCategoria relServico = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmRelCategoria)
                    {
                        relServico = (frmRelCategoria)frm;
                        break;
                    }
                }
                if (relServico == null)
                {
                    relServico = new frmRelCategoria();
                    relServico.MdiParent = this;
                    relServico.Show();
                }

                relServico.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível ser conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }

        }

        private void ordemDeServiçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmRelPost relOS = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmRelPost)
                    {
                        relOS = (frmRelPost)frm;
                        break;
                    }
                }
                if (relOS == null)
                {
                    relOS = new frmRelPost();
                    relOS.MdiParent = this;
                    relOS.Show();
                }

                relOS.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível ser conectar ao formulário devido ao erro: " + ex.Message,
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
                MessageBox.Show("Não foi possível ser conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }

        }

        private void tsbServico_Click(object sender, EventArgs e)
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
                MessageBox.Show("Não foi possível ser conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }

        }

        private void tsbOS_Click(object sender, EventArgs e)
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
                MessageBox.Show("Não foi possível ser conectar ao formulário devido ao erro: " + ex.Message,
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