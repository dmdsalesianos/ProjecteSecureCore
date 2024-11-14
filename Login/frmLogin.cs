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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            textBox_password.UseSystemPasswordChar = true;
            Vision_button.Text = "◠";

            
        }

        private void Login_Click(object sender, EventArgs e)
        {

            String usuario = textBox_user.Text.ToString();
            String contras = textBox_password.Text.ToString();

            if (usuario.Equals("Joel") && contras.Equals("12345aA"))
            {
                Error_label.Visible = false;
                frmLoading Loading = new frmLoading();
                Loading.Show();

                this.Hide();
                
            } 
            else
            {
                Error_label.Visible = true;
            }
        }

        private void Visible_button(object sender, EventArgs e)
        {
            if (textBox_password.UseSystemPasswordChar)
            {
                textBox_password.UseSystemPasswordChar = false;
                Vision_button.Text = "👁";
            }
            else
            {
                textBox_password.UseSystemPasswordChar = true;
                Vision_button.Text = "◠";
            }
        }
    }
}
