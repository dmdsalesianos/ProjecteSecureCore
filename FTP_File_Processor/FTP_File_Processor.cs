using System;
using System.IO;
using System.Net;
using System.Xml;

namespace FTP_Client
{
    public class FTP_File_Processor
    {
        private string server;
        private string user;
        private string password;
        private bool connection;

        public bool Connection { get { return connection; } set { connection = value; } }

        // Evento para notificar cuando la descarga o subida de un archivo esté completa
        public event EventHandler<string> FileOperationComplete;

        // Evento para notificar cuando la descarga o subida de un archivo de error
        public event EventHandler<string> FileOperationError;

        public FTP_File_Processor(string xmlPath)
        {
            LoadCredentials(xmlPath);
            TestConnection();
        }

        private void LoadCredentials(string xmlPath)
        {
            // Cargar las credenciales desde el archivo XML
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);
            server = doc.SelectSingleNode("//FTP/ip").InnerText;
            user = doc.SelectSingleNode("//FTP/credentials/username").InnerText;
            password = doc.SelectSingleNode("//FTP/credentials/password").InnerText;
        }

        private void TestConnection()
        {
            try
            {
                // Intentar conectarse al servidor FTP utilizando el método ListDirectory
                //Es podria fer també fent un ping en comptes de ListDirectory però aquesta manera funciona ja
                string ftpUrl = $"ftp://{server}";
                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(ftpUrl);
                ftpRequest.Credentials = new NetworkCredential(user, password);
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;

                using(FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse())
                {
                    Connection = true;
                    FileOperationComplete?.Invoke(this, $"Conexión exitosa, estado: {response.StatusDescription}");
                }
            } catch(Exception ex)
            {
                Connection = false;
                FileOperationError?.Invoke(this, $"Error al conectar: {ex.Message}");
            }
        }

        public void DownloadFile(string fileName, string localPath)
        {
            try
            {
                string ftpUrl = $"ftp://{server}/{fileName}";
                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(ftpUrl);
                ftpRequest.Credentials = new NetworkCredential(user, password);
                ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;

                using(FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse())
                {
                    using(Stream responseStream = response.GetResponseStream())
                    {
                        using(FileStream fileStream = new FileStream(localPath, FileMode.Create))
                        {
                            responseStream.CopyTo(fileStream);
                        }
                    }

                    FileOperationComplete?.Invoke(this, $"Descarga completa, estado: {response.StatusDescription}");
                }
            } catch(Exception ex)
            {
                FileOperationError?.Invoke(this, $"Error durante la descarga: {ex.Message}");
            }
        }

        public void UploadFile(string localFilePath, string remoteFileName)
        {
            try
            {
                string ftpUrl = $"ftp://{server}/{remoteFileName}";
                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(ftpUrl);
                ftpRequest.Credentials = new NetworkCredential(user, password);
                ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;

                byte[] content = File.ReadAllBytes(localFilePath);
                ftpRequest.ContentLength = content.Length;

                using(Stream requestStream = ftpRequest.GetRequestStream())
                {
                    requestStream.Write(content, 0, content.Length);
                }

                using(FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse())
                {
                    FileOperationComplete?.Invoke(this, $"Subida completa, estado: {response.StatusDescription}");
                }
            } catch(Exception ex)
            {
                FileOperationError?.Invoke(this, $"Error durante la subida: {ex.Message}");
            }
        }
    }
}
