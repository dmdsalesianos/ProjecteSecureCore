
namespace CustomControls
{
    partial class SWCodi
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.codiTxt = new System.Windows.Forms.TextBox();
            this.descTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // codiTxt
            // 
            this.codiTxt.Location = new System.Drawing.Point(24, 14);
            this.codiTxt.Name = "codiTxt";
            this.codiTxt.Size = new System.Drawing.Size(62, 22);
            this.codiTxt.TabIndex = 0;
            this.codiTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codiTxt_KeyDown);
            // 
            // descTxt
            // 
            this.descTxt.Enabled = false;
            this.descTxt.Location = new System.Drawing.Point(92, 14);
            this.descTxt.Name = "descTxt";
            this.descTxt.Size = new System.Drawing.Size(349, 22);
            this.descTxt.TabIndex = 1;
            // 
            // SWCodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.descTxt);
            this.Controls.Add(this.codiTxt);
            this.Name = "SWCodi";
            this.Size = new System.Drawing.Size(455, 51);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codiTxt;
        private System.Windows.Forms.TextBox descTxt;
    }
}
