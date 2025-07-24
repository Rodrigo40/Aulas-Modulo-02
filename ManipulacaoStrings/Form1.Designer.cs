namespace ManipulacaoStrings
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
            this.components = new System.ComponentModel.Container();
            this.ListaNomes = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCarregarDados = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.btnLastIndexOf = new System.Windows.Forms.Button();
            this.btnStartWith = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnSubstrig = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.ndNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStartWith = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTextoLetreiro = new System.Windows.Forms.TextBox();
            this.lbLetreiro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.v = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.ndNum)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaNomes
            // 
            this.ListaNomes.HideSelection = false;
            this.ListaNomes.Location = new System.Drawing.Point(12, 76);
            this.ListaNomes.Name = "ListaNomes";
            this.ListaNomes.Size = new System.Drawing.Size(827, 191);
            this.ListaNomes.TabIndex = 0;
            this.ListaNomes.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de nomes";
            // 
            // btnCarregarDados
            // 
            this.btnCarregarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarDados.Location = new System.Drawing.Point(296, 271);
            this.btnCarregarDados.Name = "btnCarregarDados";
            this.btnCarregarDados.Size = new System.Drawing.Size(240, 80);
            this.btnCarregarDados.TabIndex = 2;
            this.btnCarregarDados.Text = "Carregar dados";
            this.btnCarregarDados.UseVisualStyleBackColor = true;
            this.btnCarregarDados.Click += new System.EventHandler(this.btnCarregarDados_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(542, 36);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(297, 38);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(542, 291);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(42, 39);
            this.lbResultado.TabIndex = 5;
            this.lbResultado.Text = "R";
            // 
            // txtValor
            // 
            this.txtValor.AcceptsReturn = true;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(859, 73);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(180, 38);
            this.txtValor.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(852, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "Valor";
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndexOf.Location = new System.Drawing.Point(859, 117);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(128, 45);
            this.btnIndexOf.TabIndex = 12;
            this.btnIndexOf.Text = "IndexOf";
            this.btnIndexOf.UseVisualStyleBackColor = true;
            this.btnIndexOf.Click += new System.EventHandler(this.btnIndexOf_Click);
            // 
            // btnLastIndexOf
            // 
            this.btnLastIndexOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastIndexOf.Location = new System.Drawing.Point(860, 168);
            this.btnLastIndexOf.Name = "btnLastIndexOf";
            this.btnLastIndexOf.Size = new System.Drawing.Size(334, 45);
            this.btnLastIndexOf.TabIndex = 13;
            this.btnLastIndexOf.Text = "LastIndexOf";
            this.btnLastIndexOf.UseVisualStyleBackColor = true;
            this.btnLastIndexOf.Click += new System.EventHandler(this.btnLastIndexOf_Click);
            // 
            // btnStartWith
            // 
            this.btnStartWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartWith.Location = new System.Drawing.Point(860, 315);
            this.btnStartWith.Name = "btnStartWith";
            this.btnStartWith.Size = new System.Drawing.Size(179, 45);
            this.btnStartWith.TabIndex = 14;
            this.btnStartWith.Text = "StartWith";
            this.btnStartWith.UseVisualStyleBackColor = true;
            this.btnStartWith.Click += new System.EventHandler(this.btnStartWith_Click);
            // 
            // btnContains
            // 
            this.btnContains.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContains.Location = new System.Drawing.Point(1067, 315);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(179, 45);
            this.btnContains.TabIndex = 15;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnSubstrig
            // 
            this.btnSubstrig.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubstrig.Location = new System.Drawing.Point(860, 271);
            this.btnSubstrig.Name = "btnSubstrig";
            this.btnSubstrig.Size = new System.Drawing.Size(179, 45);
            this.btnSubstrig.TabIndex = 16;
            this.btnSubstrig.Text = "Substring";
            this.btnSubstrig.UseVisualStyleBackColor = true;
            this.btnSubstrig.Click += new System.EventHandler(this.btnSubstrig_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(868, 373);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(171, 39);
            this.lbResult.TabIndex = 17;
            this.lbResult.Text = "Resultado";
            // 
            // ndNum
            // 
            this.ndNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndNum.Location = new System.Drawing.Point(1067, 271);
            this.ndNum.Name = "ndNum";
            this.ndNum.Size = new System.Drawing.Size(165, 38);
            this.ndNum.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1060, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 39);
            this.label4.TabIndex = 19;
            this.label4.Text = "StartIndex";
            // 
            // txtStartWith
            // 
            this.txtStartWith.AcceptsReturn = true;
            this.txtStartWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartWith.Location = new System.Drawing.Point(1045, 73);
            this.txtStartWith.Name = "txtStartWith";
            this.txtStartWith.Size = new System.Drawing.Size(127, 38);
            this.txtStartWith.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1038, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 39);
            this.label5.TabIndex = 21;
            this.label5.Text = "StartWith";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 39);
            this.label6.TabIndex = 23;
            this.label6.Text = "Texto do letreiro";
            // 
            // txtTextoLetreiro
            // 
            this.txtTextoLetreiro.AcceptsReturn = true;
            this.txtTextoLetreiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextoLetreiro.Location = new System.Drawing.Point(60, 399);
            this.txtTextoLetreiro.Name = "txtTextoLetreiro";
            this.txtTextoLetreiro.Size = new System.Drawing.Size(588, 38);
            this.txtTextoLetreiro.TabIndex = 22;
            // 
            // lbLetreiro
            // 
            this.lbLetreiro.AutoSize = true;
            this.lbLetreiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLetreiro.Location = new System.Drawing.Point(3, 5);
            this.lbLetreiro.Name = "lbLetreiro";
            this.lbLetreiro.Size = new System.Drawing.Size(262, 39);
            this.lbLetreiro.TabIndex = 24;
            this.lbLetreiro.Text = "Texto do letreiro";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbLetreiro);
            this.panel1.Location = new System.Drawing.Point(60, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 47);
            this.panel1.TabIndex = 25;
            // 
            // v
            // 
            this.v.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v.Location = new System.Drawing.Point(667, 399);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(93, 49);
            this.v.TabIndex = 26;
            this.v.Text = "Start";
            this.v.UseVisualStyleBackColor = true;
            this.v.Click += new System.EventHandler(this.v_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(667, 452);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(93, 49);
            this.btnStop.TabIndex = 27;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(537, 348);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(223, 45);
            this.trackBar1.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 503);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.v);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTextoLetreiro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStartWith);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ndNum);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnSubstrig);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnStartWith);
            this.Controls.Add(this.btnLastIndexOf);
            this.Controls.Add(this.btnIndexOf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnCarregarDados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListaNomes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ndNum)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListaNomes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCarregarDados;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIndexOf;
        private System.Windows.Forms.Button btnLastIndexOf;
        private System.Windows.Forms.Button btnStartWith;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnSubstrig;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.NumericUpDown ndNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStartWith;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTextoLetreiro;
        private System.Windows.Forms.Label lbLetreiro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button v;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

