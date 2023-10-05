using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using Microsoft.Data.SqlClient;

//Classe responsavel pela Conexão com o SQL Server


namespace Desafio
{
    public partial class frmLogin : Form
    {
        //Responsavel pelo Nivel de Acesso
        public static string NivelAcesso;

        //Responsavel por mostrar quem esta conectado no sistema
        public static string usuarioConectado;
        //String de Conexão
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.ServicoConnectionString);

        public frmLogin()
        {
            InitializeComponent();
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'servicoDataSet.tbUsuario' table. You can move, or remove it, as needed.
            this.tbUsuarioTableAdapter.Fill(this.servicoDataSet.tbUsuario);
            // TODO: This line of code loads data into the 'servicoDataSet.tbUsuario' table. You can move, or remove it, as needed.
            this.tbUsuarioTableAdapter.Fill(this.servicoDataSet.tbUsuario);

            //Limpar a ComboBox
            usuarioComboBox.SelectedIndex = -1;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificar ser os campos estão preenchidos
                if ((usuarioComboBox.Text != "") && (nivelAcessoComboBox.Text != "") && (senhaTextBox.Text != ""))
                {
                    //Responsavel pelo Comando Sql

             
                    SqlCommand comm = new SqlCommand("Select * From tbUsuario Where usuario = @usuario and " +
                        "senha = @senha and nivelAcesso=@nivel", conn);

                    //Parametizar os codigos
                    comm.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuarioComboBox.Text;
                    comm.Parameters.Add("@senha", SqlDbType.VarChar).Value = senhaTextBox.Text;
                    comm.Parameters.Add("@nivel", SqlDbType.VarChar).Value = nivelAcessoComboBox.Text;

                    //Abre a conexão
                    conn.Open();

                    SqlDataReader reader = null;
                    //lê as linhas de uma base de dados SQL Server
                    reader = comm.ExecuteReader();

                    //Se tiver coisa pra lê faça:
                    if (reader.Read())
                    {
                        //Variaveil usuarioConectado recebe campo usuarioComboBox.Text
                        usuarioConectado = usuarioComboBox.Text;

                        //Variavei nivelAcesso recebe o campo nivelAcessoComboBox.Text
                        NivelAcesso = nivelAcessoComboBox.Text;

                        //Declara a variavel que recebe o formulario frmTelaPrinciapal
                        frmTelaPrincipal p = new frmTelaPrincipal();
                        //Esconde o formulario Tela de Login
                        this.Hide();
                        //Mostrar o formulario frmTelaPrinciapl
                        p.Show();

                    }
                    else
                    {
                        MessageBox.Show("Usuário e/ou senha incorretas",
                        "Aviso de Segurança",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Todos os Campos são obrigatórios",
                   "Aviso de Segurança",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                //Gerar a exceção
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Finalizar tarefa
                conn.Close();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void senhaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConectar_Click(sender, e);
            }
        }

        private void usuarioComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void nivelAcessoLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}