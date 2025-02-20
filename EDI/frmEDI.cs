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

namespace EDI
{
    public partial class frmEDI : Form
    {
        public frmEDI()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Path.Combine(Application.StartupPath, "FTP"); // Cambia esto por la ruta deseada
                openFileDialog.Filter = "Archivos EDI (*.edi)|*.edi";
                openFileDialog.Title = "Seleccionar un archivo EDI";
                openFileDialog.Multiselect = false; // Permite seleccionar solo un archivo

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = openFileDialog.FileName;
                    
                    using (StreamReader reader = new StreamReader(selectedFile))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {

                            string[] partes = line.Split('|');
                            
                            
                            line = "";
                        }
                    }
                }

                
            }


        }

    }
}
