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
    public partial class CadastrarPecas : Form
    {
        private PecaDAO pecadao = new PecaDAO();
        List<Peca> lista_peca;
       // private Peca pc;
        private bool adicionado = false;

        public bool adicionou()
        {
            return adicionado;
        }
        public CadastrarPecas()
        {
            InitializeComponent();
            txtMarca.Text = "";
            txtPeca.Text = "";
            txtModelo.Text = "";
            txtKmTroca.Text = "";
            lista_peca = pecadao.ListAll();
            btnCadastrar.Visible = true;
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
            if (txtMarca.Equals("") || txtPeca.Text.Equals("") || txtModelo.Equals("") || txtKmTroca.Equals(""))
            {
                MessageBox.Show("É necessário preencher todos os dados!");
            }
            else
            {
                adicionado = true;
                txtMarca.Text = "";
                txtPeca.Text = "";
                txtModelo.Text = "";
                txtKmTroca.Text = "";
                Close();
            }
        }
    }
}
