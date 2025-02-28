
namespace FTP_Client
{
    partial class FrmXML
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbXML = new System.Windows.Forms.RichTextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.txtServer = new CustomControls.SWTextbox();
            this.txtUser = new CustomControls.SWTextbox();
            this.txtPassword = new CustomControls.SWTextbox();
            this.txtRuta = new CustomControls.SWTextbox();
            this.btnRuta = new CustomControls.RJControls.RJButton();
            this.btnCancelar = new CustomControls.RJControls.RJButton();
            this.btnGuardar = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // rtbXML
            // 
            this.rtbXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbXML.Location = new System.Drawing.Point(48, 165);
            this.rtbXML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbXML.Name = "rtbXML";
            this.rtbXML.ReadOnly = true;
            this.rtbXML.Size = new System.Drawing.Size(772, 354);
            this.rtbXML.TabIndex = 0;
            this.rtbXML.TabStop = false;
            this.rtbXML.Text = "";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(44, 36);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(67, 20);
            this.lblServer.TabIndex = 4;
            this.lblServer.Text = "Servidor";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(379, 36);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(55, 20);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Usuari";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(590, 36);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(44, 98);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(117, 20);
            this.lblRuta.TabIndex = 10;
            this.lblRuta.Text = "Ruta Descarga";
            // 
            // txtServer
            // 
            this.txtServer.BackColor = System.Drawing.SystemColors.Window;
            this.txtServer.EsForanea = false;
            this.txtServer.Location = new System.Drawing.Point(48, 59);
            this.txtServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtServer.Name = "txtServer";
            this.txtServer.NomCampBBDD = null;
            this.txtServer.PermetreBuit = true;
            this.txtServer.Size = new System.Drawing.Size(316, 26);
            this.txtServer.TabIndex = 0;
            this.txtServer.TipusDada = CustomControls.SWTextbox.Tipus_Dada.All;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.Window;
            this.txtUser.EsForanea = false;
            this.txtUser.Location = new System.Drawing.Point(382, 59);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.NomCampBBDD = null;
            this.txtUser.PermetreBuit = true;
            this.txtUser.Size = new System.Drawing.Size(173, 26);
            this.txtUser.TabIndex = 1;
            this.txtUser.TipusDada = CustomControls.SWTextbox.Tipus_Dada.All;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.EsForanea = false;
            this.txtPassword.Location = new System.Drawing.Point(593, 59);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NomCampBBDD = null;
            this.txtPassword.PermetreBuit = true;
            this.txtPassword.Size = new System.Drawing.Size(173, 26);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TipusDada = CustomControls.SWTextbox.Tipus_Dada.All;
            // 
            // txtRuta
            // 
            this.txtRuta.BackColor = System.Drawing.SystemColors.Window;
            this.txtRuta.EsForanea = false;
            this.txtRuta.Location = new System.Drawing.Point(48, 120);
            this.txtRuta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.NomCampBBDD = null;
            this.txtRuta.PermetreBuit = true;
            this.txtRuta.Size = new System.Drawing.Size(559, 26);
            this.txtRuta.TabIndex = 15;
            this.txtRuta.TipusDada = CustomControls.SWTextbox.Tipus_Dada.All;
            // 
            // btnRuta
            // 
            this.btnRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.btnRuta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.btnRuta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRuta.BorderRadius = 0;
            this.btnRuta.BorderSize = 0;
            this.btnRuta.FlatAppearance.BorderSize = 0;
            this.btnRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRuta.ForeColor = System.Drawing.Color.White;
            this.btnRuta.Location = new System.Drawing.Point(672, 119);
            this.btnRuta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(148, 30);
            this.btnRuta.TabIndex = 3;
            this.btnRuta.Text = "Seleccionar Ruta";
            this.btnRuta.TextColor = System.Drawing.Color.White;
            this.btnRuta.UseVisualStyleBackColor = false;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 0;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(633, 525);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 42);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.btnGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardar.BorderRadius = 0;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(730, 525);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 42);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1051, 631);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.rtbXML);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmXML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Credentials";
            this.Load += new System.EventHandler(this.FormXML_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbXML;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRuta;
        private CustomControls.SWTextbox txtServer;
        private CustomControls.SWTextbox txtUser;
        private CustomControls.SWTextbox txtPassword;
        private CustomControls.SWTextbox txtRuta;
        private CustomControls.RJControls.RJButton btnRuta;
        private CustomControls.RJControls.RJButton btnCancelar;
        private CustomControls.RJControls.RJButton btnGuardar;
    }
}