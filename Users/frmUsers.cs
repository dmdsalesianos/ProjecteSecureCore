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

        private void btnSelectImage_Click(object sender, EventArgs e)
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
                        btnSelectImage.Focus();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error al copiar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
