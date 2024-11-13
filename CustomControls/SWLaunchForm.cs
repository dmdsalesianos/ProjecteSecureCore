using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Sprint53_G4 { 
    public partial class SWLaunchForm : UserControl
    {
        public SWLaunchForm()
        {
            InitializeComponent();
        }

        private string clase;
        private string form;
        private string descripcion;
        private Image image;

        [Category("Custom Properties")]
        public Image Image
        {
            get => image;
            set
            {
                image = value;
                UpdateImage();
            }
        }

        [Category("Custom Properties")]
        public string Clase { get => clase; set => clase = value; }

        [Category("Custom Properties")]
        public string Form { get => form; set => form = value; }

        [Category("Custom Properties")]
        public string Descripcion
        {
            get => descripcion;
            set
            {
                descripcion = value;
                UpdateLabels();
            }
        }
        private void OpenForm()
        {
            string claseForm = Clase + "." + Form;

            try
            {
                Assembly ensamblat = Assembly.LoadFrom($"{Clase}.dll");
                Type tipus = ensamblat.GetType(claseForm);

                if (tipus != null)
                {
                    Form frm = (Form)Activator.CreateInstance(tipus);
                    frm.TopLevel = false;
                    frm.Dock = DockStyle.Fill;

                    panel.Controls.Clear();
                    panel.Controls.Add(frm);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("La clase especificada no se encontró.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario: {ex.Message}");
            }
        }


        private void UpdateLabels() { titleLbl.Text = descripcion; }

        private void UpdateImage()
        {
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }



        private void panel_Click_1(object sender, EventArgs e)
        {
            OpenForm();
        }
    }
}
