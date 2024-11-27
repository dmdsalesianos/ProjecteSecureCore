
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
            this.codeTxt = new Sprint53_G4.SWTextbox();
            this.descTxt = new Sprint53_G4.SWTextbox();
            this.descCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filiationTxt = new Sprint53_G4.SWTextbox();
            this.categoryTxt = new Sprint53_G4.SWTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // codeTxt
            // 
            this.codeTxt.EsForanea = false;
            this.codeTxt.Location = new System.Drawing.Point(183, 29);
            this.codeTxt.Name = "codeTxt";
            this.codeTxt.NomCampBBDD = "CodeSpaceShipType";
            this.codeTxt.PermetreBuit = true;
            this.codeTxt.Size = new System.Drawing.Size(170, 22);
            this.codeTxt.TabIndex = 5;
            this.codeTxt.TipusDada = Sprint53_G4.SWTextbox.Tipus_Dada.Text;
            // 
            // descTxt
            // 
            this.descTxt.EsForanea = false;
            this.descTxt.Location = new System.Drawing.Point(183, 69);
            this.descTxt.Name = "descTxt";
            this.descTxt.NomCampBBDD = "DescSpaceShipType";
            this.descTxt.PermetreBuit = true;
            this.descTxt.Size = new System.Drawing.Size(168, 22);
            this.descTxt.TabIndex = 6;
            this.descTxt.TipusDada = Sprint53_G4.SWTextbox.Tipus_Dada.Text;
            // 
            // descCmb
            // 
            this.descCmb.FormattingEnabled = true;
            this.descCmb.Location = new System.Drawing.Point(390, 71);
            this.descCmb.Name = "descCmb";
            this.descCmb.Size = new System.Drawing.Size(136, 24);
            this.descCmb.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Desc";
            // 
            // filiationTxt
            // 
            this.filiationTxt.EsForanea = true;
            this.filiationTxt.Location = new System.Drawing.Point(183, 114);
            this.filiationTxt.Name = "filiationTxt";
            this.filiationTxt.NomCampBBDD = null;
            this.filiationTxt.PermetreBuit = true;
            this.filiationTxt.Size = new System.Drawing.Size(168, 22);
            this.filiationTxt.TabIndex = 10;
            this.filiationTxt.TipusDada = Sprint53_G4.SWTextbox.Tipus_Dada.Number;
            // 
            // categoryTxt
            // 
            this.categoryTxt.EsForanea = true;
            this.categoryTxt.Location = new System.Drawing.Point(183, 155);
            this.categoryTxt.Name = "categoryTxt";
            this.categoryTxt.NomCampBBDD = null;
            this.categoryTxt.PermetreBuit = true;
            this.categoryTxt.Size = new System.Drawing.Size(168, 22);
            this.categoryTxt.TabIndex = 11;
            this.categoryTxt.TipusDada = Sprint53_G4.SWTextbox.Tipus_Dada.Number;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Filiation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Category";
            // 
            // frmSpaceShipsTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.categoryTxt);
            this.Controls.Add(this.filiationTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descCmb);
            this.Controls.Add(this.descTxt);
            this.Controls.Add(this.codeTxt);
            this.Name = "frmSpaceShipsTypes";
            this.Text = "frmSpaceShipsTypes";
            this.Controls.SetChildIndex(this.codeTxt, 0);
            this.Controls.SetChildIndex(this.descTxt, 0);
            this.Controls.SetChildIndex(this.descCmb, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.filiationTxt, 0);
            this.Controls.SetChildIndex(this.categoryTxt, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sprint53_G4.SWTextbox codeTxt;
        private Sprint53_G4.SWTextbox descTxt;
        private System.Windows.Forms.ComboBox descCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Sprint53_G4.SWTextbox filiationTxt;
        private Sprint53_G4.SWTextbox categoryTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}