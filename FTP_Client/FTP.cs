using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FTP_Client
{
    public class FTP
    {
        FtpWebRequest ftpRequest;
        FtpWebResponse response;
        Stream responseStream;
        StreamReader reader;

        private string ftpServer;

        public string FtpServer
        {
            get { return ftpServer; }
            set { ftpServer = value; }
        }

        private string ftpUser;

        public string FtpUser
        {
            get { return ftpUser; }
            set { ftpUser = value; }
        }

        private string ftpPassword;

        public string FtpPassword
        {
            get { return ftpPassword; }
            set { ftpPassword = value; }
        }

        public FTP(string ftpServer, string ftpUser, string ftpPassword)
        {
            FtpServer = ftpServer;
            FtpUser = ftpUser;
            FtpPassword = ftpPassword;
        }

        public FtpWebResponse Connectar()
        {
            try
            {
                ftpRequest = (FtpWebRequest)WebRequest.Create($"ftp://{ftpServer}/");
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                ftpRequest.Credentials = new NetworkCredential(ftpUser, ftpPassword);
                response = (FtpWebResponse)ftpRequest.GetResponse();
            }
            catch
            {
            }

            return response;
        }

        public FtpWebResponse Download(string fileName, string rutaDescarga)
        {
            try
            {
                ftpRequest = (FtpWebRequest)WebRequest.Create($"ftp://{ftpServer}/{fileName}");
                ftpRequest.Credentials = new NetworkCredential(ftpUser, ftpPassword);
                Console.WriteLine("Solicitud FTP creada con éxito.");
                string filePath = Path.Combine(rutaDescarga, fileName);

                //**** DESCARGAR ARCHIVO ****
                ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                response = (FtpWebResponse)ftpRequest.GetResponse();
                responseStream = response.GetResponseStream();
                File.WriteAllText(filePath, reader.ReadToEnd());

            }
            catch
            {
            }

            return response;
        }

        public FtpWebResponse Download(string fileName, string rutaDescarga, string moveDirectory)
        {
            try
            {
                ftpRequest = (FtpWebRequest)WebRequest.Create($"ftp://{ftpServer}/{fileName}");
                ftpRequest.Credentials = new NetworkCredential(ftpUser, ftpPassword);
                string filePath = Path.Combine(rutaDescarga, fileName);

                //**** DESCARGAR ARCHIVO ****
                ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                response = (FtpWebResponse)ftpRequest.GetResponse();
                responseStream = response.GetResponseStream();
                reader = new StreamReader(responseStream);
                File.WriteAllText(filePath, reader.ReadToEnd());

                //**** MOVER ARCHIVO ****
                FtpWebRequest renameRequest = (FtpWebRequest)WebRequest.Create($"ftp://{ftpServer}/{fileName}");
                renameRequest.Credentials = new NetworkCredential(ftpUser, ftpPassword);
                renameRequest.Method = WebRequestMethods.Ftp.Rename;
                renameRequest.RenameTo = $"{moveDirectory}/{fileName}";
                response = (FtpWebResponse)renameRequest.GetResponse();

            }
            catch
            {
            }

            return response;
        }

        public FtpWebResponse Upload(string fileName)
        {
            ftpRequest = (FtpWebRequest)WebRequest.Create($"ftp://{ftpServer}/{fileName}");
            ftpRequest.Credentials = new NetworkCredential(ftpUser, ftpPassword);
            ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;

            byte[] content = File.ReadAllBytes(fileName);
            ftpRequest.ContentLength = content.Length;
            Stream stream = ftpRequest.GetRequestStream();
            stream.Write(content, 0, content.Length);
            stream.Close();

            response = (FtpWebResponse)ftpRequest.GetResponse();
            return response;
        }
    }
}
