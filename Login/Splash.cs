using System;
using System.Windows.Forms;

namespace Login
{

    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            timer1.Interval = 4600; 
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop(); 
            frmLogin loginForm = new frmLogin(); 
            loginForm.Show(); 
            this.Hide();
            
        }
    }

}
