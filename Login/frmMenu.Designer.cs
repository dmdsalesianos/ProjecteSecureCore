
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
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.rjbtnClose = new CustomControls.RJControls.RJButton();
            this.rndpicUser = new CustomControls.RoundedPictureBox();
            this.rjbtnLogOut = new CustomControls.RJControls.RJButton();
            this.lblName = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pibLogoName = new System.Windows.Forms.PictureBox();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader.SuspendLayout();
            this.pnlUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rndpicUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogoName)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlHeader.Controls.Add(this.pnlUserInfo);
            this.pnlHeader.Controls.Add(this.picLogo);
            this.pnlHeader.Controls.Add(this.pibLogoName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(964, 55);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.Controls.Add(this.rjbtnClose);
            this.pnlUserInfo.Controls.Add(this.rndpicUser);
            this.pnlUserInfo.Controls.Add(this.rjbtnLogOut);
            this.pnlUserInfo.Controls.Add(this.lblName);
            this.pnlUserInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlUserInfo.Location = new System.Drawing.Point(551, 0);
            this.pnlUserInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(413, 55);
            this.pnlUserInfo.TabIndex = 5;
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
            this.rjbtnClose.Location = new System.Drawing.Point(353, 0);
            this.rjbtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.rjbtnClose.Name = "rjbtnClose";
            this.rjbtnClose.Size = new System.Drawing.Size(60, 55);
            this.rjbtnClose.TabIndex = 5;
            this.rjbtnClose.TextColor = System.Drawing.Color.White;
            this.rjbtnClose.UseVisualStyleBackColor = false;
            this.rjbtnClose.Click += new System.EventHandler(this.rjbtnClose_Click);
            // 
            // rndpicUser
            // 
            this.rndpicUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.rndpicUser.Location = new System.Drawing.Point(0, 0);
            this.rndpicUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rndpicUser.Name = "rndpicUser";
            this.rndpicUser.Size = new System.Drawing.Size(73, 55);
            this.rndpicUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rndpicUser.TabIndex = 4;
            this.rndpicUser.TabStop = false;
            this.rndpicUser.MouseHover += new System.EventHandler(this.rndpicUser_MouseHover);
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
            this.rjbtnLogOut.Location = new System.Drawing.Point(296, 0);
            this.rjbtnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.rjbtnLogOut.Name = "rjbtnLogOut";
            this.rjbtnLogOut.Size = new System.Drawing.Size(60, 55);
            this.rjbtnLogOut.TabIndex = 0;
            this.rjbtnLogOut.TextColor = System.Drawing.Color.White;
            this.rjbtnLogOut.UseVisualStyleBackColor = false;
            this.rjbtnLogOut.Click += new System.EventHandler(this.rjbtnLogOut_Click);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(107, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(183, 55);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Login";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLogo.Image = global::Login.Properties.Resources.Only_logo_FFFFFF;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(68, 55);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // pibLogoName
            // 
            this.pibLogoName.Image = global::Login.Properties.Resources.Name_FFFFFF;
            this.pibLogoName.Location = new System.Drawing.Point(82, 12);
            this.pibLogoName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pibLogoName.Name = "pibLogoName";
            this.pibLogoName.Size = new System.Drawing.Size(179, 30);
            this.pibLogoName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibLogoName.TabIndex = 2;
            this.pibLogoName.TabStop = false;
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.pnlContenido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(392, 55);
            this.pnlContenido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(572, 591);
            this.pnlContenido.TabIndex = 2;
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 55);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(392, 591);
            this.pnlMenu.TabIndex = 0;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 646);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlUserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rndpicUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogoName)).EndInit();
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
    }
}