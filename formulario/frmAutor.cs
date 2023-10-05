using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Desafio
{
    public partial class frmAutor : Form
    {
        public frmAutor()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.ServicoConnectionString);
        SqlCommand cmd = null;


        private void tbAutorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if ((nomeTextBox.Text != "") && (cpfMaskedTextBox.Text != ""))
                {

                    this.Validate();
                    this.tbAutorBindingSource.EndEdit();
                    this.tbAutorTableAdapter.Update(this.servicoDataSet.tbAutor);
                    MessageBox.Show("Cadastro realizado com sucesso",
                            "Sucesso",
                                MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    //Insere a Data
                    if (dataDiaTextBox.Text == "")
                    {
                        dataDiaTextBox.Text = DateTime.Now.ToString();
                    }
                    //Mostrar o usuário que cadastrou 
                    if (cadastradoPorTextBox.Text == "")
                    {
                        cadastradoPorTextBox.Text = frmLogin.usuarioConectado;
                    }


                }
                else
                {
                    MessageBox.Show("O Campo 'Nome' e 'CPF não podem ficar vazio",
                            "Aviso",
                                MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível salvar pelo seguinte motivo: " + ex.Message);
            }
        }

        private void frmAutor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'servicoDataSet.tbPost' table. You can move, or remove it, as needed.
            this.tbPostTableAdapter.Fill(this.servicoDataSet.tbPost);
            // TODO: This line of code loads data into the 'servicoDataSet.tbPost' table. You can move, or remove it, as needed.
            this.tbPostTableAdapter.Fill(this.servicoDataSet.tbPost);
            // TODO: This line of code loads data into the 'servicoDataSet.tbAutor' table. You can move, or remove it, as needed.
            this.tbAutorTableAdapter.Fill(this.servicoDataSet.tbAutor);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmFiltrar.Text == "Código Autor")
                {
                    //Define a instrução Sql
                    string sql = "SELECT * FROM tbAutor WHERE Id =" + txtPesquisar.Text + "";

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
                    DataTable autor = new DataTable();

                    /* Adiciona ou atualiza linhas em um DataTable para que correspondam na fonte de 
                     * dados usando o DataTable.*/
                    da.Fill(autor);

                    /*A tbUsuarioDataGridView recebe o DataTable usuario*/
                    tbAutorDataGridView.DataSource = autor;

                    //Fechar a conexão


                }
                if (cbmFiltrar.Text == "Nome")
                {
                    //define a instrução SQL
                    string sql = "SELECT * FROM tbAutor WHERE nome LIKE '%" + txtPesquisar.Text + "%'";
                    cmd = new SqlCommand(sql, cn);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable autor = new DataTable();
                    da.Fill(autor);
                    tbAutorDataGridView.DataSource = autor;

                }
                if (cbmFiltrar.Text == "CPF")
                {
                    //define a instrução SQL
                    string sql = "SELECT * FROM tbAutor WHERE cpf ='" + txtPesquisar.Text + "'";
                    cmd = new SqlCommand(sql, cn);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable autor = new DataTable();
                    da.Fill(autor);
                    tbAutorDataGridView.DataSource = autor;

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

        private void cbmFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmFiltrar.Text == "Código")
            {
                txtPesquisar.Mask = "";


            }
            if (cbmFiltrar.Text == "Nome")
            {
                txtPesquisar.Mask = "";
            }
            if (cbmFiltrar.Text == "CPF")
            {
                txtPesquisar.Mask = "000,000,000-00";
            }
            if (cbmFiltrar.Text == "")
            {
                txtPesquisar.Mask = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //define a instrução SQL
                string sql = "SELECT * FROM tbPost WHERE Id ='" + idAutorTextBox.Text + "'";
                cmd = new SqlCommand(sql, cn);
                cn.Open();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable os = new DataTable();
                da.Fill(os);
                tbPostDataGridView.DataSource = os;
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
            idAutorTextBox.Clear();
            nomeTextBox.Clear();
            cpfMaskedTextBox.Clear();
            telefoneMaskedTextBox.Clear();
            enderecoTextBox.Clear();
            bairroTextBox.Clear();
            cidadeTextBox.Clear();
            estadoComboBox.SelectedIndex = -1;
            dataDiaTextBox.Clear();
            cadastradoPorTextBox.Clear();
        }
        private void tbAutorDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LimparCampo();
            idAutorTextBox.Text = tbAutorDataGridView.CurrentRow.Cells[0].Value.ToString();
            nomeTextBox.Text = tbAutorDataGridView.CurrentRow.Cells[1].Value.ToString();
            cpfMaskedTextBox.Text = tbAutorDataGridView.CurrentRow.Cells[2].Value.ToString();
            telefoneMaskedTextBox.Text = tbAutorDataGridView.CurrentRow.Cells[3].Value.ToString();
            enderecoTextBox.Text = tbAutorDataGridView.CurrentRow.Cells[4].Value.ToString();
            bairroTextBox.Text = tbAutorDataGridView.CurrentRow.Cells[5].Value.ToString();
            cidadeTextBox.Text = tbAutorDataGridView.CurrentRow.Cells[6].Value.ToString();
            estadoComboBox.Text = tbAutorDataGridView.CurrentRow.Cells[7].Value.ToString();
            dataDiaTextBox.Text = tbAutorDataGridView.CurrentRow.Cells[8].Value.ToString();
            cadastradoPorTextBox.Text = tbAutorDataGridView.CurrentRow.Cells[9].Value.ToString();

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void tbPostDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}