using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Windows.Forms;

namespace CustomControls.RJControls
{
    public class RJTextBox : TextBox
    {
        private int borderSize = 2;
        private int borderRadius = 20;
        private Color borderColor = Color.PaleVioletRed;

        [Category("RJ Code Advance")]
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; this.Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }

        private Color backgroundColor = Color.White;
        private Color textColor = Color.Black;

        [Category("RJ Code Advance")]
        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set
            {
                backgroundColor = value;
                this.BackColor = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public Color TextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;
                this.ForeColor = value;
                this.Invalidate();
            }
        }

        // Constructor para el diseñador
        public RJTextBox()
        {
            // Aseguramos que el control sea compatible con el diseñador
            this.SetStyle(ControlStyles.UserPaint, true);
            this.Multiline = false;
            this.BackColor = backgroundColor;
            this.ForeColor = textColor;

            // Definir el tamaño del control
            this.Size = new Size(200, 40);
            this.BorderStyle = BorderStyle.None;
        }

        // Método que define las esquinas redondeadas
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();

            return path;
        }

        // Método de pintura personalizada
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Solo pintar cuando no estamos en el diseñador
            if (!DesignMode)
            {
                Rectangle rectSurface = this.ClientRectangle;
                Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 2;

                using (Graphics graphics = this.CreateGraphics())
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    this.Region = new Region(pathSurface);
                    graphics.DrawPath(penSurface, pathSurface);
                    if (borderSize > 0)
                        graphics.DrawPath(penBorder, pathSurface);
                }
            }
        }

        // Método para manejar el cambio de color de fondo del contenedor
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += (sender, args) => this.Invalidate();
        }
    }
}
