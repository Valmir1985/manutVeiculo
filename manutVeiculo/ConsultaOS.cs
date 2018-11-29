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
        List<ConsultOs> lista_os = new List<ConsultOs>;
     

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
            foreach (ConsultOs os in lista_os)
            {
                if (os.NumeroOs.Equals(txtOS.Text) || os.Placa.StartsWith(txtOS.Text)
                {
                    foreach (var pessoa in os.Pessoa)
                    {
                        dGViewConsultaOS.Rows.Add(os.NumeroOs, pessoa.Nome, os.Placa, os.Status);
                    }
                        
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
    }
}
