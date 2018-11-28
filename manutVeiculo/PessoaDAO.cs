using manutVeiculo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Data;
using System.Linq;

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
            string qry = string.Format("INSERT INTO pessoa (id, cpf, nome, sexo, rua, bairro, numero, cep, cidade, uf) VALUE ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}',)", p.Id, p.Nome, p.Cpf, p.Sexo.ToString(), p.Rua, p.Bairro, p.Numero, p.Cep, p.Cidade, p.Uf);
            manutVeiculo.ExecuteSQL(qry);
        }

        public Pessoa getById(string id)
        {
            string qry = string.Format("SELECT id, cpf, nome, sexo, rua, bairro, numero, cep, cidade, uf FROM pessoa WHERE id ='{0}'", id);
            return Read(qry).FirstOrDefault();

        }

        private List<Pessoa> Read(string qry)
        {
            Pessoa p = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            if (conexao.State != System.Data.ConnectionState.Open)
            {
                conexao.Open();
            }

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            SQLiteDataReader dr = comm.ExecuteReader();

            List<Pessoa> pessoa = new List<Pessoa>();

            while (dr.Read())
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
                pessoa.Add(p);
            }

            foreach (Pessoa ps in pessoa)
            {
                qry = string.Format("SELECT * FROM veiculo WHERE idCliente ='{0}'", ps.Id);

                comm = new SQLiteCommand(qry, conexao);
                dr = comm.ExecuteReader();


                while (dr.Read())
                {
                    var v = new Veiculo();
                    v.Id = dr.GetInt16(0);
                    v.Marca = dr.GetString(1);
                    v.Modelo = dr.GetString(2);
                    v.Combustivel = dr.GetString(3);
                    v.Placa = dr.GetString(4);
                    v.KmRodado = dr.GetInt16(5);
                    v.Ano = dr.GetInt16(6);
                    p.Veiculo.Add(v);
                }
            }            

            dr.Close();
            conexao.Close();
            return pessoa;

        }

        public void Update(Pessoa p)
        {
            Database manutVeiculo = Database.GetInstance();

            string qry = string.Format("UPDATE pessoa SET id='{0}',cpf='{1}',nome='{2}',sexo='{3}',rua='{4}',bairro='{5}',numero='{6}',cep='{7}',cidade='{8}',uf='{9}'" + "WHERE id='{0}'", p.Id, p.Cpf, p.Nome, p.Sexo, p.Rua, p.Bairro, p.Numero, p.Cep);

            manutVeiculo.ExecuteSQL(qry);
        }

        public void Delete(int id)
        {
            Database manutVeic = Database.GetInstance();
            string qry = string.Format("DELETE FROM pessoa WHERE id = '" + id + "'");
            manutVeic.ExecuteSQL(qry);
        }

        public List<Pessoa> ListAll()
        {
            string qry = string.Format("SELECT id,cpf,nome,sexo,rua,bairro,numero,cep,cidade,uf FROM pessoa;");
            return Read(qry);
        }

        public List<Pessoa> FindByCpf(string cpf)
        {
            string qry;

            if (cpf != "")
                qry = string.Format("SELECT id,cpf,nome,sexo,rua,bairro,numero,cep,cidade,uf FROM Pessoa WHERE cpf LIKE '%{0}%'", cpf);
            else
                qry = string.Format("SELECT id,cpf,nome,sexo,rua,bairro,numero,cep,cidade,uf FROM Pessoa");

            return Read(qry);
        }
    }
}
