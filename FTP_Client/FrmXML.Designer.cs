
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
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblRuta = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btnRuta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbXML
            // 
            this.rtbXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbXML.Location = new System.Drawing.Point(48, 165);
            this.rtbXML.Name = "rtbXML";
            this.rtbXML.ReadOnly = true;
            this.rtbXML.Size = new System.Drawing.Size(772, 354);
            this.rtbXML.TabIndex = 0;
            this.rtbXML.TabStop = false;
            this.rtbXML.Text = "";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(48, 59);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(315, 26);
            this.txtServer.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(593, 59);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(173, 26);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(383, 59);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(173, 26);
            this.txtUser.TabIndex = 3;
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
            this.lblPassword.Location = new System.Drawing.Point(589, 36);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(730, 525);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 44);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(634, 525);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 44);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(44, 97);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(117, 20);
            this.lblRuta.TabIndex = 10;
            this.lblRuta.Text = "Ruta Descarga";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(48, 120);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(558, 26);
            this.txtRuta.TabIndex = 9;
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(612, 117);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(122, 33);
            this.btnRuta.TabIndex = 11;
            this.btnRuta.Text = "Select Ruta";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // FrmXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 631);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.rtbXML);
            this.Name = "FrmXML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormXML";
            this.Load += new System.EventHandler(this.FormXML_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbXML;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnRuta;
    }
}