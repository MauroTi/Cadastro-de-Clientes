namespace Cadastro_de_Clientes
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastroUsuario = new System.Windows.Forms.Button();
            this.btnCadastraCliente = new System.Windows.Forms.Button();
            this.btnAbrirChamado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroUsuario
            // 
            this.btnCadastroUsuario.Location = new System.Drawing.Point(34, 32);
            this.btnCadastroUsuario.Name = "btnCadastroUsuario";
            this.btnCadastroUsuario.Size = new System.Drawing.Size(133, 93);
            this.btnCadastroUsuario.TabIndex = 0;
            this.btnCadastroUsuario.Text = "Cadastrar Clientes";
            this.btnCadastroUsuario.UseVisualStyleBackColor = true;
            this.btnCadastroUsuario.Click += new System.EventHandler(this.btnCadastroUsuario_Click);
            // 
            // btnCadastraCliente
            // 
            this.btnCadastraCliente.Location = new System.Drawing.Point(348, 32);
            this.btnCadastraCliente.Name = "btnCadastraCliente";
            this.btnCadastraCliente.Size = new System.Drawing.Size(133, 93);
            this.btnCadastraCliente.TabIndex = 1;
            this.btnCadastraCliente.Text = "Cadastrar Usuários";
            this.btnCadastraCliente.UseVisualStyleBackColor = true;
            this.btnCadastraCliente.Click += new System.EventHandler(this.btnCadastraCliente_Click);
            // 
            // btnAbrirChamado
            // 
            this.btnAbrirChamado.Location = new System.Drawing.Point(196, 32);
            this.btnAbrirChamado.Name = "btnAbrirChamado";
            this.btnAbrirChamado.Size = new System.Drawing.Size(133, 93);
            this.btnAbrirChamado.TabIndex = 2;
            this.btnAbrirChamado.Text = "Abrir chamado";
            this.btnAbrirChamado.UseVisualStyleBackColor = true;
            this.btnAbrirChamado.Click += new System.EventHandler(this.btnAbrirChamado_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 162);
            this.Controls.Add(this.btnAbrirChamado);
            this.Controls.Add(this.btnCadastraCliente);
            this.Controls.Add(this.btnCadastroUsuario);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroUsuario;
        private System.Windows.Forms.Button btnCadastraCliente;
        private System.Windows.Forms.Button btnAbrirChamado;
    }
}