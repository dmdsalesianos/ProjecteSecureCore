﻿
namespace Planets
{
    partial class frmPlanets
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.lblIPPlanet = new System.Windows.Forms.Label();
            this.lblPortPlanet = new System.Windows.Forms.Label();
            this.lblPortPlanet1 = new System.Windows.Forms.Label();
            this.swTextbox3 = new CustomControls.SWTextbox();
            this.swTextbox2 = new CustomControls.SWTextbox();
            this.swTextbox1 = new CustomControls.SWTextbox();
            this.swtxtLat = new CustomControls.SWTextbox();
            this.swtxtLong = new CustomControls.SWTextbox();
            this.swtxtParsecs = new CustomControls.SWTextbox();
            this.swtxtDescPlanet = new CustomControls.SWTextbox();
            this.swtxtCodePlanet = new CustomControls.SWTextbox();
            this.swtxtImagen = new CustomControls.SWTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodePlanet
            // 
            this.lblCodePlanet.AutoSize = true;
            this.lblCodePlanet.Location = new System.Drawing.Point(22, 13);
            this.lblCodePlanet.Name = "lblCodePlanet";
            this.lblCodePlanet.Size = new System.Drawing.Size(95, 20);
            this.lblCodePlanet.TabIndex = 6;
            this.lblCodePlanet.Text = "Code planet";
            // 
            // lblDescPlanet
            // 
            this.lblDescPlanet.AutoSize = true;
            this.lblDescPlanet.Location = new System.Drawing.Point(22, 74);
            this.lblDescPlanet.Name = "lblDescPlanet";
            this.lblDescPlanet.Size = new System.Drawing.Size(131, 20);
            this.lblDescPlanet.TabIndex = 8;
            this.lblDescPlanet.Text = "Descripció planet";
            // 
            // lblParsecs
            // 
            this.lblParsecs.AutoSize = true;
            this.lblParsecs.Location = new System.Drawing.Point(22, 135);
            this.lblParsecs.Name = "lblParsecs";
            this.lblParsecs.Size = new System.Drawing.Size(66, 20);
            this.lblParsecs.TabIndex = 10;
            this.lblParsecs.Text = "Parsecs";
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.Location = new System.Drawing.Point(252, 13);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(71, 20);
            this.lblLongitud.TabIndex = 12;
            this.lblLongitud.Text = "Longitud";
            // 
            // lblLatitud
            // 
            this.lblLatitud.AutoSize = true;
            this.lblLatitud.Location = new System.Drawing.Point(252, 74);
            this.lblLatitud.Name = "lblLatitud";
            this.lblLatitud.Size = new System.Drawing.Size(58, 20);
            this.lblLatitud.TabIndex = 14;
            this.lblLatitud.Text = "Latitud";
            // 
            // cmbNatives
            // 
            this.cmbNatives.FormattingEnabled = true;
            this.cmbNatives.Location = new System.Drawing.Point(482, 97);
            this.cmbNatives.Name = "cmbNatives";
            this.cmbNatives.Size = new System.Drawing.Size(194, 28);
            this.cmbNatives.TabIndex = 15;
            // 
            // cmbFiliations
            // 
            this.cmbFiliations.FormattingEnabled = true;
            this.cmbFiliations.Location = new System.Drawing.Point(482, 156);
            this.cmbFiliations.Name = "cmbFiliations";
            this.cmbFiliations.Size = new System.Drawing.Size(194, 28);
            this.cmbFiliations.TabIndex = 16;
            // 
            // cmbSector
            // 
            this.cmbSector.FormattingEnabled = true;
            this.cmbSector.Location = new System.Drawing.Point(482, 34);
            this.cmbSector.Name = "cmbSector";
            this.cmbSector.Size = new System.Drawing.Size(194, 28);
            this.cmbSector.TabIndex = 17;
            this.cmbSector.Tag = "";
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Location = new System.Drawing.Point(478, 13);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(56, 20);
            this.lblSector.TabIndex = 18;
            this.lblSector.Text = "Sector";
            // 
            // lblNatives
            // 
            this.lblNatives.AutoSize = true;
            this.lblNatives.Location = new System.Drawing.Point(478, 74);
            this.lblNatives.Name = "lblNatives";
            this.lblNatives.Size = new System.Drawing.Size(61, 20);
            this.lblNatives.TabIndex = 19;
            this.lblNatives.Text = "Natives";
            // 
            // lblFiliation
            // 
            this.lblFiliation.AutoSize = true;
            this.lblFiliation.Location = new System.Drawing.Point(478, 135);
            this.lblFiliation.Name = "lblFiliation";
            this.lblFiliation.Size = new System.Drawing.Size(63, 20);
            this.lblFiliation.TabIndex = 20;
            this.lblFiliation.Text = "Filiation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(26, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "PlanetPicture";
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(482, 210);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(174, 34);
            this.btnImage.TabIndex = 22;
            this.btnImage.Text = "Select Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // lblIPPlanet
            // 
            this.lblIPPlanet.AutoSize = true;
            this.lblIPPlanet.Location = new System.Drawing.Point(252, 135);
            this.lblIPPlanet.Name = "lblIPPlanet";
            this.lblIPPlanet.Size = new System.Drawing.Size(69, 20);
            this.lblIPPlanet.TabIndex = 25;
            this.lblIPPlanet.Text = "IPPlanet";
            // 
            // lblPortPlanet
            // 
            this.lblPortPlanet.AutoSize = true;
            this.lblPortPlanet.Location = new System.Drawing.Point(22, 195);
            this.lblPortPlanet.Name = "lblPortPlanet";
            this.lblPortPlanet.Size = new System.Drawing.Size(87, 20);
            this.lblPortPlanet.TabIndex = 27;
            this.lblPortPlanet.Text = "Port Planet";
            // 
            // lblPortPlanet1
            // 
            this.lblPortPlanet1.AutoSize = true;
            this.lblPortPlanet1.Location = new System.Drawing.Point(252, 195);
            this.lblPortPlanet1.Name = "lblPortPlanet1";
            this.lblPortPlanet1.Size = new System.Drawing.Size(100, 20);
            this.lblPortPlanet1.TabIndex = 29;
            this.lblPortPlanet1.Text = "Port Planet 1";
            // 
            // swTextbox3
            // 
            this.swTextbox3.EsForanea = false;
            this.swTextbox3.Location = new System.Drawing.Point(256, 218);
            this.swTextbox3.Name = "swTextbox3";
            this.swTextbox3.NomCampBBDD = "PortPlanet1";
            this.swTextbox3.PermetreBuit = true;
            this.swTextbox3.Size = new System.Drawing.Size(174, 26);
            this.swTextbox3.TabIndex = 28;
            this.swTextbox3.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Number;
            this.swTextbox3.TextChanged += new System.EventHandler(this.swTextbox3_TextChanged);
            // 
            // swTextbox2
            // 
            this.swTextbox2.EsForanea = false;
            this.swTextbox2.Location = new System.Drawing.Point(26, 218);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.NomCampBBDD = "PortPlanet";
            this.swTextbox2.PermetreBuit = true;
            this.swTextbox2.Size = new System.Drawing.Size(174, 26);
            this.swTextbox2.TabIndex = 26;
            this.swTextbox2.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Number;
            // 
            // swTextbox1
            // 
            this.swTextbox1.EsForanea = false;
            this.swTextbox1.Location = new System.Drawing.Point(256, 158);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.NomCampBBDD = "IPPlanet";
            this.swTextbox1.PermetreBuit = true;
            this.swTextbox1.Size = new System.Drawing.Size(174, 26);
            this.swTextbox1.TabIndex = 24;
            this.swTextbox1.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Number;
            // 
            // swtxtLat
            // 
            this.swtxtLat.EsForanea = false;
            this.swtxtLat.Location = new System.Drawing.Point(256, 97);
            this.swtxtLat.Name = "swtxtLat";
            this.swtxtLat.NomCampBBDD = "lat";
            this.swtxtLat.PermetreBuit = true;
            this.swtxtLat.Size = new System.Drawing.Size(174, 26);
            this.swtxtLat.TabIndex = 13;
            this.swtxtLat.Tag = "";
            this.swtxtLat.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // swtxtLong
            // 
            this.swtxtLong.EsForanea = false;
            this.swtxtLong.Location = new System.Drawing.Point(256, 36);
            this.swtxtLong.Name = "swtxtLong";
            this.swtxtLong.NomCampBBDD = "long";
            this.swtxtLong.PermetreBuit = true;
            this.swtxtLong.Size = new System.Drawing.Size(174, 26);
            this.swtxtLong.TabIndex = 11;
            this.swtxtLong.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // swtxtParsecs
            // 
            this.swtxtParsecs.EsForanea = false;
            this.swtxtParsecs.Location = new System.Drawing.Point(26, 158);
            this.swtxtParsecs.Name = "swtxtParsecs";
            this.swtxtParsecs.NomCampBBDD = "parsecs";
            this.swtxtParsecs.PermetreBuit = true;
            this.swtxtParsecs.Size = new System.Drawing.Size(174, 26);
            this.swtxtParsecs.TabIndex = 9;
            this.swtxtParsecs.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // swtxtDescPlanet
            // 
            this.swtxtDescPlanet.EsForanea = false;
            this.swtxtDescPlanet.Location = new System.Drawing.Point(26, 97);
            this.swtxtDescPlanet.Name = "swtxtDescPlanet";
            this.swtxtDescPlanet.NomCampBBDD = "DescPlanet";
            this.swtxtDescPlanet.PermetreBuit = true;
            this.swtxtDescPlanet.Size = new System.Drawing.Size(174, 26);
            this.swtxtDescPlanet.TabIndex = 7;
            this.swtxtDescPlanet.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // swtxtCodePlanet
            // 
            this.swtxtCodePlanet.EsForanea = false;
            this.swtxtCodePlanet.Location = new System.Drawing.Point(26, 36);
            this.swtxtCodePlanet.Name = "swtxtCodePlanet";
            this.swtxtCodePlanet.NomCampBBDD = "CodePlanet";
            this.swtxtCodePlanet.PermetreBuit = true;
            this.swtxtCodePlanet.Size = new System.Drawing.Size(174, 26);
            this.swtxtCodePlanet.TabIndex = 5;
            this.swtxtCodePlanet.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // swtxtImagen
            // 
            this.swtxtImagen.EsForanea = false;
            this.swtxtImagen.Location = new System.Drawing.Point(71, 353);
            this.swtxtImagen.Name = "swtxtImagen";
            this.swtxtImagen.NomCampBBDD = "PlanetPicture";
            this.swtxtImagen.PermetreBuit = true;
            this.swtxtImagen.Size = new System.Drawing.Size(108, 26);
            this.swtxtImagen.TabIndex = 23;
            this.swtxtImagen.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            this.swtxtImagen.TextChanged += new System.EventHandler(this.swtxtImagen_TextChanged);
            // 
            // frmPlanets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 566);
            this.Controls.Add(this.lblPortPlanet1);
            this.Controls.Add(this.swTextbox3);
            this.Controls.Add(this.lblPortPlanet);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.lblIPPlanet);
            this.Controls.Add(this.swTextbox1);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.pictureBox1);
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
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.btnImage, 0);
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.lblIPPlanet, 0);
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.Controls.SetChildIndex(this.lblPortPlanet, 0);
            this.Controls.SetChildIndex(this.swTextbox3, 0);
            this.Controls.SetChildIndex(this.lblPortPlanet1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnImage;
        private CustomControls.SWTextbox swtxtImagen;
        private CustomControls.SWTextbox swTextbox1;
        private System.Windows.Forms.Label lblIPPlanet;
        private System.Windows.Forms.Label lblPortPlanet;
        private CustomControls.SWTextbox swTextbox2;
        private System.Windows.Forms.Label lblPortPlanet1;
        private CustomControls.SWTextbox swTextbox3;
    }
}

