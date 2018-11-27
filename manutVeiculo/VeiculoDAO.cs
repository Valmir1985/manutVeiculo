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
    class VeiculoDAO
    {
        public void Insert(Veiculo v)
        {
            Database manutVeiculo = Database.GetInstance();
            string qry = string.Format("INSERT INTO veiculoCliente (id, marca, modelo, combustivel, placa, kmRodado, ano) VALUE ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", v.Id, v.Marca, v.Modelo, v.Combustivel, v.Placa, v.KmRodado, v.Ano);
            manutVeiculo.ExecuteSQL(qry);
        }

        public Veiculo Read(string id)
        {
            Veiculo v = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry = string.Format("SELECT id, marca, modelo, combustivel, placa, kmRodado, ano FROM veiculoCliente WHERE id ='{0}'", id);

            if (conexao.State != System.Data.ConnectionState.Open)
            {
                conexao.Open();
            }

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            SQLiteDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                v = new Veiculo();
                v.Id = dr.GetInt16(0);
                v.Marca = dr.GetString(1);
                v.Modelo = dr.GetString(2);
                v.Combustivel = dr.GetString(3);
                v.Placa = dr.GetString(4);
                v.KmRodado = dr.GetInt16(5);
                v.Ano = dr.GetInt16(6);
            }
            dr.Close();
            conexao.Close();
            return v;
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
            List<Veiculo> lista_veiculo = new List<Veiculo>();
            Veiculo v = null;
            SQLiteConnection conexao = Database.GetInstance().GetConnection();

            string qry = string.Format("SELECT id,marca,modelo,combustive,placa,kmRodado,ano FROM Veiculo;");

            if (conexao.State != System.Data.ConnectionState.Open)
            {
                conexao.Open();
            }

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                int id = dr.GetInt16(0);
                string marca = dr.GetString(1);
                string modelo = dr.GetString(2);
                string combustivel = dr.GetString(3);
                string placa = dr.GetString(4);
                int kmRodado = dr.GetInt16(5);
                int ano = dr.GetInt16(6);


                v = new Veiculo(id ,marca, modelo, combustivel, placa, kmRodado, ano, null);
                lista_veiculo.Add(v);
            }
            dr.Close();
            conexao.Close();

            return lista_veiculo;
        }

        /* public List<Veiculo> FindByName(string nom)             HABILITAR PROCURAR POR NOME ????
         {
             List<Veiculo> lista_veiculo = new List<Veiculo>();
             Veiculo v = null;
             SQLiteConnection conexao = Database.GetInstance().GetConnection();

             string qry;

             if (nom != "")
                 qry = string.Format("SELECT id,marca,modelo,combustivel,placa,kmRodado,ano FROM Veiculo WHERE nome LIKE '%{0}%'", nom);
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
         }*/
    }
}
