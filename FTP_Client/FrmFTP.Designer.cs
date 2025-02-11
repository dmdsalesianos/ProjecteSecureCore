
namespace FTP_Client
{
    partial class FrmFTP
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
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblArxiu = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(119, 27);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(555, 22);
            this.txtFileName.TabIndex = 0;
            // 
            // lblArxiu
            // 
            this.lblArxiu.AutoSize = true;
            this.lblArxiu.Location = new System.Drawing.Point(12, 30);
            this.lblArxiu.Name = "lblArxiu";
            this.lblArxiu.Size = new System.Drawing.Size(101, 17);
            this.lblArxiu.TabIndex = 1;
            this.lblArxiu.Text = "Nom de l\'arxiu:";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(680, 23);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(108, 30);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 16;
            this.lstResults.Location = new System.Drawing.Point(119, 87);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(555, 260);
            this.lstResults.TabIndex = 3;
            // 
            // FrmFTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lblArxiu);
            this.Controls.Add(this.txtFileName);
            this.Name = "FrmFTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_FTP_Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmFTP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblArxiu;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ListBox lstResults;
    }
}

