
namespace Species
{
    partial class frmSpecies
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
            this.swTextox2 = new Species.SWTextox();
            this.swTextox = new Species.SWTextox();
            this.SuspendLayout();
            // 
            // swTextox2
            // 
            this.swTextox2.Location = new System.Drawing.Point(48, 152);
            this.swTextox2.Name = "swTextox2";
            this.swTextox2.nombreColumna = "descSpecie";
            this.swTextox2.Size = new System.Drawing.Size(239, 26);
            this.swTextox2.TabIndex = 6;
            // 
            // swTextox
            // 
            this.swTextox.Location = new System.Drawing.Point(48, 82);
            this.swTextox.Name = "swTextox";
            this.swTextox.nombreColumna = "codeSpecie";
            this.swTextox.Size = new System.Drawing.Size(239, 26);
            this.swTextox.TabIndex = 5;
            // 
            // frmSpecies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 567);
            this.Controls.Add(this.swTextox2);
            this.Controls.Add(this.swTextox);
            this.Name = "frmSpecies";
            this.Controls.SetChildIndex(this.swTextox, 0);
            this.Controls.SetChildIndex(this.swTextox2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SWTextox swTextox;
        private SWTextox swTextox2;
    }
}

