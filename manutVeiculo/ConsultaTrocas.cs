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
    public partial class ConsultaTrocas : Form
    {
        List<Veiculo> lista_veiculo = new List<Veiculo>();
        List<Peca> lista_peca = new List<Peca>();

        public ConsultaTrocas()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void button4_Click(object sender, EventArgs e)
        {
            var consultacliente = new ConsultaCliente();
            consultacliente.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dGViewConsultaTrocas.Rows.Clear();
            foreach (Peca p in lista_peca)
            {
                MessageBox.Show("for peca");
                if (p.Marca.Equals(cmbMarca.Text) && p.Modelo.Equals(cmbModelo.Text) && p.KmTroca.Equals(txtKmAtual.Text))       //cmbMarca.Text.Equals("Chevrolet") && cmbModelo.Text.Equals("Corsa") && cmbAno.Text.Equals("2004") && txtKmAtual.Text.Equals("12000"))
                {
                    MessageBox.Show("if");
                    dGViewConsultaTrocas.Rows.Add(p.PecaServico, p.KmTroca, p.Preco);

                }
                else{
                    MessageBox.Show("Não temos peças para esse veículo");
                }

            }

        }
    }
}
