
namespace UserCategories
{
    partial class frmUserCategories
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
            this.swTextbox1 = new CustomControls.SWTextbox();
            this.swTextbox2 = new CustomControls.SWTextbox();
            this.SuspendLayout();
            // 
            // swTextbox1
            // 
            this.swTextbox1.EsForanea = false;
            this.swTextbox1.Location = new System.Drawing.Point(134, 40);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.NomCampBBDD = "CodeCategory";
            this.swTextbox1.PermetreBuit = true;
            this.swTextbox1.Size = new System.Drawing.Size(280, 22);
            this.swTextbox1.TabIndex = 5;
            this.swTextbox1.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // swTextbox2
            // 
            this.swTextbox2.EsForanea = false;
            this.swTextbox2.Location = new System.Drawing.Point(134, 96);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.NomCampBBDD = "DescCategory";
            this.swTextbox2.PermetreBuit = true;
            this.swTextbox2.Size = new System.Drawing.Size(280, 22);
            this.swTextbox2.TabIndex = 6;
            this.swTextbox2.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Number;
            // 
            // frmUserCategories
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 541);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swTextbox1);
            this.Name = "frmUserCategories";
            this.Text = "frmUsers";
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextbox swTextbox1;
        private CustomControls.SWTextbox swTextbox2;
    }
}