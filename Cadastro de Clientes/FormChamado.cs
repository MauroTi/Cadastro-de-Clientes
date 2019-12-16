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
    public partial class FormChamado : Form
    {
        public FormChamado()
        {
            InitializeComponent();
        }
        int idSelecionado = 0;
        public FormChamado(Cliente cliente) {
            InitializeComponent();
            idSelecionado = cliente.Id;
            txtNome.Text = cliente.Nome;
            txtEndereco.Text = cliente.Endereco;
            txtTelefoneFixo.Text = cliente.TelefoneFixo;
            txtCelular1.Text = cliente.Telefone_celular_1;
            txtCelular2.Text = cliente.Telefone_celular_2;
            txtCelular3.Text = cliente.Telefone_celular_3;
            txtObservacoes.Text = cliente.Observacoes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            banco.abreConexao();
            string observacoes = txtObservacoes.Text + "\n" + txtObservacoesChamadoAtual.Text;            
            bool inseriu = banco.InsertChamado(idSelecionado, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), observacoes);
            if (inseriu)
            {
                MessageBox.Show("Evento registrado com sucesso!");
                banco.fechaConexao();
                this.Close();

            }
            else
            {
                MessageBox.Show("Erro ao registrar o evento!");
               
            }
            banco.fechaConexao();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
