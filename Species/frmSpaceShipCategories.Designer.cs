﻿
namespace Species
{
    partial class frmSpaceShipCategories
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
            this.swTextbox1 = new Sprint53_G4.SWTextbox();
            this.swTextbox2 = new Sprint53_G4.SWTextbox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // swTextbox1
            // 
            this.swTextbox1.EsForanea = false;
            this.swTextbox1.Location = new System.Drawing.Point(55, 29);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.NomCampBBDD = "codeSpaceShipCategory";
            this.swTextbox1.PermetreBuit = true;
            this.swTextbox1.Size = new System.Drawing.Size(267, 22);
            this.swTextbox1.TabIndex = 5;
            this.swTextbox1.TipusDada = Sprint53_G4.SWTextbox.Tipus_Dada.Text;
            // 
            // swTextbox2
            // 
            this.swTextbox2.EsForanea = false;
            this.swTextbox2.Location = new System.Drawing.Point(55, 76);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.NomCampBBDD = "DescSpaceShipCategory";
            this.swTextbox2.PermetreBuit = true;
            this.swTextbox2.Size = new System.Drawing.Size(267, 22);
            this.swTextbox2.TabIndex = 6;
            this.swTextbox2.TipusDada = Sprint53_G4.SWTextbox.Tipus_Dada.Text;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "descSpaceShipCategory";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 209);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "idSpaceShipCategory";
            // 
            // frmSpaceShipCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 512);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swTextbox1);
            this.Name = "frmSpaceShipCategories";
            this.Text = "frmSpecies";
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sprint53_G4.SWTextbox swTextbox1;
        private Sprint53_G4.SWTextbox swTextbox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}