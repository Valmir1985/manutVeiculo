using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace manutVeiculo
{
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente()
        {
            InitializeComponent();
        }

        private void btnCancelCli_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar essa operação?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                //
            }
            else
            {
                this.Close();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultarCli_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //CadastrarCliente cadastrarCliente = new CadastrarCliente(grid_pacientes.CurrentRow.Cells[2].Value.ToString());
            //cadastrarCliente.ShowDialog();
            //if (cadastrarCliente.adicionou())
            //{
            //    grid_pacientes.DataSource = pessoaDAO.ListAll();
            //    MessageBox.Show("Cadastro Alterado com sucesso!");
            //}
        }
    }
}
