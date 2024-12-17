using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public enum TextPosition
    {
        Left,
        Right,
        Center,
        Sliding,
        None
    }

    public class RJProgressBar : ProgressBar
    {
        // Fields
        private Color channelColor = Color.LightSteelBlue;
        private Color sliderColor = Color.RoyalBlue;
        private Color foreBackColor = Color.Transparent;
        private int channelHeight = 6;
        private int sliderHeight = 6;
        private TextPosition showValue = TextPosition.Right;
        private string symbolBefore = "";
        private string symbolAfter = "";
        private bool showMaximun = false;

        private bool stopPainting = false;

        // Constructor
        public RJProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.White;
        }

        // Properties
        [Category("RJ Code Advance")]
        public Color ChannelColor
        {
            get { return channelColor; }
            set { channelColor = value; this.Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public Color SliderColor
        {
            get { return sliderColor; }
            set { sliderColor = value; this.Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public Color ForeBackColor
        {
            get { return foreBackColor; }
            set { foreBackColor = value; this.Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public int ChannelHeight
        {
            get { return channelHeight; }
            set { channelHeight = value; this.Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public int SliderHeight
        {
            get { return sliderHeight; }
            set { sliderHeight = value; this.Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public TextPosition ShowValue
        {
            get { return showValue; }
            set { showValue = value; this.Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public string SymbolBefore
        {
            get { return symbolBefore; }
            set { symbolBefore = value; this.Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public string SymbolAfter
        {
            get { return symbolAfter; }
            set { symbolAfter = value; this.Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public bool ShowMaximun
        {
            get { return showMaximun; }
            set { showMaximun = value; this.Invalidate(); }
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // Dibujar el fondo del contenedor (para respetar la imagen de fondo del formulario)
            if (this.Parent != null)    
            {
                Graphics g = pevent.Graphics;
                Rectangle rect = new Rectangle(this.Location, this.Size);
                g.DrawImage(this.Parent.BackgroundImage, rect, rect, GraphicsUnit.Pixel);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (!stopPainting)
            {
                Graphics graph = e.Graphics;

                // Calcular el progreso (ancho de la barra de progreso)
                double scaleFactor = (((double)this.Value - this.Minimum) / (this.Maximum - this.Minimum));
                int sliderWidth = (int)(this.Width * scaleFactor);

                // Dibujar el canal (fondo)
                Rectangle rectChannel = new Rectangle(0, (this.Height - channelHeight) / 2, this.Width, channelHeight);
                using (var brushChannel = new SolidBrush(channelColor))
                {
                    graph.FillRectangle(brushChannel, rectChannel);
                }

                // Dibujar el slider (progreso)
                Rectangle rectSlider = new Rectangle(0, (this.Height - sliderHeight) / 2, sliderWidth, sliderHeight);
                using (var brushSlider = new SolidBrush(sliderColor))
                {
                    graph.FillRectangle(brushSlider, rectSlider);
                }

                // Dibujar el texto si es necesario
                if (showValue != TextPosition.None)
                {
                    DrawValueText(graph, sliderWidth);
                }
            }

            stopPainting = this.Value == this.Maximum;
        }

        private void DrawValueText(Graphics graph, int sliderWidth)
        {
            string text = symbolBefore + this.Value.ToString() + symbolAfter;

            if (showMaximun)
                text += "/" + symbolBefore + this.Maximum.ToString() + symbolAfter;

            var textSize = TextRenderer.MeasureText(text, this.Font);
            var rectText = new Rectangle(0, (this.Height - textSize.Height) / 2, textSize.Width, textSize.Height);

            using (var brushText = new SolidBrush(this.ForeColor))
            {
                switch (showValue)
                {
                    case TextPosition.Left:
                        rectText.X = 0;
                        break;
                    case TextPosition.Right:
                        rectText.X = this.Width - textSize.Width;
                        break;
                    case TextPosition.Center:
                        rectText.X = (this.Width - textSize.Width) / 2;
                        break;
                    case TextPosition.Sliding:
                        rectText.X = sliderWidth - textSize.Width;
                        break;
                }

                graph.DrawString(text, this.Font, brushText, rectText);
            }
        }
    }
}
