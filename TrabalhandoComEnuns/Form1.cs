using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhandoComEnuns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarregarDias_Click(object sender, EventArgs e)
        {
            if (cmbDias.Items.Count != -1)
            {
                foreach (var item in Enum.GetNames(typeof(DiasSemana)))
                {
                    cmbDias.Items.Add(item);
                }
            }
        }

        private void cmbDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDias.SelectedIndex != -1)
            {
                lbItemSeleciolnado.Text = cmbDias.SelectedItem.ToString();
                if (cmbDias.SelectedItem.ToString() == DiasSemana.Segunda.ToString())
                {
                    lbItemSeleciolnado.Text = "Dia de trabalho Yha!, vai trabalhar preguiçoso!";
                }
            }
        }
    }
}
