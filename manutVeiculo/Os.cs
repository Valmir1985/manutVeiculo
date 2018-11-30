using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manutVeiculo
{
    class Os
    {
        private int id;
        private String placa;
        private bool status;
        private String peca;
        private String valor;
        private int km;
        private DateTime data;
        List<Pessoa> pessoa;

        public Os()
        {
            this.pessoa = new List<Pessoa>();
        }

        public Os(int id, string placa, bool status, string peca, string valor, int km, List<Pessoa> pessoa)
            :this(id,placa,status,peca,valor,km,DateTime.Now, pessoa) 
        {

        }

        public Os(int id, string placa, bool status, string peca, string valor,
            int km, DateTime data,List<Pessoa> pessoa) : this()
        {
            this.id = id;
            this.placa = placa;
            this.status = status;
            this.peca = peca;
            this.valor = valor;
            this.km = km;
            this.data = data;
            this.pessoa = pessoa;
        }

        public int Id { get => id; set => id = value; }
        public string Placa { get => placa; set => placa = value; }
        public bool Status { get => status; set => status = value; }
        public string Peca { get => peca; set => peca = value; }
        public string Valor { get => valor; set => valor = value; }
        public int Km { get => km; set => km = value; }
        public DateTime Data { get => data; set => data = value; }
        public List<Pessoa> Pessoa { get => pessoa; set => pessoa = value; }
    }
}
