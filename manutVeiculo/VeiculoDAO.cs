using manutVeiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SQLite;
using System.Data;

namespace manutVeiculo
{
    public class VeiculoDAO
    {
        public VeiculoDAO()
        {
        }
        public void Insert(Veiculo v)
        {
            Database manutVeiculo = Database.GetInstance();
            string qry = "INSERT INTO veiculo ( marca, modelo, combustivel, placa, kmRodado, ano, idCliente )" +
               $" VALUES ('{v.Marca}','{v.Modelo}','{v.Combustivel}','{v.Placa}','{v.KmRodado}',{v.Ano},{v.Pessoa.First().Id})";
            manutVeiculo.ExecuteSQL(qry);
        }


        public Veiculo getById(string id)
        {
            string qry = string.Format("SELECT id, marca, modelo, combustivel, placa, kmRodado, ano FROM veiculo WHERE id ='{0}'", id);
            return Read(qry).FirstOrDefault();

        }

        private List<Veiculo> Read(string qry)
        {
            Veiculo v = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            if (conexao.State != System.Data.ConnectionState.Open)
            {
                conexao.Open();
            }

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            SQLiteDataReader dr = comm.ExecuteReader();

            List<Veiculo> veiculo = new List<Veiculo>();

            while (dr.Read())
            {
                v = new Veiculo();
                v.Id = dr.GetInt16(0);
                v.Marca = dr.GetString(1);
                v.Modelo = dr.GetString(2);
                v.Combustivel = dr.GetString(3);
                v.Placa = dr.GetString(4);
                v.KmRodado = dr.GetInt16(5);
                v.Ano = dr.GetInt16(6);
                veiculo.Add(v);
            }

            foreach (Veiculo vc in veiculo)
            {
                qry = string.Format("SELECT * FROM pessoa WHERE id ='{0}'", vc.Pessoa);

                comm = new SQLiteCommand(qry, conexao);
                dr = comm.ExecuteReader();

                while (dr.Read())
                {
                    var p = new Pessoa();
                    p.Id = int.Parse(dr["id"].ToString());
                    p.Cpf = dr["cpf"].ToString();
                    p.Nome = dr["nome"].ToString();
                    p.Sexo = dr["sexo"].ToString();
                    p.Rua = dr["rua"].ToString();
                    p.Bairro = dr["bairro"].ToString();
                    p.Numero = int.Parse(dr["numero"].ToString());
                    p.Cep = dr["cep"].ToString();
                    p.Cidade = dr["cidade"].ToString();
                    p.Uf = dr["uf"].ToString();
                    v.Pessoa.Add(p);
                }
            }
            dr.Close();
            conexao.Close();
            return veiculo;
        }

        /* public void Update(Veiculo v)
         {
             Database manutVeiculo = Database.GetInstance();

             string qry = string.Format("UPDATE Veiculo SET id='{0}',marca='{2}',modelo='{3}',combustivel='{4}',placa='{5}',kmRodado='{6}',ano='{7}'" + "WHERE id='{1}'", v.Marca, v.Modelo, v.Combustivel, v.Placa, v.KmRodado, v.Ano);

             manutVeiculo.ExecuteSQL(qry);
         }*/

        public void Delete(int id)
        {
            Database manutVeiculo = Database.GetInstance();
            string qry = string.Format("DELETE FROM Veiculo WHERE id = '" + id + "'");
            manutVeiculo.ExecuteSQL(qry);
        }

        public List<Veiculo> ListAll()
        {
            string qry = string.Format("SELECT id,marca,modelo,combustivel,placa,kmRodado,ano FROM veiculo;");
            return Read(qry);
        }

        public List<Veiculo> FindByPlaca(string placa)
        {
            string qry;

            if (placa != "")
                qry = string.Format("SELECT id, marca,modelo,combustivel,placa,kmRodado,ano FROM veiculo WHERE placa LIKE '%{0}%'", placa);
            else
                qry = string.Format("SELECT id, marca,modelo,combustivel,placa,kmRodado,ano FROM veiculo");

            return Read(qry);
        }
    }
}
