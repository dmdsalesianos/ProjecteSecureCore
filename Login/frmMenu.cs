using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestioDeUsuaris;

namespace Login
{
    public partial class frmMenu : Form
    {
        private string nombreUsuario;

        public frmMenu(int usetrCategory)
        {
            InitializeComponent();
            //this.nombreUsuario = usuario;
            //textBox1.Text = nombreUsuario;

        }

        private void button_logaout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();

            this.Hide();
            
        }

        private void button_Man_species_Click(object sender, EventArgs e)
        {
            //frm_Man_species Manteniment_Species = new frm_Man_species();
                        
            //CargarFormularioEnPanel(Manteniment_Species);
        }

        

        private void Enter_Mouse(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            boton.BackColor = Color.DeepSkyBlue;      
                
        }

        private void Leave_Mouse(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            boton.BackColor = Color.DodgerBlue;  
               
        }

        

        
    }
}
