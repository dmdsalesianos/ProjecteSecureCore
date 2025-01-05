using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login
{
    public partial class frmChangePassword : Form
    {
        private string login;
        MantenimentDades manteniment;
        private string connectionString;


        public frmChangePassword(string login)
        {
            InitializeComponent();
            this.login = login;

        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConexioStr"].ConnectionString;
            manteniment = new MantenimentDades(connectionString);
            Centrar();
        }

        private void Centrar()
        {
            int frmHeight = Height;
            int frmWidth = Width;

            int pnlLoginHeight = pnlPass.Height;
            int pnlLoginWidth = pnlPass.Width;

            int newPnlLoginHeight = (frmHeight - pnlLoginHeight) / 3;
            int newPnlLoginWidth = (frmWidth - pnlLoginWidth) / 2;

            pnlPass.Location = new Point(newPnlLoginWidth, newPnlLoginHeight);


        }


        private void rjbtnSave_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;


            if (newPassword == confirmPassword && IsValidPassword(newPassword))
            {

                byte[] newSalt = GenerateSalt();


                string hashedPassword = ComputeHash(newPassword, newSalt);


                SetNewPassword(hashedPassword, newSalt);

                MessageBox.Show("Contraseña cambiada exitosamente.");
                this.Close();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
            }
            else
            {
                lblErrorMessage.Visible = true;
            }
        }

        private bool IsValidPassword(string password)
        {
            if (password.Length >= 6)
            {
                lblErrorMessage.Text = "Wrong password or Confirm pass";
            }
            else
            {
                lblErrorMessage.Text = "Se necessita mas de 6 caracteres";
            }
            return password.Length >= 6;
        }

        private byte[] GenerateSalt()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[16]; 
                rng.GetBytes(salt);
                return salt;
            }
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

        private void SetNewPassword(string hashedPassword, byte[] salt)
        {

            string base64Salt = Convert.ToBase64String(salt);

            string query = "UPDATE Users " +
                           $"SET Password = '{hashedPassword}', Salt = '{base64Salt}' " +
                           $"WHERE Login = '{login}'";

            try
            {
                manteniment.Executa(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la contraseña en la base de datos: {ex.Message}");
            }
            

        }

        private void btnShowNewPassword_Click(object sender, EventArgs e)
        {
            
            if (txtNewPassword.UseSystemPasswordChar)
            {
                txtNewPassword.UseSystemPasswordChar = false;
                btnShowNewPassword.Text = "👁";
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = true;
                btnShowNewPassword.Text = "◠";
            }
        }

        private void btnShowConfirmPassword_Click(object sender, EventArgs e)
        {

            if (txtConfirmPassword.UseSystemPasswordChar)
            {
                txtConfirmPassword.UseSystemPasswordChar = false;
                btnShowConfirmPassword.Text = "👁";
            }
            else
            {
                txtConfirmPassword.UseSystemPasswordChar = true;
                btnShowConfirmPassword.Text = "◠";
            }
        }

        

        private void txtConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rjbtnSave_Click(sender, e);
            }
        }
        private void txtNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rjbtnSave_Click(sender, e);
            }
        }

        private void rjbtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
