using manutVeiculo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Data;

namespace manutVeiculo
{
    public class PessoaDAO
    {
        public PessoaDAO()
        {
        }
        public void Insert(Pessoa p)
        {
            Database manutVeiculo = Database.GetInstance();
            string qry = string.Format("INSERT INTO pessoa (id, cpf, nome, sexo, rua, bairro, numero, cep, cidade, uf) VALUE ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", p.Id, p.Nome, p.Cpf, p.Sexo.ToString(), p.Rua, p.Bairro, p.Numero, p.Cep, p.Cidade, p.Uf);
            manutVeiculo.ExecuteSQL(qry);
        }

        public Pessoa Read(string id)
        {
            Pessoa p = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry = string.Format("SELECT id, cpf, nome, sexo, rua, bairro, numero, cep, cidade, uf FROM Pessoa WHERE id ='{0}'", id);

            if (conexao.State != System.Data.ConnectionState.Open)
            {
                conexao.Open();
            }

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            SQLiteDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                p = new Pessoa();
                p.Id = dr.GetInt16(0);
                p.Cpf = dr.GetString(1);
                p.Nome = dr.GetString(2);
                p.Sexo = dr.GetString(3);
                p.Rua = dr.GetString(4);
                p.Bairro = dr.GetString(5);
                p.Numero = dr.GetInt16(6);
                p.Cep = dr.GetString(7);
                p.Cidade = dr.GetString(8);
                p.Uf = dr.GetString(9);
            }
            dr.Close();
            conexao.Close();
            return p;

        }

        public void Update(Pessoa p)
        {
            Database manutVeiculo = Database.GetInstance();

            string qry = string.Format("UPDATE Pessoa SET id='{0}',cpf='{1}',nome='{2}',sexo='{3}',rua='{4}',bairro='{5}',numero='{6}',cep='{7}',cidade='{8}',uf='{9}'" + "WHERE id='{0}'", p.Id, p.Cpf, p.Nome, p.Sexo, p.Rua, p.Bairro, p.Numero, p.Cep);

            manutVeiculo.ExecuteSQL(qry);
        }

        public void Delete(int id)
        {
            Database manutVeic = Database.GetInstance();
            string qry = string.Format("DELETE FROM Pessoa WHERE id = '" + id + "'");
            manutVeic.ExecuteSQL(qry);
        }

        public List<Pessoa> ListAll()
        {
            List<Pessoa> lista_pessoa = new List<Pessoa>();
            Pessoa p = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry = string.Format("SELECT id,cpf,nome,sexo,rua,bairro,numero,cep,cidade,uf FROM Pessoa;");

            if (conexao.State != System.Data.ConnectionState.Open)
            {
                conexao.Open();
            }

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                int id = dr.GetInt16(0);
                string nome = dr.GetString(1);
                string cpf = dr.GetString(2);
                string sexo = dr.GetString(3);
                string rua = dr.GetString(4);
                string bairro = dr.GetString(5);
                int numero = dr.GetInt16(6);
                string cep = dr.GetString(7);
                string cidade = dr.GetString(8);
                string uf = dr.GetString(9);

                p = new Pessoa(id, cpf, nome, sexo, rua, bairro, numero, cep, cidade, uf);
                lista_pessoa.Add(p);
            }
            dr.Close();
            conexao.Close();

            return lista_pessoa;
        }

        public List<Pessoa> FindByName(string cpf)
        {
            List<Pessoa> lista_pessoa = new List<Pessoa>();
            Pessoa p = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry;

            if (cpf != "")
                qry = string.Format("SELECT id,cpf,nome,sexo,rua,bairro,numero,cep,cidade,uf FROM Pessoa WHERE cpf LIKE '%{0}%'", cpf);
            else
                qry = string.Format("SELECT id,cpf,nome,sexo,rua,bairro,numero,cep,cidade,uf FROM Pessoa");

            if (conexao.State != System.Data.ConnectionState.Open)
            {
                conexao.Open();
            }

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                int id = dr.GetInt16(0);
                string nome = dr.GetString(1);
                cpf = dr.GetString(2);
                string sexo = dr.GetString(3);
                string rua = dr.GetString(4);
                string bairro = dr.GetString(5);
                int numero = dr.GetInt16(6);
                string cep = dr.GetString(7);
                string cidade = dr.GetString(8);
                string uf = dr.GetString(9);

                p = new Pessoa(id, cpf, nome, sexo, rua, bairro, numero, cep, cidade, uf);
                lista_pessoa.Add(p);
            }
            dr.Close();
            conexao.Close();

            return lista_pessoa;
        }
    }
}
