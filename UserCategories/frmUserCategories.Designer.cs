
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
            this.swtxtCodeCategory = new CustomControls.SWTextbox();
            this.swtxtDescCategory = new CustomControls.SWTextbox();
            this.lblCodeCategory = new System.Windows.Forms.Label();
            this.lblDescCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // swtxtCodeCategory
            // 
            this.swtxtCodeCategory.EsForanea = false;
            this.swtxtCodeCategory.Location = new System.Drawing.Point(336, 117);
            this.swtxtCodeCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.swtxtCodeCategory.Name = "swtxtCodeCategory";
            this.swtxtCodeCategory.NomCampBBDD = "CodeCategory";
            this.swtxtCodeCategory.PermetreBuit = true;
            this.swtxtCodeCategory.Size = new System.Drawing.Size(314, 26);
            this.swtxtCodeCategory.TabIndex = 5;
            this.swtxtCodeCategory.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // swtxtDescCategory
            // 
            this.swtxtDescCategory.EsForanea = false;
            this.swtxtDescCategory.Location = new System.Drawing.Point(336, 185);
            this.swtxtDescCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.swtxtDescCategory.Name = "swtxtDescCategory";
            this.swtxtDescCategory.NomCampBBDD = "DescCategory";
            this.swtxtDescCategory.PermetreBuit = true;
            this.swtxtDescCategory.Size = new System.Drawing.Size(314, 26);
            this.swtxtDescCategory.TabIndex = 6;
            this.swtxtDescCategory.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // lblCodeCategory
            // 
            this.lblCodeCategory.AutoSize = true;
            this.lblCodeCategory.Location = new System.Drawing.Point(332, 93);
            this.lblCodeCategory.Name = "lblCodeCategory";
            this.lblCodeCategory.Size = new System.Drawing.Size(115, 20);
            this.lblCodeCategory.TabIndex = 7;
            this.lblCodeCategory.Text = "Code Category";
            // 
            // lblDescCategory
            // 
            this.lblDescCategory.AutoSize = true;
            this.lblDescCategory.Location = new System.Drawing.Point(332, 161);
            this.lblDescCategory.Name = "lblDescCategory";
            this.lblDescCategory.Size = new System.Drawing.Size(151, 20);
            this.lblDescCategory.TabIndex = 8;
            this.lblDescCategory.Text = "Descripció Category";
            // 
            // frmUserCategories
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 676);
            this.Controls.Add(this.lblDescCategory);
            this.Controls.Add(this.lblCodeCategory);
            this.Controls.Add(this.swtxtDescCategory);
            this.Controls.Add(this.swtxtCodeCategory);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmUserCategories";
            this.Text = "frmUsers";
            this.Load += new System.EventHandler(this.frmUserCategories_Load);
            this.Controls.SetChildIndex(this.swtxtCodeCategory, 0);
            this.Controls.SetChildIndex(this.swtxtDescCategory, 0);
            this.Controls.SetChildIndex(this.lblCodeCategory, 0);
            this.Controls.SetChildIndex(this.lblDescCategory, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextbox swtxtCodeCategory;
        private CustomControls.SWTextbox swtxtDescCategory;
        private System.Windows.Forms.Label lblCodeCategory;
        private System.Windows.Forms.Label lblDescCategory;
    }
}