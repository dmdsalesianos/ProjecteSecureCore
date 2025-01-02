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
        string nombreCarpeta = "planetas";
        string imagesDirectory = Path.Combine(Application.StartupPath, "imatges");

        public frmPlanets()
        {
            InitializeComponent();
            TableName = "Planets";
            TablesFK = new List<string> { "Sectors", "Species", "Filiations" };
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

            //picPlanet.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void frmPlanets_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);

            cmbSector.DataSource = ds.Tables["Sectors"];
            cmbNatives.DataSource = ds.Tables["Species"];
            cmbFiliations.DataSource = ds.Tables["Filiations"];
        }

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
                        swtxtImagen.Text = fileName;

                        //Hago focus sobre el swtxtImagen y luego lo pierdo para que se valide
                        swtxtImagen.Focus();
                        rjbtnImage.Focus();

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
            string imagePath = Path.Combine(imagesDirectory, nombreCarpeta, swtxtImagen.Text);

            if (File.Exists(imagePath))
            {
                picPlanet.ImageLocation = imagePath;
            }
            else
            {
                picPlanet.ImageLocation = null; // Borra la imagen si no se encuentra el archivo
            }
        }

        
    }
}
