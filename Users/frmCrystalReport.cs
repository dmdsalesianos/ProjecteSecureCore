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

        public int IdPersona
        {
            get { return idPersona; }
            set { idPersona = value; }
        }

        public frmCrystalReport(int idPersona)
        {
            InitializeComponent();
            this.idPersona = idPersona;
        }

        private void frmCrystalReport_Load(object sender, EventArgs e)
        {
            MostrarInforme(idPersona);
        }

        private void MostrarInforme(int idPersona)
        {
            try
            {
                // Ruta base dinámica para imágenes
                string rutaBaseImagenes = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imatges", "usuarios");

                // Ruta del informe
                string rutaInforme = Path.Combine(
                    Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory.TrimEnd(Path.DirectorySeparatorChar)),
                    "Users",
                    "UserCard.rpt"
                );

                if (!File.Exists(rutaInforme))
                {
                    MessageBox.Show("El archivo del informe no existe en la ruta especificada.");
                    return;
                }

                ReportDocument informe = new ReportDocument();
                informe.Load(rutaInforme);

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

                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                crParameterDiscreteValue.Value = idPersona;
                crParameterFieldDefinitions = informe.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["idUser"];

                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el informe: {ex.Message}");
            }
        }

        
    }
}
