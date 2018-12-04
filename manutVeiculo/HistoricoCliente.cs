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
        List<Pessoa> lista_pessoa = new List<Pessoa>();

        public HistoricoCliente()
        {
            InitializeComponent();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar essa operação?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                
            }
            else
            {
                this.Close();
            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {

            dGViewHistCli.Rows.Clear();
             if (string.IsNullOrEmpty(txtCpfHistorico.Text.Trim()))
            {
                MessageBox.Show("Digite um cpf para consultar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            foreach (Pessoa p in lista_pessoa)
            {
                if (p.Cpf.StartsWith(txtCpfHistorico.Text))
                {
                    if (p.Veiculo.Count > 0)
                    {
                        foreach (var veiculo in p.Veiculo)
                        {
                            dGViewHistCli.Rows.Add(p.Nome, veiculo.Modelo, veiculo.Placa, veiculo.KmRodado, DateTime.Today.ToString("dd/MM/yyyy"));
                        }
                    }
                    else
                    {
                        dGViewHistCli.Rows.Add(p.Nome, "", "", "", DateTime.Today.ToString("dd/MM/yyyy"));
                    }
                }
            }

        }

        private void lvHistCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HistoricoCliente_Load(object sender, EventArgs e)
        {
            lista_pessoa = new PessoaDAO().ListAll();
        }

        private void gpbHistCliente_Enter(object sender, EventArgs e)
        {

        }
    }
}
