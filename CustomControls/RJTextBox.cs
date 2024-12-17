using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControls
{
    class RJTextBox : TextBox
    {
        private Color borderColor = Color.MediumSlateBlue;
        private Color borderFocusColor = Color.HotPink;
        private int borderSize = 2;
        private int borderRadius = 0;
        private bool isFocused = false;
        private string placeholderText = "";
        private Color placeholderColor = Color.DarkGray;
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;

        // Constructor
        public RJTextBox()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            this.ForeColor = Color.Black;
            this.TextAlign = HorizontalAlignment.Left;
            this.TextChanged += TextBox1_TextChanged;
            this.Enter += TextBox1_Enter;
            this.Leave += TextBox1_Leave;
        }

        // Propiedades personalizadas
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        public Color BorderFocusColor { get => borderFocusColor; set { borderFocusColor = value; this.Invalidate(); } }
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }
        public int BorderRadius { get => borderRadius; set { borderRadius = value; this.Invalidate(); } }
        public string PlaceholderText { get => placeholderText; set { placeholderText = value; SetPlaceholder(); } }
        public Color PlaceholderColor { get => placeholderColor; set { placeholderColor = value; } }
        //public bool PasswordChar { get => isPasswordChar; set { isPasswordChar = value; this.UseSystemPasswordChar = value; } }

        // Propiedad Text, que maneja el texto o el placeholder
        public override string Text
        {
            get => isPlaceholder ? "" : base.Text;
            set
            {
                base.Text = value;
                SetPlaceholder();
            }
        }

        // Función para dibujar bordes redondeados
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            using (GraphicsPath path = GetRoundedPath(this.ClientRectangle, borderRadius))
            using (Pen penBorder = new Pen(isFocused ? borderFocusColor : borderColor, borderSize))
            {
                this.Region = new Region(path);
                graph.DrawPath(penBorder, path);
            }
        }

        // Crear el camino para los bordes redondeados
        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        // Función que maneja el texto del placeholder
        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(this.Text) && !string.IsNullOrWhiteSpace(placeholderText))
            {
                isPlaceholder = true;
                this.Text = placeholderText;
                this.ForeColor = placeholderColor;
                this.UseSystemPasswordChar = false;
            }
        }

        // Funciones para manejar el evento de cambio de texto
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.OnTextChanged(e);
        }

        // Funciones para manejar eventos de foco
        private void TextBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            RemovePlaceholder();
            this.Invalidate();
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            SetPlaceholder();
            this.Invalidate();
        }

        // Función para quitar el texto de placeholder
        private void RemovePlaceholder()
        {
            if (isPlaceholder && !string.IsNullOrWhiteSpace(placeholderText))
            {
                isPlaceholder = false;
                this.Text = "";
                this.ForeColor = this.ForeColor;
                this.UseSystemPasswordChar = isPasswordChar;
            }
        }
    }
}
