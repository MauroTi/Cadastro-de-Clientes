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
    public partial class FormAbrirChamado : Form
    {
        public FormAbrirChamado()
        {
            InitializeComponent();
        }

        private bool ClienteExiste(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.TelefoneFixo) && string.IsNullOrEmpty(cliente.Telefone_celular_1) && string.IsNullOrEmpty(cliente.Telefone_celular_2) && string.IsNullOrEmpty(cliente.Telefone_celular_3)) {
                return false;
            }
            return true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num = fone.Text;
            Banco banco = new Banco();
            banco.abreConexao();
            var cliente = banco.SearchClienteByTelefone(num);
            if (!ClienteExiste(cliente))
            {
                MessageBox.Show("Cliente não cadastrado");
                new FormCliente().Show();
            }
            else {
                var form3 = new FormChamado(cliente);
                form3.Show();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    
        
    

