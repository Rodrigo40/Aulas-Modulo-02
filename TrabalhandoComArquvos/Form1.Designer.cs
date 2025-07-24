namespace TrabalhandoComArquvos
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
            this.btnListarPastas = new System.Windows.Forms.Button();
            this.btnListarArquivos = new System.Windows.Forms.Button();
            this.btnAbrirArquivo = new System.Windows.Forms.Button();
            this.btnCriarPasta = new System.Windows.Forms.Button();
            this.btnApagarPasta = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApagarArquivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LvLista
            // 
            this.LvLista.HideSelection = false;
            this.LvLista.Location = new System.Drawing.Point(12, 61);
            this.LvLista.Name = "LvLista";
            this.LvLista.Size = new System.Drawing.Size(749, 238);
            this.LvLista.TabIndex = 0;
            this.LvLista.UseCompatibleStateImageBehavior = false;
            this.LvLista.View = System.Windows.Forms.View.List;
            this.LvLista.SelectedIndexChanged += new System.EventHandler(this.LvLista_SelectedIndexChanged);
            this.LvLista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvLista_MouseDoubleClick);
            // 
            // btnListarPastas
            // 
            this.btnListarPastas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPastas.Location = new System.Drawing.Point(12, 305);
            this.btnListarPastas.Name = "btnListarPastas";
            this.btnListarPastas.Size = new System.Drawing.Size(211, 65);
            this.btnListarPastas.TabIndex = 1;
            this.btnListarPastas.Text = "Listar Pastas";
            this.btnListarPastas.UseVisualStyleBackColor = true;
            this.btnListarPastas.Click += new System.EventHandler(this.btnListarPastas_Click);
            // 
            // btnListarArquivos
            // 
            this.btnListarArquivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarArquivos.Location = new System.Drawing.Point(229, 305);
            this.btnListarArquivos.Name = "btnListarArquivos";
            this.btnListarArquivos.Size = new System.Drawing.Size(211, 65);
            this.btnListarArquivos.TabIndex = 2;
            this.btnListarArquivos.Text = "Listar Arquivos";
            this.btnListarArquivos.UseVisualStyleBackColor = true;
            this.btnListarArquivos.Click += new System.EventHandler(this.btnListarArquivos_Click);
            // 
            // btnAbrirArquivo
            // 
            this.btnAbrirArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirArquivo.Location = new System.Drawing.Point(446, 305);
            this.btnAbrirArquivo.Name = "btnAbrirArquivo";
            this.btnAbrirArquivo.Size = new System.Drawing.Size(211, 65);
            this.btnAbrirArquivo.TabIndex = 3;
            this.btnAbrirArquivo.Text = "Abrir item";
            this.btnAbrirArquivo.UseVisualStyleBackColor = true;
            this.btnAbrirArquivo.Visible = false;
            this.btnAbrirArquivo.Click += new System.EventHandler(this.btnAbrirArquivo_Click);
            // 
            // btnCriarPasta
            // 
            this.btnCriarPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPasta.Location = new System.Drawing.Point(12, 376);
            this.btnCriarPasta.Name = "btnCriarPasta";
            this.btnCriarPasta.Size = new System.Drawing.Size(211, 65);
            this.btnCriarPasta.TabIndex = 4;
            this.btnCriarPasta.Text = "Criar Pasta";
            this.btnCriarPasta.UseVisualStyleBackColor = true;
            this.btnCriarPasta.Click += new System.EventHandler(this.btnCriarPasta_Click);
            // 
            // btnApagarPasta
            // 
            this.btnApagarPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarPasta.Location = new System.Drawing.Point(229, 376);
            this.btnApagarPasta.Name = "btnApagarPasta";
            this.btnApagarPasta.Size = new System.Drawing.Size(211, 65);
            this.btnApagarPasta.TabIndex = 5;
            this.btnApagarPasta.Text = "Apagar Pasta";
            this.btnApagarPasta.UseVisualStyleBackColor = true;
            this.btnApagarPasta.Click += new System.EventHandler(this.btnApagarPasta_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(189, 17);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(343, 38);
            this.txtNome.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome Pasta";
            // 
            // btnApagarArquivo
            // 
            this.btnApagarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarArquivo.Location = new System.Drawing.Point(446, 376);
            this.btnApagarArquivo.Name = "btnApagarArquivo";
            this.btnApagarArquivo.Size = new System.Drawing.Size(211, 65);
            this.btnApagarArquivo.TabIndex = 8;
            this.btnApagarArquivo.Text = "Apagar Arquivo";
            this.btnApagarArquivo.UseVisualStyleBackColor = true;
            this.btnApagarArquivo.Click += new System.EventHandler(this.btnApagarArquivo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 495);
            this.Controls.Add(this.btnApagarArquivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnApagarPasta);
            this.Controls.Add(this.btnCriarPasta);
            this.Controls.Add(this.btnAbrirArquivo);
            this.Controls.Add(this.btnListarArquivos);
            this.Controls.Add(this.btnListarPastas);
            this.Controls.Add(this.LvLista);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabalhando com arquivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LvLista;
        private System.Windows.Forms.Button btnListarPastas;
        private System.Windows.Forms.Button btnListarArquivos;
        private System.Windows.Forms.Button btnAbrirArquivo;
        private System.Windows.Forms.Button btnCriarPasta;
        private System.Windows.Forms.Button btnApagarPasta;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApagarArquivo;
    }
}

