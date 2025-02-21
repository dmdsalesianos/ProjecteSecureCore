
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
            this.btnDownload.Location = new System.Drawing.Point(502, 118);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(108, 37);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(750, 118);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(108, 37);
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
            this.gbVerificacio.Location = new System.Drawing.Point(632, 161);
            this.gbVerificacio.Name = "gbVerificacio";
            this.gbVerificacio.Size = new System.Drawing.Size(483, 152);
            this.gbVerificacio.TabIndex = 3;
            this.gbVerificacio.TabStop = false;
            this.gbVerificacio.Text = "Verificació";
            // 
            // lblConnexio2
            // 
            this.lblConnexio2.AutoSize = true;
            this.lblConnexio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnexio2.Location = new System.Drawing.Point(117, 81);
            this.lblConnexio2.Name = "lblConnexio2";
            this.lblConnexio2.Size = new System.Drawing.Size(0, 20);
            this.lblConnexio2.TabIndex = 2;
            // 
            // lblConnexio
            // 
            this.lblConnexio.AutoSize = true;
            this.lblConnexio.Location = new System.Drawing.Point(14, 23);
            this.lblConnexio.Name = "lblConnexio";
            this.lblConnexio.Size = new System.Drawing.Size(139, 20);
            this.lblConnexio.TabIndex = 1;
            this.lblConnexio.Text = "Resultat Connexió";
            // 
            // picConnexion
            // 
            this.picConnexion.Location = new System.Drawing.Point(18, 56);
            this.picConnexion.Name = "picConnexion";
            this.picConnexion.Size = new System.Drawing.Size(93, 80);
            this.picConnexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picConnexion.TabIndex = 0;
            this.picConnexion.TabStop = false;
            // 
            // rtbFiles
            // 
            this.rtbFiles.Location = new System.Drawing.Point(57, 161);
            this.rtbFiles.Name = "rtbFiles";
            this.rtbFiles.ReadOnly = true;
            this.rtbFiles.Size = new System.Drawing.Size(553, 237);
            this.rtbFiles.TabIndex = 4;
            this.rtbFiles.TabStop = false;
            this.rtbFiles.Text = "";
            // 
            // txtNomArxiu
            // 
            this.txtNomArxiu.Location = new System.Drawing.Point(57, 123);
            this.txtNomArxiu.Name = "txtNomArxiu";
            this.txtNomArxiu.Size = new System.Drawing.Size(439, 26);
            this.txtNomArxiu.TabIndex = 5;
            // 
            // lblNameArxiu
            // 
            this.lblNameArxiu.AutoSize = true;
            this.lblNameArxiu.Location = new System.Drawing.Point(53, 100);
            this.lblNameArxiu.Name = "lblNameArxiu";
            this.lblNameArxiu.Size = new System.Drawing.Size(81, 20);
            this.lblNameArxiu.TabIndex = 6;
            this.lblNameArxiu.Text = "Nom Arxiu";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(486, 404);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 37);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear Terminal";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(632, 118);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(108, 37);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(327, 404);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(153, 37);
            this.btnXML.TabIndex = 9;
            this.btnXML.Text = "Modify Credentials";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // FrmFTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 562);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblNameArxiu);
            this.Controls.Add(this.txtNomArxiu);
            this.Controls.Add(this.rtbFiles);
            this.Controls.Add(this.gbVerificacio);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.btnDownload);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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

