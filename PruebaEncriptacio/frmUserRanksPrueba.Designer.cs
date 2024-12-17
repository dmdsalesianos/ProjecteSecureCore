
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
            this.codeRankTxt.Location = new System.Drawing.Point(279, 34);
            this.codeRankTxt.Name = "codeRankTxt";
            this.codeRankTxt.NomCampBBDD = "CodeRank";
            this.codeRankTxt.PermetreBuit = true;
            this.codeRankTxt.Size = new System.Drawing.Size(199, 22);
            this.codeRankTxt.TabIndex = 5;
            this.codeRankTxt.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // descRankTxt
            // 
            this.descRankTxt.EsForanea = false;
            this.descRankTxt.Location = new System.Drawing.Point(279, 96);
            this.descRankTxt.Name = "descRankTxt";
            this.descRankTxt.NomCampBBDD = "DescRank";
            this.descRankTxt.PermetreBuit = true;
            this.descRankTxt.Size = new System.Drawing.Size(199, 22);
            this.descRankTxt.TabIndex = 6;
            this.descRankTxt.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // codeRankLbl
            // 
            this.codeRankLbl.AutoSize = true;
            this.codeRankLbl.Location = new System.Drawing.Point(199, 37);
            this.codeRankLbl.Name = "codeRankLbl";
            this.codeRankLbl.Size = new System.Drawing.Size(74, 17);
            this.codeRankLbl.TabIndex = 7;
            this.codeRankLbl.Text = "CodeRank";
            // 
            // descRankLbl
            // 
            this.descRankLbl.AutoSize = true;
            this.descRankLbl.Location = new System.Drawing.Point(199, 99);
            this.descRankLbl.Name = "descRankLbl";
            this.descRankLbl.Size = new System.Drawing.Size(73, 17);
            this.descRankLbl.TabIndex = 8;
            this.descRankLbl.Text = "DescRank";
            // 
            // frmUserRanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 530);
            this.Controls.Add(this.descRankLbl);
            this.Controls.Add(this.codeRankLbl);
            this.Controls.Add(this.descRankTxt);
            this.Controls.Add(this.codeRankTxt);
            this.Name = "frmUserRanks";
            this.Text = "frmUserRanks";
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