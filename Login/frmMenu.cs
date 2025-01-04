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
        public DataSet MyProperty
        {
            get { return dsUser; }
            set { dsUser = value; }
        }


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

            label_name.Text = UserNameM;

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
        }

        private void button_logaout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();

            Close();
        }

        private void ButonForms()
        {
            int UserRankId = int.Parse(dsUser.Tables[0].Rows[0]["idUserRank"].ToString());

            string query = "SELECT * " +
                           "FROM MenuOptionsPrueba " +
                           $"WHERE UserRankId >= {UserRankId}";

            DataSet dsMenuOptions = manteniment.PortarPerConsulta(query);

            foreach (DataRow row in dsMenuOptions.Tables[0].Rows)
            {
                // Creamos un nuevo botón de menú
                MenuButton btn = new MenuButton();

                // Asignamos las propiedades del botón con los valores de la fila
                btn.TargetPanel = PanelContenido;
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


                flowLayoutPanel.Dock = DockStyle.Left;  // O DockStyle.Fill si deseas que ocupe todo el espacio disponible
                flowLayoutPanel.FlowDirection = FlowDirection.TopDown;  // Esto hará que los botones se apilen verticalmente
                flowLayoutPanel.WrapContents = false;
                flowLayoutPanel.Width = btn.Width + 15;
                // Lo añadimos al panel del formulario principal (en este caso 'targetPanel')
                flowLayoutPanel.Controls.Add(btn);

            }
        }
    }
}
