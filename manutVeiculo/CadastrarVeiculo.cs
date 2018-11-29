using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manutVeiculo
{
    public partial class CadastrarVeiculo : Form
    {
        private VeiculoDAO veiculodao = new VeiculoDAO();
        List<Veiculo> lista_veiculo;
        List<Pessoa> lista_pessoa;
        private Veiculo v;
        private bool adicionado = false;
        private Pessoa pessoa;

        public bool adicionou()
        {
            return adicionado;
        }
        public CadastrarVeiculo(Pessoa pessoa)
        {
            InitializeComponent();
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtCombustivel.Text = "";
            txtPlaca.Text = "";
            txtKmRodado.Text = "";
            lista_veiculo = veiculodao.ListAll();
            btnCadastrar.Visible = true;
            this.pessoa = pessoa;
            lista_pessoa = new List<Pessoa>();
            lista_pessoa.Add(pessoa);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtMarca.Equals("") || txtModelo.Text.Equals("") || txtCombustivel.Equals("") || txtPlaca.Equals("") || txtKmRodado.Text.Equals("")) 
            {
                MessageBox.Show("É necessário preencher todos os dados!");
            }
            else
            {
                try
                {                        
                    v = new Veiculo(0, txtMarca.Text, txtModelo.Text, txtCombustivel.Text, txtPlaca.Text, int.Parse(txtKmRodado.Text), int.Parse(txtAno.Text), lista_pessoa);
                    veiculodao.Insert(v);
                    lista_veiculo = veiculodao.ListAll();
                    adicionado = true;
                    txtMarca.Text = "";
                    txtModelo.Text = "";
                    txtCombustivel.Text = "";
                    txtPlaca.Text = "";
                    txtKmRodado.Text = "";
                    Close();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

            }

        private void btnCancelarAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair sem salvar?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                //
            }
            else
            {
                this.Close();
            }

        }

        private void CadastrarVeiculo_Load(object sender, EventArgs e)
        {

        }
    }
}
