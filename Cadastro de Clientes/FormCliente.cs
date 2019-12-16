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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }
        List<Cliente> listaClientes = new List<Cliente>();
        int IdSelecionado = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                listaClientesDB.DataSource = listaClientes;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void LimpaCampos() {
            IdSelecionado = 0;
            txtNome.Clear();
            txtEndereco.Clear();
            txtFoneFixo.Clear();
            txtCelular1.Clear();
            txtCelular2.Clear();
            txtObservacoes.Clear();
            txtCelular3.Clear();
        }
      
        private void cadastrar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            try
            {
                
                banco.abreConexao();
                string nome = txtNome.Text;
                string endereco = txtEndereco.Text;
                string telefoneFixo = txtFoneFixo.Text;
                string telefone_celular_1 = txtCelular1.Text;
                string telefone_celular_2 = txtCelular2.Text;
                string telefone_celular_3 = txtCelular3.Text;
                string observacoes = txtObservacoes.Text;

                var result = banco.InsertCliente(nome, endereco, telefoneFixo, telefone_celular_1, telefone_celular_2, telefone_celular_3, observacoes);

                if (result > 0)
                {
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    LimpaCampos();
                    listaClientes = banco.SearchCliente("", "", "","", "", "", "");
                    listaClientesDB.DataSource = listaClientes;
                }
                else {
                    MessageBox.Show("Houve um problema ao realizar o cadastro! Entre em contato com o setor responsável.");
                }

                banco.fechaConexao();
            }
            catch (Exception ex) {
                banco.fechaConexao();
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void pesquisar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            banco.abreConexao();
            var nome = txtNome.Text;
            var endereco = txtEndereco.Text;
            var telefoneFixo = txtFoneFixo.Text;
            var telefone_celular_1 = txtCelular1.Text;
            var telefone_celular_2 = txtCelular2.Text;
            var telefone_celular_3 = txtCelular3.Text;
            var observacoes = txtObservacoes.Text;
            listaClientes = banco.SearchCliente(nome, endereco, telefoneFixo, telefone_celular_1, telefone_celular_2, telefone_celular_3, observacoes);
            listaClientesDB.DataSource = listaClientes;                     
            banco.fechaConexao();

        }

        private void listaClientesDB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var gridView = (DataGridView)sender;
            IdSelecionado = Convert.ToInt32(listaClientesDB.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNome.Text = listaClientesDB.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEndereco.Text = listaClientesDB.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtFoneFixo.Text = listaClientesDB.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCelular1.Text = listaClientesDB.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCelular2.Text = listaClientesDB.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtCelular3.Text = listaClientesDB.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtObservacoes.Text = listaClientesDB.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btnDeletarCliente_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            if (IdSelecionado <= 0)
            {
                MessageBox.Show("Nenhum cliente selecionado para a exclusão. Por favor, selecione um cliente");
            }
            else {
                banco.abreConexao();
                bool deletou = banco.DeleteClienteById(IdSelecionado);
                if (deletou)
                {
                    MessageBox.Show("Cliente excluído com sucesso!");
                    LimpaCampos();
                    listaClientesDB.DataSource = banco.SearchCliente("","","","","","","");
                }
                else {
                    MessageBox.Show("Não foi possível excluir o cliente selecionado! Por favor tente novamente mais tarde!");
                }
                banco.fechaConexao();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            if (IdSelecionado <= 0)
            {
                MessageBox.Show("Nenhum cliente selecionado para atualização. Por favor, selecione um cliente");
            }
            else {

                banco.abreConexao();
                Cliente cliente = new Cliente();
                cliente.Id = IdSelecionado;
                cliente.Nome = txtNome.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.TelefoneFixo = txtFoneFixo.Text;
                cliente.Telefone_celular_1 = txtCelular1.Text;
                cliente.Telefone_celular_2 = txtCelular2.Text;
                cliente.Telefone_celular_3 = txtCelular3.Text;
                cliente.Observacoes = txtObservacoes.Text;

                bool atualizou = banco.UpdateCliente(cliente);
                if (atualizou)
                {
                    MessageBox.Show("Cliente atualizado com sucesso!");
                    LimpaCampos();
                    listaClientesDB.DataSource = banco.SearchCliente("", "", "", "", "", "", "");
                }
                else
                {
                    MessageBox.Show("Não foi possível atualizar o cliente selecionado! Por favor tente novamente mais tarde!");
                }
                banco.fechaConexao();


            }

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
