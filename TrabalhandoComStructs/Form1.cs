using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhandoComStructs
{
    public partial class Form1 : Form
    {
        CarFeatures carFeatures = new CarFeatures
        {
            HasBluetooth = false,
            HasRearViewCamera = false,
            HasTractionControl = true,
            HasHeatedSeats = false,
            HasBlindSpotMonitoring = true,
            HasNavigationSystem = false
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerDetalhes_Click(object sender, EventArgs e)
        {
            RtTexto.Text = carFeatures.GetFeatures();
        }

        private void CkBluetooth_CheckedChanged(object sender, EventArgs e)
        {
            if (!CkBluetooth.Checked)
                carFeatures.HasBluetooth = CkBluetooth.Checked;
            else
                carFeatures.HasBluetooth |= CkBluetooth.Checked;
        }

        private void ckCamera_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckCamera.Checked)
                carFeatures.HasRearViewCamera = ckCamera.Checked;
            else
                carFeatures.HasRearViewCamera |= ckCamera.Checked;
        }
    }
}
