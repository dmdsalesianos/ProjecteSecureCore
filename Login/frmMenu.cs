using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmMenu : Form
    {
        

        public frmMenu(/*String usuario*/)
        {
            InitializeComponent();
            
            
            
        }

        private void button_logaout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();

            this.Hide();
            
        }

        public int ObtenerAccessLevel(int idUsuario)
        {
            int accessLevel = 0;

            // Cadena de conexión a tu base de datos
            string connectionString = "Data Source=TU_SERVIDOR;Initial Catalog=SecureCoreG4;Integrated Security=True;";

            // Consulta SQL con JOIN
            string query = @"SELECT R.AccessLevel
                     FROM Usuarios U-
                     INNER JOIN Rangos R ON U.IdRango = R.IdRango
                     WHERE U.IdUsuario = @IdUsuario";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        accessLevel = Convert.ToInt32(reader["AccessLevel"]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return accessLevel;
        }

    }
}
