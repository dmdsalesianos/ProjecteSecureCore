
namespace Login
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pibLogoName = new System.Windows.Forms.PictureBox();
            this.rjbtnClose = new CustomControls.RJControls.RJButton();
            this.rndpicUser = new CustomControls.RoundedPictureBox();
            this.rjbtnLogOut = new CustomControls.RJControls.RJButton();
            this.pnlHeader.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogoName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rndpicUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlHeader.Controls.Add(this.pnlLogo);
            this.pnlHeader.Controls.Add(this.pnlUserInfo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1084, 69);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Controls.Add(this.pibLogoName);
            this.pnlLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(279, 69);
            this.pnlLogo.TabIndex = 0;
            this.pnlLogo.Click += new System.EventHandler(this.pnlLogo_Click);
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.Controls.Add(this.rjbtnClose);
            this.pnlUserInfo.Controls.Add(this.rndpicUser);
            this.pnlUserInfo.Controls.Add(this.rjbtnLogOut);
            this.pnlUserInfo.Controls.Add(this.lblName);
            this.pnlUserInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlUserInfo.Location = new System.Drawing.Point(619, 0);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(465, 69);
            this.pnlUserInfo.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(120, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(206, 69);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Login";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.pnlContenido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(441, 69);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(643, 739);
            this.pnlContenido.TabIndex = 2;
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 69);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(441, 739);
            this.pnlMenu.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLogo.Image = global::Login.Properties.Resources.Only_logo_FFFFFF;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(76, 69);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click_1);
            // 
            // pibLogoName
            // 
            this.pibLogoName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibLogoName.Dock = System.Windows.Forms.DockStyle.Right;
            this.pibLogoName.Image = global::Login.Properties.Resources.Name_FFFFFF;
            this.pibLogoName.Location = new System.Drawing.Point(78, 0);
            this.pibLogoName.Name = "pibLogoName";
            this.pibLogoName.Size = new System.Drawing.Size(201, 69);
            this.pibLogoName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibLogoName.TabIndex = 2;
            this.pibLogoName.TabStop = false;
            this.pibLogoName.Click += new System.EventHandler(this.pibLogoName_Click_1);
            // 
            // rjbtnClose
            // 
            this.rjbtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rjbtnClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rjbtnClose.BackgroundImage = global::Login.Properties.Resources.close;
            this.rjbtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rjbtnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rjbtnClose.BorderRadius = 0;
            this.rjbtnClose.BorderSize = 0;
            this.rjbtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.rjbtnClose.FlatAppearance.BorderSize = 0;
            this.rjbtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnClose.ForeColor = System.Drawing.Color.White;
            this.rjbtnClose.Location = new System.Drawing.Point(397, 0);
            this.rjbtnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjbtnClose.Name = "rjbtnClose";
            this.rjbtnClose.Size = new System.Drawing.Size(68, 69);
            this.rjbtnClose.TabIndex = 5;
            this.rjbtnClose.TextColor = System.Drawing.Color.White;
            this.rjbtnClose.UseVisualStyleBackColor = false;
            this.rjbtnClose.Click += new System.EventHandler(this.rjbtnClose_Click);
            // 
            // rndpicUser
            // 
            this.rndpicUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.rndpicUser.Location = new System.Drawing.Point(0, 0);
            this.rndpicUser.Name = "rndpicUser";
            this.rndpicUser.Size = new System.Drawing.Size(82, 69);
            this.rndpicUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rndpicUser.TabIndex = 4;
            this.rndpicUser.TabStop = false;
            // 
            // rjbtnLogOut
            // 
            this.rjbtnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(166)))), ((int)(((byte)(165)))));
            this.rjbtnLogOut.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(166)))), ((int)(((byte)(165)))));
            this.rjbtnLogOut.BackgroundImage = global::Login.Properties.Resources.logout2;
            this.rjbtnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rjbtnLogOut.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnLogOut.BorderRadius = 0;
            this.rjbtnLogOut.BorderSize = 0;
            this.rjbtnLogOut.FlatAppearance.BorderSize = 0;
            this.rjbtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnLogOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnLogOut.ForeColor = System.Drawing.Color.White;
            this.rjbtnLogOut.Location = new System.Drawing.Point(333, 0);
            this.rjbtnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjbtnLogOut.Name = "rjbtnLogOut";
            this.rjbtnLogOut.Size = new System.Drawing.Size(68, 69);
            this.rjbtnLogOut.TabIndex = 0;
            this.rjbtnLogOut.TextColor = System.Drawing.Color.White;
            this.rjbtnLogOut.UseVisualStyleBackColor = false;
            this.rjbtnLogOut.Click += new System.EventHandler(this.rjbtnLogOut_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 808);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlUserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogoName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rndpicUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox pibLogoName;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.FlowLayoutPanel pnlMenu;
        private System.Windows.Forms.Label lblName;
        private CustomControls.RoundedPictureBox rndpicUser;
        private System.Windows.Forms.Panel pnlUserInfo;
        private CustomControls.RJControls.RJButton rjbtnLogOut;
        private CustomControls.RJControls.RJButton rjbtnClose;
        private System.Windows.Forms.Panel pnlLogo;
    }
}