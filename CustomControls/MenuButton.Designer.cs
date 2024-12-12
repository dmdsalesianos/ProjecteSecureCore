
namespace CustomControls
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
            this.MenuBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.MenuBtn.Location = new System.Drawing.Point(-1, 1);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Padding = new System.Windows.Forms.Padding(2);
            this.MenuBtn.Size = new System.Drawing.Size(261, 124);
            this.MenuBtn.TabIndex = 0;
            this.MenuBtn.UseVisualStyleBackColor = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // optionImg
            // 
            this.optionImg.BackColor = System.Drawing.Color.Transparent;
            this.optionImg.Location = new System.Drawing.Point(32, 35);
            this.optionImg.Name = "optionImg";
            this.optionImg.Size = new System.Drawing.Size(54, 54);
            this.optionImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.optionImg.TabIndex = 1;
            this.optionImg.TabStop = false;
            // 
            // optionLbl
            // 
            this.optionLbl.AutoSize = true;
            this.optionLbl.BackColor = System.Drawing.Color.Transparent;
            this.optionLbl.Font = new System.Drawing.Font("Corbel", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionLbl.Location = new System.Drawing.Point(116, 47);
            this.optionLbl.Name = "optionLbl";
            this.optionLbl.Size = new System.Drawing.Size(89, 27);
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
