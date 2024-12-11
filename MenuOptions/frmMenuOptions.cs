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

namespace MenuOptions
{
    public partial class frmMenuOptions : prueba_txtBox.baseForm
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

                    string carpetaDirectory = Path.Combine(imagesDirectory, nombreCarpeta); //C://.../bin/Debug/imatges

                    if (!Directory.Exists(carpetaDirectory))
                    {
                        Directory.CreateDirectory(carpetaDirectory);
                    }

                    string fileName = Path.GetFileName(sourceFilePath); //Nombre de la imagen
                    string destinationFilePath = Path.Combine(carpetaDirectory, fileName); // C://.../bin/Debug/imatges/nombre_imagen

                    string rutaBBD = Path.Combine(nombreCarpeta, fileName); // imagtes/nombre_imagen

                    try
                    {
                        File.Copy(sourceFilePath, destinationFilePath, overwrite: true);

                        DataRow selectedRow = GetSelectedPlanetRow();
                        if (selectedRow != null)
                        {
                            selectedRow["Icono"] = rutaBBD;
                        }

                        MostrarImagenSeleccionada();

                        //MessageBox.Show($"Imagen copiada exitosamente a: {rutaBBD}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error al copiar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }

}

