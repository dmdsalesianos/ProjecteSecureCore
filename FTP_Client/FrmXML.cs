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

        public FrmXML()
        {
            InitializeComponent();
        }

        private void FormXML_Load(object sender, EventArgs e)
        {
            string xmlPath = Path.Combine(Directory.GetParent(Application.StartupPath)?.FullName, "FTP_Client", "FTPCredentials.xml");

            try
            {
                doc = XDocument.Load(xmlPath); // Cargar el archivo XML

                // Mostrar el XML completo en el RichTextBox
                rtbXML.Text = doc.ToString();

                // Vincular cada TextBox con un campo específico del XML
                txtServer.Text = doc.Root.Element("ip")?.Value;
                txtUser.Text = doc.Root.Element("credencials")?.Element("username")?.Value;
                txtPassword.Text = doc.Root.Element("credencials")?.Element("password")?.Value;
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
    }
}
