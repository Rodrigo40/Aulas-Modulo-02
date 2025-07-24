namespace DriveInfo
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
            this.LvLista = new System.Windows.Forms.ListView();
            this.btnListarDiscos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LvLista
            // 
            this.LvLista.HideSelection = false;
            this.LvLista.Location = new System.Drawing.Point(12, 23);
            this.LvLista.Name = "LvLista";
            this.LvLista.Size = new System.Drawing.Size(749, 238);
            this.LvLista.TabIndex = 1;
            this.LvLista.UseCompatibleStateImageBehavior = false;
            this.LvLista.View = System.Windows.Forms.View.List;
            // 
            // btnListarDiscos
            // 
            this.btnListarDiscos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarDiscos.Location = new System.Drawing.Point(12, 267);
            this.btnListarDiscos.Name = "btnListarDiscos";
            this.btnListarDiscos.Size = new System.Drawing.Size(274, 65);
            this.btnListarDiscos.TabIndex = 2;
            this.btnListarDiscos.Text = "Listar dispositivos";
            this.btnListarDiscos.UseVisualStyleBackColor = true;
            this.btnListarDiscos.Click += new System.EventHandler(this.btnListarDiscos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Controls.Add(this.btnListarDiscos);
            this.Controls.Add(this.LvLista);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacoes das dicos instalados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvLista;
        private System.Windows.Forms.Button btnListarDiscos;
    }
}

