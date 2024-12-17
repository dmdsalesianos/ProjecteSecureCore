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

namespace Planets
{
    public partial class frmPlanets : baseForm
    {
        public DataSet dsFK;
        string imagesDirectory = Application.StartupPath;

        public frmPlanets()
        {
            InitializeComponent();
            TableName = "Planets";
            querySelect = $"SELECT * FROM {TableName}";

            cmbSector.Tag = "idSector";
            cmbSector.DisplayMember = "DescSector";
            cmbSector.ValueMember = "idSector";

            cmbNatives.Tag = "idNatives"; 
            cmbNatives.DisplayMember = "DescSpecie";
            cmbNatives.ValueMember = "idSpecie";

            cmbFiliations.Tag = "idFiliation";
            cmbFiliations.DisplayMember = "DescFiliations";
            cmbFiliations.ValueMember = "idFiliation";
        }

        private void frmPlanets_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);

            dsFK = dataAccess.PortarTaula("Sectors");
            cmbSector.DataSource = dsFK.Tables["Sectors"];

            dsFK = dataAccess.PortarTaula("Species");
            cmbNatives.DataSource = dsFK.Tables["Species"];

            dsFK = dataAccess.PortarTaula("Filiations");
            cmbFiliations.DataSource = dsFK.Tables["Filiations"];
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            string nombreCarpeta = "imatges";

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
                        swtxtImagen.Text = fileName;

                        //Hago focus sobre el swtxtImagen y luego lo pierdo para que se valide
                        swtxtImagen.Focus();
                        btnImage.Focus();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error al copiar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void swtxtImagen_TextChanged(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(imagesDirectory, "imatges", swtxtImagen.Text);

            if (File.Exists(imagePath))
            {
                pictureBox1.ImageLocation = imagePath;
            }
            else
            {
                pictureBox1.ImageLocation = null; // Borra la imagen si no se encuentra el archivo
            }
        }
    }
}
