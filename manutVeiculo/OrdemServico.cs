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
    public partial class OrdemServico : Form
    {

        List<Os> lista_os = new List<Os>();

        public OrdemServico()
        {
            InitializeComponent();
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

        private void btnCancel_Click(object sender, EventArgs e)
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

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            dGViewHistVeiculo.Rows.Clear();
            if (string.IsNullOrEmpty(txtOs.Text.Trim()))
            {
                MessageBox.Show("Digite o número de uma OS para consultar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (Os os in lista_os)
            {
                if (os.Id.Equals(txtOs.Text))
                {
                  
                   dGViewHistVeiculo.Rows.Add(os.Peca, os.Km, os.Valor, DateTime.Today.ToString("dd/MM/yyyy"));
                  
                }
            }
        }
    }
}
