namespace TrabalhandoComStructs
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
            this.btnVerDetalhes = new System.Windows.Forms.Button();
            this.RtTexto = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CkBluetooth = new System.Windows.Forms.CheckBox();
            this.ckCamera = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnVerDetalhes
            // 
            this.btnVerDetalhes.Location = new System.Drawing.Point(160, 330);
            this.btnVerDetalhes.Name = "btnVerDetalhes";
            this.btnVerDetalhes.Size = new System.Drawing.Size(329, 57);
            this.btnVerDetalhes.TabIndex = 0;
            this.btnVerDetalhes.Text = "Ver detalhes do carro";
            this.btnVerDetalhes.UseVisualStyleBackColor = true;
            this.btnVerDetalhes.Click += new System.EventHandler(this.btnVerDetalhes_Click);
            // 
            // RtTexto
            // 
            this.RtTexto.Location = new System.Drawing.Point(28, 46);
            this.RtTexto.Name = "RtTexto";
            this.RtTexto.Size = new System.Drawing.Size(613, 200);
            this.RtTexto.TabIndex = 1;
            this.RtTexto.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "RECURSOS DO CARRO";
            // 
            // CkBluetooth
            // 
            this.CkBluetooth.AutoSize = true;
            this.CkBluetooth.Location = new System.Drawing.Point(28, 265);
            this.CkBluetooth.Name = "CkBluetooth";
            this.CkBluetooth.Size = new System.Drawing.Size(148, 35);
            this.CkBluetooth.TabIndex = 3;
            this.CkBluetooth.Text = "Bluetooth";
            this.CkBluetooth.UseVisualStyleBackColor = true;
            this.CkBluetooth.CheckedChanged += new System.EventHandler(this.CkBluetooth_CheckedChanged);
            // 
            // ckCamera
            // 
            this.ckCamera.AutoSize = true;
            this.ckCamera.Location = new System.Drawing.Point(200, 265);
            this.ckCamera.Name = "ckCamera";
            this.ckCamera.Size = new System.Drawing.Size(129, 35);
            this.ckCamera.TabIndex = 4;
            this.ckCamera.Text = "Camera";
            this.ckCamera.UseVisualStyleBackColor = true;
            this.ckCamera.CheckedChanged += new System.EventHandler(this.ckCamera_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 415);
            this.Controls.Add(this.ckCamera);
            this.Controls.Add(this.CkBluetooth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RtTexto);
            this.Controls.Add(this.btnVerDetalhes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabalho com structs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerDetalhes;
        private System.Windows.Forms.RichTextBox RtTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CkBluetooth;
        private System.Windows.Forms.CheckBox ckCamera;
    }
}

