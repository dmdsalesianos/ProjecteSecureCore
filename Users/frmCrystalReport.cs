using System;
using System.IO;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Users
{
    public partial class frmCrystalReport : Form
    {
        private int idPersona;

        public frmCrystalReport(int idPersona)
        {
            InitializeComponent();
            this.idPersona = idPersona;
        }

        private void frmCrystalReport_Load(object sender, EventArgs e)
        {
            MostrarInforme();
        }

        private void MostrarInforme()
        {
            try
            {
                // Ruta base dinámica para imágenes
                string rutaBaseImagenes = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imatges", "usuarios");

                // Ruta del informe
                string rutaInforme = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UserCard.rpt");

                if (!File.Exists(rutaInforme))
                {
                    MessageBox.Show("El archivo del informe no existe en la ruta especificada.");
                    return;
                }

                // Crear el documento del informe
                ReportDocument informe = new ReportDocument();
                informe.Load("UserCard.rpt");

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

                // Configurar el parámetro idUser
                ParameterFieldDefinitions crParameterFieldDefinitions = informe.DataDefinition.ParameterFields;


                ParameterFieldDefinition crParameterFieldDefinition = crParameterFieldDefinitions["UserId"];
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue
                {
                    Value = idPersona
                };

                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                // Configurar el parámetro RutaBase
                crParameterFieldDefinition = crParameterFieldDefinitions["RutaBase"];
                crParameterDiscreteValue = new ParameterDiscreteValue
                {
                    Value = rutaBaseImagenes
                };

                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

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
