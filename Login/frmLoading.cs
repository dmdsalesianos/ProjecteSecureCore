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
    public partial class frmLoading : Form
    {

        private int tiempoTotal = 1000; 
        private int intervalo = 100; 
        private int incremento;
        private int userCategoryId;

        public frmLoading(int currentUserCategoryId)
        {
            InitializeComponent();

            this.userCategoryId = currentUserCategoryId;

            timer1.Interval = 100; 
            timer1.Start();

            incremento = progressBar1.Maximum / (tiempoTotal / intervalo);

            timer1.Interval = intervalo;
            timer1.Start();

            progressBar1.ForeColor = Color.Blue;
            progressBar1.Value = 0; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Value += incremento;

            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop(); 
                this.Hide();

                
                frmMenu menu_frm = new frmMenu(userCategoryId);
                menu_frm.Show();

                
            }
        }
    }
}
