using System;
using System.Linq;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class SWTextbox : TextBox
    {
        private Color colorOriginal;
        private Tipus_Dada tipusDada;
        private bool permetreBuit = true;
        private bool esForanea;
        private string nomCampBBDD;

        // Constructor
        public SWTextbox()
        {
            InitializeComponent();
            colorOriginal = this.BackColor;
        }

        // Enumeració Tipus de Dada
        public enum Tipus_Dada
        {
            Number,
            Text,
            Code,
            All
        }

        // Propietats Personalitzades
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

        // Canvi de color en el focus
        private void SWTextbox_GotFocus(object sender, EventArgs e) { this.BackColor = Color.LightYellow; }

        private void SWTextbox_LostFocus(object sender, EventArgs e) { this.BackColor = colorOriginal; }

        // Validació del contingut
        private void SWTextbox_Validating(object sender, CancelEventArgs e)
        {
            if(!permetreBuit && string.IsNullOrEmpty(this.Text))
            {
                this.BackColor = Color.LightCoral;
            } else if(!ValidateInput(this.Text))
            {
                this.BackColor = Color.LightCoral;
            } else
            {
                this.BackColor = colorOriginal;
            }
        }

        // Funció per validar amb Regex segons el tipus de dada
        private bool ValidateInput(string text)
        {
            if(string.IsNullOrEmpty(text))
                return permetreBuit;

            switch(tipusDada)
            {
                case Tipus_Dada.Number:
                    return Regex.IsMatch(text, @"^\d+$");  // Només números
                case Tipus_Dada.Text:
                    return text.All(c => Char.IsLetter(c) || c == ' ');  // Només text
                case Tipus_Dada.Code:
                    return Regex.IsMatch(text, @"^[AEIOU][A-Z]{3}\d{2}[13579]$");  // Codi tipus AAAB1234
                case Tipus_Dada.All:
                    return true;  // Codi tipus AAAB1234
                default:
                    return true;
            }
        }

        // Esdeveniment per controlar el canvi de contingut
        private void SWTextbox_TextChanged(object sender, EventArgs e)
        {
            if(esForanea && !string.IsNullOrEmpty(nomCampBBDD))
            {
                // Logica per gestionar el canvi en el control SWCodi associat, si cal
                // Aquesta lògica hauria de modificar la selecció del control SWCodi associat.
                // Aquí podries cridar un mètode per actualitzar la selecció del SWCodi.
            }
        }

        // Inicialitzar components
        private void InitializeComponent()
        {
            this.GotFocus += SWTextbox_GotFocus;
            this.LostFocus += SWTextbox_LostFocus;
            this.Validating += SWTextbox_Validating;
            this.TextChanged += SWTextbox_TextChanged;
        }
    }
}
