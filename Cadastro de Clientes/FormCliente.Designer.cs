namespace Cadastro_de_Clientes
{
    partial class FormCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cadastrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDeletarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtFoneFixo = new System.Windows.Forms.TextBox();
            this.txtCelular1 = new System.Windows.Forms.TextBox();
            this.txtCelular2 = new System.Windows.Forms.TextBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.txtCelular3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.listaClientesDB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesDB)).BeginInit();
            this.SuspendLayout();
            // 
            // cadastrar
            // 
            this.cadastrar.Location = new System.Drawing.Point(110, 290);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(98, 27);
            this.cadastrar.TabIndex = 0;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.pesquisar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(417, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 26);
            this.button3.TabIndex = 2;
            this.button3.Text = "Alterar Cadastro";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDeletarCliente
            // 
            this.btnDeletarCliente.Location = new System.Drawing.Point(569, 290);
            this.btnDeletarCliente.Name = "btnDeletarCliente";
            this.btnDeletarCliente.Size = new System.Drawing.Size(125, 27);
            this.btnDeletarCliente.TabIndex = 3;
            this.btnDeletarCliente.Text = "Deletar";
            this.btnDeletarCliente.UseVisualStyleBackColor = true;
            this.btnDeletarCliente.Click += new System.EventHandler(this.btnDeletarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefone Fixo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefone Celular 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone Celular 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Telefone Celular 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(522, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Observações";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(107, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Cliente";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(223, 52);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(228, 20);
            this.txtNome.TabIndex = 16;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(223, 84);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(228, 20);
            this.txtEndereco.TabIndex = 17;
            // 
            // txtFoneFixo
            // 
            this.txtFoneFixo.Location = new System.Drawing.Point(223, 116);
            this.txtFoneFixo.Name = "txtFoneFixo";
            this.txtFoneFixo.Size = new System.Drawing.Size(228, 20);
            this.txtFoneFixo.TabIndex = 18;
            // 
            // txtCelular1
            // 
            this.txtCelular1.Location = new System.Drawing.Point(223, 153);
            this.txtCelular1.Name = "txtCelular1";
            this.txtCelular1.Size = new System.Drawing.Size(228, 20);
            this.txtCelular1.TabIndex = 19;
            // 
            // txtCelular2
            // 
            this.txtCelular2.Location = new System.Drawing.Point(223, 185);
            this.txtCelular2.Name = "txtCelular2";
            this.txtCelular2.Size = new System.Drawing.Size(228, 20);
            this.txtCelular2.TabIndex = 20;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(527, 52);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(343, 186);
            this.txtObservacoes.TabIndex = 21;
            // 
            // txtCelular3
            // 
            this.txtCelular3.Location = new System.Drawing.Point(223, 218);
            this.txtCelular3.Name = "txtCelular3";
            this.txtCelular3.Size = new System.Drawing.Size(228, 20);
            this.txtCelular3.TabIndex = 26;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(743, 291);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 25);
            this.button5.TabIndex = 27;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listaClientesDB
            // 
            this.listaClientesDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaClientesDB.Location = new System.Drawing.Point(32, 333);
            this.listaClientesDB.Name = "listaClientesDB";
            this.listaClientesDB.Size = new System.Drawing.Size(897, 141);
            this.listaClientesDB.TabIndex = 28;
            this.listaClientesDB.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaClientesDB_CellDoubleClick);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 512);
            this.Controls.Add(this.listaClientesDB);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtCelular3);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.txtCelular2);
            this.Controls.Add(this.txtCelular1);
            this.Controls.Add(this.txtFoneFixo);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeletarCliente);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cadastrar);
            this.Name = "FormCliente";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDeletarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtFoneFixo;
        private System.Windows.Forms.TextBox txtCelular1;
        private System.Windows.Forms.TextBox txtCelular2;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.TextBox txtCelular3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView listaClientesDB;
    }
}

