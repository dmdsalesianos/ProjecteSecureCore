using CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using System.Configuration;

namespace Login
{
    public partial class frmLoading : Form
    {
        //ANTES HABIAN 5000 ms
        private int tiempoTotal = 1000;
        private int intervalo = 100;
        private int incremento;
        DataSet dsUser = new DataSet();        

        private int dotCount = 0;

        public frmLoading(DataSet ds)
        {
            InitializeComponent();

            this.dsUser = ds;

            timer1.Interval = intervalo;
            timer1.Start();

            //Configuración del RJProgressBar
            incremento = rjProgressBar.Maximum / (tiempoTotal / intervalo);
            rjProgressBar.Value = 0;
            rjProgressBar.ChannelColor = ColorTranslator.FromHtml("#232F5F");   // Color del canal de fondo
            rjProgressBar.SliderColor = ColorTranslator.FromHtml("#2490F1");   // Color del progreso
            rjProgressBar.ForeBackColor = Color.Transparent;              // Fondo del texto transparente
            rjProgressBar.ShowValue = TextPosition.None;                  // No mostrar porcentaje


            lblLoadingMessage.ForeColor = ColorTranslator.FromHtml("#2490F1");
            lblLoadingMessage.BackColor = Color.Transparent;                  // Transparencia en el texto
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            Centrar();
        }

        private void Centrar()
        {
            int frmHeight = Height;
            int frmWidth = Width;

            int gboxHeight = panel1.Height;
            int gboxWidth = panel1.Width;

            int newHeight = (frmHeight - gboxHeight) / 3;
            int newWidth = (frmWidth - gboxWidth) / 2;

            panel1.Location = new Point(newWidth, newHeight);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rjProgressBar.Value += incremento;

            dotCount = (dotCount + 1) % 4;
            lblLoadingMessage.Text = "Cooking" + new string('.', dotCount);


            if(rjProgressBar.Value >= rjProgressBar.Maximum)

            {
                timer1.Stop();
                this.Hide();

                frmMenu menu_frm = new frmMenu(dsUser);
                menu_frm.Show();
            }
        }

        
    }
}
