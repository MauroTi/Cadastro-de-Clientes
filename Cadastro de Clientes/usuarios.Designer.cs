namespace Cadastro_de_Clientes
{
    partial class Usuarios
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
            this.senha_usuario = new System.Windows.Forms.TextBox();
            this.usuario_usuario = new System.Windows.Forms.TextBox();
            this.nome_usuario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cadastrar = new System.Windows.Forms.Button();
            this.gridViewUsuario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // senha_usuario
            // 
            this.senha_usuario.Location = new System.Drawing.Point(285, 186);
            this.senha_usuario.Name = "senha_usuario";
            this.senha_usuario.Size = new System.Drawing.Size(228, 20);
            this.senha_usuario.TabIndex = 32;
            this.senha_usuario.UseSystemPasswordChar = true;
            // 
            // usuario_usuario
            // 
            this.usuario_usuario.Location = new System.Drawing.Point(285, 154);
            this.usuario_usuario.Name = "usuario_usuario";
            this.usuario_usuario.Size = new System.Drawing.Size(228, 20);
            this.usuario_usuario.TabIndex = 31;
            // 
            // nome_usuario
            // 
            this.nome_usuario.Location = new System.Drawing.Point(285, 122);
            this.nome_usuario.Name = "nome_usuario";
            this.nome_usuario.Size = new System.Drawing.Size(228, 20);
            this.nome_usuario.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(211, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Usuário";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Senha";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(211, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Nome";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(40, 245);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 25);
            this.button5.TabIndex = 37;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(40, 85);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 27);
            this.button4.TabIndex = 36;
            this.button4.Text = "Deletar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(40, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 26);
            this.button3.TabIndex = 35;
            this.button3.Text = "Alterar Cadastro";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 27);
            this.button2.TabIndex = 34;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cadastrar
            // 
            this.cadastrar.Location = new System.Drawing.Point(40, 32);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(98, 27);
            this.cadastrar.TabIndex = 33;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click_1);
            // 
            // gridViewUsuario
            // 
            this.gridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewUsuario.Location = new System.Drawing.Point(40, 302);
            this.gridViewUsuario.Name = "gridViewUsuario";
            this.gridViewUsuario.Size = new System.Drawing.Size(473, 286);
            this.gridViewUsuario.TabIndex = 38;
            this.gridViewUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewUsuario_CellDoubleClick);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 626);
            this.Controls.Add(this.gridViewUsuario);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.senha_usuario);
            this.Controls.Add(this.usuario_usuario);
            this.Controls.Add(this.nome_usuario);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "Usuarios";
            this.Text = "usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox senha_usuario;
        private System.Windows.Forms.TextBox usuario_usuario;
        private System.Windows.Forms.TextBox nome_usuario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.DataGridView gridViewUsuario;
    }
}