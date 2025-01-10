using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using CustomControls;
using System.IO;

namespace Login
{
    public partial class frmMenu : Form
    {
        string IconImagesDirectory = Path.Combine(Application.StartupPath, "imatges", "iconos");
        string UserImagesDirectory = Path.Combine(Application.StartupPath, "imatges", "usuarios");
        string UserNameM;

        private MantenimentDades manteniment;
        private string connectionString;
        private DataSet dsUser;
        private bool isDarkMode = false;
        private Dictionary<Control, (Color BackColor, Color ForeColor)> originalColors = new Dictionary<Control, (Color, Color)>();

        public frmMenu(DataSet dsUser)
        {
            InitializeComponent();
            DoubleBuffered = true;

            this.dsUser = dsUser;
            UserNameM = dsUser.Tables[0].Rows[0]["Login"].ToString().ToUpper();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConexioStr"].ConnectionString;
            manteniment = new MantenimentDades(connectionString);

            lblName.Text = UserNameM;

            string fileName = dsUser.Tables[0].Rows[0]["Photo"].ToString();

            if (fileName != null)
            {
                string fileLocation = Path.Combine(UserImagesDirectory, fileName);

                if (File.Exists(fileLocation))
                {
                    rndpicUser.ImageLocation = fileLocation;
                }
                else
                {
                    rndpicUser.ImageLocation = null;
                }
            }

            ButonForms();

            foreach (Control control in this.Controls)
            {
                // Verifica si el control es uno de los tipos especificados
                
                    // Guardamos tanto el BackColor como el ForeColor en una tupla
                    originalColors[control] = (control.BackColor, control.ForeColor); // Guardamos la tupla de colores
                
            }


        }


        private void ButonForms()
        {
            int idUser = int.Parse(dsUser.Tables[0].Rows[0]["idUser"].ToString());

            string query = "SELECT mo.* " +
                           "FROM MenuOptions mo, UserCategories uc, Users u " +
                           "WHERE u.idUserCategory = uc.idUserCategory " +
                           "AND mo.AccessLevel <= uc.AccessLevel " +
                           $"AND u.idUser = {idUser}";

            DataSet dsMenuOptions = manteniment.PortarPerConsulta(query);

            foreach (DataRow row in dsMenuOptions.Tables[0].Rows)
            {
                // Creamos un nuevo botón de menú
                MenuButton btn = new MenuButton();

                // Asignamos las propiedades del botón con los valores de la fila
                btn.TargetPanel = pnlContenido;
                btn.LabelText = row["Texto"].ToString();  // Asignamos el nombre de la opción
                btn.Clase = row["Clase"].ToString();
                btn.Form = row["Form"].ToString(); // Asignamos la clase
                btn.RutaImagen = Path.Combine(IconImagesDirectory, row["Icono"].ToString());
                btn.BottomBorderColor = Color.White;
                // Obtén el valor del color desde la fila
                string colorValue = row["Color"].ToString();

                // Verifica si es un nombre de color
                if (Color.FromName(colorValue).IsKnownColor)
                {
                    // Es un nombre de color conocido
                    btn.BackColor = Color.FromName(colorValue);
                    btn.ColorOri = Color.FromName(colorValue);
                }
                else
                {
                    // Intenta procesarlo como RGB separado por punto y coma
                    try
                    {
                        // Divide el valor en componentes R, G, B
                        string[] rgb = colorValue.Split(';');
                        int r = int.Parse(rgb[0].Trim());
                        int g = int.Parse(rgb[1].Trim());
                        int b = int.Parse(rgb[2].Trim());

                        // Asigna el color RGB
                        btn.BackColor = Color.FromArgb(r, g, b);
                        btn.ColorOri = Color.FromArgb(r, g, b);
                    }
                    catch
                    {
                        // En caso de error, asignar un color predeterminado
                        btn.BackColor = Color.FromArgb(36, 144, 241);
                        btn.ColorOri = Color.FromArgb(36, 144, 241);

                    }
                } // Asignamos el color de fondoç


                pnlMenu.Dock = DockStyle.Left;  // O DockStyle.Fill si deseas que ocupe todo el espacio disponible
                pnlMenu.FlowDirection = FlowDirection.TopDown;  // Esto hará que los botones se apilen verticalmente
                pnlMenu.WrapContents = false;
                pnlMenu.Width = btn.Width + 18;

                // Lo añadimos al panel del formulario principal (en este caso 'targetPanel')
                pnlMenu.Controls.Add(btn);

            }
        }

        private void rjbtnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();

            Close();
        }

