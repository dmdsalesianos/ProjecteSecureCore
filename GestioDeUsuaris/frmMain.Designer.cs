
namespace GestioDeUsuaris
{
    partial class frmMain
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
            this.swCodi1 = new Sprint53_G4.SWCodi();
            this.swLaunchForm1 = new Sprint53_G4.SWLaunchForm();
            this.SuspendLayout();
            // 
            // swCodi1
            // 
            this.swCodi1.ClaseCS = "SpcaeShipCategories";
            this.swCodi1.ControlID = "idSpaceShipCategory";
            this.swCodi1.FormCS = "frmSpaceShipCategories";
            this.swCodi1.Location = new System.Drawing.Point(12, 119);
            this.swCodi1.Name = "swCodi1";
            this.swCodi1.NomCodi = "codeSpaceShipCategory";
            this.swCodi1.NomDesc = "DescSpaceShipCategory";
            this.swCodi1.NomId = "idSpaceShipCategory";
            this.swCodi1.NomTaula = "SpaceShipCategories";
            this.swCodi1.Size = new System.Drawing.Size(455, 51);
            this.swCodi1.TabIndex = 1;
            // 
            // swLaunchForm1
            // 
            this.swLaunchForm1.Clase = "SpcaeShipCategories";
            this.swLaunchForm1.Descripcion = "spcae Ship Categories";
            this.swLaunchForm1.Form = "frmSpaceShipCategories";
            this.swLaunchForm1.Image = global::GestioDeUsuaris.Properties.Resources.Screenshot_2024_10_03_175751;
            this.swLaunchForm1.Location = new System.Drawing.Point(298, 3);
            this.swLaunchForm1.Name = "swLaunchForm1";
            this.swLaunchForm1.Size = new System.Drawing.Size(1171, 558);
            this.swLaunchForm1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 573);
            this.Controls.Add(this.swCodi1);
            this.Controls.Add(this.swLaunchForm1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private Sprint53_G4.SWLaunchForm swLaunchForm1;
        private Sprint53_G4.SWCodi swCodi1;
    }
}

