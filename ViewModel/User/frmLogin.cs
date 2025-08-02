using ControllerV;
using Model;
using RRZCControls;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            DragControl drag = new DragControl();
            drag.SelectControl(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Cadastro de Venda", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserModel u = new UserModel()
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text,
            };

            UserController c = new UserController();
            var user = c.Login(u);
            if (user != null)
            {
                frmHome home = new frmHome(user);
                home.ShowDialog();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            UserController user = new UserController();
            user.VerificaUsers();
        }
    }
}
