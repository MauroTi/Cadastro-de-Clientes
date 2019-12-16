namespace Cadastro_de_Clientes
{
    partial class FormAbrirChamado
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
            this.btnAbreCliente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAbreCliente
            // 
            this.btnAbreCliente.Location = new System.Drawing.Point(62, 109);
            this.btnAbreCliente.Name = "btnAbreCliente";
            this.btnAbreCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAbreCliente.TabIndex = 0;
            this.btnAbreCliente.Text = "Ok";
            this.btnAbreCliente.UseVisualStyleBackColor = true;
            this.btnAbreCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite um número de telefone";
            // 
            // fone
            // 
            this.fone.Location = new System.Drawing.Point(62, 68);
            this.fone.Name = "fone";
            this.fone.Size = new System.Drawing.Size(191, 20);
            this.fone.TabIndex = 3;
            // 
            // FormAbrirChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 178);
            this.Controls.Add(this.fone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAbreCliente);
            this.Name = "FormAbrirChamado";
            this.Text = "Abrir Chamado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbreCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fone;
    }
}