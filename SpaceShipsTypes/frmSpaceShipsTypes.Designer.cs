
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
            this.categoryCmb = new System.Windows.Forms.ComboBox();
            this.filiationCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descTxt = new CustomControls.SWTextbox();
            this.codeTxt = new CustomControls.SWTextbox();
            this.SuspendLayout();
            // 
            // categoryCmb
            // 
            this.categoryCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.categoryCmb.FormattingEnabled = true;
            this.categoryCmb.Location = new System.Drawing.Point(562, 236);
            this.categoryCmb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.categoryCmb.Name = "categoryCmb";
            this.categoryCmb.Size = new System.Drawing.Size(210, 28);
            this.categoryCmb.TabIndex = 4;
            // 
            // filiationCmb
            // 
            this.filiationCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.filiationCmb.FormattingEnabled = true;
            this.filiationCmb.Location = new System.Drawing.Point(562, 187);
            this.filiationCmb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.filiationCmb.Name = "filiationCmb";
            this.filiationCmb.Size = new System.Drawing.Size(210, 28);
            this.filiationCmb.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Space Ship Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(462, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Filiation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Desc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Code";
            // 
            // descTxt
            // 
            this.descTxt.EsForanea = false;
            this.descTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.descTxt.Location = new System.Drawing.Point(103, 236);
            this.descTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.descTxt.Name = "descTxt";
            this.descTxt.NomCampBBDD = "DescSpaceShipType";
            this.descTxt.PermetreBuit = true;
            this.descTxt.Size = new System.Drawing.Size(210, 26);
            this.descTxt.TabIndex = 2;
            this.descTxt.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // codeTxt
            // 
            this.codeTxt.EsForanea = false;
            this.codeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.codeTxt.Location = new System.Drawing.Point(103, 189);
            this.codeTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.codeTxt.Name = "codeTxt";
            this.codeTxt.NomCampBBDD = "CodeSpaceShipType";
            this.codeTxt.PermetreBuit = true;
            this.codeTxt.Size = new System.Drawing.Size(210, 26);
            this.codeTxt.TabIndex = 1;
            this.codeTxt.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // frmSpaceShipsTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 450);
            this.Controls.Add(this.categoryCmb);
            this.Controls.Add(this.filiationCmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descTxt);
            this.Controls.Add(this.codeTxt);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmSpaceShipsTypes";
            this.Text = "frmSpaceShipssType";
            this.Load += new System.EventHandler(this.frmSpaceShipsTypes_Load);
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

        private System.Windows.Forms.ComboBox categoryCmb;
        private System.Windows.Forms.ComboBox filiationCmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.SWTextbox descTxt;
        private CustomControls.SWTextbox codeTxt;
    }
}