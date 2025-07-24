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
    public partial class FrmCadPessoa : Form
    {
        public FrmCadPessoa()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            // Verifica se os campos obrigatórios estão preenchidos
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                errorProvider1.SetError(txtNome, "O campo Nome é obrigatório.");
            }
            else if (string.IsNullOrEmpty(txtSobrenome.Text))
            {
                errorProvider1.SetError(txtSobrenome, "O campo Sobrenome é obrigatório.");
            }
            else if (string.IsNullOrEmpty(txtdata.Text))
            {
                errorProvider1.SetError(txtdata, "O campo Data de Nascimento é obrigatório.");
            }
            else
            {
                PessoaModel pessoa = new PessoaModel
                {
                    Nome = txtNome.Text,
                    Sobrenome = txtSobrenome.Text,
                    DataNascimento = txtdata.Text
                };
                // Aqui você pode adicionar a lógica para salvar a pessoa, por exemplo, em um banco de dados
                PessoaModel.GetInstacia().ListaPessoa.Add(pessoa);
                MessageBox.Show("Pessoa cadastrada com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();   
            }
        }

        private void dtData_ValueChanged(object sender, EventArgs e)
        {
            if (dtData.Checked)
            {
                txtdata.Text = dtData.Value.ToShortDateString();
            }
        }
    }
}
