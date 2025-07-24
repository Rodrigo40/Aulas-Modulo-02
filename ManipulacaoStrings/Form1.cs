using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipulacaoStrings
{
    public partial class Form1 : Form
    {
        string texto = string.Empty;
        int count = 0;
        string[] Nomes = new string[6]
           {
                "Pico","Pica","Fine","Okay","Done","properly"
           };

        StringBuilder sb = new StringBuilder();
       
        public Form1()
        {
            InitializeComponent();
            ListaNomes.View = View.List;
        }

        private void btnCarregarDados_Click(object sender, EventArgs e)
        {
            ListaNomes.Items.Clear();
            foreach (var n in Nomes)
            {
                sb.AppendLine(n);
                ListaNomes.Items.Add(sb.ToString());
                sb.Clear();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string pesquisa = txtBuscar.Text;

                if (!string.IsNullOrEmpty(pesquisa) && ListaNomes.Items.Count != 0)
                {
                    lbResultado.Text =
                        Array.Find(Nomes, (x) => x == pesquisa.Trim())
                        == null ? "Não achei yha" :
                       $"Achei {Array.Find(Nomes, (x) => x == pesquisa.Trim())}";

                    ListaNomes.Items.Clear();
                    ListaNomes.Items.Add(Array.Find(Nomes, (x) => x == pesquisa.Trim()));
                }
                lbResultado.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            lbResult.Text = txtValor.Text.IndexOf(txtValor.Text, Convert.ToInt32(ndNum.Value)).ToString();
        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            lbResult.Text = txtValor.Text.LastIndexOf(txtValor.Text, Convert.ToInt32(ndNum.Value)).ToString();
        }

        private void btnStartWith_Click(object sender, EventArgs e)
        {
            lbResult.Text = txtValor.Text.StartsWith(txtStartWith.Text).ToString();
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            lbResult.Text = txtValor.Text.Contains(txtStartWith.Text).ToString();
        }

        private void btnSubstrig_Click(object sender, EventArgs e)
        {
            lbResult.Text = txtValor.Text.Substring(Convert.ToInt32(ndNum.Value), txtValor.Text.Length - Convert.ToInt32(ndNum.Value)).ToString();
        }
       
        private void v_Click(object sender, EventArgs e)
        {
            texto = txtTextoLetreiro.Text;
            count = 0;
            lbLetreiro.Text = string.Empty;
            timer1.Start();
         }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
         }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < texto.Length)
            {
                lbLetreiro.Text += texto[count];
                count++;
            }
            else 
            {
                timer1.Stop();
            }
        }
     }
}
