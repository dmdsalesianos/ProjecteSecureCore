using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace CustomControls
{
    public partial class MenuButton : UserControl
    {
        public MenuButton() { InitializeComponent(); }

        private string form;
        private string clase;


        [Category("Custom Properties")]
        public string Clase { get => clase; set { clase = value; } }

        [Category("Custom Properties")]
        public string Form { get => form; set { form = value; } }

        [Category("Custom Properties")]
        public Panel TargetPanel { get; set; }

        [Category("Custom Properties")]
        public string LabelText { get => optionLbl.Text; set => optionLbl.Text = value; }

        [Category("Custom Properties")]
        public string RutaImagen { get => optionImg.ImageLocation; set => optionImg.ImageLocation = value; }

        private void OpenForm()
        {
            string claseForm = Clase + "." + Form;

            try
            {
                Assembly ensamblat = Assembly.LoadFrom($"{Clase}.dll");
                Type tipus = ensamblat.GetType(claseForm);

                if(tipus != null)
                {
                    Form frm = (Form)Activator.CreateInstance(tipus);
                    frm.TopLevel = false;
                    frm.Dock = DockStyle.Fill;

                    TargetPanel.Controls.Clear();
                    TargetPanel.Controls.Add(frm);
                    frm.Show();
                } else
                {
                    MessageBox.Show("La clase especificada no se encontró.");
                }
            } catch(Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario: {ex.Message}");
            }
        }

        private void MenuBtn_Click(object sender, EventArgs e) { OpenForm(); }
    }
}
