using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FTP_Client
{
    public partial class FrmXML : Form
    {
        private XDocument doc; // Almacenar el documento cargado

        public FrmXML(XDocument xDocument)
        {
            InitializeComponent();

            doc = xDocument;
        }

        private void FormXML_Load(object sender, EventArgs e)
        {
            try
            {
                rtbXML.Text = doc.ToString();

                txtServer.Text = doc.Root.Element("ip")?.Value;
                txtUser.Text = doc.Root.Element("credencials")?.Element("username")?.Value;
                txtPassword.Text = doc.Root.Element("credencials")?.Element("password")?.Value;
                txtRuta.Text = doc.Root.Element("rutadescarga")?.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el archivo XML: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                doc.Root.Element("ip")?.SetValue(txtServer.Text);
                doc.Root.Element("credencials")?.Element("username")?.SetValue(txtUser.Text);
                doc.Root.Element("credencials")?.Element("password")?.SetValue(txtPassword.Text);
                doc.Root.Element("rutadescarga")?.SetValue(txtRuta.Text);

                string xmlPath = Path.Combine(Directory.GetParent(Application.StartupPath)?.FullName, "FTP_Client", "FTPCredentials.xml");
                doc.Save(xmlPath);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el archivo XML: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Seleccione la carpeta donde desea guardar los archivos";
                folderDialog.ShowNewFolderButton = true;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;
                    txtRuta.Text = selectedPath;
                }
            }
        }

    }
}
