using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Sprint53_G4
{
    public partial class RoundedButton : Button
    {
        public int CornerRadius { get; set; } = 20; // Valor predeterminado de radio de esquina

        public RoundedButton()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, CornerRadius * 2, CornerRadius * 2, 180, 90); // Esquina superior izquierda
            path.AddArc(Width - CornerRadius * 2, 0, CornerRadius * 2, CornerRadius * 2, 270, 90); // Esquina superior derecha
            path.AddArc(Width - CornerRadius * 2, Height - CornerRadius * 2, CornerRadius * 2, CornerRadius * 2, 0, 90); // Esquina inferior derecha
            path.AddArc(0, Height - CornerRadius * 2, CornerRadius * 2, CornerRadius * 2, 90, 90); // Esquina inferior izquierda
            path.CloseFigure();

            this.Region = new Region(path); // Aplicar la región redondeada

            // Pintar el botón
            using (Brush brush = new SolidBrush(this.BackColor))
            {
                pevent.Graphics.FillPath(brush, path); // Rellenar el fondo con color
            }

            base.OnPaint(pevent); //
        }
    }
}
