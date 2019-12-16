using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Clientes
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }
        int IdSelecionado = 0;
        List<Cliente> listaClientes = new List<Cliente>();
        List<Usuario> listaUsuarios = new List<Usuario>();
        


        

       

        private void button2_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            banco.abreConexao();
            var nome = nome_usuario.Text;
            var usuario = usuario_usuario.Text;
            var senha = senha_usuario.Text;
            listaUsuarios = banco.SearchUsuario(nome, usuario, senha);
            gridViewUsuario.DataSource = listaUsuarios;

            banco.fechaConexao();
        }

        private void cadastrar_Click_1(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            try
            {

                banco.abreConexao();
                string nome = nome_usuario.Text;
                string usuario = usuario_usuario.Text;
                usuario = usuario.Replace("@", "\\@");
                string senha = senha_usuario.Text;


                var result = banco.InsertUsuario(nome, usuario, senha);

                if (result > 0)
                {
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    nome_usuario.Clear();
                    usuario_usuario.Clear();
                    senha_usuario.Clear();
                    listaUsuarios = banco.SearchUsuario("", "", "");
                    gridViewUsuario.DataSource = listaUsuarios;

                }
                else
                {
                    MessageBox.Show("Houve um problema ao realizar o cadastro! Entre em contato com o setor responsável.");
                }

                banco.fechaConexao();
            }
            catch (Exception ex)
            {
                banco.fechaConexao();
                MessageBox.Show(ex.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Deletar
        private void button4_Click(object sender, EventArgs e)
        {
            if (IdSelecionado <= 0)
            {
                MessageBox.Show("Nenhum usuário selecionado. Por favor selecione um usuário para excluir!");
            }
            else
            {
                Banco banco = new Banco();
                banco.abreConexao();

                var resultado = banco.deleteUsuario(IdSelecionado);
                if (resultado)
                {
                    MessageBox.Show("Usuário excluído com sucesso!");
                    limpa_campos();
                    listaUsuarios = banco.SearchUsuario("", "", "");
                    gridViewUsuario.DataSource = listaUsuarios;
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro. Por favor tente novamente.");
                }



                banco.fechaConexao();

            }
            
        }

        private void gridViewUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var gridView = (DataGridView)sender;
            IdSelecionado = Convert.ToInt32(gridViewUsuario.Rows[e.RowIndex].Cells[0].Value.ToString());
            nome_usuario.Text = gridViewUsuario.Rows[e.RowIndex].Cells[1].Value.ToString();
            usuario_usuario.Text = gridViewUsuario.Rows[e.RowIndex].Cells[2].Value.ToString();
            senha_usuario.Text = gridViewUsuario.Rows[e.RowIndex].Cells[3].Value.ToString();
            
        }

        //Alterar
        private void button3_Click(object sender, EventArgs e)
        {
            if (IdSelecionado <= 0)
            {
                MessageBox.Show("Nenhum usuário selecionado. Por favor selecione um usuário para excluir!");
            }
            else
            {
                Banco banco = new Banco();
                banco.abreConexao();

                Usuario usuario = new Usuario();
                usuario.Id = IdSelecionado;
                usuario.nome = nome_usuario.Text;
                usuario.usuario = usuario_usuario.Text.Replace("@", "\\@");
                usuario.senha = senha_usuario.Text;

                var resultado = banco.UpdateUsuario(usuario);
                if (resultado)
                {
                    MessageBox.Show("Usuário alterado com sucesso!");
                    limpa_campos();
                    listaUsuarios = banco.SearchUsuario("", "", "");
                    gridViewUsuario.DataSource = listaUsuarios;
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro. Por favor tente novamente.");
                }

                banco.fechaConexao();
            }
        }

        public void limpa_campos()
        {
            nome_usuario.Clear();
            usuario_usuario.Clear();
            senha_usuario.Clear();
        }

    }

}

