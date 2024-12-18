
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
            this.optionImg = new System.Windows.Forms.PictureBox();
            this.optionLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.optionImg)).BeginInit();
            this.SuspendLayout();
            // 
            // optionImg
            // 
            this.optionImg.BackColor = System.Drawing.Color.Transparent;
            this.optionImg.Location = new System.Drawing.Point(22, 44);
            this.optionImg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optionImg.Name = "optionImg";
            this.optionImg.Size = new System.Drawing.Size(75, 78);
            this.optionImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.optionImg.TabIndex = 1;
            this.optionImg.TabStop = false;
            this.optionImg.Click += new System.EventHandler(this.MenuButton_Click);
            this.optionImg.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.optionImg.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            // 
            // optionLbl
            // 
            this.optionLbl.BackColor = System.Drawing.Color.Transparent;
            this.optionLbl.Font = new System.Drawing.Font("Corbel", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionLbl.Location = new System.Drawing.Point(104, 44);
            this.optionLbl.MinimumSize = new System.Drawing.Size(200, 2);
            this.optionLbl.Name = "optionLbl";
            this.optionLbl.Size = new System.Drawing.Size(200, 78);
            this.optionLbl.TabIndex = 2;
            this.optionLbl.Text = "OPTION";
            this.optionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionLbl.Click += new System.EventHandler(this.MenuButton_Click);
            this.optionLbl.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.optionLbl.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            // 
            // MenuButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.optionLbl);
            this.Controls.Add(this.optionImg);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(240, 159);
            this.Name = "MenuButton";
            this.Size = new System.Drawing.Size(338, 159);
            this.Click += new System.EventHandler(this.MenuButton_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuButton_Paint);
            this.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.optionImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox optionImg;
        private System.Windows.Forms.Label optionLbl;
    }
}
