using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Base;

namespace MenuOptions
{
    public partial class frmMenuOptions : baseForm
    {
        string imagesDirectory = Path.Combine(Directory.GetParent(Application.StartupPath)?.Parent.Parent.FullName, "App");
        public DataSet dsFK;

        public frmMenuOptions()
        {
            InitializeComponent();
            TableName = "MenuOptions";
            querySelect = $"SELECT * FROM {TableName}";

            
        }

        protected override void BaseForm_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);

            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;

        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            MostrarImagenSeleccionada();
        }

        private void MostrarImagenSeleccionada()
        {
            DataRow selectedRow = GetSelectedPlanetRow();
            if (selectedRow != null)
            {
                string imagePath = Path.Combine(imagesDirectory, selectedRow["Icono"]?.ToString());
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    pictureBox_icono.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureBox_icono.Image = null; // Limpiar el PictureBox si no hay imagen válida
                }
            }
        }

        private DataRow GetSelectedPlanetRow()
        {
            if (dataGridView1.CurrentRow != null)
            {
                int selectedIndex = dataGridView1.CurrentRow.Index;
                return ds.Tables[TableName].Rows[selectedIndex];
            }

            return null;
        }

        private void rjButton_image_Click(object sender, EventArgs e)
        {
            string nombreCarpeta = "iconos";

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
                        rjButton_image.Focus();

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
            string imagePath = Path.Combine(imagesDirectory, "iconos", swtxtImagen.Text);

            if (File.Exists(imagePath))
            {
                pictureBox_icono.ImageLocation = imagePath;
            }
            else
            {
                pictureBox_icono.ImageLocation = null; // Borra la imagen si no se encuentra el archivo
            }
        }
    }

}

