
namespace Planets
{
    partial class frmPlanets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodePlanet = new System.Windows.Forms.Label();
            this.lblDescPlanet = new System.Windows.Forms.Label();
            this.lblParsecs = new System.Windows.Forms.Label();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.lblLatitud = new System.Windows.Forms.Label();
            this.cmbNatives = new System.Windows.Forms.ComboBox();
            this.cmbFiliations = new System.Windows.Forms.ComboBox();
            this.cmbSector = new System.Windows.Forms.ComboBox();
            this.lblSector = new System.Windows.Forms.Label();
            this.lblNatives = new System.Windows.Forms.Label();
            this.lblFiliation = new System.Windows.Forms.Label();
            this.picPlanet = new System.Windows.Forms.PictureBox();
            this.lblIPPlanet = new System.Windows.Forms.Label();
            this.lblPortPlanet = new System.Windows.Forms.Label();
            this.lblPortPlanet1 = new System.Windows.Forms.Label();
            this.swtxtPortPlanet = new CustomControls.SWTextbox();
            this.swtxtbox = new CustomControls.SWTextbox();
            this.swtxtIPPlanet = new CustomControls.SWTextbox();
            this.swtxtLat = new CustomControls.SWTextbox();
            this.swtxtLong = new CustomControls.SWTextbox();
            this.swtxtParsecs = new CustomControls.SWTextbox();
            this.swtxtDescPlanet = new CustomControls.SWTextbox();
            this.swtxtCodePlanet = new CustomControls.SWTextbox();
            this.swtxtImagen = new CustomControls.SWTextbox();
            this.rjbtnImage = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.picPlanet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodePlanet
            // 
            this.lblCodePlanet.AutoSize = true;
            this.lblCodePlanet.BackColor = System.Drawing.Color.Transparent;
            this.lblCodePlanet.Location = new System.Drawing.Point(367, 105);
            this.lblCodePlanet.Name = "lblCodePlanet";
            this.lblCodePlanet.Size = new System.Drawing.Size(95, 20);
            this.lblCodePlanet.TabIndex = 6;
            this.lblCodePlanet.Text = "Code planet";
            // 
            // lblDescPlanet
            // 
            this.lblDescPlanet.AutoSize = true;
            this.lblDescPlanet.BackColor = System.Drawing.Color.Transparent;
            this.lblDescPlanet.Location = new System.Drawing.Point(331, 156);
            this.lblDescPlanet.Name = "lblDescPlanet";
            this.lblDescPlanet.Size = new System.Drawing.Size(131, 20);
            this.lblDescPlanet.TabIndex = 8;
            this.lblDescPlanet.Text = "Descripció planet";
            // 
            // lblParsecs
            // 
            this.lblParsecs.AutoSize = true;
            this.lblParsecs.BackColor = System.Drawing.Color.Transparent;
            this.lblParsecs.Location = new System.Drawing.Point(1084, 109);
            this.lblParsecs.Name = "lblParsecs";
            this.lblParsecs.Size = new System.Drawing.Size(66, 20);
            this.lblParsecs.TabIndex = 10;
            this.lblParsecs.Text = "Parsecs";
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.BackColor = System.Drawing.Color.Transparent;
            this.lblLongitud.Location = new System.Drawing.Point(734, 102);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(71, 20);
            this.lblLongitud.TabIndex = 12;
            this.lblLongitud.Text = "Longitud";
            // 
            // lblLatitud
            // 
            this.lblLatitud.AutoSize = true;
            this.lblLatitud.BackColor = System.Drawing.Color.Transparent;
            this.lblLatitud.Location = new System.Drawing.Point(747, 153);
            this.lblLatitud.Name = "lblLatitud";
            this.lblLatitud.Size = new System.Drawing.Size(58, 20);
            this.lblLatitud.TabIndex = 14;
            this.lblLatitud.Text = "Latitud";
            // 
            // cmbNatives
            // 
            this.cmbNatives.FormattingEnabled = true;
            this.cmbNatives.Location = new System.Drawing.Point(484, 199);
            this.cmbNatives.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNatives.Name = "cmbNatives";
            this.cmbNatives.Size = new System.Drawing.Size(194, 28);
            this.cmbNatives.TabIndex = 15;
            // 
            // cmbFiliations
            // 
            this.cmbFiliations.FormattingEnabled = true;
            this.cmbFiliations.Location = new System.Drawing.Point(828, 199);
            this.cmbFiliations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFiliations.Name = "cmbFiliations";
            this.cmbFiliations.Size = new System.Drawing.Size(194, 28);
            this.cmbFiliations.TabIndex = 16;
            // 
            // cmbSector
            // 
            this.cmbSector.FormattingEnabled = true;
            this.cmbSector.Location = new System.Drawing.Point(1171, 199);
            this.cmbSector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSector.Name = "cmbSector";
            this.cmbSector.Size = new System.Drawing.Size(194, 28);
            this.cmbSector.TabIndex = 17;
            this.cmbSector.Tag = "";
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.BackColor = System.Drawing.Color.Transparent;
            this.lblSector.Location = new System.Drawing.Point(1094, 199);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(56, 20);
            this.lblSector.TabIndex = 18;
            this.lblSector.Text = "Sector";
            // 
            // lblNatives
            // 
            this.lblNatives.AutoSize = true;
            this.lblNatives.BackColor = System.Drawing.Color.Transparent;
            this.lblNatives.Location = new System.Drawing.Point(401, 202);
            this.lblNatives.Name = "lblNatives";
            this.lblNatives.Size = new System.Drawing.Size(61, 20);
            this.lblNatives.TabIndex = 19;
            this.lblNatives.Text = "Natives";
            // 
            // lblFiliation
            // 
            this.lblFiliation.AutoSize = true;
            this.lblFiliation.BackColor = System.Drawing.Color.Transparent;
            this.lblFiliation.Location = new System.Drawing.Point(742, 199);
            this.lblFiliation.Name = "lblFiliation";
            this.lblFiliation.Size = new System.Drawing.Size(63, 20);
            this.lblFiliation.TabIndex = 20;
            this.lblFiliation.Text = "Filiation";
            // 
            // picPlanet
            // 
            this.picPlanet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlanet.Location = new System.Drawing.Point(1759, 84);
            this.picPlanet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPlanet.Name = "picPlanet";
            this.picPlanet.Size = new System.Drawing.Size(199, 135);
            this.picPlanet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlanet.TabIndex = 21;
            this.picPlanet.TabStop = false;
            this.picPlanet.Tag = "PlanetPicture";
            // 
            // lblIPPlanet
            // 
            this.lblIPPlanet.AutoSize = true;
            this.lblIPPlanet.BackColor = System.Drawing.Color.Transparent;
            this.lblIPPlanet.Location = new System.Drawing.Point(1084, 156);
            this.lblIPPlanet.Name = "lblIPPlanet";
            this.lblIPPlanet.Size = new System.Drawing.Size(69, 20);
            this.lblIPPlanet.TabIndex = 25;
            this.lblIPPlanet.Text = "IPPlanet";
            // 
            // lblPortPlanet
            // 
            this.lblPortPlanet.AutoSize = true;
            this.lblPortPlanet.BackColor = System.Drawing.Color.Transparent;
            this.lblPortPlanet.Location = new System.Drawing.Point(1421, 105);
            this.lblPortPlanet.Name = "lblPortPlanet";
            this.lblPortPlanet.Size = new System.Drawing.Size(87, 20);
            this.lblPortPlanet.TabIndex = 27;
            this.lblPortPlanet.Text = "Port Planet";
            // 
            // lblPortPlanet1
            // 
            this.lblPortPlanet1.AutoSize = true;
            this.lblPortPlanet1.BackColor = System.Drawing.Color.Transparent;
            this.lblPortPlanet1.Location = new System.Drawing.Point(1408, 159);
            this.lblPortPlanet1.Name = "lblPortPlanet1";
            this.lblPortPlanet1.Size = new System.Drawing.Size(100, 20);
            this.lblPortPlanet1.TabIndex = 29;
            this.lblPortPlanet1.Text = "Port Planet 1";
            // 
            // swtxtPortPlanet
            // 
            this.swtxtPortPlanet.EsForanea = false;
            this.swtxtPortPlanet.Location = new System.Drawing.Point(1532, 156);
            this.swtxtPortPlanet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swtxtPortPlanet.Name = "swtxtPortPlanet";
            this.swtxtPortPlanet.NomCampBBDD = "PortPlanet1";
            this.swtxtPortPlanet.PermetreBuit = true;
            this.swtxtPortPlanet.Size = new System.Drawing.Size(194, 26);
            this.swtxtPortPlanet.TabIndex = 28;
            this.swtxtPortPlanet.TipusDada = CustomControls.SWTextbox.Tipus_Dada.All;
            // 
            // swtxtbox
            // 
            this.swtxtbox.EsForanea = false;
            this.swtxtbox.Location = new System.Drawing.Point(1532, 105);
            this.swtxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swtxtbox.Name = "swtxtbox";
            this.swtxtbox.NomCampBBDD = "PortPlanet";
            this.swtxtbox.PermetreBuit = true;
            this.swtxtbox.Size = new System.Drawing.Size(194, 26);
            this.swtxtbox.TabIndex = 26;
            this.swtxtbox.TipusDada = CustomControls.SWTextbox.Tipus_Dada.All;
            // 
            // swtxtIPPlanet
            // 
            this.swtxtIPPlanet.EsForanea = false;
            this.swtxtIPPlanet.Location = new System.Drawing.Point(1171, 156);
            this.swtxtIPPlanet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swtxtIPPlanet.Name = "swtxtIPPlanet";
            this.swtxtIPPlanet.NomCampBBDD = "IPPlanet";
            this.swtxtIPPlanet.PermetreBuit = true;
            this.swtxtIPPlanet.Size = new System.Drawing.Size(194, 26);
            this.swtxtIPPlanet.TabIndex = 24;
            this.swtxtIPPlanet.TipusDada = CustomControls.SWTextbox.Tipus_Dada.All;
            // 
            // swtxtLat
            // 
            this.swtxtLat.EsForanea = false;
            this.swtxtLat.Location = new System.Drawing.Point(828, 150);
            this.swtxtLat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swtxtLat.Name = "swtxtLat";
            this.swtxtLat.NomCampBBDD = "lat";
            this.swtxtLat.PermetreBuit = true;
            this.swtxtLat.Size = new System.Drawing.Size(194, 26);
            this.swtxtLat.TabIndex = 13;
            this.swtxtLat.Tag = "";
            this.swtxtLat.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Number;
            // 
            // swtxtLong
            // 
            this.swtxtLong.EsForanea = false;
            this.swtxtLong.Location = new System.Drawing.Point(828, 102);
            this.swtxtLong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swtxtLong.Name = "swtxtLong";
            this.swtxtLong.NomCampBBDD = "long";
            this.swtxtLong.PermetreBuit = true;
            this.swtxtLong.Size = new System.Drawing.Size(194, 26);
            this.swtxtLong.TabIndex = 11;
            this.swtxtLong.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Number;
            // 
            // swtxtParsecs
            // 
            this.swtxtParsecs.EsForanea = false;
            this.swtxtParsecs.Location = new System.Drawing.Point(1171, 105);
            this.swtxtParsecs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swtxtParsecs.Name = "swtxtParsecs";
            this.swtxtParsecs.NomCampBBDD = "parsecs";
            this.swtxtParsecs.PermetreBuit = true;
            this.swtxtParsecs.Size = new System.Drawing.Size(194, 26);
            this.swtxtParsecs.TabIndex = 9;
            this.swtxtParsecs.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Number;
            // 
            // swtxtDescPlanet
            // 
            this.swtxtDescPlanet.EsForanea = false;
            this.swtxtDescPlanet.Location = new System.Drawing.Point(484, 152);
            this.swtxtDescPlanet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swtxtDescPlanet.Name = "swtxtDescPlanet";
            this.swtxtDescPlanet.NomCampBBDD = "DescPlanet";
            this.swtxtDescPlanet.PermetreBuit = true;
            this.swtxtDescPlanet.Size = new System.Drawing.Size(194, 26);
            this.swtxtDescPlanet.TabIndex = 7;
            this.swtxtDescPlanet.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // swtxtCodePlanet
            // 
            this.swtxtCodePlanet.EsForanea = false;
            this.swtxtCodePlanet.Location = new System.Drawing.Point(484, 100);
            this.swtxtCodePlanet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swtxtCodePlanet.Name = "swtxtCodePlanet";
            this.swtxtCodePlanet.NomCampBBDD = "CodePlanet";
            this.swtxtCodePlanet.PermetreBuit = true;
            this.swtxtCodePlanet.Size = new System.Drawing.Size(194, 26);
            this.swtxtCodePlanet.TabIndex = 5;
            this.swtxtCodePlanet.TipusDada = CustomControls.SWTextbox.Tipus_Dada.All;
            // 
            // swtxtImagen
            // 
            this.swtxtImagen.EsForanea = false;
            this.swtxtImagen.Location = new System.Drawing.Point(1807, 159);
            this.swtxtImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swtxtImagen.Name = "swtxtImagen";
            this.swtxtImagen.NomCampBBDD = "PlanetPicture";
            this.swtxtImagen.PermetreBuit = true;
            this.swtxtImagen.Size = new System.Drawing.Size(108, 26);
            this.swtxtImagen.TabIndex = 23;
            this.swtxtImagen.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            this.swtxtImagen.TextChanged += new System.EventHandler(this.swtxtImagen_TextChanged);
            // 
            // rjbtnImage
            // 
            this.rjbtnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.rjbtnImage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.rjbtnImage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnImage.BorderRadius = 0;
            this.rjbtnImage.BorderSize = 0;
            this.rjbtnImage.FlatAppearance.BorderSize = 0;
            this.rjbtnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnImage.ForeColor = System.Drawing.Color.White;
            this.rjbtnImage.Location = new System.Drawing.Point(1759, 250);
            this.rjbtnImage.Name = "rjbtnImage";
            this.rjbtnImage.Size = new System.Drawing.Size(199, 39);
            this.rjbtnImage.TabIndex = 30;
            this.rjbtnImage.Text = "Select Image";
            this.rjbtnImage.TextColor = System.Drawing.Color.White;
            this.rjbtnImage.UseVisualStyleBackColor = false;
            this.rjbtnImage.Click += new System.EventHandler(this.rjbtnImage_Click);
            // 
            // frmPlanets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2493, 1068);
            this.Controls.Add(this.rjbtnImage);
            this.Controls.Add(this.lblPortPlanet1);
            this.Controls.Add(this.swtxtPortPlanet);
            this.Controls.Add(this.lblPortPlanet);
            this.Controls.Add(this.swtxtbox);
            this.Controls.Add(this.lblIPPlanet);
            this.Controls.Add(this.swtxtIPPlanet);
            this.Controls.Add(this.picPlanet);
            this.Controls.Add(this.lblFiliation);
            this.Controls.Add(this.lblNatives);
            this.Controls.Add(this.lblSector);
            this.Controls.Add(this.cmbSector);
            this.Controls.Add(this.cmbFiliations);
            this.Controls.Add(this.cmbNatives);
            this.Controls.Add(this.lblLatitud);
            this.Controls.Add(this.swtxtLat);
            this.Controls.Add(this.lblLongitud);
            this.Controls.Add(this.swtxtLong);
            this.Controls.Add(this.lblParsecs);
            this.Controls.Add(this.swtxtParsecs);
            this.Controls.Add(this.lblDescPlanet);
            this.Controls.Add(this.swtxtDescPlanet);
            this.Controls.Add(this.lblCodePlanet);
            this.Controls.Add(this.swtxtCodePlanet);
            this.Controls.Add(this.swtxtImagen);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPlanets";
            this.Load += new System.EventHandler(this.frmPlanets_Load);
            this.Controls.SetChildIndex(this.swtxtImagen, 0);
            this.Controls.SetChildIndex(this.swtxtCodePlanet, 0);
            this.Controls.SetChildIndex(this.lblCodePlanet, 0);
            this.Controls.SetChildIndex(this.swtxtDescPlanet, 0);
            this.Controls.SetChildIndex(this.lblDescPlanet, 0);
            this.Controls.SetChildIndex(this.swtxtParsecs, 0);
            this.Controls.SetChildIndex(this.lblParsecs, 0);
            this.Controls.SetChildIndex(this.swtxtLong, 0);
            this.Controls.SetChildIndex(this.lblLongitud, 0);
            this.Controls.SetChildIndex(this.swtxtLat, 0);
            this.Controls.SetChildIndex(this.lblLatitud, 0);
            this.Controls.SetChildIndex(this.cmbNatives, 0);
            this.Controls.SetChildIndex(this.cmbFiliations, 0);
            this.Controls.SetChildIndex(this.cmbSector, 0);
            this.Controls.SetChildIndex(this.lblSector, 0);
            this.Controls.SetChildIndex(this.lblNatives, 0);
            this.Controls.SetChildIndex(this.lblFiliation, 0);
            this.Controls.SetChildIndex(this.picPlanet, 0);
            this.Controls.SetChildIndex(this.swtxtIPPlanet, 0);
            this.Controls.SetChildIndex(this.lblIPPlanet, 0);
            this.Controls.SetChildIndex(this.swtxtbox, 0);
            this.Controls.SetChildIndex(this.lblPortPlanet, 0);
            this.Controls.SetChildIndex(this.swtxtPortPlanet, 0);
            this.Controls.SetChildIndex(this.lblPortPlanet1, 0);
            this.Controls.SetChildIndex(this.rjbtnImage, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picPlanet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextbox swtxtCodePlanet;
        private System.Windows.Forms.Label lblCodePlanet;
        private System.Windows.Forms.Label lblDescPlanet;
        private CustomControls.SWTextbox swtxtDescPlanet;
        private System.Windows.Forms.Label lblParsecs;
        private CustomControls.SWTextbox swtxtParsecs;
        private System.Windows.Forms.Label lblLongitud;
        private CustomControls.SWTextbox swtxtLong;
        private System.Windows.Forms.Label lblLatitud;
        private CustomControls.SWTextbox swtxtLat;
        private System.Windows.Forms.ComboBox cmbNatives;
        private System.Windows.Forms.ComboBox cmbFiliations;
        private System.Windows.Forms.ComboBox cmbSector;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.Label lblNatives;
        private System.Windows.Forms.Label lblFiliation;
        private System.Windows.Forms.PictureBox picPlanet;
        private CustomControls.SWTextbox swtxtImagen;
        private CustomControls.SWTextbox swtxtIPPlanet;
        private System.Windows.Forms.Label lblIPPlanet;
        private System.Windows.Forms.Label lblPortPlanet;
        private CustomControls.SWTextbox swtxtbox;
        private System.Windows.Forms.Label lblPortPlanet1;
        private CustomControls.SWTextbox swtxtPortPlanet;
        private CustomControls.RJControls.RJButton rjbtnImage;
    }
}