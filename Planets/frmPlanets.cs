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

        public frmPlanets()
        {
            InitializeComponent();
            TableName = "Planets";
            querySelect = $"SELECT * FROM {TableName}";

            cmbSector.Tag = "Sectors";
            cmbSector.DisplayMember = "DescSector";
            cmbSector.ValueMember = "idSector";

            cmbNatives.Tag = "Species";
            cmbNatives.DisplayMember = "DescSpecie";
            cmbNatives.ValueMember = "idNatives";

            cmbFiliations.Tag = "Filiations";
            cmbFiliations.DisplayMember = "DescFiliations";
            cmbFiliations.ValueMember = "idFiliation";
        }

        private void frmPlanets_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);

            dsFK = dataAccess.PortarTaula(cmbSector.Tag.ToString());
            cmbSector.DataSource = dsFK.Tables[cmbSector.Tag.ToString()];

            dsFK = dataAccess.PortarTaula(cmbNatives.Tag.ToString());
            cmbNatives.DataSource = dsFK.Tables[cmbNatives.Tag.ToString()];

            dsFK = dataAccess.PortarTaula(cmbFiliations.Tag.ToString());
            cmbFiliations.DataSource = dsFK.Tables[cmbFiliations.Tag.ToString()];

            // Suscribirse al evento de selección del DataGridView
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;

            // Mostrar la imagen inicial del planeta seleccionado (si aplica)
            MostrarImagenSeleccionada();
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

                    string projectDirectory = Application.StartupPath; //Cojo el dierectorio del projecto C:/.../bin/Debug
                    string carpetaDirectory = Path.Combine(projectDirectory, nombreCarpeta); //C://.../bin/Debug/imatges

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
                            selectedRow["PlanetPicture"] = rutaBBD;
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

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            MostrarImagenSeleccionada();
        }

        private void MostrarImagenSeleccionada()
        {
            DataRow selectedRow = GetSelectedPlanetRow();
            if (selectedRow != null)
            {
                string imagePath = Path.Combine(Application.StartupPath, selectedRow["PlanetPicture"]?.ToString());
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureBox1.Image = null; // Limpiar el PictureBox si no hay imagen válida
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
    }
}
