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
    public partial class frmTag : Form
    {
        public frmTag()
        {
            InitializeComponent();

        }
        SqlConnection cn = new SqlConnection(Desafio.Properties.Settings.Default.ServicoConnectionString);
        SqlCommand cmd = null;
        private void salvarToolStripButton_Click(object sender, EventArgs e)

        {
            try
            {
                //Desabilita o botão excluir para quem tiver nivel de acesso Operador
                if (frmLogin.NivelAcesso == "")
                {
                    //bindingNavigatorDeleteItem.Enabled = false;
                }
                //Se os campos estiver preenchido faça
                if (nomeTagTextBox.Text != "")
                {


                    //Mostrar a Data do Cadastro na Hora
                    if (dataCadastroTagTextBox.Text == "")
                    {
                        dataCadastroTagTextBox.Text = DateTime.Now.ToString();
                    }
                    //Mostrar quem Cadastrou o usuario
                    if (usuarioCadastroTagTextBox.Text == "")
                    {
                        usuarioCadastroTagTextBox.Text = frmLogin.usuarioConectado;
                    }


                    //Executar a aplicação
                    this.Validate();
                    this.tbTagBindingSource.EndEdit();
                    //this.tbTagTableAdapter.Update(this.servicoDataSet.tbTag);
                    MessageBox.Show("Cadastro realizado com sucesso",
                               "Sucesso",
                                   MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
                }

                else
                {
                    //Ser os campos não estiverem preenchido
                    MessageBox.Show("O Campo nome não pode ficar vazio");
                }
            }
            catch (Exception ex)
            {
                //Caso haja uma exceção será tratada neste código
                MessageBox.Show("Não foi possível salvar pelo seguinte motivo: " + ex.Message);
            }


        }

        private void frmTag_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'servicoDataSet.tbTag' table. You can move, or remove it, as needed.
            this.tbTagTableAdapter.Fill(this.servicoDataSet.tbTag);


        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmFiltrarTag.Text == "Código")
                {
                    //Define a instrução Sql
                    string sql = "SELECT * FROM tbTag WHERE Id =" + txtPesquisar.Text + "";

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
                    DataTable tag = new DataTable();

                    /* Adiciona ou atualiza linhas em um DataTable para que correspondam na fonte de 
                     * dados usando o DataTable.*/
                    da.Fill(tag);

                    /*A TagDataGridView recebe o DataTable usuario*/
                    tagDataGridView.DataSource = tag;




                }
                if (cbmFiltrarTag.Text == "Nome")
                {
                    //define a instrução SQL
                    string sql = "SELECT * FROM tbTag WHERE nome LIKE '%" + txtPesquisar.Text + "%'";
                    cmd = new SqlCommand(sql, cn);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable tag = new DataTable();
                    da.Fill(tag);
                    tagDataGridView.DataSource = tag;

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
            idTagTextBox.Clear();
            nomeTagTextBox.Clear();
            dataCadastroTagTextBox.Clear();
            usuarioCadastroTagTextBox.Clear();
        }

        private void tbTagDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LimparCampo();
            idTagTextBox.Text = tagDataGridView.CurrentRow.Cells[0].Value.ToString();
            nomeTagTextBox.Text = tagDataGridView.CurrentRow.Cells[1].Value.ToString();
            dataCadastroTagTextBox.Text = tagDataGridView.CurrentRow.Cells[2].Value.ToString();
            usuarioCadastroTagTextBox.Text = tagDataGridView.CurrentRow.Cells[3].Value.ToString();

        }
        private void tbTagBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }


    }
}
