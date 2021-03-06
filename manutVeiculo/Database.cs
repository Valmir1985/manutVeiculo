﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Collections.ObjectModel;



namespace manutVeiculo
{
    class Database
    {

        private static SQLiteConnection conexao;
        private static Database instance;
        private const string URL = "Data Source=manutVeiculo.db; foreign keys = true;";

        public int LastId { get; private set; }

        private Database()
        {
            if (!File.Exists("manutVeiculo.db"))
            {
                CreateDB();
            }
            conexao = new SQLiteConnection(URL);
        }
        public static Database GetInstance()
        {
            if (instance == null)
            {
                instance = new Database();
            }
            return instance;
        }
        public SQLiteConnection GetConnection()
        {
            return conexao;
        }
        public void ExecuteSQL(string qry)
        {
            if (conexao.State != System.Data.ConnectionState.Open)
            {
                conexao.Open();
            }
            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            comm.ExecuteNonQuery();
            LastId = (int)conexao.LastInsertRowId;
            conexao.Close();
        }
        private void CreateDB()
        {
            SQLiteConnection.CreateFile("manutVeiculo.db");
            SQLiteConnection conn = new SQLiteConnection(URL);
            conn.Open();
            
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("CREATE TABLE IF NOT EXISTS pessoa (");
            sql.AppendLine("[id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, ");
            sql.AppendLine("[cpf] VARCHAR(20) NOT NULL, ");
            sql.AppendLine("[nome] VARCHAR(100), ");
            sql.AppendLine("[telefone] INTEGER, ");
            sql.AppendLine("[sexo] VARCHAR(1), ");
            sql.AppendLine("[rua] VARCHAR(100), ");
            sql.AppendLine("[bairro] VARCHAR(50), ");
            sql.AppendLine("[numero] INTEGER, ");
            sql.AppendLine("[cep] VARCHAR(20), ");
            sql.AppendLine("[cidade] VARCHAR(50), ");
            sql.AppendLine("[uf] VARCHAR(2)); ");

            SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar banco de dados: " + ex.Message);
            }

            sql.Clear();

            sql.AppendLine("CREATE TABLE IF NOT EXISTS veiculo(");
            sql.AppendLine("[id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, ");
            sql.AppendLine("[idCliente] VARCHAR(20) NOT NULL, ");
            sql.AppendLine("[marca] VARCHAR(50), ");
            sql.AppendLine("[modelo] VARCHAR(50), ");
            sql.AppendLine("[combustivel] VARCHAR(20), ");
            sql.AppendLine("[placa] VARCHAR(50), ");
            sql.AppendLine("[kmRodado] INTEGER, ");
            sql.AppendLine("[ano] INTEGER, ");
            sql.AppendLine("FOREIGN KEY(idCliente) REFERENCES pessoa(id));");

                cmd = new SQLiteCommand(sql.ToString(), conn);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar banco de dados: " + ex.Message);
            }

            sql.Clear();

            sql.AppendLine("CREATE TABLE IF NOT EXISTS peca(");
            sql.AppendLine("id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, ");
            sql.AppendLine("marca VARCHAR(50),");
            sql.AppendLine("pecaServico VARCHAR(100),");
            sql.AppendLine("modelo VARCHAR(50),");
            sql.AppendLine("kmTroca INTEGER,");
            sql.AppendLine("ano INTEGER,");
            sql.AppendLine("preco FLOAT);");


            cmd = new SQLiteCommand(sql.ToString(), conn);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar banco de dados: " + ex.Message);
            }

            sql.Clear();


            sql.AppendLine("CREATE TABLE IF NOT EXISTS os(");
            sql.AppendLine("id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, ");
            sql.AppendLine("cliente INTEGER, ");
            sql.AppendLine("placa VARCHAR(20), ");
            sql.AppendLine("status BOOLEAN, ");
            sql.AppendLine("peca VARCHAR(100), ");
            sql.AppendLine("valor VARCHAR(50), ");
            sql.AppendLine("km INTEGER, ");
            sql.AppendLine("data DATE,");
            sql.AppendLine("FOREIGN KEY (cliente) REFERENCES pessoa(id),");
            sql.AppendLine("FOREIGN KEY (placa) REFERENCES veiculo (placa));");

            cmd = new SQLiteCommand(sql.ToString(), conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar banco de dados: " + ex.Message);
            }

            sql.Clear();

            sql.AppendLine("CREATE TABLE IF NOT EXISTS consultaOs(");
            sql.AppendLine("numeroOs INTEGER NOT NULL PRIMARY KEY,");
            sql.AppendLine("cliente INTEGER,");
            sql.AppendLine("placa VARCHAR(50),");
            sql.AppendLine("status BOOLEAN DEFAULT false,");
            sql.AppendLine("FOREIGN KEY (cliente) REFERENCES pessoa (id),");
            sql.AppendLine("FOREIGN KEY (numeroOs) REFERENCES os (id));");

            cmd = new SQLiteCommand(sql.ToString(), conn);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar banco de dados: " + ex.Message);
            }

            sql.Clear();

            sql.AppendLine("CREATE TABLE IF NOT EXISTS OsPeca(");
            sql.AppendLine("idOs INTEGER NOT NULL, ");
            sql.AppendLine("idPeca INTEGER NOT NULL,");
            sql.AppendLine("FOREIGN KEY (idOs) REFERENCES os (id),");
            sql.AppendLine("FOREIGN KEY (idPeca) REFERENCES peca (id));");


            cmd = new SQLiteCommand(sql.ToString(), conn);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar banco de dados: " + ex.Message);
            }

            conn.Close();
        }
    }
}


