
namespace UserRanks
{
    partial class frmUserRanks
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
            this.codeRankTxt = new CustomControls.SWTextbox();
            this.descRankTxt = new CustomControls.SWTextbox();
            this.codeRankLbl = new System.Windows.Forms.Label();
            this.descRankLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // codeRankTxt
            // 
            this.codeRankTxt.EsForanea = false;
            this.codeRankTxt.Location = new System.Drawing.Point(169, 197);
            this.codeRankTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.codeRankTxt.Name = "codeRankTxt";
            this.codeRankTxt.NomCampBBDD = "CodeRank";
            this.codeRankTxt.PermetreBuit = true;
            this.codeRankTxt.Size = new System.Drawing.Size(223, 26);
            this.codeRankTxt.TabIndex = 1;
            this.codeRankTxt.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // descRankTxt
            // 
            this.descRankTxt.EsForanea = false;
            this.descRankTxt.Location = new System.Drawing.Point(169, 240);
            this.descRankTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.descRankTxt.Name = "descRankTxt";
            this.descRankTxt.NomCampBBDD = "DescRank";
            this.descRankTxt.PermetreBuit = true;
            this.descRankTxt.Size = new System.Drawing.Size(223, 26);
            this.descRankTxt.TabIndex = 2;
            this.descRankTxt.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // codeRankLbl
            // 
            this.codeRankLbl.AutoSize = true;
            this.codeRankLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeRankLbl.Location = new System.Drawing.Point(33, 203);
            this.codeRankLbl.Name = "codeRankLbl";
            this.codeRankLbl.Size = new System.Drawing.Size(95, 20);
            this.codeRankLbl.TabIndex = 7;
            this.codeRankLbl.Text = "CodeRank";
            // 
            // descRankLbl
            // 
            this.descRankLbl.AutoSize = true;
            this.descRankLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descRankLbl.Location = new System.Drawing.Point(34, 247);
            this.descRankLbl.Name = "descRankLbl";
            this.descRankLbl.Size = new System.Drawing.Size(93, 20);
            this.descRankLbl.TabIndex = 8;
            this.descRankLbl.Text = "DescRank";
            // 
            // frmUserRanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 662);
            this.Controls.Add(this.descRankLbl);
            this.Controls.Add(this.codeRankLbl);
            this.Controls.Add(this.descRankTxt);
            this.Controls.Add(this.codeRankTxt);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "frmUserRanks";
            this.TabIndexActualitzarBtn = 4;
            this.TabIndexAgregarBtn = 3;
            this.Text = "frmUserRanks";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.Controls.SetChildIndex(this.codeRankTxt, 0);
            this.Controls.SetChildIndex(this.descRankTxt, 0);
            this.Controls.SetChildIndex(this.codeRankLbl, 0);
            this.Controls.SetChildIndex(this.descRankLbl, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextbox codeRankTxt;
        private CustomControls.SWTextbox descRankTxt;
        private System.Windows.Forms.Label codeRankLbl;
        private System.Windows.Forms.Label descRankLbl;
    }
}