using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manutVeiculo
{
    class ConsultOs
    {
        private int numeroOs;
        private int Cliente;
        private String placa;
        private bool status;
        List<Pessoa> pessoa;
        List<Veiculo> veiculo;

        public ConsultOs(int numeroOs, int cliente, string placa, bool status, List<Pessoa> pessoa, List<Veiculo> veiculo)
        {
            this.numeroOs = numeroOs;
            Cliente = cliente;
            this.placa = placa;
            this.status = status;
            this.pessoa = pessoa;
            this.veiculo = veiculo;
        }

        public int NumeroOs { get => numeroOs; set => numeroOs = value; }
        public int Cliente1 { get => Cliente; set => Cliente = value; }
        public string Placa { get => placa; set => placa = value; }
        public bool Status { get => status; set => status = value; }
        public List<Pessoa> Pessoa { get => pessoa; set => pessoa = value; }
        public List<Veiculo> Veiculo { get => veiculo; set => veiculo = value; }
    }
}

