﻿
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_logaout = new System.Windows.Forms.Button();
            this.PanelContenido = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button_logaout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 59);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Login.Properties.Resources.Name_FFFFFF;
            this.pictureBox2.Location = new System.Drawing.Point(91, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(249, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Login.Properties.Resources.Only_logo_FFFFFF;
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button_logaout
            // 
            this.button_logaout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_logaout.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_logaout.FlatAppearance.BorderSize = 0;
            this.button_logaout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_logaout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_logaout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logaout.Font = new System.Drawing.Font("Arial Nova", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logaout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_logaout.Location = new System.Drawing.Point(1042, 0);
            this.button_logaout.Name = "button_logaout";
            this.button_logaout.Size = new System.Drawing.Size(142, 59);
            this.button_logaout.TabIndex = 0;
            this.button_logaout.Text = "Log out";
            this.button_logaout.UseVisualStyleBackColor = false;
            this.button_logaout.Click += new System.EventHandler(this.button_logaout_Click);
            // 
            // PanelContenido
            // 
            this.PanelContenido.BackColor = System.Drawing.Color.PaleTurquoise;
            this.PanelContenido.Controls.Add(this.flowLayoutPanel);
            this.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenido.Location = new System.Drawing.Point(0, 59);
            this.PanelContenido.Name = "PanelContenido";
            this.PanelContenido.Size = new System.Drawing.Size(1184, 698);
            this.PanelContenido.TabIndex = 2;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.Color.SeaGreen;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(357, 698);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 757);
            this.Controls.Add(this.PanelContenido);
            this.Controls.Add(this.panel1);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelContenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_logaout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel PanelContenido;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}