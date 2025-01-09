
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
            this.swtxtCodeCategory.Location = new System.Drawing.Point(252, 160);
            this.swtxtCodeCategory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.swtxtCodeCategory.Name = "swtxtCodeCategory";
            this.swtxtCodeCategory.NomCampBBDD = "CodeCategory";
            this.swtxtCodeCategory.PermetreBuit = true;
            this.swtxtCodeCategory.Size = new System.Drawing.Size(314, 26);
            this.swtxtCodeCategory.TabIndex = 1;
            this.swtxtCodeCategory.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // swtxtDescCategory
            // 
            this.swtxtDescCategory.EsForanea = false;
            this.swtxtDescCategory.Location = new System.Drawing.Point(252, 206);
            this.swtxtDescCategory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.swtxtDescCategory.Name = "swtxtDescCategory";
            this.swtxtDescCategory.NomCampBBDD = "DescCategory";
            this.swtxtDescCategory.PermetreBuit = true;
            this.swtxtDescCategory.Size = new System.Drawing.Size(314, 26);
            this.swtxtDescCategory.TabIndex = 2;
            this.swtxtDescCategory.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // lblCodeCategory
            // 
            this.lblCodeCategory.AutoSize = true;
            this.lblCodeCategory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeCategory.Location = new System.Drawing.Point(76, 166);
            this.lblCodeCategory.Name = "lblCodeCategory";
            this.lblCodeCategory.Size = new System.Drawing.Size(133, 20);
            this.lblCodeCategory.TabIndex = 7;
            this.lblCodeCategory.Text = "Code Category";
            // 
            // lblDescCategory
            // 
            this.lblDescCategory.AutoSize = true;
            this.lblDescCategory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescCategory.Location = new System.Drawing.Point(30, 212);
            this.lblDescCategory.Name = "lblDescCategory";
            this.lblDescCategory.Size = new System.Drawing.Size(179, 20);
            this.lblDescCategory.TabIndex = 8;
            this.lblDescCategory.Text = "Descripció Category";
            // 
            // lblAccessLevel
            // 
            this.lblAccessLevel.AutoSize = true;
            this.lblAccessLevel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessLevel.Location = new System.Drawing.Point(90, 260);
            this.lblAccessLevel.Name = "lblAccessLevel";
            this.lblAccessLevel.Size = new System.Drawing.Size(117, 20);
            this.lblAccessLevel.TabIndex = 9;
            this.lblAccessLevel.Text = "Access Level";
            // 
            // swtxtAccessLevel
            // 
            this.swtxtAccessLevel.EsForanea = false;
            this.swtxtAccessLevel.Location = new System.Drawing.Point(252, 253);
            this.swtxtAccessLevel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.swtxtAccessLevel.Name = "swtxtAccessLevel";
            this.swtxtAccessLevel.NomCampBBDD = "AccessLevel";
            this.swtxtAccessLevel.PermetreBuit = true;
            this.swtxtAccessLevel.Size = new System.Drawing.Size(314, 26);
            this.swtxtAccessLevel.TabIndex = 3;
            this.swtxtAccessLevel.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Number;
            // 
            // frmUserCategories
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 675);
            this.Controls.Add(this.swtxtAccessLevel);
            this.Controls.Add(this.lblAccessLevel);
            this.Controls.Add(this.lblDescCategory);
            this.Controls.Add(this.lblCodeCategory);
            this.Controls.Add(this.swtxtDescCategory);
            this.Controls.Add(this.swtxtCodeCategory);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
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