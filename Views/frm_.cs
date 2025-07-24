using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class frm_ : Form
    {
        public frm_()
        {
            InitializeComponent();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            using (InputBox inputBox=new InputBox())
            {
                inputBox.ShowDialog();
                lbResultado.Text = inputBox.Valor;
            }
        }
    }
}
