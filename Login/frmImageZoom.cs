using System;
using System.Drawing;
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

        private void frmImageZoom_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
