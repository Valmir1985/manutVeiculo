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
        List<Peca> lista_peca = new List<Peca>();

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
                if (os.Id.Equals(int.Parse(txtOs.Text)))
                {
                    foreach (var pc in os.Peca)
                    {
                        dGViewHistVeiculo.Rows.Add(pc.PecaServico, os.Km, pc.Preco, DateTime.Today.ToString("dd/MM/yyyy"));
                    }
                }
            }
        }

        private void OrdemServico_Load(object sender, EventArgs e)
        {
            lista_os = new OsDAO().ListAll();
            lista_peca = new PecaDAO().ListAll();
        }

        private void dGViewHistVeiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFinaliza_Click(object sender, EventArgs e)
        {

            while (dGViewHistVeiculo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma OS para finalizar!");
                return;
                
            }
            if (MessageBox.Show("Tem certeza que deseja fechar essa OS?", "Confirmação",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Database manutVeiculo = Database.GetInstance();
                string qry = string.Format("UPDATE os SET status= 'fechado'" + " WHERE id='{0}'", txtOs.Text);
                manutVeiculo.ExecuteSQL(qry);

            }
            this.Close();
        }
    }
}
