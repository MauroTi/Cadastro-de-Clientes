using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Cadastro_de_Clientes
{
   public class Banco
    {
        MySqlConnection connection;
        MySqlCommand query;

        public void abreConexao() {
            connection = new MySqlConnection("Server = localhost; Database = cliente; Uid = root;");
            connection.Open();
        }

        public void fechaConexao() {
            connection.Close();
        }

        public int Insert(string nome, string endereco, string telefoneFixo, string telefone_celular_1, string telefone_celular_2, string telefone_celular_3, string observacoes) {
            query = new MySqlCommand("INSERT INTO clientes (nome, endereco, telefone_fixo, telefone_celular_1, telefone_celular_2, telefone_celular_3, observacoes)" +
                " VALUES ('" + nome + "', '" + endereco + "', '" + telefoneFixo + "', '" + telefone_celular_1 + "', '" + telefone_celular_2 + "', '" + telefone_celular_3 + "', '" + observacoes + "')", connection);
            return query.ExecuteNonQuery();
        }

        public List<Cliente> Search(string nome, string endereco, string telefoneFixo, string telefone_celular_1, string telefone_celular_2, string telefone_celular_3, string observacoes) {

            var listaCliente = new List<Cliente>();
            int regulador = 0;
            string queryStr = "";

            if (string.IsNullOrEmpty(nome) && string.IsNullOrEmpty(endereco) && string.IsNullOrEmpty(telefoneFixo) && string.IsNullOrEmpty(telefone_celular_1) && string.IsNullOrEmpty(telefone_celular_2) && string.IsNullOrEmpty(telefone_celular_3) && string.IsNullOrEmpty(observacoes))
            {
                queryStr = "select * from clientes";
            }
            else {
                queryStr = "select * from clientes WHERE ";
            }
            

                                 
           
             if (!string.IsNullOrEmpty(nome)) {
                 if (regulador == 0)
                 {
                     queryStr += "nome like '%" + nome + "%' ";
                     regulador++;
                 }
                 else {
                     queryStr += " AND nome like '%" + nome + "%'";
                 }

             }

             if (!string.IsNullOrEmpty(endereco))
             {
                 if (regulador == 0)
                 {
                     queryStr += "endereco like '%" + endereco + "%' ";
                     regulador++;
                 }
                 else
                 {
                     queryStr += " AND endereco like '%" + endereco + "%'";
                 }

             }

             if (!string.IsNullOrEmpty(telefoneFixo))
             {
                 if (regulador == 0)
                 {
                     queryStr += "telefone_fixo like '%" + telefoneFixo + "%' ";
                     regulador++;
                 }
                 else
                 {
                     queryStr += " AND telefone_fixo like '%" + telefoneFixo + "%'";
                 }

             }

            if (!string.IsNullOrEmpty(telefone_celular_1))
            {
                if (regulador == 0)
                {
                    queryStr += "telefone_celular_1 like '%" + telefone_celular_1 + "%' ";
                    regulador++;
                }
                else
                {
                    queryStr += " AND telefone_celular_1 like '%" + telefone_celular_1 + "%'";
                }

            }

            if (!string.IsNullOrEmpty(telefone_celular_2))
            {
                if (regulador == 0)
                {
                    queryStr += "telefone_celular_2 like '%" + telefone_celular_2 + "%' ";
                    regulador++;
                }
                else
                {
                    queryStr += " AND telefone_celular_2 like '%" + telefone_celular_2 + "%'";
                }

            }

            if (!string.IsNullOrEmpty(telefone_celular_3))
            {
                if (regulador == 0)
                {
                    queryStr += "telefone_celular_3 like '%" + telefone_celular_3 + "%' ";
                    regulador++;
                }
                else
                {
                    queryStr += " AND telefone_celular_3 like '%" + telefone_celular_3 + "%'";
                }

            }

            if (!string.IsNullOrEmpty(observacoes))
            {
                if (regulador == 0)
                {
                    queryStr += "observacoes like '%" + observacoes + "%' ";
                    regulador++;
                }
                else
                {
                    queryStr += " AND observacoes like '%" + observacoes + "%'";
                }

            }

            query = new MySqlCommand(queryStr, connection);

            var reader = query.ExecuteReader();
                  
            while (reader.Read())
            {
                listaCliente.Add(new Cliente
                {
                    Nome = Convert.ToString(reader["nome"]),
                    Endereco = Convert.ToString(reader["endereco"]),
                    TelefoneFixo = Convert.ToString(reader["telefone_fixo"]),
                    Telefone_celular_1 = Convert.ToString(reader["telefone_celular_1"]),
                    Telefone_celular_2 = Convert.ToString(reader["telefone_celular_2"]),
                    Telefone_celular_3 = Convert.ToString(reader["telefone_celular_3"]),
                    Observacoes = Convert.ToString(reader["observacoes"])
                });
            }


            return listaCliente;

            //query = new 
        }
    }
}
