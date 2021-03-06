﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manutVeiculo
{
    public class Pessoa
    {
        private int id;
        private String cpf;
        private String nome;
        private String sexo;
        private String rua;
        private String bairro;
        private int numero;
        private String cep;
        private String cidade;
        private String uf;
        List<Veiculo> veiculo;


        public Pessoa()
        {
            this.veiculo = new List<Veiculo>();
        }

        public Pessoa(int id, string cpf, string nome, string sexo, string rua,
            string bairro, int numero, string cep, string cidade, string uf,
            List<Veiculo> veiculo) : this()
        {
            this.id = id;
            this.cpf = cpf;
            this.nome = nome;
            this.sexo = sexo;
            this.rua = rua;
            this.bairro = bairro;
            this.numero = numero;
            this.cep = cep;
            this.cidade = cidade;
            this.uf = uf;
            if (veiculo != null)
                this.veiculo = veiculo;


        }

        public int Id { get => id; set => id = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public List<Veiculo> Veiculo { get => veiculo; set => veiculo = value; }
    }
}




