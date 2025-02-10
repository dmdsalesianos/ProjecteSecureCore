
namespace FrmLlistat
{
    partial class FrmLlistat
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtParametre = new System.Windows.Forms.TextBox();
            this.btnInforme = new System.Windows.Forms.Button();
            this.CRVReports = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de comanda:";
            // 
            // txtParametre
            // 
            this.txtParametre.Location = new System.Drawing.Point(178, 48);
            this.txtParametre.Name = "txtParametre";
            this.txtParametre.Size = new System.Drawing.Size(100, 22);
            this.txtParametre.TabIndex = 1;
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(299, 45);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(132, 29);
            this.btnInforme.TabIndex = 2;
            this.btnInforme.Text = "Mostrar informe";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // CRVReports
            // 
            this.CRVReports.ActiveViewIndex = -1;
            this.CRVReports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVReports.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRVReports.Location = new System.Drawing.Point(31, 91);
            this.CRVReports.Name = "CRVReports";
            this.CRVReports.Size = new System.Drawing.Size(1407, 740);
            this.CRVReports.TabIndex = 3;
            // 
            // FrmLlistat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 859);
            this.Controls.Add(this.CRVReports);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.txtParametre);
            this.Controls.Add(this.label1);
            this.Name = "FrmLlistat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLlistat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParametre;
        private System.Windows.Forms.Button btnInforme;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRVReports;
    }
}

