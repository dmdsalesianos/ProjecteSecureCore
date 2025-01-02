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
                    "TarjetaIdentificacion.rpt"
                );
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

                // Configurar parámetros
                ParameterFieldDefinitions parametros = informe.DataDefinition.ParameterFields;

                // Parámetro idUser
                ParameterFieldDefinition parametroPersonaId = parametros["idUser"];
                ParameterDiscreteValue valorParametroId = new ParameterDiscreteValue { Value = idPersona };
                parametroPersonaId.CurrentValues.Clear();
                parametroPersonaId.CurrentValues.Add(valorParametroId);
                parametroPersonaId.ApplyCurrentValues(parametroPersonaId.CurrentValues);

                // Parámetro RutaBase
                ParameterFieldDefinition parametroRutaBase = parametros["RutaBase"];
                ParameterDiscreteValue valorParametroRuta = new ParameterDiscreteValue { Value = rutaBaseImagenes };
                parametroRutaBase.CurrentValues.Clear();
                parametroRutaBase.CurrentValues.Add(valorParametroRuta);
                parametroRutaBase.ApplyCurrentValues(parametroRutaBase.CurrentValues);

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
