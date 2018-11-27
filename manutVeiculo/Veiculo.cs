using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manutVeiculo
{
    public class Veiculo
    {
        private int id;
        private String marca;
        private String modelo;
        private String combustivel;
        private String placa;
        private int kmRodado;
        private int ano;
        private Pessoa pessoa;

        public Veiculo()
        {
                
        }

        public Veiculo(int id, string marca, string modelo, string combustivel, string placa, int kmRodado, int ano, Pessoa pessoa)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.combustivel = combustivel;
            this.placa = placa;
            this.kmRodado = kmRodado;
            this.ano = ano;
            this.pessoa = pessoa;

        }

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Combustivel { get => combustivel; set => combustivel = value; }
        public string Placa { get => placa; set => placa = value; }
        public int KmRodado { get => kmRodado; set => kmRodado = value; }
        public int Ano { get => ano; set => ano = value; }
        internal Pessoa Pessoa { get => pessoa; set => pessoa = value; }
    }
}
