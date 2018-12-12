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
    public partial class CadastrarCliente : Form
    {
        private PessoaDAO pessoadao = new PessoaDAO();
        List<Pessoa> lista_pessoa;
        //List<Veiculo> lista_veiculo;
        private Pessoa p;
        private string sexo;
        private bool adicionado = false;
        private bool existe = false;
        private Veiculo veiculo;
        private Pessoa pessoa;

        public Pessoa Pessoa { get; internal set; }

        public bool adicionou()
        {
            return adicionado;
        }
        public CadastrarCliente()
        {
            InitializeComponent();
            txtCpf.Text = "";
            txtNome.Text = "";
            rbtnMasc.Checked = false;
            rbtnFem.Checked = false;
            txtTelefone.Text = "";
            txtRua.Text = "";
            txtBairro.Text = "";
            txtNro.Text = "";
            txtCep.Text = "";
            txtCidade.Text = "";
            txtUf.Text = "";
            lista_pessoa = pessoadao.ListAll();
            btnCadastrar.Visible = true;
            //this.veiculo = veiculo;
            //lista_veiculo = new List<Veiculo>();
            //lista_veiculo.Add(veiculo);
        }

        //public CadastrarCliente()
        //{

        //}

        public bool validaCpf(string cpf)
        {
            int[] mt1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mt2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string TempCPF;
            string Digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(",", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            TempCPF = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(TempCPF[i].ToString()) * mt1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            Digito = resto.ToString();
            TempCPF = TempCPF + Digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(TempCPF[i].ToString()) * mt2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            Digito = Digito + resto.ToString();

            return cpf.EndsWith(Digito);
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


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!validaCpf(txtCpf.Text))
            {
                MessageBox.Show("CPF inválido!");
                return;
            }
            else
            {
                if (txtCpf.Equals("") || txtNome.Text.Equals("") || txtTelefone.Equals("") || txtRua.Equals("") || txtBairro.Text.Equals("") || txtNro.Text.Equals("") || txtCep.Text.Equals("") || txtCidade.Text.Equals("") || txtUf.Text.Equals("") || (rbtnMasc.Checked == false && rbtnFem.Checked == false))
                {
                    MessageBox.Show("É necessário preencher todos os dados!");
                    return;
                }
                else
                {


                    if (existe)
                    {
                        MessageBox.Show("CPF já existe no cadastro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (rbtnMasc.Checked) sexo = "masculino";
                        if (rbtnFem.Checked) sexo = "feminino";

                        p = new Pessoa(0, txtCpf.Text, txtNome.Text, int.Parse(txtTelefone.Text), sexo, txtRua.Text, txtBairro.Text, int.Parse(txtNro.Text), txtCep.Text, txtCidade.Text, txtUf.Text, null /*lista_veiculo*/);
                        
                        try
                        {
                            pessoadao.Insert(p);
                            lista_pessoa = pessoadao.ListAll();
                            adicionado = true;
                            txtNome.Text = "";
                            txtTelefone.Text = "";
                            txtCpf.Text = "";
                            rbtnMasc.Checked = false;
                            rbtnFem.Checked = false;
                            txtTelefone.Text = "";
                            txtRua.Text = "";
                            txtBairro.Text = "";
                            txtNro.Text = "";
                            txtCep.Text = "";
                            txtCidade.Text = "";
                            txtUf.Text = "";

                            Pessoa = p;

                            Close();
                            existe = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                }
            }
            var cadastraVeiculo = new CadastrarVeiculo(p);
            cadastraVeiculo.ShowDialog();

        }

        public void AtualizaCliente(Pessoa p)
        {
            pessoa = p;
            if (p != null)
            {
                rbtnFem.Checked = p.Sexo == "feminino";
                rbtnMasc.Checked = p.Sexo == "masculino";
                txtNome.Text = p.Nome;
                txtTelefone.Text = p.Telefone.ToString();
                txtRua.Text = p.Rua;
                txtNro.Text = p.Numero.ToString();
                txtBairro.Text = p.Bairro;
                txtCep.Text = p.Cep;
                txtCidade.Text = p.Cidade;
                txtUf.Text = p.Uf;
            }
            pessoadao.Update(p);

        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
