using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=sqlserver.S2AM.sdslab.cat;Initial Catalog=SecureCoreG4;Persist Security Info=True;User ID=G4;Password=12345G4aA2425.";

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> criteris = new Dictionary<string, string>();
            string nomTaula = "Alumnes";
            MantenimentDades manteniment = new MantenimentDades(connectionString);
            DataSet ds = new DataSet();

            criteris.Add("Login", "MAND");

            ds = manteniment.GeneraConsultaCerca(nomTaula, criteris);

            // Asegúrate de que el DataSet tiene datos
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                string result = string.Empty;

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string login = row["Login"].ToString(); // Asegúrate de que la columna "Login" existe
                    string nom = row["Nom"].ToString();     // Asegúrate de que la columna "Nom" existe

                    result += $"Login: {login}, Nom: {nom}\n";
                }

                // Mostrar en un MessageBox
                MessageBox.Show(result, "Datos del DataSet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontraron datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
