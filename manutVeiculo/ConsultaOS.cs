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
        List<ConsultOs> lista_os = new List<ConsultOs>();
        List<Os> lista_ordem = new List<Os>();

        public ConsultarOS()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dGViewConsultaOS.Rows.Clear();
            if (string.IsNullOrEmpty(txtOS.Text.Trim()))
            {
                MessageBox.Show("Digite o número de uma OS para consultar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (Os os in lista_ordem)
            {

                if (os.Id.Equals(int.Parse(txtOS.Text)))
                {
                   // foreach (var pessoa in os.)
                   // {
                        dGViewConsultaOS.Rows.Add(os.Id, os.Pessoa.Nome, os.Placa, os.Status);
                  //  }

                }
            }
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

        private void ConsultarOS_Load(object sender, EventArgs e)
        {
            lista_ordem = new OsDAO().ListAll();
         
        }
    }
}
