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
    public partial class FmrLogin : Form
    {
        public FmrLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
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
                var usuario = UsuarioModel.GetInstacia();
                List<UsuarioModel> login = usuario.ListaUsuarios.Where
                (
                  u => u.Usuario == txtUsuario.Text &&
                  u.Password == txtPassword.Text
                ).ToList();

                if (login.Count != 0)
                {
                    if (Application.OpenForms["Frm_Principal"] != null)
                    {
                        Application.OpenForms["Frm_Principal"].Show();
                        this.Hide();
                    }
                    else
                    {
                        Frm_Principal frm = new Frm_Principal();
                        frm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario ou passoword incorretos", "Erro ao efetuar login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lkCriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_CadUsuario frm = new Frm_CadUsuario();
            frm.Show();
            this.Hide();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtUsuario.Text))
                {
                    txtUsuario.Focus();
                }
                else if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    txtPassword.Focus();
                }
                else
                {
                    btnLogin_Click(e, null);
                }
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    txtPassword.Focus();
                }
                else if (string.IsNullOrEmpty(txtUsuario.Text))
                {
                    txtUsuario.Focus();
                }
                else
                {
                    btnLogin_Click(e, null);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FmrLogin_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void FmrLogin_Click(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void FmrLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Esta a sair do programa, deseja processeguir", "Sair do programa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
               
            }
            else { Application.Exit(); }
        }
    }
}
