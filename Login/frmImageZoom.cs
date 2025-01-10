using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmImageZoom : Form
    {
        public frmImageZoom(PictureBox pictureBox)
        {
            InitializeComponent();
            pictureBox1.Image = pictureBox.Image;

            this.Opacity = 0.2;

            AnimateForm(true);

        }

        private void frmImageZoom_Load(object sender, EventArgs e)
        {
            Centrar();
        }

        private async void AnimateForm(bool open)
        {
            if (open)
            {
                for (double i = 0.1; i <= 1.0; i += 0.05) // Aumentar opacidad gradualmente
                {
                    this.Opacity = i;
                    await Task.Delay(5); // Delay para hacer el efecto más fluido
                }
            }
        }

        private void Centrar()
        {
            // Calcular las coordenadas para centrar el PictureBox
            int x = (this.ClientSize.Width - pictureBox1.Width) / 2;
            int y = (this.ClientSize.Height - pictureBox1.Height) / 2;

            // Asignar la nueva ubicación al PictureBox
            pictureBox1.Location = new Point(x, y);
        }

        private void frmImageZoom_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
