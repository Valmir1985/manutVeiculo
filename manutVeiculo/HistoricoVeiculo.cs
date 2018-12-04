﻿using System;
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
    public partial class HistoricoVeiculo : Form
    {
        Veiculo v = new Veiculo();
        Pessoa p = new Pessoa();
        List<Veiculo> lista_veiculo = new List<Veiculo>();

        public HistoricoVeiculo()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

            dGViewHistVeiculo.Rows.Clear();
            if (string.IsNullOrEmpty(txtPlacaHistorico.Text.Trim()))
            {
                MessageBox.Show("Digite uma Placa para consultar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            else if (txtPlacaHistorico.Text.Equals("4455"))
            {
                dGViewHistVeiculo.Rows.Add(v.Placa, v.KmRodado, v.Placa, v.Placa);
                MessageBox.Show("funcionaaaaa");
            }



            //dGViewHistVeiculo.Rows.Clear();
            //if (string.IsNullOrEmpty(txtPlacaHistorico.Text.Trim()))
            //{
            //    MessageBox.Show("Digite uma Placa para consultar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //foreach (Veiculo v in lista_veiculo)
            //{
            //    if (v.Placa == txtPlacaHistorico.Text)
            //    {
            //        dGViewHistVeiculo.Rows.Add(v.Placa, v.KmRodado, " ", v.Pessoa);
            //    }
            //}

            //dGViewHistVeiculo.Rows.Clear();
            //if (string.IsNullOrEmpty(txtPlacaHistorico.Text.Trim()))
            //{
            //    MessageBox.Show("Digite uma placa para consultar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //foreach (Veiculo v in lista_veiculo)
            //{
            //    MessageBox.Show("Entrou no for", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    if (v.Placa.StartsWith(txtPlacaHistorico.Text))
            //    {
            //        MessageBox.Show("Entrou no if", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        dGViewHistVeiculo.Rows.Add(v.Marca, v.KmRodado, DateTime.Today.ToString("dd/MM/yyyy"), v.Modelo);
            //        if (v.Pessoa.Count > 0)
            //        {
            //            foreach (var pessoa in v.Pessoa)
            //            {
            //                dGViewHistVeiculo.Rows.Add(v.Marca, v.KmRodado, DateTime.Today.ToString("dd/MM/yyyy"), pessoa.Nome);
            //            }
            //        }
            //        else
            //        {
            //            dGViewHistVeiculo.Rows.Add("", "", "", DateTime.Today.ToString("dd/MM/yyyy"), "");
            //        }
            //    }

            //}


            //dGViewHistVeiculo.Rows.Clear();
            //if (string.IsNullOrEmpty(txtPlacaHistorico.Text.Trim()))
            //{
            //    MessageBox.Show("Digite uma Placa para consultar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //foreach (Veiculo v in lista_veiculo)
            //{
            //    if (v.Placa == txtPlacaHistorico.Text)
            //    {
            //        dGViewHistVeiculo.Rows.Add(v.Placa, v.KmRodado, " ", v.Pessoa);
            //    }
            //}


        }
        private void gbHistVeiculo_Enter(object sender, EventArgs e)
        {

        }
    }
}
