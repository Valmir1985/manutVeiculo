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
        private VeiculoDAO veiculodao = new VeiculoDAO();
        List<Pessoa> lista_pessoa;
        List<Veiculo> lista_veiculo;
        private Pessoa p;
        private string sexo;
        private bool adicionado = false;
        private bool existe = false;//teste teste
        private int hello;

        public bool adicionou()
        {
            return adicionado;
        }
        public CadastrarCliente()
        {
            InitializeComponent();
            //this.Text = "Adicionar Cliente";
            txtCpf.Text = "";
            txtNome.Text = "";
            rbtnMasc.Checked = false;
            rbtnFem.Checked = false;
            txtTelefone.Text = "";
            txtCep.Text = "";
            txtBairro.Text = "";
            txtRua.Text = "";
            txtCidade.Text = "";
            txtUf.Text = "";
            txtNro.Text = "";
            txtCor.Text = "";
            txtPlaca.Text = "";
            txtKmRodado.Text = "";
            txtAno.Text = "";
            txtMarca.Text = "";
            lista_veiculo = veiculodao.ListAll();
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
            }
            else
            {
                if (txtCpf.Equals("") || txtNome.Text.Equals("") || txtTelefone.Equals("") || txtRua.Equals("") || txtBairro.Text.Equals("") || txtNro.Text.Equals("") || txtCep.Text.Equals("") || txtCidade.Text.Equals("") || txtUf.Text.Equals("") || (rbtnMasc.Checked == false && rbtnFem.Checked == false))
                {
                    MessageBox.Show("É necessário preencher todos os dados!");
                }
                else
                {
                    
                    foreach (Pessoa p in lista_pessoa)
                        if (txtCpf.Text.Equals(p.cpf))
                    {
                            existe = true;
                    }
                    
                    if (existe)
                    {
                        MessageBox.Show("CPF já existe no cadastro!");
                    }
                    else
                    {
                        if (rbtnMasc.Checked) sexo = "masculino";
                        if (rbtnFem.Checked) sexo = "feminino";
                        p = new Pessoa(txtCpf.Text, txtNome.Text, sexo, txtTelefone.Text, txtRua.Text, txtBairro.Text, txtNro.Text, txtCep.Text, txtCidade.Text, txtUf.Text);
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
                }
    
}
