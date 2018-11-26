using manutVeiculo;
using System;
using System.Data.Entity;
using System.Data.SQLite;

public class PessoaDAO
{
	public PessoaDAO()
	{
        public void Insert(Pessoa p)
        {
            Database manutVeic = Database.GetInstance();
            string qry = string.Format ("INSERT INTO pessoa (id, cpf, nome, sexo, rua, bairro, numero, cep, cidade, uf) VALUE ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", p.Id, p.Nome, p.Cpf, p.Sexo.ToString(), p.Rua, p.Bairro, p.Numero, p.Cep, p.Cidade, p.Uf);
            DBHospital.ExecuteSQL(qry);
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
                p = new Pessoa("", "", "", "", "", "", "", "", "", "");
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
            Database manutVeic = Database.GetInstance();

            string qry = string.Format("UPDATE Pessoa SET id='{0}',cpf='{2}',nome='{3}',sexo='{4}',rua='{5}',bairro='{6}',numero='{7}',cep='{8}',cidade='{9}',uf='{10}'" + "WHERE id='{1}'", p.Nome, p.Cpf, p.Nasc.ToString("yyyy-MM-dd"), p.Sexo, p.Tel, p.Logradouro, p.Num, p.Complemento, p.Cep, p.Cidade, p.Uf, p.Pais, p.Profissao);

            manutVeic.ExecuteSQL(qry);
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
                int id = dr.GetString(0);
                string nome = dr.GetString(1);
                string cpf = dr.GetString(2);
                string sexo = dr.GetString(3);
                string rua = dr.GetString(4);
                string bairro = dr.GetString(5);
                string numero = dr.GetString(6);
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

        public List<Pessoa> FindByName(string nom)
        {
            List<Pessoa> lista_pessoa = new List<Pessoa>();
            Pessoa p = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry;

            if (nom != "")
                qry = string.Format("SELECT id,cpf,nome,sexo,rua,bairro,numero,cep,cidade,uf FROM Pessoa WHERE nome LIKE '%{0}%'", nom);
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
                int id = dr.GetString(0);
                string nome = dr.GetString(1);
                string cpf = dr.GetString(2);
                string sexo = dr.GetString(3);
                string rua = dr.GetString(4);
                string bairro = dr.GetString(5);
                int numero = dr.GetString(6);
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
