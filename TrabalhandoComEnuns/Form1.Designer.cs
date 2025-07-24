namespace TrabalhandoComEnuns
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
            this.cmbDias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCarregarDias = new System.Windows.Forms.Button();
            this.lbItemSeleciolnado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbDias
            // 
            this.cmbDias.FormattingEnabled = true;
            this.cmbDias.Location = new System.Drawing.Point(111, 141);
            this.cmbDias.Name = "cmbDias";
            this.cmbDias.Size = new System.Drawing.Size(530, 39);
            this.cmbDias.TabIndex = 0;
            this.cmbDias.SelectedIndexChanged += new System.EventHandler(this.cmbDias_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o dia da semana";
            // 
            // btnCarregarDias
            // 
            this.btnCarregarDias.Location = new System.Drawing.Point(252, 199);
            this.btnCarregarDias.Name = "btnCarregarDias";
            this.btnCarregarDias.Size = new System.Drawing.Size(248, 57);
            this.btnCarregarDias.TabIndex = 2;
            this.btnCarregarDias.Text = "Carregar dias";
            this.btnCarregarDias.UseVisualStyleBackColor = true;
            this.btnCarregarDias.Click += new System.EventHandler(this.btnCarregarDias_Click);
            // 
            // lbItemSeleciolnado
            // 
            this.lbItemSeleciolnado.Location = new System.Drawing.Point(111, 308);
            this.lbItemSeleciolnado.Name = "lbItemSeleciolnado";
            this.lbItemSeleciolnado.Size = new System.Drawing.Size(530, 34);
            this.lbItemSeleciolnado.TabIndex = 3;
            this.lbItemSeleciolnado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 411);
            this.Controls.Add(this.lbItemSeleciolnado);
            this.Controls.Add(this.btnCarregarDias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDias);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabalhando com enuns";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCarregarDias;
        private System.Windows.Forms.Label lbItemSeleciolnado;
    }
}

