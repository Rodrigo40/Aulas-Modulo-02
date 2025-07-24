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
    public partial class Frm_Splesh : Form
    {
        public Frm_Splesh()
        {
            InitializeComponent();
        }

        private void Frm_Splesh_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pnProg.Width <= 431 && progressBar1.Value <= 100)
            {
                pnProg.Width += 10;
                progressBar1.Value += 2;
            }
            else
            {
                timer1.Enabled = false;
                timer1.Dispose();
                FmrLogin frm = new FmrLogin();
                frm.Show();
                this.Hide();
            }
        }
    }
}
