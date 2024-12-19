using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using System.Data; // Para DataSet y SqlDataAdapter
using System.Data.SqlClient; // Para SqlConnection y SqlDataAdapter
using System.Configuration; // Para ConfigurationManager
using System.Web.WebPages;

namespace Users
{
    public partial class Form1 : Form
    {
        private int idUserDG;

        public int IdUserDG
        {
            get { return idUserDG; }
            set { idUserDG = value; }
        }

        public Form1(int idPersona)
        {
            InitializeComponent();
            this.idUserDG = idPersona;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Carga y configura el informe
            MostrarInforme(idUserDG);
        }

        private void MostrarInforme(int idPersona)
        {
            try
            {
                // Ruta del informe
                string rutaInforme = Application.StartupPath;
                ReportDocument informe = new ReportDocument();
                informe.Load(@"C:\proyecto_clase_git\ProjecteSecureCore\Users\TarjetaIdentificacion.rpt");

                // Configurar las credenciales de conexión
                ConnectionInfo crConnectionInfo = new ConnectionInfo
                {
                    ServerName = "sqlserver.S2AM.sdslab.cat",
                    DatabaseName = "SecureCoreG4",
                    UserID = "G4",
                    Password = "12345G4aA2425."
                };

                // Aplicar las credenciales a todas las tablas del informe
                Tables crTables = informe.Database.Tables;
                foreach (Table crTable in crTables)
                {
                    TableLogOnInfo crTableLogOnInfo = crTable.LogOnInfo;
                    crTableLogOnInfo.ConnectionInfo = crConnectionInfo;
                    crTable.ApplyLogOnInfo(crTableLogOnInfo);
                }

                // Configura el parámetro
                ParameterFieldDefinitions parametros = informe.DataDefinition.ParameterFields;
                ParameterFieldDefinition parametroPersonaId = parametros["idUser"];
                ParameterDiscreteValue valorParametro = new ParameterDiscreteValue
                {
                    Value = idPersona
                };

                parametroPersonaId.CurrentValues.Clear();
                parametroPersonaId.CurrentValues.Add(valorParametro);
                parametroPersonaId.ApplyCurrentValues(parametroPersonaId.CurrentValues);

                // Asignar el informe al visor
                crystalReportViewer1.ReportSource = informe;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el informe: {ex.Message}");
            }

            

        }
    }
}
