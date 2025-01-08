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
    public partial class frmUsers : baseForm
    {
        protected int idUserDG;
        string nombreCarpeta = "usuarios";
        string imagesDirectory = Path.Combine(Application.StartupPath, "imatges");

        public frmUsers()
        {
            InitializeComponent();
            TableName = "Users";
            TablesFK = new List<string> { "UserCategories", "UserRanks", "Species", "Planets" };
            querySelect = $"SELECT * FROM {TableName}";

            cmbUserCategory.Tag = "idUserCategory";
            cmbUserCategory.DisplayMember = "DescCategory";
            cmbUserCategory.ValueMember = "idUserCategory";

            cmbUserRank.Tag = "idUserRank";
            cmbUserRank.DisplayMember = "DescRank";
            cmbUserRank.ValueMember = "idUserRank";

            cmbSpecie.Tag = "idSpecie";
            cmbSpecie.DisplayMember = "DescSpecie";
            cmbSpecie.ValueMember = "idSpecie";

            cmbPlanet.Tag = "idPlanet";
            cmbPlanet.DisplayMember = "DescPlanet";
            cmbPlanet.ValueMember = "idPlanet";

            //pictureBoxLoading.Visible = false;
        }

        protected override void BaseForm_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);

            cmbUserCategory.DataSource = ds.Tables["UserCategories"];
            cmbUserRank.DataSource = ds.Tables["UserRanks"];
            cmbSpecie.DataSource = ds.Tables["Species"];
            cmbPlanet.DataSource = ds.Tables["Planets"];

            if (dataGridView1.Columns.Contains("Password"))
            {
                dataGridView1.Columns["Password"].Visible = false;
            }
            if (dataGridView1.Columns.Contains("Salt"))
            {
                dataGridView1.Columns["Salt"].Visible = false;
            }
        }

        private void rjbtnInforme_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                idUserDG = Convert.ToInt32(selectedRow.Cells[0].Value);
            }


            //MostrarInforme(idUserDG);

            frmCrystalReport frmCrystal = new frmCrystalReport(idUserDG);
            frmCrystal.Show();
        }

        //private void MostrarInforme(int idPersona)
        //{
        //    try
        //    {
        //        // Mostrar animación de carga
        //        pictureBoxLoading.Visible = true;
        //        panel1.Visible = true;

        //        // Ruta base dinámica para imágenes
        //        string rutaBaseImagenes = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imatges", "usuarios");

        //        // Ruta del informe
        //        string rutaInforme = Path.Combine(
        //            Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory.TrimEnd(Path.DirectorySeparatorChar)),
        //            "Users",
        //            "TarjetaIdentificacion.rpt"
        //        );
        //        ReportDocument informe = new ReportDocument();
        //        informe.Load(rutaInforme);

        //        // Configurar las credenciales de conexión
        //        ConnectionInfo crConnectionInfo = new ConnectionInfo
        //        {
        //            ServerName = "sqlserver.S2AM.sdslab.cat",
        //            DatabaseName = "SecureCoreG4",
        //            UserID = "G4",
        //            Password = "12345G4aA2425."
        //        };

        //        // Aplicar las credenciales a todas las tablas del informe
        //        Tables crTables = informe.Database.Tables;
        //        foreach (Table crTable in crTables)
        //        {
        //            TableLogOnInfo crTableLogOnInfo = crTable.LogOnInfo;
        //            crTableLogOnInfo.ConnectionInfo = crConnectionInfo;
        //            crTable.ApplyLogOnInfo(crTableLogOnInfo);
        //        }

        //        // Configurar parámetros
        //        ParameterFieldDefinitions parametros = informe.DataDefinition.ParameterFields;

        //        // Parámetro idUser
        //        ParameterFieldDefinition parametroPersonaId = parametros["idUser"];
        //        ParameterDiscreteValue valorParametroId = new ParameterDiscreteValue { Value = idPersona };
        //        parametroPersonaId.CurrentValues.Clear();
        //        parametroPersonaId.CurrentValues.Add(valorParametroId);
        //        parametroPersonaId.ApplyCurrentValues(parametroPersonaId.CurrentValues);

        //        // Parámetro RutaBase
        //        ParameterFieldDefinition parametroRutaBase = parametros["RutaBase"];
        //        ParameterDiscreteValue valorParametroRuta = new ParameterDiscreteValue { Value = rutaBaseImagenes };
        //        parametroRutaBase.CurrentValues.Clear();
        //        parametroRutaBase.CurrentValues.Add(valorParametroRuta);
        //        parametroRutaBase.ApplyCurrentValues(parametroRutaBase.CurrentValues);

        //        // Asignar el informe al visor
        //        crystalReportViewer1.ReportSource = informe;
        //        crystalReportViewer1.Refresh();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error al cargar el informe: {ex.Message}");
        //    }
        //    finally
        //    {
        //        // Ocultar animación de carga
        //        pictureBoxLoading.Visible = false;
        //    }
        //}

        private void rjbtnImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Seleccionar una imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceFilePath = openFileDialog.FileName;

                    string carpetaDirectory = Path.Combine(imagesDirectory, nombreCarpeta); //C://.../App

                    if (!Directory.Exists(carpetaDirectory))
                    {
                        Directory.CreateDirectory(carpetaDirectory);
                    }

                    string fileName = Path.GetFileName(sourceFilePath); //Nombre de la imagen
                    string destinationFilePath = Path.Combine(carpetaDirectory, fileName); // C://.../App/imatges/nombre_imagen

                    try
                    {
                        File.Copy(sourceFilePath, destinationFilePath, overwrite: true);
                        swtxtPhoto.Text = fileName;

                        //Hago focus sobre el swtxtImagen y luego lo pierdo para que se valide
                        swtxtPhoto.Focus();
                        rjbtnImage.Focus();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error al copiar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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

        private void rjbtnRestablecerContraseña_Click(object sender, EventArgs e)
        {

            swtxtPassword.Text = "12345aA";
            base.ValidarTextBox(swtxtPassword, e);
            base.rjbtnActualitzar_Click(sender, e);
        }
    }
}
