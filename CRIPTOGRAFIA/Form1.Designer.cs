namespace CRIPTOGRAFIA
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.btnCriptografar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTextoCriptografado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModoPreechimento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTamanhoBloco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescriptografado = new System.Windows.Forms.TextBox();
            this.btnDecriptografar = new System.Windows.Forms.Button();
            this.btnGrarAleatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criando Criptografia AES de 256 bit";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(25, 140);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(437, 38);
            this.txtTexto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Texto plano";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tamanho bits";
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(25, 227);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(437, 38);
            this.txtTamanho.TabIndex = 3;
            // 
            // btnCriptografar
            // 
            this.btnCriptografar.Location = new System.Drawing.Point(490, 370);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(251, 48);
            this.btnCriptografar.TabIndex = 5;
            this.btnCriptografar.Text = "Criptografar";
            this.btnCriptografar.UseVisualStyleBackColor = true;
            this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Texto Criptografado";
            // 
            // txtTextoCriptografado
            // 
            this.txtTextoCriptografado.Location = new System.Drawing.Point(25, 314);
            this.txtTextoCriptografado.Name = "txtTextoCriptografado";
            this.txtTextoCriptografado.Size = new System.Drawing.Size(437, 38);
            this.txtTextoCriptografado.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Modo ctiptografia";
            // 
            // txtModo
            // 
            this.txtModo.Location = new System.Drawing.Point(480, 140);
            this.txtModo.Name = "txtModo";
            this.txtModo.Size = new System.Drawing.Size(256, 38);
            this.txtModo.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Modo preenchimento";
            // 
            // txtModoPreechimento
            // 
            this.txtModoPreechimento.Location = new System.Drawing.Point(480, 227);
            this.txtModoPreechimento.Name = "txtModoPreechimento";
            this.txtModoPreechimento.Size = new System.Drawing.Size(256, 38);
            this.txtModoPreechimento.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tamanho do bloco";
            // 
            // txtTamanhoBloco
            // 
            this.txtTamanhoBloco.Location = new System.Drawing.Point(485, 314);
            this.txtTamanhoBloco.Name = "txtTamanhoBloco";
            this.txtTamanhoBloco.Size = new System.Drawing.Size(256, 38);
            this.txtTamanhoBloco.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(283, 31);
            this.label8.TabIndex = 15;
            this.label8.Text = "Texto Decriptografado";
            // 
            // txtDescriptografado
            // 
            this.txtDescriptografado.Location = new System.Drawing.Point(25, 403);
            this.txtDescriptografado.Name = "txtDescriptografado";
            this.txtDescriptografado.Size = new System.Drawing.Size(437, 38);
            this.txtDescriptografado.TabIndex = 14;
            // 
            // btnDecriptografar
            // 
            this.btnDecriptografar.Location = new System.Drawing.Point(490, 424);
            this.btnDecriptografar.Name = "btnDecriptografar";
            this.btnDecriptografar.Size = new System.Drawing.Size(251, 48);
            this.btnDecriptografar.TabIndex = 16;
            this.btnDecriptografar.Text = "Decriptografar";
            this.btnDecriptografar.UseVisualStyleBackColor = true;
            this.btnDecriptografar.Click += new System.EventHandler(this.btnDecriptografar_Click);
            // 
            // btnGrarAleatorio
            // 
            this.btnGrarAleatorio.Location = new System.Drawing.Point(255, 86);
            this.btnGrarAleatorio.Name = "btnGrarAleatorio";
            this.btnGrarAleatorio.Size = new System.Drawing.Size(207, 48);
            this.btnGrarAleatorio.TabIndex = 17;
            this.btnGrarAleatorio.Text = "Gerar Aleatorio";
            this.btnGrarAleatorio.UseVisualStyleBackColor = true;
            this.btnGrarAleatorio.Click += new System.EventHandler(this.btnGrarAleatorio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 484);
            this.Controls.Add(this.btnGrarAleatorio);
            this.Controls.Add(this.btnDecriptografar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDescriptografado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTamanhoBloco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtModoPreechimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtModo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTextoCriptografado);
            this.Controls.Add(this.btnCriptografar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRIPTOGRAFIA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Button btnCriptografar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTextoCriptografado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModoPreechimento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTamanhoBloco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescriptografado;
        private System.Windows.Forms.Button btnDecriptografar;
        private System.Windows.Forms.Button btnGrarAleatorio;
    }
}

