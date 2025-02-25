
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFTP));
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.gbVerificacio = new System.Windows.Forms.GroupBox();
            this.lblConnexio2 = new System.Windows.Forms.Label();
            this.lblConnexio = new System.Windows.Forms.Label();
            this.picConnexion = new System.Windows.Forms.PictureBox();
            this.rtbFiles = new System.Windows.Forms.RichTextBox();
            this.txtNomArxiu = new System.Windows.Forms.TextBox();
            this.lblNameArxiu = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnXML = new System.Windows.Forms.Button();
            this.gbVerificacio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConnexion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(446, 94);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(96, 30);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(667, 94);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(96, 30);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // gbVerificacio
            // 
            this.gbVerificacio.Controls.Add(this.lblConnexio2);
            this.gbVerificacio.Controls.Add(this.lblConnexio);
            this.gbVerificacio.Controls.Add(this.picConnexion);
            this.gbVerificacio.Location = new System.Drawing.Point(562, 129);
            this.gbVerificacio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbVerificacio.Name = "gbVerificacio";
            this.gbVerificacio.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbVerificacio.Size = new System.Drawing.Size(429, 122);
            this.gbVerificacio.TabIndex = 3;
            this.gbVerificacio.TabStop = false;
            this.gbVerificacio.Text = "Verificació";
            // 
            // lblConnexio2
            // 
            this.lblConnexio2.AutoSize = true;
            this.lblConnexio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnexio2.Location = new System.Drawing.Point(104, 65);
            this.lblConnexio2.Name = "lblConnexio2";
            this.lblConnexio2.Size = new System.Drawing.Size(0, 17);
            this.lblConnexio2.TabIndex = 2;
            // 
            // lblConnexio
            // 
            this.lblConnexio.AutoSize = true;
            this.lblConnexio.Location = new System.Drawing.Point(12, 18);
            this.lblConnexio.Name = "lblConnexio";
            this.lblConnexio.Size = new System.Drawing.Size(122, 17);
            this.lblConnexio.TabIndex = 1;
            this.lblConnexio.Text = "Resultat Connexió";
            // 
            // picConnexion
            // 
            this.picConnexion.Location = new System.Drawing.Point(16, 45);
            this.picConnexion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picConnexion.Name = "picConnexion";
            this.picConnexion.Size = new System.Drawing.Size(83, 64);
            this.picConnexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picConnexion.TabIndex = 0;
            this.picConnexion.TabStop = false;
            // 
            // rtbFiles
            // 
            this.rtbFiles.Location = new System.Drawing.Point(51, 129);
            this.rtbFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbFiles.Name = "rtbFiles";
            this.rtbFiles.ReadOnly = true;
            this.rtbFiles.Size = new System.Drawing.Size(492, 190);
            this.rtbFiles.TabIndex = 4;
            this.rtbFiles.TabStop = false;
            this.rtbFiles.Text = "";
            // 
            // txtNomArxiu
            // 
            this.txtNomArxiu.Location = new System.Drawing.Point(51, 98);
            this.txtNomArxiu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomArxiu.Name = "txtNomArxiu";
            this.txtNomArxiu.Size = new System.Drawing.Size(391, 22);
            this.txtNomArxiu.TabIndex = 5;
            // 
            // lblNameArxiu
            // 
            this.lblNameArxiu.AutoSize = true;
            this.lblNameArxiu.Location = new System.Drawing.Point(47, 80);
            this.lblNameArxiu.Name = "lblNameArxiu";
            this.lblNameArxiu.Size = new System.Drawing.Size(72, 17);
            this.lblNameArxiu.TabIndex = 6;
            this.lblNameArxiu.Text = "Nom Arxiu";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(432, 323);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 30);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear Terminal";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(562, 94);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(96, 30);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(291, 323);
            this.btnXML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(136, 30);
            this.btnXML.TabIndex = 9;
            this.btnXML.Text = "Modify Credentials";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // FrmFTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 450);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblNameArxiu);
            this.Controls.Add(this.txtNomArxiu);
            this.Controls.Add(this.rtbFiles);
            this.Controls.Add(this.gbVerificacio);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.btnDownload);
            this.DoubleBuffered = true;
            this.Name = "FrmFTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_FTP_Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmFTP_Load);
            this.gbVerificacio.ResumeLayout(false);
            this.gbVerificacio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConnexion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.GroupBox gbVerificacio;
        private System.Windows.Forms.Label lblConnexio2;
        private System.Windows.Forms.Label lblConnexio;
        private System.Windows.Forms.PictureBox picConnexion;
        private System.Windows.Forms.RichTextBox rtbFiles;
        private System.Windows.Forms.TextBox txtNomArxiu;
        private System.Windows.Forms.Label lblNameArxiu;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnXML;
    }
}

