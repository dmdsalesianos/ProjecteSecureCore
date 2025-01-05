
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
            this.lblAccessLevel = new System.Windows.Forms.Label();
            this.swtxtAccessLevel = new CustomControls.SWTextbox();
            this.SuspendLayout();
            // 
            // swtxtCodeCategory
            // 
            this.swtxtCodeCategory.EsForanea = false;
            this.swtxtCodeCategory.Location = new System.Drawing.Point(344, 107);
            this.swtxtCodeCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.swtxtCodeCategory.Name = "swtxtCodeCategory";
            this.swtxtCodeCategory.NomCampBBDD = "CodeCategory";
            this.swtxtCodeCategory.PermetreBuit = true;
            this.swtxtCodeCategory.Size = new System.Drawing.Size(211, 20);
            this.swtxtCodeCategory.TabIndex = 1;
            this.swtxtCodeCategory.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // swtxtDescCategory
            // 
            this.swtxtDescCategory.EsForanea = false;
            this.swtxtDescCategory.Location = new System.Drawing.Point(344, 145);
            this.swtxtDescCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.swtxtDescCategory.Name = "swtxtDescCategory";
            this.swtxtDescCategory.NomCampBBDD = "DescCategory";
            this.swtxtDescCategory.PermetreBuit = true;
            this.swtxtDescCategory.Size = new System.Drawing.Size(211, 20);
            this.swtxtDescCategory.TabIndex = 2;
            this.swtxtDescCategory.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // lblCodeCategory
            // 
            this.lblCodeCategory.AutoSize = true;
            this.lblCodeCategory.Location = new System.Drawing.Point(243, 109);
            this.lblCodeCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodeCategory.Name = "lblCodeCategory";
            this.lblCodeCategory.Size = new System.Drawing.Size(77, 13);
            this.lblCodeCategory.TabIndex = 7;
            this.lblCodeCategory.Text = "Code Category";
            // 
            // lblDescCategory
            // 
            this.lblDescCategory.AutoSize = true;
            this.lblDescCategory.Location = new System.Drawing.Point(219, 145);
            this.lblDescCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescCategory.Name = "lblDescCategory";
            this.lblDescCategory.Size = new System.Drawing.Size(102, 13);
            this.lblDescCategory.TabIndex = 8;
            this.lblDescCategory.Text = "Descripció Category";
            // 
            // lblAccessLevel
            // 
            this.lblAccessLevel.AutoSize = true;
            this.lblAccessLevel.Location = new System.Drawing.Point(249, 176);
            this.lblAccessLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccessLevel.Name = "lblAccessLevel";
            this.lblAccessLevel.Size = new System.Drawing.Size(71, 13);
            this.lblAccessLevel.TabIndex = 9;
            this.lblAccessLevel.Text = "Access Level";
            // 
            // swtxtAccessLevel
            // 
            this.swtxtAccessLevel.EsForanea = false;
            this.swtxtAccessLevel.Location = new System.Drawing.Point(344, 176);
            this.swtxtAccessLevel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.swtxtAccessLevel.Name = "swtxtAccessLevel";
            this.swtxtAccessLevel.NomCampBBDD = "AccessLevel";
            this.swtxtAccessLevel.PermetreBuit = true;
            this.swtxtAccessLevel.Size = new System.Drawing.Size(211, 20);
            this.swtxtAccessLevel.TabIndex = 3;
            this.swtxtAccessLevel.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Number;
            // 
            // frmUserCategories
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 439);
            this.Controls.Add(this.swtxtAccessLevel);
            this.Controls.Add(this.lblAccessLevel);
            this.Controls.Add(this.lblDescCategory);
            this.Controls.Add(this.lblCodeCategory);
            this.Controls.Add(this.swtxtDescCategory);
            this.Controls.Add(this.swtxtCodeCategory);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmUserCategories";
            this.TabIndexActualitzarBtn = 5;
            this.TabIndexAgregarBtn = 4;
            this.Text = "frmUsers";
            this.Load += new System.EventHandler(this.frmUserCategories_Load);
            this.Controls.SetChildIndex(this.swtxtCodeCategory, 0);
            this.Controls.SetChildIndex(this.swtxtDescCategory, 0);
            this.Controls.SetChildIndex(this.lblCodeCategory, 0);
            this.Controls.SetChildIndex(this.lblDescCategory, 0);
            this.Controls.SetChildIndex(this.lblAccessLevel, 0);
            this.Controls.SetChildIndex(this.swtxtAccessLevel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextbox swtxtCodeCategory;
        private CustomControls.SWTextbox swtxtDescCategory;
        private System.Windows.Forms.Label lblCodeCategory;
        private System.Windows.Forms.Label lblDescCategory;
        private System.Windows.Forms.Label lblAccessLevel;
        private CustomControls.SWTextbox swtxtAccessLevel;
    }
}