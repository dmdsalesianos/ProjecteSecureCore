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
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Seleccionar una imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Ruta de la imagen seleccionada
                    string sourceFilePath = openFileDialog.FileName;

                    // Ruta del directorio 'resources' en el proyecto
                    string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string resourcesDirectory = Path.Combine(projectDirectory, "resources");

                    // Crear la carpeta si no existe
                    if (!Directory.Exists(resourcesDirectory))
                    {
                        Directory.CreateDirectory(resourcesDirectory);
                    }

                    // Copiar la imagen a la carpeta 'resources'
                    string fileName = Path.GetFileName(sourceFilePath);
                    string destinationFilePath = Path.Combine(resourcesDirectory, fileName);

                    try
                    {
                        File.Copy(sourceFilePath, destinationFilePath, overwrite: true);
                        MessageBox.Show($"Imagen copiada exitosamente a: {destinationFilePath}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
