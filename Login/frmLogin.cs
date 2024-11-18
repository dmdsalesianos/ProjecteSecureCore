using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmLogin : Form
    {
        private const string InitialPassword = "12345aA"; // Paraula de pas inicial
        private int userAccessLevel = 0; // Nivell d'accés de l'usuari

        public frmLogin()
        {
            InitializeComponent();
            textBox_password.UseSystemPasswordChar = true;
            Vision_button.Text = "◠";

            // Camps per al canvi de paraula de pas estan ocults al principi
            //txtNewPassword.Visible = false;
            //txtConfirmPassword.Visible = false;
            //btnChangePassword.Visible = false;
            //lblNewPassword.Visible = false;
            //lblConfirmPassword.Visible = false;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string usuario = textBox_user.Text.ToString();
            string contras = textBox_password.Text.ToString();

            if (usuario.Equals("Joel") && contras.Equals(InitialPassword))
            {
                EnablePasswordChange();
            }
            else if (VerifyLogin(usuario, contras))
            {
                Error_label.Visible = false;
                ShowWelcomeMessage();
                frmLoading Loading = new frmLoading();
                Loading.Show();
                this.Hide();
            }
            else
            {
                Error_label.Visible = true;
            }
        }

        private void EnablePasswordChange()
        {
            MessageBox.Show("És necessari canviar la paraula de pas inicial.");
        //    txtNewPassword.Visible = true;
        //    txtConfirmPassword.Visible = true;
        //    btnChangePassword.Visible = true;
        //    lblNewPassword.Visible = true;
        //    lblConfirmPassword.Visible = true;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            //string newPassword = txtNewPassword.Text;
            //string confirmPassword = txtConfirmPassword.Text;

            //if (newPassword == confirmPassword && IsValidPassword(newPassword))
            //{
            //    byte[] salt = GenerateSalt();
            //    string hashedPassword = ComputeHash(newPassword, salt);

            //    // Emmagatzema hashedPassword i salt a la base de dades

            //    MessageBox.Show("Paraula de pas canviada amb èxit! Ara pots entrar amb la nova paraula de pas.");
            //    HidePasswordChangeFields();

            //    textBox_password.Clear();
            //}
            //else
            //{
            //    MessageBox.Show("Les paraules de pas no coincideixen o no són vàlides.");
            //}
        }

        private bool VerifyLogin(string username, string password)
        {
            // Verificació simulada per al propòsit de l'exemple.
            if (username == "Joel" && password != InitialPassword)
            {
                userAccessLevel = GetUserAccessLevel(username);
                return true;
            }
            return false;
        }

        private void ShowWelcomeMessage()
        {
            string welcomeMessage = $"Benvingut {textBox_user.Text}! Nivell d'accés: {userAccessLevel}." +
                                    "\nSeràs redirigit a l'aplicació principal en 5 segons.";
            MessageBox.Show(welcomeMessage);
        }

        private void HidePasswordChangeFields()
        {
            //txtNewPassword.Visible = false;
            //txtConfirmPassword.Visible = false;
            //btnChangePassword.Visible = false;
            //lblNewPassword.Visible = false;
            //lblConfirmPassword.Visible = false;
        }

        private bool IsValidPassword(string password)
        {
            return password.Length >= 6; // Aquí pots afegir més validacions si cal
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

        private int GetUserAccessLevel(string username)
        {
            // Funció simulada per obtenir el nivell d'accés
            return 1; // Assignar el nivell d'accés segons les dades
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
