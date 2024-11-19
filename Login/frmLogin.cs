using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class frmLogin : Form
    {
        private const string InitialPassword = "12345aA"; // Contraseña inicial
        private int userAccessLevel = 0; // Nivel de acceso del usuario
        private int userId = 0; // ID del usuario (para obtener su categoría)

        public frmLogin()
        {
            InitializeComponent();
            textBox_password.UseSystemPasswordChar = true;
            Vision_button.Text = "◠";

            // Inicialmente ocultamos los campos de cambio de contraseña
            txtNewPassword.Visible = false;
            txtConfirmPassword.Visible = false;
            btnChangePassword.Visible = false;
            lblNewPassword.Visible = false;
            lblConfirmPassword.Visible = false;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username = textBox_user.Text;
            string password = textBox_password.Text;

            // Verificamos si el usuario existe y si la contraseña es correcta
            if (VerifyLogin(username, password))
            {
                // Si la contraseña no es la inicial, mostramos el mensaje de bienvenida
                Error_label.Visible = false;
                ShowWelcomeMessage();
                frmLoading Loading = new frmLoading();
                Loading.Show();
                this.Hide();

            }
            else
            {
                if (password == InitialPassword)
                {
                    // Si la contraseña es la inicial, mostramos los campos de cambio de contraseña
                    EnablePasswordChange();
                }
                Error_label.Visible = true; // Mostramos el mensaje de error si el usuario no existe
            }
        }

        private void EnablePasswordChange()
        {
            // Mostramos los campos para cambiar la contraseña
            MessageBox.Show("És necessari canviar la paraula de pas inicial.");
            txtNewPassword.Visible = true;
            txtConfirmPassword.Visible = true;
            btnChangePassword.Visible = true;
            lblNewPassword.Visible = true;
            lblConfirmPassword.Visible = true;
        }

        private byte[] ConvertSaltToBytes(string saltString)
        {
            // Eliminar los guiones del string
            saltString = saltString.Replace("-", "");

            // Convertir el string hexadecimal a un arreglo de bytes
            byte[] salt = new byte[saltString.Length / 2];

            for (int i = 0; i < saltString.Length; i += 2)
            {
                salt[i / 2] = Convert.ToByte(saltString.Substring(i, 2), 16); // Convertir de hexadecimal a byte
            }

            return salt;
        }

        private bool VerifyLogin(string username, string password)
        {
            bool isValid = false;
            string connectionString = ConfigurationManager.ConnectionStrings["ConexioStr"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT [idUser], [UserName], [Password], [Salt], [idUserCategory] FROM [Users] WHERE [Login] = @Login";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Login", username);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string storedPassword = reader["Password"].ToString();
                    string storedSaltString = reader["Salt"].ToString(); 
                    byte[] storedSalt = ConvertSaltToBytes(storedSaltString); 

                    userId = (int)reader["idUser"];
                    int userCategoryId = (int)reader["idUserCategory"];

                    

                    // Verificamos si la contraseña es correcta
                    if (VerifyPassword(password, storedPassword, storedSalt))
                    {
                        userAccessLevel = GetUserAccessLevel(userCategoryId);
                        isValid = true;
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado.");
                }
            }
            return isValid;
        }


        private bool VerifyPassword(string enteredPassword, string storedPassword, byte[] salt)
        {
            string hashedPassword = ComputeHash(enteredPassword, salt);
            return storedPassword == hashedPassword;
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

        private int GetUserAccessLevel(int userCategoryId)
        {
            int accessLevel = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["ConexioStr"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT [AccessLevel] FROM [UserCategories] WHERE [idUserCategory] = @userCategoryId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userCategoryId", userCategoryId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        accessLevel = (int)reader["AccessLevel"];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el nivel de acceso: " + ex.Message);
                }
            }
            return accessLevel;
        }

        private void ShowWelcomeMessage()
        {
            string welcomeMessage = $"Benvingut {textBox_user.Text}! Nivell d'accés: {userAccessLevel}." +
                                    "\nSeràs redirigit a l'aplicació principal en 5 segons.";
            MessageBox.Show(welcomeMessage);

            // Aquí rediriges a la pantalla principal si la validación es correcta
            frmLoading Loading = new frmLoading();
            Loading.Show();
            this.Hide();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Verificamos si las contraseñas coinciden
            if (newPassword == confirmPassword && IsValidPassword(newPassword))
            {
                byte[] salt = GenerateSalt();
                string hashedPassword = ComputeHash(newPassword, salt);

                // Aquí deberías actualizar la base de datos con la nueva contraseña (hashedPassword) y el salt generado
                string connectionString = ConfigurationManager.ConnectionStrings["ConexioStr"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string updateQuery = "UPDATE [Users] SET [Password] = @Password, [Salt] = @Salt WHERE [idUser] = @idUser";

                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@Password", hashedPassword);
                    command.Parameters.AddWithValue("@Salt", BitConverter.ToString(salt).Replace("-", "")); // Convertir salt a string sin guiones
                    command.Parameters.AddWithValue("@idUser", userId); // El id del usuario actual

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        HidePasswordChangeFields();
                        textBox_password.Clear(); // Limpiar el campo de la contraseña
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al actualizar la contraseña: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden o no son válidas.");
            }
        }


        private void HidePasswordChangeFields()
        {
            txtNewPassword.Visible = false;
            txtConfirmPassword.Visible = false;
            btnChangePassword.Visible = false;
            lblNewPassword.Visible = false;
            lblConfirmPassword.Visible = false;
        }

        private bool IsValidPassword(string password)
        {
            return password.Length >= 6; // Aquí puedes agregar más validaciones si es necesario
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

        private byte[] GenerateSalt()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[16];
                rng.GetBytes(salt);
                return salt;
            }
        }
    }
}
