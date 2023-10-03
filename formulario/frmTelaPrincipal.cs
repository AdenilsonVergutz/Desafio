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

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCliente cliente = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmCliente)
                    {
                        cliente = (frmCliente)frm;
                        break;
                    }
                }
                if (cliente == null)
                {
                    cliente = new frmCliente();
                    cliente.MdiParent = this;
                    cliente.Show();
                }

                cliente.Focus();
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
                formulario.frmServico servico = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is formulario.frmServico)
                    {
                        servico = (formulario.frmServico)frm;
                        break;
                    }
                }
                if (servico == null)
                {
                    servico = new formulario.frmServico();
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
                frmOS os = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmOS)
                    {
                        os = (frmOS)frm;
                        break;
                    }
                }
                if (os == null)
                {
                    os = new frmOS();
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

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmRelCliente relcliente = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmRelCliente)
                    {
                        relcliente = (frmRelCliente)frm;
                        break;
                    }
                }
                if (relcliente == null)
                {
                    relcliente = new frmRelCliente();
                    relcliente.MdiParent = this;
                    relcliente.Show();
                }

                relcliente.Focus();
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
                frmRelServico relServico = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmRelServico)
                    {
                        relServico = (frmRelServico)frm;
                        break;
                    }
                }
                if (relServico == null)
                {
                    relServico = new frmRelServico();
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
                frmRelOS relOS = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmRelOS)
                    {
                        relOS = (frmRelOS)frm;
                        break;
                    }
                }
                if (relOS == null)
                {
                    relOS = new frmRelOS();
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

        private void tsbCliente_Click(object sender, EventArgs e)
        {
            try
            {
                frmCliente cliente = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmCliente)
                    {
                        cliente = (frmCliente)frm;
                        break;
                    }
                }
                if (cliente == null)
                {
                    cliente = new frmCliente();
                    cliente.MdiParent = this;
                    cliente.Show();
                }

                cliente.Focus();
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
                formulario.frmServico servico = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is formulario.frmServico)
                    {
                        servico = (formulario.frmServico)frm;
                        break;
                    }
                }
                if (servico == null)
                {
                    servico = new formulario.frmServico();
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
                frmOS os = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmOS)
                    {
                        os = (frmOS)frm;
                        break;
                    }
                }
                if (os == null)
                {
                    os = new frmOS();
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