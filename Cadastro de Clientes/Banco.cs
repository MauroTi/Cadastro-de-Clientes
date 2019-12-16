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

        public void abreConexao()
        {
            connection = new MySqlConnection("Server = localhost; Database = cliente; Uid = root;");
            connection.Open();
        }

        public void fechaConexao()
        {
            connection.Close();
        }

        public int InsertCliente(string nome, string endereco, string telefoneFixo, string telefone_celular_1, string telefone_celular_2, string telefone_celular_3, string observacoes)
        {
            query = new MySqlCommand("INSERT INTO clientes (nome, endereco, telefone_fixo, telefone_celular_1, telefone_celular_2, telefone_celular_3, observacoes)" +
                " VALUES ('" + nome + "', '" + endereco + "', '" + telefoneFixo + "', '" + telefone_celular_1 + "', '" + telefone_celular_2 + "', '" + telefone_celular_3 + "', '" + observacoes + "')", connection);
            return query.ExecuteNonQuery();
        }

        public List<Cliente> SearchCliente(string nome, string endereco, string telefoneFixo, string telefone_celular_1, string telefone_celular_2, string telefone_celular_3, string observacoes)
        {

            var listaCliente = new List<Cliente>();
            int regulador = 0;
            string queryStr = "";

            if (string.IsNullOrEmpty(nome) && string.IsNullOrEmpty(endereco) && string.IsNullOrEmpty(telefoneFixo) && string.IsNullOrEmpty(telefone_celular_1) && string.IsNullOrEmpty(telefone_celular_2) && string.IsNullOrEmpty(telefone_celular_3) && string.IsNullOrEmpty(observacoes))
            {
                queryStr = "select * from clientes";
            }
            else
            {
                queryStr = "select * from clientes WHERE ";
            }




            if (!string.IsNullOrEmpty(nome))
            {
                if (regulador == 0)
                {
                    queryStr += "nome like '%" + nome + "%' ";
                    regulador++;
                }
                else
                {
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
                    Id = Convert.ToInt32(reader["id"]),
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


        }

        public int InsertUsuario(string nome, string usuario, string senha)
        {
            query = new MySqlCommand("INSERT INTO usuarios (nome, usuario, senha)" +
                " VALUES ('" + nome + "', '" + usuario + "', '" + senha + "')", connection);
            return query.ExecuteNonQuery();
        }

        public List<Usuario> SearchUsuario(string nome, string usuario, string senha)
        {

            var listaUsuario = new List<Usuario>();
            int regulador = 0;
            string queryStr = "";

            if (string.IsNullOrEmpty(nome) && string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(senha))
            {
                queryStr = "select * from usuarios";
            }
            else
            {
                queryStr = "select * from usuarios WHERE ";
            }




            if (!string.IsNullOrEmpty(nome))
            {
                if (regulador == 0)
                {
                    queryStr += "nome like '%" + nome + "%' ";
                    regulador++;
                }
                else
                {
                    queryStr += " AND nome like '%" + nome + "%' ";
                }

            }

            if (!string.IsNullOrEmpty(usuario))
            {
                if (regulador == 0)
                {
                    queryStr += "usuario like '%" + usuario + "%' ";
                    regulador++;
                }
                else
                {
                    queryStr += " AND usuario like '%" + usuario + "%' ";
                }

            }

            if (!string.IsNullOrEmpty(senha))
            {
                if (regulador == 0)
                {
                    queryStr += "senha like '%" + senha + "%' ";
                    regulador++;
                }
                else
                {
                    queryStr += " AND senha like '%" + senha + "%' ";
                }

            }



            query = new MySqlCommand(queryStr, connection);

            var reader = query.ExecuteReader();

            while (reader.Read())
            {
                listaUsuario.Add(new Usuario
                {
                    Id = Convert.ToInt32(reader["id"]),
                    nome = Convert.ToString(reader["nome"]),
                    usuario = Convert.ToString(reader["usuario"]),
                    senha = Convert.ToString(reader["senha"]),

                });
            }


            return listaUsuario;

            //query = new 
        }

        public Cliente SearchClienteByTelefone(string numeroTelefone)
        {

            Cliente cliente = new Cliente();

            string queryStr = "select * from clientes where telefone_fixo" +
                " like '%" + numeroTelefone + "%' OR telefone_celular_1 like" +
                " '%" + numeroTelefone + "%' OR telefone_celular_2 like '%" + numeroTelefone + "%' OR telefone_celular_3 like '%" + numeroTelefone + "%'";

            query = new MySqlCommand(queryStr, connection);

            MySqlDataReader reader = query.ExecuteReader();

            if (reader.Read())
            {
                cliente.Id = Convert.ToInt32(reader["id"]);
                cliente.Nome = Convert.ToString(reader["nome"]);
                cliente.Endereco = Convert.ToString(reader["endereco"]);
                cliente.TelefoneFixo = Convert.ToString(reader["telefone_fixo"]);
                cliente.Telefone_celular_1 = Convert.ToString(reader["telefone_celular_1"]);
                cliente.Telefone_celular_2 = Convert.ToString(reader["telefone_celular_2"]);
                cliente.Telefone_celular_3 = Convert.ToString(reader["telefone_celular_3"]);
                cliente.Observacoes = Convert.ToString(reader["observacoes"]);


            }

            return cliente;
        }

        public bool DeleteClienteById(int Id)
        {
            string queryStr = "DELETE FROM clientes Where id = " + Id;

            query = new MySqlCommand(queryStr, connection);

            int resultado = query.ExecuteNonQuery();

            return resultado > 0;
        }

        public bool InsertChamado(int idCliente, string dateTime, string observacoes)
        {
            string queryStr = "INSERT INTO registro (idcliente, data_chamado, registro_chamado) values" +
                " ('" + idCliente + "', '" + dateTime + "', '" + observacoes + "')";

            query = new MySqlCommand(queryStr, connection);

            int resultado = query.ExecuteNonQuery();
            return resultado > 0;
        }

        public bool UpdateCliente(Cliente cliente)
        {
            string queryStr = "UPDATE clientes set " +
                "nome = '" + cliente.Nome +
                "', endereco = '" + cliente.Endereco +
                "', telefone_fixo = '" +
                cliente.TelefoneFixo +
                "', telefone_celular_1 = '" +
                cliente.Telefone_celular_1 + "', telefone_celular_2 = '" +
                cliente.Telefone_celular_2 + "' , telefone_celular_3 = '" +
                cliente.Telefone_celular_3 + "', observacoes = '" + cliente.Observacoes + "' where id = " + cliente.Id;

            query = new MySqlCommand(queryStr, connection);

            int resultado = query.ExecuteNonQuery();

            return resultado > 0;

        }

        public bool deleteUsuario(int Id)
        {
            string queryStr = "DELETE FROM usuarios Where id = " + Id;

            query = new MySqlCommand(queryStr, connection);

            int resultado = query.ExecuteNonQuery();

            return resultado > 0;
        }

        public bool UpdateUsuario(Usuario usuario)
        {
            string queryStr = "UPDATE usuarios set " +
                "nome = '" + usuario.nome +
                "', usuario = '" + usuario.usuario +
                "', senha = '" +
                usuario.senha+
                "' where id = " + usuario.Id;

            query = new MySqlCommand(queryStr, connection);

            int resultado = query.ExecuteNonQuery();

            return resultado > 0;

        }
    }
}

