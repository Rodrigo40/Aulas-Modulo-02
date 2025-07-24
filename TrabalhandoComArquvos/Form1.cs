using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace TrabalhandoComArquvos
{
    public partial class Form1 : Form
    {
        private string ArquivoSelecionado { get; set; }
        string pastaRaiz = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnListarPastas_Click(object sender, EventArgs e)
        {
            Directory.EnumerateDirectories(pastaRaiz)
                .ToList()
                .ForEach(pasta => LvLista.Items.Add(pasta));
        }

        private void btnListarArquivos_Click(object sender, EventArgs e)
        {
            string pastaRaiz = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            Directory.GetFiles(pastaRaiz)
                .ToList()
                .ForEach(pasta => LvLista.Items.Add(pasta));
        }

        private void LvLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LvLista.SelectedItems.Count > 0)
            {
                ArquivoSelecionado = LvLista.SelectedItems[0].Text;
                btnAbrirArquivo.Visible = true;
            }
            else
            {
                btnAbrirArquivo.Visible = false;
            }
        }

        private void LvLista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (LvLista.SelectedItems.Count > 0)
            {
                MessageBox.Show($"{LvLista.SelectedItems[0].Text}");
            }
        }

        private void btnAbrirArquivo_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = ArquivoSelecionado;
            p.Start();
        }

        private void btnCriarPasta_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.CreateDirectory(Path.Combine(pastaRaiz, txtNome.Text == "" ? "Nova Pasta 2025" : txtNome.Text));
                LvLista.Items.Clear();
                btnListarPastas_Click(e, null);
            }
            catch (DirectoryNotFoundException error)
            {
                MessageBox.Show($"Erro: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Erro: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
         
        }

        private void btnApagarPasta_Click(object sender, EventArgs e)
        {
            Directory.Delete(ArquivoSelecionado, true);
            LvLista.Items.Clear();
            btnListarPastas_Click(e, null);
        }

        private void btnApagarArquivo_Click(object sender, EventArgs e)
        {
            File.Delete(ArquivoSelecionado);
            LvLista.Items.Clear();
            btnListarPastas_Click(e, null);
        }
    }
}
