using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Models;

namespace Views
{
    public partial class InputBox : Form
    {
        public string Valor { get; set; }
        public InputBox()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInput.Text))
            {
                InputModel model = new InputModel();
                model.ReceivedValue = txtInput.Text;

                InputControl control = new InputControl();
                this.Valor = control.GetValue(model);

                this.Close();
            }
            else
            {
                RRZC_MensageBox.sms_erro.Enviar_Mensagem("Digite um valor primeiro","Ops");
            }

        }
    }
}
