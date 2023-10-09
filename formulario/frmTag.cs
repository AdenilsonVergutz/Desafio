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
            SqlConnection cn = new SqlConnection(Desafio.Properties.Settings.Default.ServicoConnectionString);
            SqlCommand cmd = null;

        }
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
            //this.tbTagTableAdapter.Fill(this.servicoDataSet.tbTag);


        }

        private void LimparCampo()
        {
            idTagTextBox.Clear();
            nomeTagTextBox.Clear();
        }

        private void tbTagDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LimparCampo();
            idTagTextBox.Text = tagDataGridView.CurrentRow.Cells[0].Value.ToString();
            nomeTagTextBox.Text = tagDataGridView.CurrentRow.Cells[1].Value.ToString();

        }

        private void filtrarPorTagLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
