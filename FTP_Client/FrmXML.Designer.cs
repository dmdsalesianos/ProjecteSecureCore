﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmXML));
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
            this.rtbXML.Location = new System.Drawing.Point(43, 132);
            this.rtbXML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbXML.Name = "rtbXML";
            this.rtbXML.ReadOnly = true;
            this.rtbXML.Size = new System.Drawing.Size(687, 284);
            this.rtbXML.TabIndex = 0;
            this.rtbXML.TabStop = false;
            this.rtbXML.Text = "";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(43, 47);
            this.txtServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(280, 22);
            this.txtServer.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(527, 47);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(154, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(340, 47);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(154, 22);
            this.txtUser.TabIndex = 3;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(39, 29);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(61, 17);
            this.lblServer.TabIndex = 4;
            this.lblServer.Text = "Servidor";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(337, 29);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(49, 17);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Usuari";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(524, 29);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(649, 420);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 35);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(564, 420);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 35);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(39, 78);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(103, 17);
            this.lblRuta.TabIndex = 10;
            this.lblRuta.Text = "Ruta Descarga";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(43, 96);
            this.txtRuta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(496, 22);
            this.txtRuta.TabIndex = 9;
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(544, 94);
            this.btnRuta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(108, 26);
            this.btnRuta.TabIndex = 11;
            this.btnRuta.Text = "Select Ruta";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // FrmXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 505);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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