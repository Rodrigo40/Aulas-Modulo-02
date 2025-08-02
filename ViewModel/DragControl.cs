using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices; // Necessário para importar funções da API do Windows

namespace RRZCControls
{
    public class DragControl
    {
        // Variáveis para rastrear a posição do mouse e se o arraste está ativo
        private bool mouseDown = false;
        private Point lastLocation;
        private Control targetControl; // O controle que irá disparar o arraste
        private Form parentForm;      // O formulário que será movido

        // Construtor padrão
        public DragControl()
        {
        }

        // Método para tornar um controle arrastável
        public void SelectControl(Control control)
        {
            targetControl = control;
            parentForm = control.FindForm(); // Encontra o formulário pai do controle

            if (parentForm == null)
            {
                throw new InvalidOperationException("O controle deve estar em um formulário para ser arrastável.");
            }

            // Adiciona os manipuladores de evento do mouse ao controle alvo
            targetControl.MouseDown += new MouseEventHandler(this.Control_MouseDown);
            targetControl.MouseMove += new MouseEventHandler(this.Control_MouseMove);
            targetControl.MouseUp += new MouseEventHandler(this.Control_MouseUp);
        }

        // Manipulador de evento MouseDown
        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                lastLocation = e.Location; // Salva a posição inicial do mouse
            }
        }

        // Manipulador de evento MouseMove
        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                // Calcula a nova posição do formulário
                parentForm.Location = new Point(
                    (parentForm.Location.X - lastLocation.X) + e.X,
                    (parentForm.Location.Y - lastLocation.Y) + e.Y);

                // Atualiza o formulário para evitar "rastros" visuais
                parentForm.Update();
            }
        }

        // Manipulador de evento MouseUp
        private void Control_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

    }
}
