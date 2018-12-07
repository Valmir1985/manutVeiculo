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
        List<Peca> lista_peca_selecionada = new List<Peca>();

        public ConsultaTrocas()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            lista_veiculo = new VeiculoDAO().ListAll();
            lista_peca = new PecaDAO().ListAll();
            cmbAno.Items.Clear();
            cmbMarca.Items.Clear();
            cmbModelo.Items.Clear();
            Dictionary<string, string> dicMarca = new Dictionary<string, string>()
            {
                { "" , "" }
            };
            Dictionary<string, string> dicModelo = new Dictionary<string, string>()
            {
                { "" , "" }
            };

            Dictionary<string, string> dicAno = new Dictionary<string, string>()
            {
                { "" , "" }
            };

            foreach (var item in lista_peca)
            {
                dicMarca[item.Marca] = item.Marca;
                dicModelo[item.Modelo] = item.Modelo;
                dicAno[item.Ano.ToString()] = item.Ano.ToString();
            }

            cmbMarca.DataSource = new BindingSource(dicMarca, null);
            cmbMarca.DisplayMember = "Key";
            cmbMarca.ValueMember = "Value";

            cmbModelo.DataSource = new BindingSource(dicModelo, null);
            cmbModelo.DisplayMember = "Key";
            cmbModelo.ValueMember = "Value";

            cmbAno.DataSource = new BindingSource(dicAno, null);
            cmbAno.DisplayMember = "Key";
            cmbAno.ValueMember = "Value";


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
            var consultacliente = new ConsultaCliente(lista_peca_selecionada);
            consultacliente.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dGViewConsultaTrocas.Rows.Clear();
            lista_peca_selecionada.Clear();
            foreach (Peca p in lista_peca)
            {
                if (p.Marca == cmbMarca.Text && p.Modelo == cmbModelo.Text && p.Ano == int.Parse(cmbAno.Text) && p.KmTroca >= int.Parse(txtKmAtual.Text))
                {
                    dGViewConsultaTrocas.Rows.Add(p.PecaServico, p.KmTroca, p.Preco);
                    lista_peca_selecionada.Add(p);

                }

            }
            if (dGViewConsultaTrocas.Rows.Count == 0)
            {
                MessageBox.Show("Não temos peças para esse veículo");
            }

        }
    }
}
