using ControllerV;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewModel.User
{
    public partial class frmCadastrar : Form
    {
        ErrorProvider erro = new ErrorProvider();

        public frmCadastrar()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Cadastro de Venda", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            erro.Clear();
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrEmpty(((TextBox)c).Text))
                    {
                        erro.SetError(((TextBox)c), "Compo obrigatorio!");
                        ((TextBox)c).Focus();
                    }
                    else
                    {
                        if (string.Equals(txtPassword.Text, txtConfirmarPasswod.Text))
                        {
                            UserModel u = new UserModel()
                            {
                                Nome = txtNome.Text,
                                Email = txtEmail.Text,
                                Password = txtPassword.Text
                            };

                            UserController uc = new UserController();
                            var resposta = uc.Cadastrar(u);
                            MessageBox.Show(resposta, "Sistema de venda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimprarControles();
                        }
                        else
                        {
                            MessageBox.Show("Senhas nao combinam!", "Sistema de venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                }
            }
        }
        private void LimprarControles()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).ResetText();
                }
            }
            erro.Clear();

        }
    }
}
