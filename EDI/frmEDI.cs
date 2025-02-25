using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EDI
{
    public partial class frmEDI : Form
    {
        public frmEDI() { InitializeComponent(); }
        private string file;
        private List<string[]> lines = new List<string[]>(); // Inicializado correctamente

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            SelectFile();
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(file))
            {
                MessageBox.Show("Por favor, seleccione un archivo antes de procesarlo.");
                return;
            }
            AnalizeLines(file);
            CreateOrders();
        }

        private void SelectFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Path.Combine(Application.StartupPath, "FTP");
                openFileDialog.Filter = "Archivos EDI (*.edi)|*.edi";
                openFileDialog.Title = "Seleccionar un archivo EDI";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    file = openFileDialog.FileName;
                }
            }
        }

        private void CreateOrders()
        {
            
            using (SecureCoreG4Entities db = new SecureCoreG4Entities())
            {
                foreach (var line in lines)
                {
                    if (line.Equals("ORD"))
                    {
                        Orders order = new Orders();

                        order.codeOrder = "HOLA";
                    }
                    else if (true)
                    {
                        
                    }
                    else if (true)
                    {

                    }
                    else if (true)
                    {

                    }
                    else if (true)
                    {

                    }
                    else if (true)
                    {

                    }
                    else if (true)
                    {

                    }
                }             
                db.SaveChanges();
            }               
        }

        private void AnalizeLines(string file)
        {
            lines.Clear(); // Limpia la lista antes de procesar un nuevo archivo

            var fileLines = File.ReadAllLines(file);

            if (fileLines.Length == 0 || !fileLines[0].Trim().Equals("POTCUST_D_96A_UN_EAN008"))
            {
                throw new FormatException("El fitxer no té el format correcte.");
            }

            var orderLines = fileLines
                .Skip(1)  // Omite la primera línea que parece ser un encabezado
                .Select(linea => linea.Split('|'))  // Divide cada línea por '|'
                .Where(columnas => columnas.Length >= 1)  // Asegura que la línea no esté vacía
                .ToList();

            lines = orderLines; // Asigna el resultado a `orders`
        }
    }
}
