using System;
using System.Configuration;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using DataAccess;
using System.Drawing;
using CustomControls;
using System.IO;

namespace Login
{
    public partial class frmLogin : Form
    {
        private string connectionString;
        MantenimentDades manteniment;
        DataSet dsUser = new DataSet();

        private int tiempoTotal = 5000;
        private int intervalo = 100;
        private int incremento;
        private int dotCount = 0;

        string imagesDirectory = Path.Combine(Application.StartupPath, "imatges", "usuarios");

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
            CentrarPanel();
        }

        private void frmLogin_SizeChanged(object sender, EventArgs e)
        {
            CentrarPanel();
        }

        private void CentrarPanel()
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
            string loginTxt = textBox_user.Text;
            string passwordTxt = textBox_password.Text;

            string query = "SELECT * " +
                           "FROM Users " +
                           $"WHERE Login = '{loginTxt}' COLLATE SQL_Latin1_General_CP1_CS_AS";

            dsUser = manteniment.PortarPerConsulta(query);

            // Verificar si se encontró algún resultado
            if (dsUser.Tables[0].Rows.Count > 0)
            {
                string passwordBBD = dsUser.Tables[0].Rows[0]["Password"].ToString();

                if (passwordBBD == "12345aA" && passwordTxt == "12345aA")
                {
                    frmChangePassword changePasswordForm = new frmChangePassword(loginTxt);
                    changePasswordForm.Show();
                    this.Hide();

                    Close();
                }
                else
                {
                    string saltBBD = dsUser.Tables[0].Rows[0]["Salt"].ToString();

                    bool verify = VerifyUser(passwordBBD, saltBBD, passwordTxt);

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
            rjProgressBar.SliderColor = Color.White;   // Color del progreso
            rjProgressBar.ForeBackColor = Color.Transparent;              // Fondo del texto transparente
            rjProgressBar.ShowValue = TextPosition.None;                  // No mostrar porcentaje

            lblName.Text = $"{dsUser.Tables[0].Rows[0]["UserName"]}";

            string query = "SELECT [DescCategory] " +
                           "FROM [UserCategories] " +
                           $"WHERE [idUserCategory] = {dsUser.Tables[0].Rows[0]["idUserCategory"]}";

            DataSet ds = manteniment.PortarPerConsulta(query);

            lblUserCategory.Text = $"{ds.Tables[0].Rows[0]["DescCategory"]}";

            CentrarLabel();

            imgUser.ImageLocation = Path.Combine(imagesDirectory, dsUser.Tables[0].Rows[0]["Photo"].ToString());

            pnlLoading.Visible = true;
        }

        private void CentrarLabel()
        {
            // Obtener el ancho del panel
            int pnlLoadingWidth = pnlLoading.Width;

            // Obtener el ancho de cada label
            int lblNameWidth = lblName.Width;
            int lblUserCategoryWidth = lblUserCategory.Width;

            // Calcular la posición Left para centrar lblName
            lblName.Left = (pnlLoadingWidth - lblNameWidth) / 2;

            // Calcular la posición Left para centrar lblUserCategory
            lblUserCategory.Left = (pnlLoadingWidth - lblUserCategoryWidth) / 2;

            // Si quieres que también estén centrados uno debajo del otro,
            // ajusta las propiedades Top para evitar que se solapen.
            lblUserCategory.Top = lblName.Bottom + 10; // Separación de 10 píxeles
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword changePasswordForm = new frmChangePassword(textBox_user.Text);
            changePasswordForm.Show();
            this.Hide();

            Close();
        }

        private void lblChangePassword_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                // Aplica el subrayado manteniendo la fuente original
                label.Font = new Font("Arial Rounded MT Bold", 8.25f, FontStyle.Underline);
                label.Cursor = Cursors.Hand; // Cambia el cursor a mano
            }
        }

        private void lblChangePassword_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                // Restaura la fuente original
                label.Font = new Font("Arial Rounded MT Bold", 8.25f, FontStyle.Regular);
                label.Cursor = Cursors.Default; // Cambia el cursor a predeterminado
            }
        }
    }
}
