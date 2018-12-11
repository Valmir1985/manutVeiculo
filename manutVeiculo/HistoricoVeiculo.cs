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
    public partial class HistoricoVeiculo : Form
    {
        List<Veiculo> lista_veiculo = new List<Veiculo>();
        Peca peca = new Peca();

        public HistoricoVeiculo()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            lista_veiculo = new VeiculoDAO().ListAll();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

            dGViewHistVeiculo.Rows.Clear();
            if (string.IsNullOrEmpty(txtPlacaHistorico.Text.Trim()))
            {
                MessageBox.Show("Digite uma Placa para consultar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (Veiculo v in lista_veiculo)
            {
                if (v.Placa == txtPlacaHistorico.Text)
                {
                    if (v.Pessoa.Count > 0)
                    {
                        foreach (var pessoa in v.Pessoa)
                        {
                            dGViewHistVeiculo.Rows.Add(pessoa.Nome, v.Modelo, v.Placa, v.KmRodado);
                        }
                    }

                }
            }
        }

        private void HistoricoVeiculo_Load(object sender, EventArgs e)
        {

        }
        private void gbHistVeiculo_Enter(object sender, EventArgs e)
        {

        }
    }
}
