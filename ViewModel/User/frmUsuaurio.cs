using ControllerV;
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
    public partial class frmUsuaurio : Form
    {
        public frmUsuaurio()
        {
            InitializeComponent();
            DragControl drag = new DragControl();
            drag.SelectControl(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmUsuaurio_Load(object sender, EventArgs e)
        {
            UserController u = new UserController();
            DataLista.DataSource = await u.GetUsers();
            DataLista.Columns["id"].Visible = false;
            DataLista.Columns["password"].Visible = false;
            DataLista.Columns["nome"].HeaderText="Nome";
        }
    }
}
