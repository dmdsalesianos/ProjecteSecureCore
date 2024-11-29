using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CustomControls
{
    public partial class SWTextbox : TextBox
    {
        private Color colorOriginal;
        private Tipus_Dada tipusDada;
        private bool permetreBuit = true;
        private bool esForanea;
        private string nomCampBBDD;

        public SWTextbox() { colorOriginal = this.BackColor; }

        public enum Tipus_Dada
        {
            Number,
            Text,
            Code
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

        private void SWTextbox_GotFocus(object sender, EventArgs e) { this.BackColor = Color.LightYellow; }

        private void SWTextbox_LostFocus(object sender, EventArgs e) { this.BackColor = colorOriginal; }

        private void SWTextbox_Validating(object sender, CancelEventArgs e)
        {
            if(!permetreBuit && string.IsNullOrEmpty(this.Text))
            {
                this.BackColor = Color.LightCoral;
                e.Cancel = true;
            } else if(!ValidateInput(this.Text))
            {
                this.BackColor = Color.LightCoral;
                e.Cancel = true;
            } else
            {
                this.BackColor = colorOriginal;
            }
        }

        private bool ValidateInput(string text)
        {
            if(string.IsNullOrEmpty(text))
                return permetreBuit;

            switch(tipusDada)
            {
                case Tipus_Dada.Number:
                    return Regex.IsMatch(text, @"^\d+$");
                case Tipus_Dada.Text:
                    return Regex.IsMatch(text, @"^[a-zA-Z]+$");
                case Tipus_Dada.Code:
                    return Regex.IsMatch(text, @"^[AEIOU][A-Z]{3}\d{2}[13579]$");
                default:
                    return true;
            }
        }

        private void SWTextbox_TextChanged(object sender, EventArgs e)
        {
            if(esForanea && !string.IsNullOrEmpty(nomCampBBDD))
            {
                // Logica per gestionar el canvi en el control SWCodi associat, si cal
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.GotFocus += SWTextbox_GotFocus;
            this.LostFocus += SWTextbox_LostFocus;
            this.Validating += SWTextbox_Validating;
            this.TextChanged += SWTextbox_TextChanged;
            this.ResumeLayout(false);
        }
    }
}
