
namespace SpaceShipCategories
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
            this.txtBoxCodeSpaceShipCategory = new CustomControls.SWTextbox();
            this.txtBoxDescSpaceShipCategory = new CustomControls.SWTextbox();
            this.lblCodeSpaceShipCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxCodeSpaceShipCategory
            // 
            this.txtBoxCodeSpaceShipCategory.EsForanea = false;
            this.txtBoxCodeSpaceShipCategory.Location = new System.Drawing.Point(227, 58);
            this.txtBoxCodeSpaceShipCategory.Name = "txtBoxCodeSpaceShipCategory";
            this.txtBoxCodeSpaceShipCategory.NomCampBBDD = "CodeSpaceShipCategory";
            this.txtBoxCodeSpaceShipCategory.PermetreBuit = true;
            this.txtBoxCodeSpaceShipCategory.Size = new System.Drawing.Size(259, 26);
            this.txtBoxCodeSpaceShipCategory.TabIndex = 5;
            this.txtBoxCodeSpaceShipCategory.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // txtBoxDescSpaceShipCategory
            // 
            this.txtBoxDescSpaceShipCategory.EsForanea = false;
            this.txtBoxDescSpaceShipCategory.Location = new System.Drawing.Point(227, 121);
            this.txtBoxDescSpaceShipCategory.Name = "txtBoxDescSpaceShipCategory";
            this.txtBoxDescSpaceShipCategory.NomCampBBDD = "DescSpaceShipCategory";
            this.txtBoxDescSpaceShipCategory.PermetreBuit = true;
            this.txtBoxDescSpaceShipCategory.Size = new System.Drawing.Size(259, 26);
            this.txtBoxDescSpaceShipCategory.TabIndex = 6;
            this.txtBoxDescSpaceShipCategory.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // lblCodeSpaceShipCategory
            // 
            this.lblCodeSpaceShipCategory.AutoSize = true;
            this.lblCodeSpaceShipCategory.Location = new System.Drawing.Point(223, 35);
            this.lblCodeSpaceShipCategory.Name = "lblCodeSpaceShipCategory";
            this.lblCodeSpaceShipCategory.Size = new System.Drawing.Size(180, 20);
            this.lblCodeSpaceShipCategory.TabIndex = 7;
            this.lblCodeSpaceShipCategory.Text = "Code spacehip category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Desc spaceship category";
            // 
            // frmSpaceshipsCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 559);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCodeSpaceShipCategory);
            this.Controls.Add(this.txtBoxDescSpaceShipCategory);
            this.Controls.Add(this.txtBoxCodeSpaceShipCategory);
            this.Name = "frmSpaceshipsCategories";
            this.Load += new System.EventHandler(this.frmSpaceshipsCategories_Load);
            this.Controls.SetChildIndex(this.txtBoxCodeSpaceShipCategory, 0);
            this.Controls.SetChildIndex(this.txtBoxDescSpaceShipCategory, 0);
            this.Controls.SetChildIndex(this.lblCodeSpaceShipCategory, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextbox txtBoxCodeSpaceShipCategory;
        private CustomControls.SWTextbox txtBoxDescSpaceShipCategory;
        private System.Windows.Forms.Label lblCodeSpaceShipCategory;
        private System.Windows.Forms.Label label1;
    }
}