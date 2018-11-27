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
    public partial class HistoricoCliente : Form
    {
        private PessoaDAO pessoadao = new PessoaDAO();
        List<Pessoa> lista_pessoa;

    
        public HistoricoCliente()
        {
            InitializeComponent();
            dGViewHistCli.Rows.Clear(); 
            
        }


        private void btnCancelar_Click(object sender, EventArgs e)
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

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (!txtCpfHistorico.Text.Equals(""))
            { 
                dGViewHistCli.DataSource = pessoadao.FindByCpf(txtCpfHistorico.Text);
            }
            else
            {
                MessageBox.Show("Digite um CPF válido!");
            }
        }

        private void lvHistCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
