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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(Desafio.Properties.Settings.Default.ServicoConnectionString);
        SqlCommand cmd = null;

        private void tbServicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Desabilita o bot�o excluir para quem tiver nivel de acesso Operador
                if (frmLogin.NivelAcesso == "")
                {
                    bindingNavigatorDeleteItem.Enabled = false;
                }
                //Se os campos estiver preenchido fa�a
                if (nomeTextBox.Text != "")
                {

                    //Mostrar a Data do Cadastro na Hora
                    if (dataDiaTextBox.Text == "")
                    {
                        dataDiaTextBox.Text = DateTime.Now.ToString();
                    }
                    //Mostrar quem Cadastrou o usuario
                    if (cadastradoPorTextBox.Text == "")
                    {
                        cadastradoPorTextBox.Text = frmLogin.usuarioConectado;
                    }
                    //Executar a aplica��o
                    this.Validate();
                    this.tbCategoriaBindingSource.EndEdit();
                    this.tbCategoriaTableAdapter.Update(this.servicoDataSet.tbCategoria);
                    MessageBox.Show("Cadastro realizado com sucesso",
                               "Sucesso",
                                   MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
                }

                else
                {
                    //Ser os campos n�o estiverem preenchido
                    MessageBox.Show("O Campo nome n�o pode ficar vazio");
                }
            }
            catch (Exception ex)
            {
                //Caso haja uma exce��o ser� tratada neste c�digo
                MessageBox.Show("N�o foi poss�vel salvar pelo seguinte motivo: " + ex.Message);
            }


        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'servicoDataSet.tbCategoria' table. You can move, or remove it, as needed.
            this.tbCategoriaTableAdapter.Fill(this.servicoDataSet.tbCategoria);


        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmFiltrar.Text == "C�digo")
                {
                    //Define a instru��o Sql
                    string sql = "SELECT * FROM tbCategoria WHERE Id =" + txtPesquisar.Text + "";

                    //L� os dados da variavel sql e conectar no cn
                    cmd = new SqlCommand(sql, cn);
                    //Abre conex�o
                    cn.Open();

                    //Define o valor da CommandType para cmd
                    cmd.CommandType = CommandType.Text;

                    /*Representa um conjunto de comandos de dados e uma conex�o de banco de dados 
                    que s�o usados para preencher o DataSet e atualizar um banco de dados SQL Server.*/
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    //Representa uma tabela de dados na mem�ria.
                    DataTable servico = new DataTable();

                    /* Adiciona ou atualiza linhas em um DataTable para que correspondam na fonte de 
                     * dados usando o DataTable.*/
                    da.Fill(servico);

                    /*A tbUsuarioDataGridView recebe o DataTable usuario*/
                    tbCategoriaDataGridView.DataSource = servico;




                }
                if (cbmFiltrar.Text == "Nome")
                {
                    //define a instru��o SQL
                    string sql = "SELECT * FROM tbCategoria WHERE nome LIKE '%" + txtPesquisar.Text + "%'";
                    cmd = new SqlCommand(sql, cn);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable servico = new DataTable();
                    da.Fill(servico);
                    tbCategoriaDataGridView.DataSource = servico;

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
            idCategoriaTextBox.Clear();
            nomeTextBox.Clear();
            descricaoTextBox.Clear();
            valorTextBox.Clear();
            dataDiaTextBox.Clear();
            cadastradoPorTextBox.Clear();
        }

        private void tbServicoDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LimparCampo();
            idCategoriaTextBox.Text = tbCategoriaDataGridView.CurrentRow.Cells[0].Value.ToString();
            nomeTextBox.Text = tbCategoriaDataGridView.CurrentRow.Cells[1].Value.ToString();
            descricaoTextBox.Text = tbCategoriaDataGridView.CurrentRow.Cells[2].Value.ToString();
            observacaoTextBox.Text = tbCategoriaDataGridView.CurrentRow.Cells[3].Value.ToString();
            valorTextBox.Text = tbCategoriaDataGridView.CurrentRow.Cells[4].Value.ToString();
            dataDiaTextBox.Text = tbCategoriaDataGridView.CurrentRow.Cells[5].Value.ToString();
            cadastradoPorTextBox.Text = tbCategoriaDataGridView.CurrentRow.Cells[6].Value.ToString();

        }
    }
}