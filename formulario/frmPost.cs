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
    public partial class frmPost : Form
    {
        public frmPost()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(Desafio.Properties.Settings.Default.ServicoConnectionString);
        SqlCommand cmd = null;
        private void tbPostBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if ((idAutorComboBox.Text != "") && (idCategoriaComboBox.Text != ""))
            {
                if (dataDiaTextBox.Text == "")
                {
                    dataDiaTextBox.Text = DateTime.Now.ToString();
                }
                if (cadastradorPorTextBox.Text == "")
                {
                    cadastradorPorTextBox.Text = frmLogin.usuarioConectado;
                }
                this.Validate();
                this.tbPostBindingSource.EndEdit();
                this.tbPostTableAdapter.Update(this.servicoDataSet.tbPost);
                MessageBox.Show("Post cadastrado com sucesso",
                               "Sucesso",
                                   MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Todos os campos são obrigatorio");
            }
        }

        private void frmPost_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'servicoDataSet.tbCategoria' table. You can move, or remove it, as needed.
            this.tbCategoriaTableAdapter.Fill(this.servicoDataSet.tbCategoria);
            // TODO: This line of code loads data into the 'servicoDataSet.tbAutor' table. You can move, or remove it, as needed.
            this.tbAutorTableAdapter.Fill(this.servicoDataSet.tbAutor);
            // TODO: This line of code loads data into the 'servicoDataSet.tbPost' table. You can move, or remove it, as needed.
            this.tbPostTableAdapter.Fill(this.servicoDataSet.tbPost);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmFiltrar.Text == "POST")
                {
                    //Define a instrução Sql
                    string sql = "SELECT * FROM tbPost WHERE Id =" + txtPesquisar.Text + "";

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
                    DataTable os = new DataTable();

                    /* Adiciona ou atualiza linhas em um DataTable para que correspondam na fonte de 
                     * dados usando o DataTable.*/
                    da.Fill(os);

                    /*A tbUsuarioDataGridView recebe o DataTable usuario*/
                    tbPostDataGridView.DataSource = os;

                    //Fechar a conexão


                }
                if (cbmFiltrar.Text == "Autor")
                {
                    //define a instrução SQL
                    string sql = "SELECT * FROM tbPost WHERE Id =" + txtPesquisar.Text + "";
                    cmd = new SqlCommand(sql, cn);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable os = new DataTable();
                    da.Fill(os);
                    tbPostDataGridView.DataSource = os;

                }
                if (cbmFiltrar.Text == "Código Categoria")
                {
                    //define a instrução SQL
                    string sql = "SELECT * FROM tbPost WHERE idCategoria =" + txtPesquisar.Text + "";
                    cmd = new SqlCommand(sql, cn);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable os = new DataTable();
                    da.Fill(os);
                    tbPostDataGridView.DataSource = os;

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
            idPostTextBox.Clear();
            idAutorComboBox.SelectedIndex = -1;
            idCategoriaComboBox.SelectedIndex = -1;
            dataDiaTextBox.Clear();
            cadastradorPorTextBox.Clear();
        }
        private void tbPostDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LimparCampo();
            idPostTextBox.Text = tbPostDataGridView.CurrentRow.Cells[0].Value.ToString();
            idAutorComboBox.Text = tbPostDataGridView.CurrentRow.Cells[1].Value.ToString();
            idCategoriaComboBox.Text = tbPostDataGridView.CurrentRow.Cells[2].Value.ToString();
            dataDiaTextBox.Text = tbPostDataGridView.CurrentRow.Cells[3].Value.ToString();
            cadastradorPorTextBox.Text = tbPostDataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void idAutorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void idCategoriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}