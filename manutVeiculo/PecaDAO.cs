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
        public PecaDAO()
        {
        }
        public void Insert(Peca pc)
        {
            Database manutVeiculo = Database.GetInstance();
            string qry = string.Format("INSERT INTO peca (id, peca, marca, modelo, kmTroca) VALUE ('{0}','{1}','{2}','{3}','{4}')", pc.Id, pc.PecaServico, pc.Marca, pc.Modelo, pc.KmTroca);
            manutVeiculo.ExecuteSQL(qry);
        }

        public Peca Read(string peca)
        {
            Peca pc = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry = string.Format("SELECT id, peca, marca, modelo, kmTroca FROM Peca WHERE peca ='{1}'", peca);

            if (conexao.State != System.Data.ConnectionState.Open)
            {
                conexao.Open();
            }

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            SQLiteDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                pc = new Peca(-1, "", "", "", -1);
                pc.Id = dr.GetInt16(0);
                pc.PecaServico = dr.GetString(1);
                pc.Marca = dr.GetString(2);
                pc.Modelo = dr.GetString(3);
                pc.KmTroca = dr.GetInt16(4);
            }
            dr.Close();
            conexao.Close();
            return pc;

        }

        public void Update(Peca pc)
        {
            Database manutVeiculo = Database.GetInstance();

            string qry = string.Format("UPDATE Peca SET id='{0}',peca='{2}',marca='{3}',modelo='{4}',kmTroca='{5}'" + "WHERE id='{1}'", pc.PecaServico, pc.Marca, pc.Modelo, pc.KmTroca);

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
            List<Peca> lista_peca = new List<Peca>();
            Peca pc = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry = string.Format("SELECT id,pecaServico,marca, modelo,kmTroca FROM Peca;");

            if (conexao.State != System.Data.ConnectionState.Open)
            {
                conexao.Open();
            }

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                int id = dr.GetInt16(0);
                string peca = dr.GetString(1);
                string marca = dr.GetString(2);
                string modelo = dr.GetString(3);
                int kmTroca = dr.GetInt16(4);


                pc = new Peca(id, peca, marca, modelo, kmTroca);
                lista_peca.Add(pc);
            }
            dr.Close();
            conexao.Close();

            return lista_peca;
        }

        public List<Peca> FindByName(string nom)
        {
            List<Peca> lista_peca = new List<Peca>();
            Peca pc = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry;

            if (nom != "")
                qry = string.Format("SELECT id,peca,marca,modelo,kmTroca FROM Peca WHERE peca LIKE '%{0}%'", nom);
            else
                qry = string.Format("SELECT id,peca,marca,modelo,kmTroca FROM Peca");

            if (conexao.State != System.Data.ConnectionState.Open)
            {
                conexao.Open();
            }

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                int id = dr.GetInt16(0);
                string peca = dr.GetString(1);
                string marca = dr.GetString(2);
                string modelo = dr.GetString(3);
                int kmTroca = dr.GetInt16(4);

                pc = new Peca(id, peca, marca, modelo, kmTroca);
                lista_peca.Add(pc);
            }
            dr.Close();
            conexao.Close();

            return lista_peca;
        }
    }
}
