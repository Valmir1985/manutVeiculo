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
        private int kmTroca;

        public Peca(int id, string marca, string pecaServico, string modelo, int kmTroca)
        {
            this.Id = id;
            this.Marca = marca;
            this.PecaServico = pecaServico;
            this.Modelo = modelo;
            this.KmTroca = kmTroca;
        }

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string PecaServico { get => pecaServico; set => pecaServico = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int KmTroca { get => kmTroca; set => kmTroca = value; }
    }
}
