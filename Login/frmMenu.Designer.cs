
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.label_name = new System.Windows.Forms.Label();
            this.rndpicUser = new CustomControls.RoundedPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_logaout = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PanelContenido = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.pnlUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rndpicUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pnlUserInfo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button_logaout);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 45);
            this.panel1.TabIndex = 0;
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.Controls.Add(this.label_name);
            this.pnlUserInfo.Controls.Add(this.rndpicUser);
            this.pnlUserInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlUserInfo.Location = new System.Drawing.Point(431, 0);
            this.pnlUserInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(195, 45);
            this.pnlUserInfo.TabIndex = 5;
            // 
            // label_name
            // 
            this.label_name.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(65, 0);
            this.label_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(130, 45);
            this.label_name.TabIndex = 3;
            this.label_name.Text = "label1";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rndpicUser
            // 
            this.rndpicUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.rndpicUser.Location = new System.Drawing.Point(0, 0);
            this.rndpicUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rndpicUser.Name = "rndpicUser";
            this.rndpicUser.Size = new System.Drawing.Size(61, 45);
            this.rndpicUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rndpicUser.TabIndex = 4;
            this.rndpicUser.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Login.Properties.Resources.Only_logo_FFFFFF;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button_logaout
            // 
            this.button_logaout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_logaout.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_logaout.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_logaout.FlatAppearance.BorderSize = 0;
            this.button_logaout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_logaout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_logaout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_logaout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logaout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_logaout.Location = new System.Drawing.Point(626, 0);
            this.button_logaout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_logaout.Name = "button_logaout";
            this.button_logaout.Size = new System.Drawing.Size(97, 45);
            this.button_logaout.TabIndex = 0;
            this.button_logaout.Text = "LogOut";
            this.button_logaout.UseVisualStyleBackColor = false;
            this.button_logaout.Click += new System.EventHandler(this.button_logaout_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Login.Properties.Resources.Name_FFFFFF;
            this.pictureBox2.Location = new System.Drawing.Point(61, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // PanelContenido
            // 
            this.PanelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.PanelContenido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenido.Location = new System.Drawing.Point(279, 45);
            this.PanelContenido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelContenido.Name = "PanelContenido";
            this.PanelContenido.Size = new System.Drawing.Size(444, 480);
            this.PanelContenido.TabIndex = 2;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 45);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(279, 480);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 525);
            this.Controls.Add(this.PanelContenido);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel1.ResumeLayout(false);
            this.pnlUserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rndpicUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel PanelContenido;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_logaout;
        private CustomControls.RoundedPictureBox rndpicUser;
        private System.Windows.Forms.Panel pnlUserInfo;
    }
}