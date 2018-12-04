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

        public ConsultaCliente(){ }
            

        public ConsultaCliente(Os os)
        {
            InitializeComponent();
            txtCpf.Text = "";
            txtNome.Text = "";
            txtRua.Text = "";
            txtNro.Text = "";
            txtBairro.Text = "";
            txtCep.Text = "";
            txtCidade.Text = "";
            txtUf.Text = "";
            lista_pessoa = pessoaDao.ListAll();
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
                osdao.Insert(ordem);
                lista_os = osdao.ListAll(); 
                // preciso vincular esse cliente a OS..como fazer?
                // quando entra nessa tela, ele traz o numero da OS e apos confirmar os dados do cliente, tem q juntas esses dois objetos
            }catch(Exception ex)
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

            foreach (Pessoa p in lista_pessoa)
            {
                if (p.Cpf.StartsWith(txtCpf.Text))
                {
                    gpbInfoPessoal.Enabled = true;
                    gpbEndereco.Enabled = true;

                    txtNome.Text = p.Nome;
                    txtRua.Text = p.Rua;
                    txtNro.Text = p.Numero.ToString();
                    txtBairro.Text = p.Bairro;
                    txtCep.Text = p.Cep;
                    txtCidade.Text = p.Cidade;
                    txtUf.Text = p.Uf;
                }
                else
                {
                   DialogResult confirm =  MessageBox.Show("CPF não encontrado! Deseja cadastrar novo cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                   if (confirm.ToString().ToUpper() == "YES")
                    {
                        var cadastrocliente = new CadastrarCliente();
                        cadastrocliente.ShowDialog();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
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
