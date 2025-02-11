using System;
using System.Linq;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Globalization;

namespace CustomControls
{
    public partial class SWTextbox : TextBox
    {
        private Color colorOriginal;
        private Tipus_Dada tipusDada;
        private bool permetreBuit = true;
        private bool esForanea;
        private string nomCampBBDD;
        private bool esValid = true;

        public SWTextbox()
        {
            InitializeComponent();
            colorOriginal = this.BackColor;
        }

        public enum Tipus_Dada
        {
            Number,
            Text,
            Code,
            Date,
            All
        }

        [Category("Custom Properties")]
        [Description("Especifica el tipus de dada que accepta el control.")]
        public Tipus_Dada TipusDada { get => tipusDada; set => tipusDada = value; }

        [Category("Custom Properties")]
        [Description("Indica si es permet que el camp estigui buit.")]
        public bool PermetreBuit { get => permetreBuit; set => permetreBuit = value; }

        [Category("Custom Properties")]
        [Description("Indica si el camp és una clau forana.")]
        public bool EsForanea { get => esForanea; set => esForanea = value; }

        [Category("Custom Properties")]
        [Description("Especifica el nom del camp de la BBDD associat.")]
        public string NomCampBBDD { get => nomCampBBDD; set => nomCampBBDD = value; }

        private void SWTextbox_GotFocus(object sender, EventArgs e)
        {
            if (esValid)
            {
                this.BackColor = Color.LightYellow;
            }
        }

        private void SWTextbox_LostFocus(object sender, EventArgs e)
        {
            if (esValid)
            {
                this.BackColor = colorOriginal;
            }
            else
            {
                Focus();
            }
        }


        private bool ValidateInput(string text)
        {
            if (string.IsNullOrEmpty(text))
                return permetreBuit;

            switch (tipusDada)
            {
                case Tipus_Dada.Number:
                    return Regex.IsMatch(text, @"^\d+$"); // Només números
                case Tipus_Dada.Text:
                    return text.All(c => Char.IsLetter(c) || c == ' ' || c == '\''); // Només text amb espais i cometes simples
                case Tipus_Dada.Code:
                    return Regex.IsMatch(text, @"^[AEIOU][A-Z]{3}\d{2}[13579]$"); // Codi tipus AAAB1234
                case Tipus_Dada.Date:
                    return DateTime.TryParseExact( //Data
                        text,
                        "dd/MM/yyyy",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out _);
                case Tipus_Dada.All:
                    return true; // Permet tot

                default:
                    return true;
            }
        }


        private void SWTextbox_TextChanged(object sender, EventArgs e) { ActualizarColorValidación(); }

        private void ActualizarColorValidación()
        {
            esValid = ValidateInput(this.Text);

            if (esValid)
            {
                // Si el dato es válido y el control tiene el foco, se pone amarillo
                this.BackColor = this.Focused ? Color.LightYellow : colorOriginal;
            }
            else
            {
                // Si el dato es inválido, se pone LightCoral
                this.BackColor = Color.LightCoral;
            }
        }

        private void InitializeComponent()
        {
            this.GotFocus += SWTextbox_GotFocus;
            this.LostFocus += SWTextbox_LostFocus;
            this.TextChanged += SWTextbox_TextChanged;
        }
    }
}
