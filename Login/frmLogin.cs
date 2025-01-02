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
using DataAccess;
using CustomControls;

namespace Login
{
    public partial class frmLogin : Form
    {
        private string connectionString;
        MantenimentDades manteniment;

        public frmLogin()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }
        public int CurrentUserCategoryId { get; set; }
        

        private int GetUserCategoryId(string username)
        {
            int userCategoryId = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryRank = @"
                    SELECT u.idUserCategory
                    FROM Users u
                    WHERE u.UserName = @username";


                SqlCommand command = new SqlCommand(queryRank, connection);
                command.Parameters.AddWithValue("@username", username);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    userCategoryId = Convert.ToInt32(reader["idUserCategory"]);
                }
            }

            return userCategoryId;


        }

        private void Login_Click(object sender, EventArgs e)
        {
            {
                string username = textBox_user.Text;
                string password = textBox_password.Text;


                if (password == "12345aA")
                {
                    frmChangePassword changePasswordForm = new frmChangePassword(username);
                    changePasswordForm.Show();
                    this.Hide();
                }
                else
                {

                    if (VerifyUser(username, password))
                    {
                        CurrentUserCategoryId = GetUserCategoryId(username);
                        //MessageBox.Show("ID UserCategory Guardada: " + CurrentUserCategoryId.ToString(), "Verificación");

                        frmLoading frmLoading = new frmLoading(CurrentUserCategoryId, username.ToUpperInvariant());
                        frmLoading.Show();
                        this.Close();
                    }
                    else
                    {
                        Error_label.Visible = true;
                    }
                }
            }
        }

        private bool VerifyUser(string username, string password)
        {

            bool isValidUser = false;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Password, Salt FROM Users WHERE UserName = @UserName";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", username);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedPasswordHash = reader["Password"].ToString();
                                string base64Salt = reader["Salt"].ToString();

                               
                                byte[] storedSalt = ConvertBase64ToBytes(base64Salt);
                                if (storedSalt == null)
                                {
                                    MessageBox.Show("Error: el salt almacenado no es válido.");
                                    return false;
                                }

                                
                                string enteredPasswordHash = ComputeHash(password, storedSalt);

                                
                                if (storedPasswordHash == enteredPasswordHash)
                                {
                                    isValidUser = true;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al verificar la contraseña: {ex.Message}");
                }
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
                Login_Click(sender, e);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConexioStr"].ConnectionString;
            manteniment = new MantenimentDades(connectionString);
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
