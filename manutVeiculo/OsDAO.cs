using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manutVeiculo
{
    class OsDAO
    {
        public void Insert(Os os)
        {
            Database manutVeiculo = Database.GetInstance();
            string qry = "INSERT INTO os (cliente, placa, status, valor, km, data)" +
                $" VALUES ('{os.Pessoa.First().Id}','{os.Placa}','{os.Status}','{os.Valor}','{os.Km}', '{os.Km}')";
            manutVeiculo.ExecuteSQL(qry);
            os.Id = manutVeiculo.LastId;

            foreach (var item in os.Peca)
            {
                qry = $"INSERT INTO os_peca (os_id,peca_id) VALUES ('{os.Id}','{item.Id}')";
                manutVeiculo.ExecuteSQL(qry);
            }
        }

        public Os getById(string id)
        {
            string qry = string.Format("SELECT id, cliente, placa, status, peca, valor, km, data FROM os WHERE id ='{0}'", id);
            return Read(qry).FirstOrDefault();
        }


        private List<Os> Read(string qry)
        {
            Os os = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            if (conexao.State != System.Data.ConnectionState.Open)
            {
                conexao.Open();
            }

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            SQLiteDataReader dr = comm.ExecuteReader();

            List<Os> oss = new List<Os>();

            while (dr.Read())
            {
                os = new Os();
                os.Id = int.Parse(dr["id"].ToString());
                os.Placa = dr["placa"].ToString();
                os.Status = bool.Parse(dr["status"].ToString());
                //os.Peca = dr["peca"].ToString(); ;
                os.Valor = dr["valor"].ToString();
                os.Km = int.Parse(dr["km"].ToString());
                oss.Add(os);
            }

            qry = "select os_id,peca_id from os_peca where os_id=" + os.Id;
            comm = new SQLiteCommand(qry, conexao);
            dr = comm.ExecuteReader();
            List<string> pecasId = new List<string>();
            while (dr.Read())
            {
                pecasId.Add(dr["peca_id"].ToString());
            }

            foreach (var item in pecasId)
            {
                qry = "select * from peca where id=" + item;
                comm = new SQLiteCommand(qry, conexao);
                dr = comm.ExecuteReader();

                var peca = new Peca();


                os.Peca.Add(peca);
            }
            

            dr.Close();
            conexao.Close();
            return oss;
        }


        public void Update(Os os)
        {
            Database manutVeiculo = Database.GetInstance();

            string qry = string.Format("UPDATE os SET id='{0}',placa='{1}',status='{2}',peca='{3}',valor='{4}',km='{5}'" + "WHERE id='{0}'", os.Id, os.Placa, os.Status, os.Peca, os.Valor, os.Km);

            manutVeiculo.ExecuteSQL(qry);
        }

        public void Delete(int id)
        {
            //Database manutVeic = Database.GetInstance();
            //string qry = string.Format("DELETE FROM Pessoa WHERE id = '" + id + "'");
            //manutVeic.ExecuteSQL(qry);
        }

        public List<Os> ListAll()
        {
            string qry = string.Format("SELECT id,placa,status,peca,valor,km FROM os;");
            return Read(qry);

        }

        public List<Os> FindById(string id)
        {
            string qry;

            if (id != "")
                qry = string.Format("SELECT id,placa,status,peca,valor,km FROM os WHERE id LIKE '%{0}%'", id);
            else
                qry = string.Format("SELECT id,placa,status,peca,valor,km FROM os");

            return Read(qry);
        }
    }
}
