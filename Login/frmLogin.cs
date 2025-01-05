using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using DataAccess;
using System.Drawing;
using System.Threading;
using CustomControls;

namespace Login
{
    public partial class frmLogin : Form
    {
        private string connectionString;
        MantenimentDades manteniment;
        DataSet dsUser = new DataSet();

        private int tiempoTotal = 1000;
        private int intervalo = 100;
        private int incremento;
        private int dotCount = 0;


        public frmLogin()
        {
            InitializeComponent();
            DoubleBuffered = true;
            pnlLogin.Visible = true;
            pnlLoading.Visible = false;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConexioStr"].ConnectionString;
            manteniment = new MantenimentDades(connectionString);
            Centrar();
        }

        private void frmLogin_SizeChanged(object sender, EventArgs e)
        {
            Centrar();
        }

        private void Centrar()
        {
            int frmHeight = Height;
            int frmWidth = Width;

            int pnlLoginHeight = pnlLogin.Height;
            int pnlLoginWidth = pnlLogin.Width;
            int pnlLoadingHeight = pnlLoading.Height;
            int pnlLoadingWidth = pnlLoading.Width;

            int newPnlLoginHeight = (frmHeight - pnlLoginHeight) / 3;
            int newPnlLoginWidth = (frmWidth - pnlLoginWidth) / 2;

            int newPnlLoadingHeight = (frmHeight - pnlLoadingHeight) / 3;
            int newPnlLoadingWidth = (frmWidth - pnlLoadingWidth) / 2;

            pnlLogin.Location = new Point(newPnlLoginWidth, newPnlLoginHeight);
            pnlLoading.Location = new Point(newPnlLoadingWidth, newPnlLoadingHeight);

        }

        private void rjbtnLogin_Click(object sender, EventArgs e)
        {
            string login = textBox_user.Text;
            string password = textBox_password.Text;

            Dictionary<string, string> criterios = new Dictionary<string, string>
            {
                { "Login", login }
            };

            dsUser = manteniment.GeneraConsultaCerca("Users", criterios);

            // Verificar si se encontró algún resultado
            if (dsUser.Tables[0].Rows.Count > 0)
            {
                if (password == "12345aA")
                {
                    frmChangePassword changePasswordForm = new frmChangePassword(login);
                    changePasswordForm.Show();
                    this.Hide();

                    Close();
                }
                else
                {
                    bool verify = VerifyUser(dsUser.Tables[0].Rows[0]["Password"].ToString(), dsUser.Tables[0].Rows[0]["Salt"].ToString(), password);

                    if (verify)
                    {
                        //frmLoading frmLoading = new frmLoading(dsUser);
                        //frmLoading.Show();
                        //Close();

                        MostrarLoading();
                       
                    }
                    else
                    {
                        Error_label.Visible = true;
                    }

                }
            }
            else
            {
                Error_label.Visible = true;
            }

        }

        private bool VerifyUser(string password, string salt, string introducedPass)
        {

            bool isValidUser = false;

            byte[] saltByte = ConvertBase64ToBytes(salt);
            string enteredPasswordHash = ComputeHash(introducedPass, saltByte);

            if (enteredPasswordHash == password)
            {
                isValidUser = true;
            }
            

            return isValidUser;

        }

        private string ComputeHash(string password, byte[] salt)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] saltedPassword = Encoding.UTF8.GetBytes(password);
                byte[] saltedPasswordWithSalt = new byte[saltedPassword.Length + salt.Length];
                Buffer.BlockCopy(salt, 0, saltedPasswordWithSalt, 0, salt.Length);
                Buffer.BlockCopy(saltedPassword, 0, saltedPasswordWithSalt, salt.Length, saltedPassword.Length);

                byte[] hashBytes = sha256.ComputeHash(saltedPasswordWithSalt);
                return Convert.ToBase64String(hashBytes);
            }
        }
        private byte[] ConvertBase64ToBytes(string base64Salt)
        {
            try
            {
                return Convert.FromBase64String(base64Salt);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Error al convertir el Salt desde Base64: {ex.Message}");
                return null;
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

        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rjbtnLogin_Click(sender, e);
            }
        }
        private void textBox_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rjbtnLogin_Click(sender, e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rjProgressBar.Value += incremento;

            dotCount = (dotCount + 1) % 4;
            lblLoadingMessage.Text = "Cooking" + new string('.', dotCount);


            if (rjProgressBar.Value >= rjProgressBar.Maximum)

            {
                timer1.Stop();
                this.Close();

                frmMenu menu_frm = new frmMenu(dsUser);
                menu_frm.Show();
            }
        }
        
        private void MostrarLoading()
        {
            pnlLogin.Visible = false;


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
            lblLoadingMessage.BackColor = Color.Transparent;

            pnlLoading.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
