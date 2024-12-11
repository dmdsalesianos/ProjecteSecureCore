
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuButton1 = new CustomControls.MenuButton();
            this.menuButton2 = new CustomControls.MenuButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(265, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 592);
            this.panel1.TabIndex = 1;
            // 
            // menuButton1
            // 
            this.menuButton1.Clase = "UserRanks";
            this.menuButton1.Form = "frmUserRanks";
            this.menuButton1.Location = new System.Drawing.Point(-1, -1);
            this.menuButton1.Name = "menuButton1";
            this.menuButton1.Size = new System.Drawing.Size(260, 127);
            this.menuButton1.TabIndex = 0;
            this.menuButton1.TargetPanel = this.panel1;
            // 
            // menuButton2
            // 
            this.menuButton2.Clase = "SpaceShipsTypes";
            this.menuButton2.Form = "frmSpaceShipsTypes";
            this.menuButton2.Location = new System.Drawing.Point(-1, 120);
            this.menuButton2.Name = "menuButton2";
            this.menuButton2.Size = new System.Drawing.Size(260, 127);
            this.menuButton2.TabIndex = 2;
            this.menuButton2.TargetPanel = this.panel1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 663);
            this.Controls.Add(this.menuButton2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.MenuButton menuButton1;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.MenuButton menuButton2;
    }
}

