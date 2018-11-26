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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form6 = new CadastrarPecas();
            form6.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            var form2 = new CadastrarCliente();
            form2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form3 = new OrdemServico();
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form4 = new HistoricoCliente();
            form4.ShowDialog();
        }

        private void btnConsultaTroca_Click(object sender, EventArgs e)
        {
            var consultaTroca = new ConsultaTrocas();
            consultaTroca.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form9 = new HistoricoVeiculo();
            form9.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cadastrarVeiculo = new CadastrarVeiculo();
            cadastrarVeiculo.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var consultaOS = new ConsultarOS();
            consultaOS.ShowDialog();
        }
    }
    
}
