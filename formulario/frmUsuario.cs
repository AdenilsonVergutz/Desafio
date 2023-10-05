using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Desafio.formulario
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(Desafio.Properties.Settings.Default.ServicoConnectionString);
        SqlCommand cmd = null;
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'servicoDataSet.tbUsuario' table. You can move, or remove it, as needed.
            this.tbUsuarioTableAdapter.Fill(this.servicoDataSet.tbUsuario);

        }

        private void tbUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Se os campos estiver preenchido faça
                if ((usuarioTextBox.Text != "") && (nivelAcessoComboBox.Text != "") && (senhaTextBox.Text != "") && (repitaSenhaTextBox.Text != "") && (emailTextBox.Text != "") && (bioTextBox.Text != "") && (slugTextBox.Text != ""))
                {
                    //Se as senhas forem igual faça
                    if (senhaTextBox.Text == repitaSenhaTextBox.Text)
                    {
                        //Mostrar a Data do Cadastro na Hora
                        if (dataDiaTextBox.Text == "")
                        {
                            dataDiaTextBox.Text = DateTime.Now.ToString();
                        }
                        //Mostrar quem Cadastrou o usuario
                        if (cadastradorPorTextBox.Text == "")
                        {
                            cadastradorPorTextBox.Text = frmLogin.usuarioConectado;
                        }
                        //Executar a aplicação
                        this.Validate();
                        this.tbUsuarioBindingSource.EndEdit();
                        this.tbUsuarioTableAdapter.Update(this.servicoDataSet.tbUsuario);
                    }
                    else
                    {
                        //Caso as senhas são diferentes
                        MessageBox.Show("As senhas estão diferentes");
                    }
                }
                else
                {
                    //Ser os campos não estiverem preenchido
                    MessageBox.Show("Todos os campos não podem ficar vazio");
                }
            }
            catch (Exception ex)
            {
                //Caso haja uma exceção será tratada neste código
                MessageBox.Show("Não foi possível salvar pelo seguinte motivo: " + ex.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmFiltrar.Text == "Código")
                {
                    //Define a instrução Sql
                    string sql = "SELECT * FROM tbUsuario WHERE idUsuario =" + txtPesquisar.Text + "";

                    //Lê os dados da variavel sql e conectar no cn
                    cmd = new SqlCommand(sql, cn);
                    //Abre conexão
                    cn.Open();



                    //Define o valor da CommandType para cmd
                    cmd.CommandType = CommandType.Text;

                    /*Representa um conjunto de comandos de dados e uma conexão de banco de dados 
                    que são usados para preencher o DataSet e atualizar um banco de dados SQL Server.*/
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    //Representa uma tabela de dados na memória.
                    DataTable usuario = new DataTable();

                    /* Adiciona ou atualiza linhas em um DataTable para que correspondam na fonte de 
                     * dados usando o DataTable.*/
                    da.Fill(usuario);

                    /*A tbUsuarioDataGridView recebe o DataTable usuario*/
                    tbUsuarioDataGridView.DataSource = usuario;

                    //Fechar a conexão


                }
                if (cbmFiltrar.Text == "Usuário")
                {
                    //define a instrução SQL
                    string sql = "SELECT * FROM tbUsuario WHERE usuario LIKE '%" + txtPesquisar.Text + "%'";
                    cmd = new SqlCommand(sql, cn);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable usuario = new DataTable();
                    da.Fill(usuario);
                    tbUsuarioDataGridView.DataSource = usuario;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void LimparCampo()
        {
            idUsuarioTextBox.Clear();
            usuarioTextBox.Clear();
            senhaTextBox.Clear();
            repitaSenhaTextBox.Clear();
            nivelAcessoComboBox.Text = "";
            dataDiaTextBox.Text = "";
            cadastradorPorTextBox.Clear();
            emailTextBox.Text = "";
            slugTextBox.Text = "";
            bioTextBox.Text = "";
        }
        private void tbUsuarioDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                LimparCampo();
                idUsuarioTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[0].Value.ToString();
                usuarioTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[1].Value.ToString();
                senhaTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[2].Value.ToString();
                repitaSenhaTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[3].Value.ToString();
                nivelAcessoComboBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[4].Value.ToString();
                dataDiaTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[5].Value.ToString();
                cadastradorPorTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[6].Value.ToString();
                emailTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[1].Value.ToString();
                bioTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[1].Value.ToString();
                slugTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[1].Value.ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível Carregar os dados pelo motivo: " + ex.Message);
            }
        }

        private void tbUsuarioBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}