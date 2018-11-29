using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manutVeiculo
{
    class Peca
    {
        private int id;
        private String marca;
        private String pecaServico;
        private String modelo;
        private String kmTroca;
        private float preco;

        public Peca()
        {
        }

        public Peca(int id, string marca, string pecaServico, string modelo,string kmTroca, float preco)
        {
            this.Id = id;
            this.Marca = marca;
            this.PecaServico = pecaServico;
            this.Modelo = modelo;
            this.KmTroca = kmTroca;
            this.preco = preco;
        }

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string PecaServico { get => pecaServico; set => pecaServico = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string KmTroca { get => kmTroca; set => kmTroca = value; }
        public float Preco { get => preco; set => preco = value; }
    }
}
