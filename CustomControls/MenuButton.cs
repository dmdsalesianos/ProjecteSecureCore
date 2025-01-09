using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace CustomControls
{
    public partial class MenuButton : UserControl
    {
        public MenuButton()
        {
            InitializeComponent();
            optionLbl.ForeColor = Color.White;
        }

        private string form;
        private string clase;
        private static MenuButton selectedButton;
        private bool isSelected = false;

        private int bottomBorderSize = 2;
        private Color bottomBorderColor = Color.Black;

        [Category("Custom Properties")]
        public string Clase { get => clase; set => clase = value; }

        [Category("Custom Properties")]
        public string Form { get => form; set => form = value; }

        [Category("Custom Properties")]
        public Panel TargetPanel { get; set; }

        [Category("Custom Properties")]
        public string LabelText { get => optionLbl.Text; set => optionLbl.Text = value; }

        [Category("Custom Properties")]
        public string RutaImagen { get => optionImg.ImageLocation; set => optionImg.ImageLocation = value; }

        [Category("Custom Properties")]
        public Color ColorOri { get; set; }

        [Category("Custom Properties")]
        public Color BottomBorderColor
        {
            get => bottomBorderColor;
            set
            {
                bottomBorderColor = value;
                this.Invalidate(); 
            }
        }

        [Category("Custom Properties")]
        public int BottomBorderSize
        {
            get => bottomBorderSize;
            set
            {
                bottomBorderSize = value;
                this.Invalidate(); 
            }
        }

        private void OpenForm()
        {
            string claseForm = $"{Clase}.{Form}";
            
            try
            {
                Assembly ensamblat = Assembly.LoadFrom($"{Clase}.dll");
                Type tipus = ensamblat.GetType(claseForm);

                if(tipus != null)
                {
                    Form frm = (Form)Activator.CreateInstance(tipus);
                    frm.TopLevel = false;
                    frm.FormBorderStyle = FormBorderStyle.None;
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
                TargetPanel.Controls.Clear();
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            OpenForm();

            // Deselecciona el botón previamente seleccionado
            if(selectedButton != null && selectedButton != this)
            {
                selectedButton.BackColor = selectedButton.ColorOri;
                selectedButton.BorderStyle = BorderStyle.None;
                selectedButton.isSelected = false;
            }

            // Marca este botón como seleccionado
            isSelected = true;
            BorderStyle = BorderStyle.Fixed3D;
            selectedButton = this;
        }

        private void MenuButton_MouseEnter(object sender, EventArgs e)
        {
            if(!isSelected)
            {
                BackColor = Color.FromArgb(34, 68, 153);  // Amarillo (Rojo: 255, Verde: 255, Azul: 0)
            }
        }

        private void MenuButton_MouseLeave(object sender, EventArgs e)
        {
            if(!isSelected)
            {
                BackColor = ColorOri;
            }
        }

        private void MenuButton_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            using(Pen bottomBorderPen = new Pen(bottomBorderColor, bottomBorderSize))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.DrawLine(
                    bottomBorderPen,
                    0,
                    this.Height - bottomBorderSize / 2,
                    this.Width,
                    this.Height - bottomBorderSize / 2);
            }
        }
    }
}
