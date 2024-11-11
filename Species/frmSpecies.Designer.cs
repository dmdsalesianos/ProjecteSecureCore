
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.swTextBox2 = new Species.SWTextox();
            this.swTextBox1 = new Species.SWTextox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "UserName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 209);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "idUser";
            // 
            // swTextBox2
            // 
            this.swTextBox2.Location = new System.Drawing.Point(43, 122);
            this.swTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swTextBox2.Name = "swTextBox2";
            this.swTextBox2.nombreColumna = "UserName";
            this.swTextBox2.Size = new System.Drawing.Size(213, 22);
            this.swTextBox2.TabIndex = 6;
            // 
            // swTextBox1
            // 
            this.swTextBox1.Location = new System.Drawing.Point(43, 66);
            this.swTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.nombreColumna = "codeUser";
            this.swTextBox1.Size = new System.Drawing.Size(213, 22);
            this.swTextBox1.TabIndex = 5;
            // 
            // frmSpecies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 454);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.swTextBox2);
            this.Controls.Add(this.swTextBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSpecies";
            this.Controls.SetChildIndex(this.swTextBox1, 0);
            this.Controls.SetChildIndex(this.swTextBox2, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SWTextox swTextBox1;
        private SWTextox swTextBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

