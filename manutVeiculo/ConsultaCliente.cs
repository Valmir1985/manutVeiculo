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
    public partial class ConsultaCliente : Form
    {
        List<Pessoa> lista_pessoa = new List<Pessoa>();
        PessoaDAO pessoaDao = new PessoaDAO();
        OsDAO osdao = new OsDAO();
        List<Os> lista_os = new List<Os>();
        Os oss = new Os();
        private List<Peca> pecas;

        private ConsultaCliente()
        {
            InitializeComponent();
            lista_pessoa = pessoaDao.ListAll();
        }

        public ConsultaCliente(List<Peca> pecas) : this()
        {
            this.pecas = pecas;
        }


        public ConsultaCliente(Os os) : this()
        {

            txtCpf.Text = "";
            txtNome.Text = "";
            txtRua.Text = "";
            txtNro.Text = "";
            txtBairro.Text = "";
            txtCep.Text = "";
            txtCidade.Text = "";
            txtUf.Text = "";

            this.oss = os;
            lista_os = new List<Os>();
            lista_os.Add(os);

        }

        private void btnCancelCli_Click(object sender, EventArgs e)
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var ordem = new Os();
                //ordem.Peca = pecas;
                //ordem.Km = ;
                //ordem.Status = true;
                //ordem.Placa -  

               // osdao.Insert(ordem);
                lista_os = osdao.ListAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultarCli_Click(object sender, EventArgs e)
        {
            gpbInfoPessoal.Enabled = false;
            gpbEndereco.Enabled = false;

            if (string.IsNullOrEmpty(txtCpf.Text.Trim()))
            {
                MessageBox.Show("Digite um cpf!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool encontrou = false;
            foreach (Pessoa p in lista_pessoa)
            {
                if (p.Cpf.StartsWith(txtCpf.Text))
                {
                    CarregarForm(p);
                    encontrou = true;
                    break;
                }

            }
            if (!encontrou)
            {
                DialogResult confirm = MessageBox.Show("CPF não encontrado! Deseja cadastrar novo cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (confirm.ToString().ToUpper() == "YES")
                {
                    var cadastrocliente = new CadastrarCliente();
                    cadastrocliente.ShowDialog();

                    var p = cadastrocliente.Pessoa;

                    CarregarForm(p);
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void CarregarForm(Pessoa p)
        {
            gpbInfoPessoal.Enabled =
                gpbEndereco.Enabled =
                btnAtualizar.Enabled =
                btnConfirm.Enabled = true;

            rbtnFem.Checked = p.Sexo == "feminino";
            rbtnMasc.Checked = p.Sexo == "masculino";
            txtNome.Text = p.Nome;
            txtRua.Text = p.Rua;
            txtNro.Text = p.Numero.ToString();
            txtBairro.Text = p.Bairro;
            txtCep.Text = p.Cep;
            txtCidade.Text = p.Cidade;
            txtUf.Text = p.Uf;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //CadastrarCliente cadastrarCliente = new CadastrarCliente(grid_pacientes.CurrentRow.Cells[2].Value.ToString());
            //cadastrarCliente.ShowDialog();
            //if (cadastrarCliente.adicionou())
            //{
            //    grid_pacientes.DataSource = pessoaDAO.ListAll();
            //    MessageBox.Show("Cadastro Alterado com sucesso!");
            //}
        }
    }
}
