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
        private Pessoa p;
        private string sexo;
        private bool adicionado = false;
        private bool existe = false;

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
        }

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

                    //foreach (Pessoa p in lista_pessoa)
                    //    if (txtCpf.Text.Equals(p.cpf))
                    //{
                    //        existe = true;
                    //}

                    if (existe)
                    {
                        MessageBox.Show("CPF já existe no cadastro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (rbtnMasc.Checked) sexo = "masculino";
                        if (rbtnFem.Checked) sexo = "feminino";
                        p = new Pessoa(0, txtCpf.Text, txtNome.Text, sexo, txtRua.Text, txtBairro.Text, int.Parse(txtNro.Text), txtCep.Text, txtCidade.Text, txtUf.Text, null);
                        //Não tem telefone na pessoa
                        // Agora foi deu pau  por falta de coluna combustivel
                        // txtTelefone.Text,

                        try
                        {
                            pessoadao.Insert(p);
                            lista_pessoa = pessoadao.ListAll();
                            adicionado = true;
                            txtNome.Text = "";
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
    }
}
