using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Base;


namespace Users
{
    public partial class frmUsers : baseForm
    {
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
        private void frmUsers_Load(object sender, EventArgs e)
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
            if (dataGridView1.Columns.Contains("Photo"))
            {
                dataGridView1.Columns["Photo"].Visible = false;
            }
        }

        private void rjbtnInforme_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                int userId = int.Parse(dataGridView1.Rows[rowIndex].Cells["idUser"].Value.ToString());

                frmCrystalReport frmCrystal = new frmCrystalReport(userId);
                frmCrystal.Show();
            }            
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

            // Mostrar ventana de confirmación
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas restablecer la contraseña?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si el usuario confirma, realiza la acción
            if (resultado == DialogResult.Yes)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    var userId = dataGridView1.Rows[rowIndex].Cells["idUser"].Value;

                    if (userId != null)
                    {
                        string query = "UPDATE Users " +
                               "SET password = '12345aA' " +
                               $"WHERE idUser = {userId}";

                        dataAccess.Executa(query);
                        base.CargarDatos();
                    }
                }
            }
        }
    }
}
