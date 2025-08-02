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
using ViewModel.User;

namespace ViewModel
{
    public partial class frmHome : Form
    {
        public frmHome(UserModel user)
        {
            InitializeComponent();
            DragControl control=new DragControl();
            control.SelectControl(this);

            if (user != null )
                usuarioToolStripMenuItem.Text=$"Olá {user.Nome}!";
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Cadastro de Venda", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Cadastro de Venda", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmCadastrar cd=new frmCadastrar())
            {
                cd.ShowDialog();
            }
        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmUsuaurio u=new frmUsuaurio())
            {
                u.ShowDialog();
            }
        }
    }
}
