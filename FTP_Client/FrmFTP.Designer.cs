
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
            this.gbVerificacio = new System.Windows.Forms.GroupBox();
            this.lblConnexio2 = new System.Windows.Forms.Label();
            this.lblConnexio = new System.Windows.Forms.Label();
            this.picConnexion = new System.Windows.Forms.PictureBox();
            this.rtbFiles = new System.Windows.Forms.RichTextBox();
            this.lblNameArxiu = new System.Windows.Forms.Label();
            this.btnClear = new CustomControls.RJControls.RJButton();
            this.btnXML = new CustomControls.RJControls.RJButton();
            this.btnUploadFile = new CustomControls.RJControls.RJButton();
            this.btnConnect = new CustomControls.RJControls.RJButton();
            this.btnDownload = new CustomControls.RJControls.RJButton();
            this.txtNomArxiu = new CustomControls.SWTextbox();
            this.gbVerificacio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConnexion)).BeginInit();
            this.SuspendLayout();
            // 
            // gbVerificacio
            // 
            this.gbVerificacio.Controls.Add(this.picConnexion);
            this.gbVerificacio.Controls.Add(this.lblConnexio2);
            this.gbVerificacio.Controls.Add(this.lblConnexio);
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
            this.lblConnexio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnexio2.Location = new System.Drawing.Point(104, 65);
            this.lblConnexio2.Name = "lblConnexio2";
            this.lblConnexio2.Size = new System.Drawing.Size(231, 21);
            this.lblConnexio2.TabIndex = 2;
            this.lblConnexio2.Text = "resultat2";
            this.lblConnexio2.Visible = false;
            // 
            // lblConnexio
            // 
            this.lblConnexio.Location = new System.Drawing.Point(12, 18);
            this.lblConnexio.Name = "lblConnexio";
            this.lblConnexio.Size = new System.Drawing.Size(382, 25);
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
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.btnClear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.btnClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClear.BorderRadius = 0;
            this.btnClear.BorderSize = 0;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(407, 324);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 26);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear Terminal";
            this.btnClear.TextColor = System.Drawing.Color.White;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnXML
            // 
            this.btnXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.btnXML.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.btnXML.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXML.BorderRadius = 0;
            this.btnXML.BorderSize = 0;
            this.btnXML.FlatAppearance.BorderSize = 0;
            this.btnXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXML.ForeColor = System.Drawing.Color.White;
            this.btnXML.Location = new System.Drawing.Point(265, 324);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(136, 26);
            this.btnXML.TabIndex = 14;
            this.btnXML.Text = "Modify Credentials";
            this.btnXML.TextColor = System.Drawing.Color.White;
            this.btnXML.UseVisualStyleBackColor = false;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.btnUploadFile.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.btnUploadFile.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUploadFile.BorderRadius = 0;
            this.btnUploadFile.BorderSize = 0;
            this.btnUploadFile.FlatAppearance.BorderSize = 0;
            this.btnUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadFile.ForeColor = System.Drawing.Color.White;
            this.btnUploadFile.Location = new System.Drawing.Point(662, 94);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(94, 26);
            this.btnUploadFile.TabIndex = 13;
            this.btnUploadFile.Text = "Upload File";
            this.btnUploadFile.TextColor = System.Drawing.Color.White;
            this.btnUploadFile.UseVisualStyleBackColor = false;
            this.btnUploadFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.btnConnect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.btnConnect.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConnect.BorderRadius = 0;
            this.btnConnect.BorderSize = 0;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(562, 94);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(94, 26);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Connect";
            this.btnConnect.TextColor = System.Drawing.Color.White;
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.btnDownload.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.btnDownload.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDownload.BorderRadius = 0;
            this.btnDownload.BorderSize = 0;
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Location = new System.Drawing.Point(449, 94);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(94, 26);
            this.btnDownload.TabIndex = 11;
            this.btnDownload.Text = "Download";
            this.btnDownload.TextColor = System.Drawing.Color.White;
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtNomArxiu
            // 
            this.txtNomArxiu.BackColor = System.Drawing.SystemColors.Control;
            this.txtNomArxiu.EsForanea = false;
            this.txtNomArxiu.Location = new System.Drawing.Point(50, 96);
            this.txtNomArxiu.Name = "txtNomArxiu";
            this.txtNomArxiu.NomCampBBDD = null;
            this.txtNomArxiu.PermetreBuit = true;
            this.txtNomArxiu.Size = new System.Drawing.Size(392, 22);
            this.txtNomArxiu.TabIndex = 10;
            this.txtNomArxiu.TipusDada = CustomControls.SWTextbox.Tipus_Dada.All;
            // 
            // FrmFTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.btnUploadFile);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtNomArxiu);
            this.Controls.Add(this.lblNameArxiu);
            this.Controls.Add(this.rtbFiles);
            this.Controls.Add(this.gbVerificacio);
            this.DoubleBuffered = true;
            this.Name = "FrmFTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_FTP_Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmFTP_Load);
            this.gbVerificacio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picConnexion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbVerificacio;
        private System.Windows.Forms.Label lblConnexio2;
        private System.Windows.Forms.Label lblConnexio;
        private System.Windows.Forms.PictureBox picConnexion;
        private System.Windows.Forms.RichTextBox rtbFiles;
        private System.Windows.Forms.Label lblNameArxiu;
        private CustomControls.SWTextbox txtNomArxiu;
        private CustomControls.RJControls.RJButton btnDownload;
        private CustomControls.RJControls.RJButton btnConnect;
        private CustomControls.RJControls.RJButton btnUploadFile;
        private CustomControls.RJControls.RJButton btnXML;
        private CustomControls.RJControls.RJButton btnClear;
    }
}

