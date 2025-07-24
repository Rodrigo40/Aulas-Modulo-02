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
    public partial class Frm_CadUsuario : Form
    {
        public Frm_CadUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Digite o usuario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Digite a Password", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else
            {
                if (string.Equals(txtPassword.Text, txtConfirmaPassword.Text))
                {
                    UsuarioModel usuario = new UsuarioModel();
                    usuario.Usuario = txtUsuario.Text;
                    usuario.Password = txtPassword.Text;

                    UsuarioModel.GetInstacia().ListaUsuarios.Add(usuario);
                    MessageBox.Show("Usuario cadastrado com sucesso", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (Application.OpenForms["FmrLogin"] != null)
                    {
                        Application.OpenForms["FmrLogin"].Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("As passwords não conscidem", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
