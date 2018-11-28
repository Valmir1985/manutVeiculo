using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manutVeiculo
{
    public partial class ConsultarOS : Form
    {
        private PessoaDAO pessoadao = new PessoaDAO();
        //List<Pessoa> lista_pessoa;
        //private VeiculoDAO veiculodao = new VeiculoDAO();
       // List<Veiculo> lista_veiculo;

        public ConsultarOS()
        {
            InitializeComponent();
            dGViewConsultaOS.Rows.Clear();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            //string qry = string.Format("SELECT os.id, p.nome, v.placa, os.status FROM ((pessoa INNER JOIN os ON p.id = os.cliente) INNER JOIN   WHERE id ='{0}'", id);

            //if (conexao.State != System.Data.ConnectionState.Open)
            //{
            //    conexao.Open();
            //}

            //SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            //SQLiteDataReader dr = comm.ExecuteReader();

            ////instanciar pessoa, veiculo e pecas p buscar nas respectivas tabelas os dados p preencher o Grid

            //if (!txtOS.Text.Equals(""))
            //{
            //    //dGViewConsultaOS.Rows.Add(os.Id, p.Nome, values.Placa, os.Status);
            //}
            //else
            //{
            //    MessageBox.Show("Digite um CPF válido!");
            //}

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
    }
}
