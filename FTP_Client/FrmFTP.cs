using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using System.Drawing;
using System.Xml.Linq;

namespace FTP_Client
{
    public partial class FrmFTP : Form
    {
        public FrmFTP() { InitializeComponent(); }

        private static string ftpServer;
        private static string ftpUser;
        private static string ftpPassword;

        FTP FTP;
        FtpWebResponse response;
        StreamReader reader;
        XDocument doc;

        string rutaDescarga;

        private void FrmFTP_Load(object sender, EventArgs e)
        {
            LoadFtpCredentials();
            FTP = new FTP(ftpServer, ftpUser, ftpPassword);

            string xmlPath = Path.Combine(Directory.GetParent(Application.StartupPath)?.FullName, "FTP_Client", "FTPCredentials.xml");
            doc = XDocument.Load(xmlPath);

            rutaDescarga = doc.Root.Element("rutadescarga")?.Value;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            LoadFtpCredentials();
            FTP = new FTP(ftpServer, ftpUser, ftpPassword);

            response = FTP.Connectar();

            if (response != null && response.StatusCode == FtpStatusCode.OpeningData)
            {
                picConnexion.Image = Properties.Resources.OK;
                lblConnexio2.Text = "CONNEXIO CORRECTA";

                MostrarArchivosFTP();
            }
            else
            {
                picConnexion.Image = Properties.Resources.NOK;
                lblConnexio2.Text = "CONNEXIO FALLIDA";
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNomArxiu.Text))
            {

                picConnexion.Image = Properties.Resources.LOADING;
                lblConnexio2.Text = $"DESCARGANDO {txtNomArxiu.Text}...";
                response = FTP.Download(txtNomArxiu.Text, rutaDescarga,"tractats");

                if (response != null && response.StatusCode == FtpStatusCode.FileActionOK)
                {
                    picConnexion.Image = Properties.Resources.OK;
                    lblConnexio2.Text = $"{txtNomArxiu.Text} DESCARGADO";
                    txtNomArxiu.Text = "";

                    btnConnect_Click(sender, e);
                }
                else
                {
                    picConnexion.Image = Properties.Resources.NOK;
                    lblConnexio2.Text = $"ERROR AL DESCARGAR {txtNomArxiu.Text}";
                    txtNomArxiu.Text = "";
                }
            }
            else
            {
                picConnexion.Image = Properties.Resources.NOK;
                lblConnexio2.Text = "INTRODUCE UN NOMBRE";
            }
        }      

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos EDI (*.edi)|*.edi";
            openFileDialog.Title = "Seleccionar archivo EDI";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(openFileDialog.FileName);

                response = FTP.Upload(fileName);
                if (response != null && response.StatusCode == FtpStatusCode.ClosingData)
                {
                    picConnexion.Image = Properties.Resources.OK;
                    lblConnexio2.Text = "ARCHIVO SUBIDO CORRECTAMENTE";
                }
                else
                {
                    picConnexion.Image = Properties.Resources.NOK;
                    lblConnexio2.Text = "ERROR AL SUBIR EL ARCHIVO";
                }
            }

        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            FrmXML frmXML = new FrmXML(doc);
            frmXML.Show();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbFiles.Clear();
        }


        private void LoadFtpCredentials()
        {
            string xmlpath = Path.Combine(Directory.GetParent(Application.StartupPath)?.FullName, "FTP_Client", "FTPCredentials.xml");
            try
            {
                XDocument doc = XDocument.Load(xmlpath);
                ftpServer = doc.Root.Element("ip")?.Value;
                ftpUser = doc.Root.Element("credencials")?.Element("username")?.Value;
                ftpPassword = doc.Root.Element("credencials")?.Element("password")?.Value;
            }
            catch
            {
                picConnexion.Image = Properties.Resources.NOK;
                lblConnexio2.Text = "CREDENCIALES NO CARGADAS CORRECTAMENTE";
            }
        }
        private void MostrarArchivosFTP()
        {
            reader = new StreamReader(response.GetResponseStream());
            // Mostrar archivos
            rtbFiles.AppendText("\nARCHIVOS DISPONIBLES\n");
            rtbFiles.AppendText("-------------------------------------------------------\n");

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.EndsWith(".edi", StringComparison.OrdinalIgnoreCase))
                {
                    rtbFiles.AppendText(line + Environment.NewLine);
                }
            }
            rtbFiles.ScrollToCaret();
        }


    }
}
