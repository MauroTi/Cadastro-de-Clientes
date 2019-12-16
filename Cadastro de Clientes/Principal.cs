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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        

        private void btnCadastraCliente_Click(object sender, EventArgs e)
        {
            var usuarios = new Usuarios();
            usuarios.Show();
        }

        private void btnCadastroUsuario_Click(object sender, EventArgs e)
        {
            var form1 = new FormCliente();
            form1.Show();
        }

        private void btnAbrirChamado_Click(object sender, EventArgs e)
        {
            var form4 = new FormAbrirChamado();
            form4.Show();

        }
    }
}
