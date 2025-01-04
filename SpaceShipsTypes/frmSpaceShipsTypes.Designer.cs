
namespace SpaceShipsTypes
{
    partial class frmSpaceShipsTypes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descTxt = new CustomControls.SWTextbox();
            this.codeTxt = new CustomControls.SWTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.filiationCmb = new System.Windows.Forms.ComboBox();
            this.categoryCmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Desc";
            // 
            // descTxt
            // 
            this.descTxt.EsForanea = false;
            this.descTxt.Location = new System.Drawing.Point(399, 224);
            this.descTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.descTxt.Name = "descTxt";
            this.descTxt.NomCampBBDD = "DescSpaceShipType";
            this.descTxt.PermetreBuit = true;
            this.descTxt.Size = new System.Drawing.Size(188, 26);
            this.descTxt.TabIndex = 6;
            this.descTxt.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // codeTxt
            // 
            this.codeTxt.EsForanea = false;
            this.codeTxt.Location = new System.Drawing.Point(396, 172);
            this.codeTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.codeTxt.Name = "codeTxt";
            this.codeTxt.NomCampBBDD = "CodeSpaceShipType";
            this.codeTxt.PermetreBuit = true;
            this.codeTxt.Size = new System.Drawing.Size(191, 26);
            this.codeTxt.TabIndex = 5;
            this.codeTxt.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(719, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Filiation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(623, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Space Ship Category";
            // 
            // filiationCmb
            // 
            this.filiationCmb.FormattingEnabled = true;
            this.filiationCmb.Location = new System.Drawing.Point(798, 176);
            this.filiationCmb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filiationCmb.Name = "filiationCmb";
            this.filiationCmb.Size = new System.Drawing.Size(191, 28);
            this.filiationCmb.TabIndex = 14;
            // 
            // categoryCmb
            // 
            this.categoryCmb.FormattingEnabled = true;
            this.categoryCmb.Location = new System.Drawing.Point(798, 227);
            this.categoryCmb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.categoryCmb.Name = "categoryCmb";
            this.categoryCmb.Size = new System.Drawing.Size(191, 28);
            this.categoryCmb.TabIndex = 15;
            // 
            // frmSpaceShipsTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 632);
            this.Controls.Add(this.categoryCmb);
            this.Controls.Add(this.filiationCmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descTxt);
            this.Controls.Add(this.codeTxt);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmSpaceShipsTypes";
            this.Text = "frmSpaceShipsTypes";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.Controls.SetChildIndex(this.codeTxt, 0);
            this.Controls.SetChildIndex(this.descTxt, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.filiationCmb, 0);
            this.Controls.SetChildIndex(this.categoryCmb, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextbox codeTxt;
        private CustomControls.SWTextbox descTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox filiationCmb;
        private System.Windows.Forms.ComboBox categoryCmb;
    }
}