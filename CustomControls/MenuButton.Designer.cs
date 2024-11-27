
namespace Sprint53_G4
{
    partial class MenuButton
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
            this.MenuBtn = new System.Windows.Forms.Button();
            this.optionImg = new System.Windows.Forms.PictureBox();
            this.optionLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.optionImg)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuBtn
            // 
            this.MenuBtn.Location = new System.Drawing.Point(-3, 3);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(260, 127);
            this.MenuBtn.TabIndex = 0;
            this.MenuBtn.UseVisualStyleBackColor = true;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // optionImg
            // 
            this.optionImg.Location = new System.Drawing.Point(33, 38);
            this.optionImg.Name = "optionImg";
            this.optionImg.Size = new System.Drawing.Size(54, 54);
            this.optionImg.TabIndex = 1;
            this.optionImg.TabStop = false;
            // 
            // optionLbl
            // 
            this.optionLbl.AutoSize = true;
            this.optionLbl.Location = new System.Drawing.Point(136, 58);
            this.optionLbl.Name = "optionLbl";
            this.optionLbl.Size = new System.Drawing.Size(61, 17);
            this.optionLbl.TabIndex = 2;
            this.optionLbl.Text = "OPTION";
            // 
            // MenuButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.optionLbl);
            this.Controls.Add(this.optionImg);
            this.Controls.Add(this.MenuBtn);
            this.Name = "MenuButton";
            this.Size = new System.Drawing.Size(260, 127);
            ((System.ComponentModel.ISupportInitialize)(this.optionImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.PictureBox optionImg;
        private System.Windows.Forms.Label optionLbl;
    }
}
