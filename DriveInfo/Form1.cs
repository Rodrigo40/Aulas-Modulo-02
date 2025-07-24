using System;
using System.Windows.Forms;
using System.IO;

namespace DriveInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListarDiscos_Click(object sender, EventArgs e)
        {
          
            foreach (var item in System.IO.Directory.GetLogicalDrives())
            {
                LvLista.Items.Add(item);
            }
        }
    }
}
