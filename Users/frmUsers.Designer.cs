﻿
namespace Users
{
    partial class frmUsers
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
            this.swtxtCodeUser = new CustomControls.SWTextbox();
            this.swtxtUserName = new CustomControls.SWTextbox();
            this.cmbUserCategory = new System.Windows.Forms.ComboBox();
            this.cmbUserRank = new System.Windows.Forms.ComboBox();
            this.swtxtPhoto = new CustomControls.SWTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCodeUser = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserRank = new System.Windows.Forms.Label();
            this.lblUserCategory = new System.Windows.Forms.Label();
            this.cmbPlanet = new System.Windows.Forms.ComboBox();
            this.cmbSpecie = new System.Windows.Forms.ComboBox();
            this.lblPlanet = new System.Windows.Forms.Label();
            this.lblSpecie = new System.Windows.Forms.Label();
            this.rjbtnImage = new CustomControls.RJControls.RJButton();
            this.rjbtnInforme = new CustomControls.RJControls.RJButton();
            this.swtxtLogin = new CustomControls.SWTextbox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.rjbtnRestablecerContraseña = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // swtxtCodeUser
            // 
            this.swtxtCodeUser.EsForanea = false;
            this.swtxtCodeUser.Location = new System.Drawing.Point(380, 106);
            this.swtxtCodeUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.swtxtCodeUser.Name = "swtxtCodeUser";
            this.swtxtCodeUser.NomCampBBDD = "CodeUser";
            this.swtxtCodeUser.PermetreBuit = true;
            this.swtxtCodeUser.Size = new System.Drawing.Size(218, 26);
            this.swtxtCodeUser.TabIndex = 1;
            this.swtxtCodeUser.TipusDada = CustomControls.SWTextbox.Tipus_Dada.All;
            // 
            // swtxtUserName
            // 
            this.swtxtUserName.EsForanea = false;
            this.swtxtUserName.Location = new System.Drawing.Point(380, 151);
            this.swtxtUserName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.swtxtUserName.Name = "swtxtUserName";
            this.swtxtUserName.NomCampBBDD = "UserName";
            this.swtxtUserName.PermetreBuit = true;
            this.swtxtUserName.Size = new System.Drawing.Size(218, 26);
            this.swtxtUserName.TabIndex = 2;
            this.swtxtUserName.TipusDada = CustomControls.SWTextbox.Tipus_Dada.All;
            // 
            // cmbUserCategory
            // 
            this.cmbUserCategory.FormattingEnabled = true;
            this.cmbUserCategory.Location = new System.Drawing.Point(802, 152);
            this.cmbUserCategory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbUserCategory.Name = "cmbUserCategory";
            this.cmbUserCategory.Size = new System.Drawing.Size(218, 28);
            this.cmbUserCategory.TabIndex = 5;
            // 
            // cmbUserRank
            // 
            this.cmbUserRank.FormattingEnabled = true;
            this.cmbUserRank.Location = new System.Drawing.Point(802, 106);
            this.cmbUserRank.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbUserRank.Name = "cmbUserRank";
            this.cmbUserRank.Size = new System.Drawing.Size(218, 28);
            this.cmbUserRank.TabIndex = 4;
            // 
            // swtxtPhoto
            // 
            this.swtxtPhoto.EsForanea = false;
            this.swtxtPhoto.Location = new System.Drawing.Point(69, 149);
            this.swtxtPhoto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.swtxtPhoto.Name = "swtxtPhoto";
            this.swtxtPhoto.NomCampBBDD = "Photo";
            this.swtxtPhoto.PermetreBuit = true;
            this.swtxtPhoto.Size = new System.Drawing.Size(112, 26);
            this.swtxtPhoto.TabIndex = 11;
            this.swtxtPhoto.TabStop = false;
            this.swtxtPhoto.TipusDada = CustomControls.SWTextbox.Tipus_Dada.All;
            this.swtxtPhoto.TextChanged += new System.EventHandler(this.swtxtPhoto_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(36, 106);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblCodeUser
            // 
            this.lblCodeUser.AutoSize = true;
            this.lblCodeUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeUser.Location = new System.Drawing.Point(268, 112);
            this.lblCodeUser.Name = "lblCodeUser";
            this.lblCodeUser.Size = new System.Drawing.Size(92, 20);
            this.lblCodeUser.TabIndex = 13;
            this.lblCodeUser.Text = "CodeUser";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(261, 157);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(100, 20);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.Text = "User Name";
            // 
            // lblUserRank
            // 
            this.lblUserRank.AutoSize = true;
            this.lblUserRank.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRank.Location = new System.Drawing.Point(693, 112);
            this.lblUserRank.Name = "lblUserRank";
            this.lblUserRank.Size = new System.Drawing.Size(94, 20);
            this.lblUserRank.TabIndex = 15;
            this.lblUserRank.Text = "User Rank";
            // 
            // lblUserCategory
            // 
            this.lblUserCategory.AutoSize = true;
            this.lblUserCategory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCategory.Location = new System.Drawing.Point(669, 160);
            this.lblUserCategory.Name = "lblUserCategory";
            this.lblUserCategory.Size = new System.Drawing.Size(128, 20);
            this.lblUserCategory.TabIndex = 16;
            this.lblUserCategory.Text = "User Category";
            // 
            // cmbPlanet
            // 
            this.cmbPlanet.FormattingEnabled = true;
            this.cmbPlanet.Location = new System.Drawing.Point(1190, 105);
            this.cmbPlanet.Name = "cmbPlanet";
            this.cmbPlanet.Size = new System.Drawing.Size(218, 28);
            this.cmbPlanet.TabIndex = 6;
            // 
            // cmbSpecie
            // 
            this.cmbSpecie.FormattingEnabled = true;
            this.cmbSpecie.Location = new System.Drawing.Point(1190, 151);
            this.cmbSpecie.Name = "cmbSpecie";
            this.cmbSpecie.Size = new System.Drawing.Size(218, 28);
            this.cmbSpecie.TabIndex = 7;
            // 
            // lblPlanet
            // 
            this.lblPlanet.AutoSize = true;
            this.lblPlanet.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanet.Location = new System.Drawing.Point(1108, 112);
            this.lblPlanet.Name = "lblPlanet";
            this.lblPlanet.Size = new System.Drawing.Size(61, 20);
            this.lblPlanet.TabIndex = 19;
            this.lblPlanet.Text = "Planet";
            // 
            // lblSpecie
            // 
            this.lblSpecie.AutoSize = true;
            this.lblSpecie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecie.Location = new System.Drawing.Point(1107, 160);
            this.lblSpecie.Name = "lblSpecie";
            this.lblSpecie.Size = new System.Drawing.Size(66, 20);
            this.lblSpecie.TabIndex = 20;
            this.lblSpecie.Text = "Specie";
            // 
            // rjbtnImage
            // 
            this.rjbtnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.rjbtnImage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.rjbtnImage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnImage.BorderRadius = 0;
            this.rjbtnImage.BorderSize = 0;
            this.rjbtnImage.FlatAppearance.BorderSize = 0;
            this.rjbtnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnImage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnImage.ForeColor = System.Drawing.Color.White;
            this.rjbtnImage.Location = new System.Drawing.Point(34, 254);
            this.rjbtnImage.Name = "rjbtnImage";
            this.rjbtnImage.Size = new System.Drawing.Size(200, 38);
            this.rjbtnImage.TabIndex = 8;
            this.rjbtnImage.Text = "Select Image";
            this.rjbtnImage.TextColor = System.Drawing.Color.White;
            this.rjbtnImage.UseVisualStyleBackColor = false;
            this.rjbtnImage.Click += new System.EventHandler(this.rjbtnImage_Click);
            // 
            // rjbtnInforme
            // 
            this.rjbtnInforme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(241)))));
            this.rjbtnInforme.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(241)))));
            this.rjbtnInforme.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnInforme.BorderRadius = 0;
            this.rjbtnInforme.BorderSize = 0;
            this.rjbtnInforme.FlatAppearance.BorderSize = 0;
            this.rjbtnInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnInforme.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnInforme.ForeColor = System.Drawing.Color.White;
            this.rjbtnInforme.Location = new System.Drawing.Point(1078, 283);
            this.rjbtnInforme.Name = "rjbtnInforme";
            this.rjbtnInforme.Size = new System.Drawing.Size(165, 40);
            this.rjbtnInforme.TabIndex = 10;
            this.rjbtnInforme.Text = "Mostrar Informe";
            this.rjbtnInforme.TextColor = System.Drawing.Color.White;
            this.rjbtnInforme.UseVisualStyleBackColor = false;
            this.rjbtnInforme.Click += new System.EventHandler(this.rjbtnInforme_Click);
            // 
            // swtxtLogin
            // 
            this.swtxtLogin.EsForanea = false;
            this.swtxtLogin.Location = new System.Drawing.Point(380, 195);
            this.swtxtLogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.swtxtLogin.Name = "swtxtLogin";
            this.swtxtLogin.NomCampBBDD = "Login";
            this.swtxtLogin.PermetreBuit = true;
            this.swtxtLogin.Size = new System.Drawing.Size(218, 26);
            this.swtxtLogin.TabIndex = 3;
            this.swtxtLogin.TipusDada = CustomControls.SWTextbox.Tipus_Dada.All;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(298, 200);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(55, 20);
            this.lblLogin.TabIndex = 34;
            this.lblLogin.Text = "Login";
            // 
            // rjbtnRestablecerContraseña
            // 
            this.rjbtnRestablecerContraseña.BackColor = System.Drawing.Color.Red;
            this.rjbtnRestablecerContraseña.BackgroundColor = System.Drawing.Color.Red;
            this.rjbtnRestablecerContraseña.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnRestablecerContraseña.BorderRadius = 0;
            this.rjbtnRestablecerContraseña.BorderSize = 0;
            this.rjbtnRestablecerContraseña.FlatAppearance.BorderSize = 0;
            this.rjbtnRestablecerContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnRestablecerContraseña.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnRestablecerContraseña.ForeColor = System.Drawing.Color.White;
            this.rjbtnRestablecerContraseña.Location = new System.Drawing.Point(850, 283);
            this.rjbtnRestablecerContraseña.Name = "rjbtnRestablecerContraseña";
            this.rjbtnRestablecerContraseña.Size = new System.Drawing.Size(224, 40);
            this.rjbtnRestablecerContraseña.TabIndex = 9;
            this.rjbtnRestablecerContraseña.Text = "Restablecer Contraseña";
            this.rjbtnRestablecerContraseña.TextColor = System.Drawing.Color.White;
            this.rjbtnRestablecerContraseña.UseVisualStyleBackColor = false;
            this.rjbtnRestablecerContraseña.Click += new System.EventHandler(this.rjbtnRestablecerContraseña_Click);
            // 
            // frmUsers
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1049);
            this.Controls.Add(this.rjbtnRestablecerContraseña);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.swtxtLogin);
            this.Controls.Add(this.rjbtnInforme);
            this.Controls.Add(this.rjbtnImage);
            this.Controls.Add(this.lblSpecie);
            this.Controls.Add(this.lblPlanet);
            this.Controls.Add(this.cmbSpecie);
            this.Controls.Add(this.cmbPlanet);
            this.Controls.Add(this.lblUserCategory);
            this.Controls.Add(this.lblUserRank);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblCodeUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.swtxtPhoto);
            this.Controls.Add(this.cmbUserRank);
            this.Controls.Add(this.cmbUserCategory);
            this.Controls.Add(this.swtxtUserName);
            this.Controls.Add(this.swtxtCodeUser);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "frmUsers";
            this.TabIndexActualitzarBtn = 12;
            this.TabIndexAgregarBtn = 11;
            this.Text = "frmUsers";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.Controls.SetChildIndex(this.swtxtCodeUser, 0);
            this.Controls.SetChildIndex(this.swtxtUserName, 0);
            this.Controls.SetChildIndex(this.cmbUserCategory, 0);
            this.Controls.SetChildIndex(this.cmbUserRank, 0);
            this.Controls.SetChildIndex(this.swtxtPhoto, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.lblCodeUser, 0);
            this.Controls.SetChildIndex(this.lblUserName, 0);
            this.Controls.SetChildIndex(this.lblUserRank, 0);
            this.Controls.SetChildIndex(this.lblUserCategory, 0);
            this.Controls.SetChildIndex(this.cmbPlanet, 0);
            this.Controls.SetChildIndex(this.cmbSpecie, 0);
            this.Controls.SetChildIndex(this.lblPlanet, 0);
            this.Controls.SetChildIndex(this.lblSpecie, 0);
            this.Controls.SetChildIndex(this.rjbtnImage, 0);
            this.Controls.SetChildIndex(this.rjbtnInforme, 0);
            this.Controls.SetChildIndex(this.swtxtLogin, 0);
            this.Controls.SetChildIndex(this.lblLogin, 0);
            this.Controls.SetChildIndex(this.rjbtnRestablecerContraseña, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextbox swtxtCodeUser;
        private CustomControls.SWTextbox swtxtUserName;
        private System.Windows.Forms.ComboBox cmbUserCategory;
        private System.Windows.Forms.ComboBox cmbUserRank;
        private CustomControls.SWTextbox swtxtPhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCodeUser;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserRank;
        private System.Windows.Forms.Label lblUserCategory;
        private System.Windows.Forms.ComboBox cmbPlanet;
        private System.Windows.Forms.ComboBox cmbSpecie;
        private System.Windows.Forms.Label lblPlanet;
        private System.Windows.Forms.Label lblSpecie;
        private CustomControls.RJControls.RJButton rjbtnImage;
        private CustomControls.RJControls.RJButton rjbtnInforme;
        private CustomControls.SWTextbox swtxtLogin;
        private System.Windows.Forms.Label lblLogin;
        private CustomControls.RJControls.RJButton rjbtnRestablecerContraseña;
    }
}