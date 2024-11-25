
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
            this.descCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descTxt = new Sprint53_G4.SWTextbox();
            this.codeTxt = new Sprint53_G4.SWTextbox();
            this.swTextbox1 = new Sprint53_G4.SWTextbox();
            this.swTextbox2 = new Sprint53_G4.SWTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // descCmb
            // 
            this.descCmb.DisplayMember = "DescFiliation";
            this.descCmb.FormattingEnabled = true;
            this.descCmb.Location = new System.Drawing.Point(407, 69);
            this.descCmb.Name = "descCmb";
            this.descCmb.Size = new System.Drawing.Size(136, 24);
            this.descCmb.TabIndex = 7;
            this.descCmb.ValueMember = "idFiliation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Desc";
            // 
            // descTxt
            // 
            this.descTxt.EsForanea = false;
            this.descTxt.Location = new System.Drawing.Point(202, 71);
            this.descTxt.Name = "descTxt";
            this.descTxt.NomCampBBDD = "DescSpaceShipType";
            this.descTxt.PermetreBuit = true;
            this.descTxt.Size = new System.Drawing.Size(168, 22);
            this.descTxt.TabIndex = 6;
            this.descTxt.TipusDada = Sprint53_G4.SWTextbox.Tipus_Dada.Text;
            // 
            // codeTxt
            // 
            this.codeTxt.EsForanea = false;
            this.codeTxt.Location = new System.Drawing.Point(202, 29);
            this.codeTxt.Name = "codeTxt";
            this.codeTxt.NomCampBBDD = "CodeSpaceShipType";
            this.codeTxt.PermetreBuit = true;
            this.codeTxt.Size = new System.Drawing.Size(170, 22);
            this.codeTxt.TabIndex = 5;
            this.codeTxt.TipusDada = Sprint53_G4.SWTextbox.Tipus_Dada.Text;
            // 
            // swTextbox1
            // 
            this.swTextbox1.EsForanea = false;
            this.swTextbox1.Location = new System.Drawing.Point(202, 111);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.NomCampBBDD = null;
            this.swTextbox1.PermetreBuit = true;
            this.swTextbox1.Size = new System.Drawing.Size(170, 22);
            this.swTextbox1.TabIndex = 10;
            this.swTextbox1.TipusDada = Sprint53_G4.SWTextbox.Tipus_Dada.Number;
            // 
            // swTextbox2
            // 
            this.swTextbox2.EsForanea = false;
            this.swTextbox2.Location = new System.Drawing.Point(202, 155);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.NomCampBBDD = null;
            this.swTextbox2.PermetreBuit = true;
            this.swTextbox2.Size = new System.Drawing.Size(170, 22);
            this.swTextbox2.TabIndex = 11;
            this.swTextbox2.TipusDada = Sprint53_G4.SWTextbox.Tipus_Dada.Number;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Filiation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Space Ship Category";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(407, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(72, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(407, 155);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(72, 24);
            this.comboBox2.TabIndex = 15;
            // 
            // frmSpaceShipsTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 506);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swTextbox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descCmb);
            this.Controls.Add(this.descTxt);
            this.Controls.Add(this.codeTxt);
            this.Name = "frmSpaceShipsTypes";
            this.Text = "frmSpaceShipsTypes";
            this.Load += new System.EventHandler(this.frmSpaceShipsTypes_Load);
            this.Controls.SetChildIndex(this.codeTxt, 0);
            this.Controls.SetChildIndex(this.descTxt, 0);
            this.Controls.SetChildIndex(this.descCmb, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.comboBox2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sprint53_G4.SWTextbox codeTxt;
        private Sprint53_G4.SWTextbox descTxt;
        private System.Windows.Forms.ComboBox descCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Sprint53_G4.SWTextbox swTextbox1;
        private Sprint53_G4.SWTextbox swTextbox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}