using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Base;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Configuration;
using System.Data.SqlClient; // Para SqlConnection y SqlDataAdapter
using System.Web.WebPages;



namespace Users
{
    public partial class frmUser : baseForm
    {
        public DataSet dsFK;
        protected int idUserDG;
        string nombreCarpeta = "usuarios";
        string imagesDirectory = Path.Combine(Application.StartupPath, "imatges");

        public frmUser()
        {
            InitializeComponent();
            TableName = "Users";
            querySelect = $"SELECT * FROM {TableName}";

            comboBox1.Tag = "UserCategories";
            comboBox1.DisplayMember = "DescCategory";
            comboBox1.ValueMember = "idUserCategory";

            comboBox2.Tag = "UserRanks";
            comboBox2.DisplayMember = "DescRank";
            comboBox2.ValueMember = "idUserRank";

            pictureBoxLoading.Visible = false;


            //comboBox3.Tag = "Species";
            //comboBox3.DisplayMember = "DescSpecie";
            //comboBox3.ValueMember = "idSpecie";

            //comboBox4.Tag = "Planets";
            //comboBox4.DisplayMember = "DescPlanet";
            //comboBox4.ValueMember = "idPlanet";

        }

        protected override void BaseForm_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);

            dsFK = dataAccess.PortarTaula("UserCategories");
            comboBox1.DataSource = dsFK.Tables["UserCategories"];

            dsFK = dataAccess.PortarTaula("UserRanks");
            comboBox2.DataSource = dsFK.Tables["UserRanks"];


            //dsFK = dataAccess.PortarTaula("Species");
            //comboBox3.DataSource = dsFK.Tables["Species"];

            //dsFK = dataAccess.PortarTaula(comboBox4.Tag.ToString());
            //comboBox4.DataSource = dsFK.Tables[comboBox4.Tag.ToString()];
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                idUserDG = Convert.ToInt32(selectedRow.Cells[0].Value);
            }


            MostrarInforme(idUserDG);
        }

        private void swtxtPhoto_TextChanged(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(imagesDirectory, nombreCarpeta, swtxtPhoto.Text);

            if (File.Exists(imagePath))
            {
                pictureBox1.ImageLocation = imagePath;
            }
            else
            {
                pictureBox1.ImageLocation = null; // Borra la imagen si no se encuentra el archivo
            }
        }

        private void MostrarInforme(int idPersona)
        {
            try
            {
                // Mostrar animación de carga
                pictureBoxLoading.Visible = true;

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
            finally
            {
                // Ocultar animación de carga
                pictureBoxLoading.Visible = false;
            }
        }
    }
}
