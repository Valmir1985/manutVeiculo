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
    class PecaDAO
    {
        public void Insert(Peca pc)
        {
            Database manutVeiculo = Database.GetInstance();
            string qry = "INSERT INTO peca (marca , pecaServico, ano, modelo, kmTroca, preco)" +
                $" VALUES ('{pc.Marca}','{pc.PecaServico}','{pc.Ano}','{pc.Modelo}','{pc.KmTroca}','{pc.Preco}')";
            manutVeiculo.ExecuteSQL(qry);
        }

        public Peca getById(string id)
        {
            string qry = string.Format("SELECT id, marca, pecaServico, ano, modelo, kmTroca,preco FROM peca WHERE id ='{0}'", id);
            return Read(qry).FirstOrDefault();
        }


        private List<Peca> Read(string qry)
        {
            Peca pc = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            if (conexao.State != System.Data.ConnectionState.Open)
            {
                conexao.Open();
            }

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            SQLiteDataReader dr = comm.ExecuteReader();

            List<Peca> peca = new List<Peca>();

            while (dr.Read())
            {
                pc = new Peca();
                pc.Id = int.Parse(dr["id"].ToString());
                pc.Marca = dr["marca"].ToString();
                pc.PecaServico = dr["pecaServico"].ToString();
                pc.Ano = int.Parse(dr["ano"].ToString());
                pc.Modelo = dr["modelo"].ToString(); ;
                pc.KmTroca = int.Parse(dr["kmTroca"].ToString());
                pc.Preco = float.Parse(dr["preco"].ToString());
                peca.Add(pc);
            }
            dr.Close();
            conexao.Close();
            return peca;
        }


        public void Update(Peca pc)
        {
            Database manutVeiculo = Database.GetInstance();

            string qry = string.Format("UPDATE peca SET id='{0}',marca='{1}',pecaServico='{2}',ano ='{3}',modelo='{4}',kmTroca='{5}',preco='{6}'" + "WHERE id='{0}'", pc.Id, pc.Marca, pc.PecaServico,pc.Ano, pc.Modelo, pc.KmTroca, pc.Preco);

            manutVeiculo.ExecuteSQL(qry);
        }

        public void Delete(int id)
        {
            //Database manutVeic = Database.GetInstance();
            //string qry = string.Format("DELETE FROM Pessoa WHERE id = '" + id + "'");
            //manutVeic.ExecuteSQL(qry);
        }

        public List<Peca> ListAll()
        {
            string qry = string.Format("SELECT id,marca,pecaServico,ano,modelo,kmTroca,preco FROM peca;");
            return Read(qry);

        }

        public List<Peca> FindByName(string nom)
        {
            string qry;

            if (nom != "")
                qry = string.Format("SELECT id,marca,pecaServico,ano,modelo,kmTroca,preco FROM peca WHERE pecaServico LIKE '%{0}%'", nom);
            else
                qry = string.Format("SELECT id,marca,pecaServico,ano,modelo,kmTroca,preco FROM peca");

            return Read(qry);
        }

    }
}
