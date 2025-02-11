using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using System.Drawing;

namespace FTP_Client
{
    public partial class FrmFTP : Form
    {
        private FTP_File_Processor ftp;

        public FrmFTP() { InitializeComponent(); }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();
            string fileName = txtFileName.Text;
            if(string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Introdueix el nom del fitxer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string localPath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

            ftp.DownloadFile(fileName, localPath);
        }

        // Método que maneja el evento de la operación de descarga completada
        private void OnFileOperationComplete(object sender, string message)
        {
            MessageBox.Show(message, "Èxit", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string localPath = Path.Combine(Directory.GetCurrentDirectory(), txtFileName.Text);

            try
            {
                // Leer el archivo y mostrar las líneas que contienen "LIN"
                using(StreamReader reader = new StreamReader(localPath))
                {
                    string line;
                    while((line = reader.ReadLine()) != null)
                    {
                        if(line.StartsWith("LIN"))
                        {
                            string[] parts = line.Split('|');
                            if(parts.Length > 2)
                            {
                                lstResults.Items.Add("Nau trobada: " + parts[2]);
                            }
                        }
                    }
                }

                // Comprobar si existe la carpeta "tractats", si no, crearla
                string treatedDir = Path.Combine(Directory.GetCurrentDirectory(), "tractats");
                if(!Directory.Exists(treatedDir))
                {
                    Directory.CreateDirectory(treatedDir);
                }

                // Definir el nuevo nombre del archivo (sobreescribible)
                string newFileName = Path.Combine(
                    treatedDir,
                    Path.GetFileNameWithoutExtension(txtFileName.Text) + "_OK" + Path.GetExtension(txtFileName.Text));

                // Si el archivo ya existe, eliminarlo antes de mover el nuevo
                if(File.Exists(newFileName))
                {
                    File.Delete(newFileName);
                }

                // Mover el archivo a la carpeta "tractats"
                File.Move(localPath, newFileName);

                MessageBox.Show(
                    "Fitxer mogut a: " + newFileName,
                    "Èxit",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            } catch(Exception ex)
            {
                MessageBox.Show(
                    "Error al processar l'arxiu: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Método que maneja el evento de error de operación de archivo
        private void OnFileOperationError(object sender, string message)
        { MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        private void FrmFTP_Load(object sender, EventArgs e)
        {
            ftp = new FTP_File_Processor("FTPCredentials.xml");

            // Conectar al servidor y mostrar el estado
            if(ftp.Connection)
            {
                MessageBox.Show(
                    "Conexió amb el servidor FTP establerta exitòsament.",
                    "Informació",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show(
                    "Conexión con servidor FTP no establecida.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            // Subscribir a los eventos de la clase FTP_File_Processor
            ftp.FileOperationComplete += OnFileOperationComplete;
            ftp.FileOperationError += OnFileOperationError;
        }
    }
}
