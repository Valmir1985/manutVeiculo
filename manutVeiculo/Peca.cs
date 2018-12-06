using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manutVeiculo
{
   public class Peca
    {
        private int id;
        private String marca;
        private String pecaServico;
        private String modelo;
        private int kmTroca;
        private float preco;
        private int ano;

        public Peca()
        {
        }

        public Peca(int id, string marca, string pecaServico, string modelo,int kmTroca, float preco, int ano)
        {
            this.Id = id;
            this.Marca = marca;
            this.PecaServico = pecaServico;
            this.Modelo = modelo;
            this.KmTroca = kmTroca;
            this.preco = preco;
            this.ano = ano;
        }

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string PecaServico { get => pecaServico; set => pecaServico = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int KmTroca { get => kmTroca; set => kmTroca = value; }
        public float Preco { get => preco; set => preco = value; }
        public int Ano { get => ano; set => ano = value; }
    }
}
