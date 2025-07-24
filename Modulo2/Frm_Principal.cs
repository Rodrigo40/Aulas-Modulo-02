using Modulo2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo2
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadPessoa frm = new FrmCadPessoa();
            frm.ShowDialog();// Bloqueia o formulário principal até que o formulário de cadastro seja fechado.
            //frm.Show();// Alternativa não bloqueante, o formulário principal continua ativo.
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            if (PessoaModel.GetInstacia().ListaPessoa.Count > 0)
            {
                LvPessoas.Items.Clear();
                foreach (var pessoa in PessoaModel.GetInstacia().ListaPessoa)
                {
                    string dados = $"{pessoa.Nome} {pessoa.Sobrenome} - {pessoa.DataNascimento}";
                    LvPessoas.Items.Add(dados);
                }
            }
        }

        private void Frm_Principal_Activated(object sender, EventArgs e)
        {
            if (PessoaModel.GetInstacia().ListaPessoa.Count > 0)
            {
                LvPessoas.Items.Clear();
                foreach (var pessoa in PessoaModel.GetInstacia().ListaPessoa)
                {
                    string dados = $"{pessoa.Nome} {pessoa.Sobrenome} - {pessoa.DataNascimento}";
                    LvPessoas.Items.Add(dados);
                }
            }
        }

        private void cmbModoVisual_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModoVisual.SelectedIndex > 0)
            {
                if (cmbModoVisual.Text == "Tile")
                {
                  LvPessoas.View = View.Tile;
                }
                else if (cmbModoVisual.Text == "Details")
                {
                    LvPessoas.View = View.Details;
                }
                else if (cmbModoVisual.Text == "List")
                {
                    LvPessoas.View = View.List;
                }
                else
                {
                    MessageBox.Show("Selecione uma opção válida", "Opção inválida",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
