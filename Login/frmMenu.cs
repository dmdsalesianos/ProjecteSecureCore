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

namespace Login
{
    public partial class frmMenu : Form
    {
        private int accesLevel = 100;

        public frmMenu(int currentUserCategoryId)
        {
            InitializeComponent();
            accesLevel = ObtenerAccessLevel(currentUserCategoryId);
            //MessageBox.Show($"Access Level: {accesLevel}");


        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            ButonForms();
        }

        private void button_logaout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();

            this.Hide();

        }

        private int ObtenerAccessLevel(int currentUserCategoryId)
        {
            accesLevel = 0;

            string query = "SELECT cat.AccessLevel " +
                           "FROM UserCategories cat " +
                           "INNER JOIN Users us ON cat.idUserCategory = us.idUserCategory " +
                           $"WHERE cat.idUserCategory = {currentUserCategoryId}";

            string connectionString = ConfigurationManager.ConnectionStrings["ConexioStr"].ConnectionString;
            MantenimentDades mantenimentDades = new MantenimentDades(connectionString);
            DataSet ds = new DataSet();

            ds = mantenimentDades.PortarPerConsulta(query);

            accesLevel = Convert.ToInt32(ds.Tables[0].Rows[0]["AccessLevel"]);

            return accesLevel; // Devolvemos el nivel de acceso
        }

        private void ButonForms()
        {
            
            string query = $"select Texto, AccessLevel, Clase, Form, Icono, Color from MenuOptions where AccessLevel <= {accesLevel}";

            string connectionString = ConfigurationManager.ConnectionStrings["ConexioStr"].ConnectionString;
            MantenimentDades menuOptionsDataSet = new MantenimentDades(connectionString);
            DataSet ds = new DataSet();

      
            ds = menuOptionsDataSet.PortarPerConsulta(query);

            //Para cada fila en el DataSet de MenuOptions que obtenemos de la base de datos
            DataTable menuOptionsTable = ds.Tables[0];

            


            foreach (DataRow row in menuOptionsTable.Rows)
            {

                // Comprobar si el nivel de acceso del usuario es mayor o igual al nivel de acceso de la fila de MenuOptions
                if (accesLevel >= Convert.ToInt32(row["AccessLevel"]))
                {
                    // Creamos un nuevo botón de menú
                    MenuButton btn = new MenuButton();

                    // Asignamos las propiedades del botón con los valores de la fila
                    btn.TargetPanel = PanelContenido;
                    btn.LabelText = row["Texto"].ToString();  // Asignamos el nombre de la opción
                    btn.Clase = row["Clase"].ToString();
                    btn.Form = row["Form"].ToString(); // Asignamos la clase
                    btn.RutaImagen = row["Icono"].ToString();
                    btn.BackColor = Color.FromName(row["Color"].ToString());  // Asignamos el color de fondo

                    // Agregamos el botón al panel especificado
                    btn.Dock = DockStyle.Left;

                    flowLayoutPanel.Dock = DockStyle.Left;  // O DockStyle.Fill si deseas que ocupe todo el espacio disponible
                    flowLayoutPanel.FlowDirection = FlowDirection.TopDown;  // Esto hará que los botones se apilen verticalmente
                    flowLayoutPanel.WrapContents = false;
                    // Lo añadimos al panel del formulario principal (en este caso 'targetPanel')
                    flowLayoutPanel.Controls.Add(btn);
                }
            }
        }
    }

}
