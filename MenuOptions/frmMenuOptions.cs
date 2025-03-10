﻿using System;
using System.IO;
using System.Windows.Forms;
using Base;

namespace MenuOptions
{
    public partial class frmMenuOptions : baseForm
    {
        string nombreCarpeta = "iconos";
        string imagesDirectory = Path.Combine(Application.StartupPath, "imatges");

        public frmMenuOptions()
        {
            InitializeComponent();
            TableName = "MenuOptions";
            querySelect = $"SELECT * FROM {TableName}";            
        }

        private void frmMenuOptions_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);
        }

        private void rjbtnImagen_Click(object sender, EventArgs e)
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
                        rjbtnImagen.Focus();

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
                pictureBox_icono.ImageLocation = imagePath;
            }
            else
            {
                pictureBox_icono.ImageLocation = null; // Borra la imagen si no se encuentra el archivo
            }
        }

        
    }
}
