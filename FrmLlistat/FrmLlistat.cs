using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace FrmLlistat
{
    public partial class FrmLlistat : Form
    {
        private string cnx;

        public FrmLlistat()
        {
            InitializeComponent();
            cnx = ConfigurationManager.ConnectionStrings["ConexioStr"].ConnectionString;
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            string idComanda = txtParametre.Text;

            if(string.IsNullOrWhiteSpace(idComanda))
            {
                MessageBox.Show("Introduce un ID de Comanda válido.");
            } else
            {
                // Verificar si la comanda existe
                if(!ComandaExiste(idComanda))
                {
                    MessageBox.Show("La Comanda " + idComanda + " no existe.");
                    CRVReports.ReportSource = null;
                } else
                {
                    // Cargar el informe si la comanda existe
                    CargarInforme(idComanda);
                }
            }
        }

        private bool ComandaExiste(string idComanda)
        {
            try
            {
                // Consulta SQL para verificar si existe la comanda
                using(SqlConnection conn = new SqlConnection(cnx))
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM Orders WHERE idOrder = @idComanda";
                    using(SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idComanda", idComanda);
                        int result = (int)cmd.ExecuteScalar();
                        return result > 0;
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Error al verificar la comanda: " + ex.Message);
                return false;
            }
        }

        private void CargarInforme(string idComanda)
        {
            try
            {
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load("..\\CrComandes\\CrComandes.rpt");

                //Configuración de conexión
                ConnectionInfo crConnectionInfo = new ConnectionInfo();
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cnx);

                crConnectionInfo.ServerName = builder.DataSource;
                crConnectionInfo.DatabaseName = builder.InitialCatalog;
                crConnectionInfo.UserID = builder.UserID;
                crConnectionInfo.Password = builder.Password;

                //Aplicar conexión a todas las tablas del informe
                TableLogOnInfos crTableLogOnInfos = new TableLogOnInfos();
                foreach(Table table in cryRpt.Database.Tables)
                {
                    TableLogOnInfo tableLogOnInfo = table.LogOnInfo;
                    tableLogOnInfo.ConnectionInfo = crConnectionInfo;
                    table.ApplyLogOnInfo(tableLogOnInfo);
                }

                //Aplicar el filtro por IdComanda
                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                crParameterDiscreteValue.Value = idComanda;
                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["IdComanda"];

                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                //Mostrar el reporte en el visor
                CRVReports.ReportSource = cryRpt;
                CRVReports.Refresh();
            } catch(Exception ex)
            {
                MessageBox.Show("Error al cargar el informe: " + ex.Message);
            }
        }
    }
}
