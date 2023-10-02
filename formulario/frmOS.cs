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
    public partial class frmOS : Form
    {
        public frmOS()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(Desafio.Properties.Settings.Default.ServicoConnectionString);
        SqlCommand cmd = null;
        private void tbOrdemServicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if ((idClienteComboBox.Text != "") && (idServicoComboBox.Text != ""))
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
                this.tbOrdemServicoBindingSource.EndEdit();
                this.tbOrdemServicoTableAdapter.Update(this.servicoDataSet.tbOrdemServico);
                MessageBox.Show("OS realizado com sucesso",
                               "Sucesso",
                                   MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Todos os campos são obrigatorio");
            }
        }

        private void frmOS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'servicoDataSet.tbServico' table. You can move, or remove it, as needed.
            this.tbServicoTableAdapter.Fill(this.servicoDataSet.tbServico);
            // TODO: This line of code loads data into the 'servicoDataSet.tbCliente' table. You can move, or remove it, as needed.
            this.tbClienteTableAdapter.Fill(this.servicoDataSet.tbCliente);
            // TODO: This line of code loads data into the 'servicoDataSet.tbOrdemServico' table. You can move, or remove it, as needed.
            this.tbOrdemServicoTableAdapter.Fill(this.servicoDataSet.tbOrdemServico);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmFiltrar.Text == "Código OS")
                {
                    //Define a instrução Sql
                    string sql = "SELECT * FROM tbOrdemServico WHERE idOrdem =" + txtPesquisar.Text + "";

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
                    tbOrdemServicoDataGridView.DataSource = os;

                    //Fechar a conexão


                }
                if (cbmFiltrar.Text == "Código Cliente")
                {
                    //define a instrução SQL
                    string sql = "SELECT * FROM tbOrdemServico WHERE idCliente =" + txtPesquisar.Text + "";
                    cmd = new SqlCommand(sql, cn);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable os = new DataTable();
                    da.Fill(os);
                    tbOrdemServicoDataGridView.DataSource = os;

                }
                if (cbmFiltrar.Text == "Código Serviço")
                {
                    //define a instrução SQL
                    string sql = "SELECT * FROM tbOrdemServico WHERE idServico=" + txtPesquisar.Text + "";
                    cmd = new SqlCommand(sql, cn);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable os = new DataTable();
                    da.Fill(os);
                    tbOrdemServicoDataGridView.DataSource = os;

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
            idOrdemTextBox.Clear();
            idClienteComboBox.SelectedIndex = -1;
            idServicoComboBox.SelectedIndex = -1;
            dataDiaTextBox.Clear();
            cadastradorPorTextBox.Clear();
        }
        private void tbOrdemServicoDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LimparCampo();
            idOrdemTextBox.Text = tbOrdemServicoDataGridView.CurrentRow.Cells[0].Value.ToString();
            idClienteComboBox.Text = tbOrdemServicoDataGridView.CurrentRow.Cells[1].Value.ToString();
            idServicoComboBox.Text = tbOrdemServicoDataGridView.CurrentRow.Cells[2].Value.ToString();
            dataDiaTextBox.Text = tbOrdemServicoDataGridView.CurrentRow.Cells[3].Value.ToString();
            cadastradorPorTextBox.Text = tbOrdemServicoDataGridView.CurrentRow.Cells[4].Value.ToString();
        }
    }
}