        private void rjbtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlLogo_Click(object sender, EventArgs e)
        {
            pnlContenido.Controls.Clear();
            foreach (MenuButton btn in pnlMenu.Controls)
            {
                btn.BorderStyle = BorderStyle.None;
                if (btn.BackColor != btn.ColorOri)
                {
                    btn.BackColor = btn.ColorOri;
                }

            }
        }
        private void pibLogoName_Click_1(object sender, EventArgs e)
        {
            pnlContenido.Controls.Clear();
            foreach (MenuButton btn in pnlMenu.Controls)
            {
                btn.BorderStyle = BorderStyle.None;
                if (btn.BackColor != btn.ColorOri)
                {
                    btn.BackColor = btn.ColorOri;
                }
            }
        }

        private void picLogo_Click_1(object sender, EventArgs e)
        {
            pnlContenido.Controls.Clear();
            foreach (MenuButton btn in pnlMenu.Controls)
            {
                btn.BorderStyle = BorderStyle.None;
                if (btn.BackColor != btn.ColorOri)
                {
                    btn.BackColor = btn.ColorOri;
                }
            }
        }

        private void rndpicUser_Click(object sender, EventArgs e)
        {
            frmImageZoom frmZoom = new frmImageZoom(rndpicUser);

            frmZoom.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;
            SetMode(this); // Llamamos al método SetMode con el formulario principal
        }

        private void SetMode(Control parentControl)
        {
            if (isDarkMode)
            {
                // Almacenar los colores originales si aún no están almacenados
                if (!originalColors.ContainsKey(parentControl))
                {
                    originalColors[parentControl] = (parentControl.BackColor, parentControl.ForeColor);
                }

                // Cambiar los colores al modo oscuro
                parentControl.BackColor = Color.FromArgb(30, 30, 30); // Fondo oscuro
                parentControl.ForeColor = Color.White; // Texto blanco

                foreach (Control control in parentControl.Controls)
                {
                    if (!originalColors.ContainsKey(control)) // Almacenar colores originales si no están
                    {
                        originalColors[control] = (control.BackColor, control.ForeColor);
                    }

                    // Excluir controles específicos como TextBox, Button, etc.
                    if (control is TextBox || control is Button || control is RoundedPictureBox)
                    {
                        continue;
                    }

                    // Cambiar el fondo de Labels, Panels, etc.
                    if (control is Label || control is Panel)
                    {
                        control.BackColor = Color.FromArgb(50, 50, 50); // Fondo oscuro para estos controles
                        control.ForeColor = Color.White; // Texto blanco
                    }

                    // Cambiar el estilo de DataGridView para modo oscuro
                    if (control is DataGridView dataGridView)
                    {
                        dataGridView.BackgroundColor = Color.FromArgb(18, 18, 18); // Fondo azul oscuro
                        dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30); // Fondo de celdas oscuro
                        dataGridView.DefaultCellStyle.ForeColor = Color.White; // Texto blanco
                        dataGridView.GridColor = Color.FromArgb(80, 80, 80); // Color de la cuadrícula
                    }

                    // Recursión para los controles dentro de otros formularios o user controls
                    if (control.Controls.Count > 0)
                    {
                        SetMode(control); // Recursión para los controles dentro de este control
                    }
                }
            }
            else
            {
                // Restaurar los colores originales
                if (originalColors.ContainsKey(parentControl))
                {
                    parentControl.BackColor = originalColors[parentControl].BackColor;
                    parentControl.ForeColor = originalColors[parentControl].ForeColor;
                }

                foreach (Control control in parentControl.Controls)
                {
                    // Restaurar colores originales para cada control
                    if (originalColors.ContainsKey(control))
                    {
                        control.BackColor = originalColors[control].BackColor;
                        control.ForeColor = originalColors[control].ForeColor;
                    }

                    // Excluir controles específicos como TextBox, Button, etc.
                    if (control is TextBox || control is Button)
                    {
                        continue;
                    }

                    lblName.BackColor = Color.RoyalBlue;
                    picLogo.BackColor = Color.RoyalBlue;
                    pibLogoName.BackColor = Color.RoyalBlue;
                    pnlUserInfo.BackColor = Color.RoyalBlue;

                    // Restaurar DataGridView al estilo original
                    if (control is DataGridView dataGridView)
                    {
                        dataGridView.BackgroundColor = SystemColors.Control; // Fondo original
                        dataGridView.DefaultCellStyle.BackColor = SystemColors.Window; // Fondo de celdas original
                        dataGridView.DefaultCellStyle.ForeColor = SystemColors.ControlText; // Texto negro original
                        dataGridView.GridColor = SystemColors.ControlDark; // Color de cuadrícula original
                    }

                    // Recursión para los controles dentro de otros formularios o user controls
                    if (control.Controls.Count > 0)
                    {
                        SetMode(control); // Recursión para los controles dentro de este control
                    }
                }
            }
        }



        private void rndpicUser_MouseHover(object sender, EventArgs e)
        {
            frmImageZoom frmZoom = new frmImageZoom(rndpicUser);

            frmZoom.Show();
        }
    }
}
