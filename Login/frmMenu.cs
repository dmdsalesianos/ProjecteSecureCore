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
    public partial class frmMenu : Form
    {
        

        public frmMenu(/*String usuario*/)
        {
            InitializeComponent();
            
            
            
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

        private void button_Man_User_Click(object sender, EventArgs e)
        {
            //frm_Man_Usuari Manteniment_Usuari = new frm_Man_Usuari();

            //CargarFormularioEnPanel(Manteniment_Usuari);
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

        private void CargarFormularioEnPanel(Form formulario)
        {
            //Liampiar panel
            if (PanelContenido.Controls.Count > 0)
            {
                PanelContenido.Controls.RemoveAt(0);
            }
                

            formulario.TopLevel = false; 
            formulario.FormBorderStyle = FormBorderStyle.None; 
            formulario.Dock = DockStyle.Fill; 
                        
            PanelContenido.Controls.Add(formulario);
            PanelContenido.Tag = formulario;
            formulario.Show();
        }
    }
}
