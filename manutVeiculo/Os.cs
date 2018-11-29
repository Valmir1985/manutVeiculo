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
        private String cliente;
        private String placa;
        private bool status;
        private String peca;
        private String valor;
        private int km;
        private DateTime data;

        public Os(int id, string cliente, string placa, bool status, string peca, string valor, int km)
            :this(id,cliente,placa,status,peca,valor,km,DateTime.Now)
        {

        }

        public Os(int id, string cliente, string placa, bool status, string peca, string valor, int km, DateTime data)
        {
            this.id = id;
            this.cliente = cliente;
            this.placa = placa;
            this.status = status;
            this.peca = peca;
            this.valor = valor;
            this.km = km;
            this.data = data;
        }

        public int Id { get => id; set => id = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Placa { get => placa; set => placa = value; }
        public bool Status { get => status; set => status = value; }
        public string Peca { get => peca; set => peca = value; }
        public string Valor { get => valor; set => valor = value; }
        public int Km { get => km; set => km = value; }
        public DateTime Data { get => data; set => data = value; }
    }
}
