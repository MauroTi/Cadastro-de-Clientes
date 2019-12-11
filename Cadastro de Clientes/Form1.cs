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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Cliente> listaClientes = new List<Cliente>();
        private void Form1_Load(object sender, EventArgs e)
        {
            try {
                listaClientesDB.DataSource = listaClientes;
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            try
            {
                
                banco.abreConexao();
                string nome = textBox1.Text;
                string endereco = textBox2.Text;
                string telefoneFixo = textBox3.Text;
                string telefone_celular_1 = textBox4.Text;
                string telefone_celular_2 = textBox5.Text;
                string telefone_celular_3 = textBox7.Text;
                string observacoes = textBox6.Text;

                var result = banco.Insert(nome, endereco, telefoneFixo, telefone_celular_1, telefone_celular_2, telefone_celular_3, observacoes);

                if (result > 0)
                {
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    listaClientes = banco.Search("", "", "","", "", "", "");
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
            var nome = textBox1.Text;
            var endereco = textBox2.Text;
            var telefoneFixo = textBox3.Text;
            var telefone_celular_1 = textBox4.Text;
            var telefone_celular_2 = textBox5.Text;
            var telefone_celular_3 = textBox7.Text;
            var observacoes = textBox6.Text;
            listaClientes = banco.Search(nome, endereco, telefoneFixo, telefone_celular_1, telefone_celular_2, telefone_celular_3, observacoes);
            listaClientesDB.DataSource = listaClientes;                     
            banco.fechaConexao();

        }

        private void listaClientesDB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var gridView = (DataGridView)sender;
            textBox1.Text = listaClientesDB.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = listaClientesDB.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = listaClientesDB.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = listaClientesDB.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = listaClientesDB.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = listaClientesDB.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox7.Text = listaClientesDB.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
