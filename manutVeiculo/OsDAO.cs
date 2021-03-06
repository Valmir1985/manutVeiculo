﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manutVeiculo
{
    class OsDAO
    {
        //Pessoa pessoa = new Pessoa();
        public void Insert(Os os)
        {
            Database manutVeiculo = Database.GetInstance();
            Pessoa pessoa = os.Pessoa.First();
            string qry = "";
            // É necessário fazer a inclusão de um novo veiculo antes de criar a OS
            foreach (var veiculo in pessoa.Veiculo)
            {
                if (veiculo.Id == 0)
                {
                    qry = "INSERT INTO veiculo ( marca, modelo, combustivel, placa, kmRodado, ano, idCliente)" +
                            $" VALUES ('{veiculo.Marca}','{veiculo.Modelo}','{veiculo.Combustivel}','{veiculo.Placa}','{veiculo.KmRodado}',{veiculo.Ano},{veiculo.Pessoa.First().Id})";


                    manutVeiculo.ExecuteSQL(qry);
                    veiculo.Id = manutVeiculo.LastId;
                }
                else
                {
                    qry = string.Format("UPDATE veiculo SET marca='{1}',modelo='{2}',combustivel='{3}',placa='{4}',kmRodado='{5}',ano='{6}'" + " WHERE id='{0}'", veiculo.Id, veiculo.Marca, veiculo.Modelo, veiculo.Combustivel, veiculo.Placa, veiculo.KmRodado, veiculo.Ano);

                    manutVeiculo.ExecuteSQL(qry);
                }
            }

            qry = "INSERT INTO os (cliente, placa, valor, km, data)" +
                $" VALUES ('{pessoa.Id}','{os.Placa}','{os.Valor}','{os.Km}', '{os.Km}')";
            manutVeiculo.ExecuteSQL(qry);
            os.Id = manutVeiculo.LastId;

            foreach (var item in os.Peca)
            {
                qry = $"INSERT INTO osPeca (idOs, idPeca) VALUES ('{os.Id}','{item.Id}')";
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
            //Montando uma lista de peças para ser consultado posteriormente.
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
                peca.Ano =int.Parse( dr["ano"].ToString());
                peca.Id =int.Parse( dr["id"].ToString());
                peca.KmTroca = int.Parse (dr["kmTroca"].ToString()); 
                peca.Marca = dr["marca"].ToString();
                peca.Modelo = dr["modelo"].ToString();
                peca.PecaServico = dr["pecaServico"].ToString();
                peca.Preco = float.Parse(dr["preco"].ToString());                

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

        public void Fechar(Os id)
        {
            Database manutVeiculo = Database.GetInstance();

            string qry = string.Format("UPDATE os SET status='true'" + " WHERE id='{0}'", id);

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
