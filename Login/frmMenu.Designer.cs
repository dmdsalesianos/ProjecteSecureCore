
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usuariLbl = new System.Windows.Forms.Label();
            this.button_logaout = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PanelContenido = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.usuariLbl);
            this.panel1.Controls.Add(this.button_logaout);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 56);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Login.Properties.Resources.Only_logo_FFFFFF;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // usuariLbl
            // 
            this.usuariLbl.AutoSize = true;
            this.usuariLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariLbl.ForeColor = System.Drawing.Color.White;
            this.usuariLbl.Location = new System.Drawing.Point(750, 12);
            this.usuariLbl.Margin = new System.Windows.Forms.Padding(0);
            this.usuariLbl.Name = "usuariLbl";
            this.usuariLbl.Size = new System.Drawing.Size(102, 32);
            this.usuariLbl.TabIndex = 3;
            this.usuariLbl.Text = "Usuari";
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
            this.button_logaout.Location = new System.Drawing.Point(855, 0);
            this.button_logaout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_logaout.Name = "button_logaout";
            this.button_logaout.Size = new System.Drawing.Size(130, 56);
            this.button_logaout.TabIndex = 0;
            this.button_logaout.Text = "LogOut";
            this.button_logaout.UseVisualStyleBackColor = false;
            this.button_logaout.Click += new System.EventHandler(this.button_logaout_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Login.Properties.Resources.Name_FFFFFF;
            this.pictureBox2.Location = new System.Drawing.Point(81, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // PanelContenido
            // 
            this.PanelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.PanelContenido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenido.Location = new System.Drawing.Point(372, 56);
            this.PanelContenido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelContenido.Name = "PanelContenido";
            this.PanelContenido.Size = new System.Drawing.Size(613, 590);
            this.PanelContenido.TabIndex = 2;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 56);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(372, 590);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 646);
            this.Controls.Add(this.PanelContenido);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label usuariLbl;
        private System.Windows.Forms.Button button_logaout;
    }
}