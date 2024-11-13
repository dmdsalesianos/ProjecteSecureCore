
namespace Species
{
    partial class frmUserCategories
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.swTextbox1 = new Sprint53_G4.SWTextbox();
            this.swTextbox2 = new Sprint53_G4.SWTextbox();
            this.swTextbox3 = new Sprint53_G4.SWTextbox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "descCategory";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 174);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "idUserCategory";
            // 
            // swTextbox1
            // 
            this.swTextbox1.EsForanea = false;
            this.swTextbox1.Location = new System.Drawing.Point(42, 29);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.NomCampBBDD = "codeCategory";
            this.swTextbox1.PermetreBuit = false;
            this.swTextbox1.Size = new System.Drawing.Size(250, 22);
            this.swTextbox1.TabIndex = 8;
            this.swTextbox1.TipusDada = Sprint53_G4.SWTextbox.Tipus_Dada.Text;
            // 
            // swTextbox2
            // 
            this.swTextbox2.EsForanea = false;
            this.swTextbox2.Location = new System.Drawing.Point(42, 78);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.NomCampBBDD = "descCategory";
            this.swTextbox2.PermetreBuit = false;
            this.swTextbox2.Size = new System.Drawing.Size(250, 22);
            this.swTextbox2.TabIndex = 9;
            this.swTextbox2.TipusDada = Sprint53_G4.SWTextbox.Tipus_Dada.Text;
            // 
            // swTextbox3
            // 
            this.swTextbox3.EsForanea = false;
            this.swTextbox3.Location = new System.Drawing.Point(42, 131);
            this.swTextbox3.Name = "swTextbox3";
            this.swTextbox3.NomCampBBDD = "AccessLevel";
            this.swTextbox3.PermetreBuit = false;
            this.swTextbox3.Size = new System.Drawing.Size(250, 22);
            this.swTextbox3.TabIndex = 10;
            this.swTextbox3.TipusDada = Sprint53_G4.SWTextbox.Tipus_Dada.Text;
            // 
            // frmUserCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 454);
            this.Controls.Add(this.swTextbox3);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swTextbox1);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUserCategories";
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.Controls.SetChildIndex(this.swTextbox3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private Sprint53_G4.SWTextbox swTextbox1;
        private Sprint53_G4.SWTextbox swTextbox2;
        private Sprint53_G4.SWTextbox swTextbox3;
    }
}

