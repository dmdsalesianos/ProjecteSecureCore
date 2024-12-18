
namespace Login
{
    partial class frmLoading
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblLoadingMessage = new System.Windows.Forms.Label();
            this.rjProgressBar = new CustomControls.RJProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.Only_logo_2490F1;
            this.pictureBox1.Location = new System.Drawing.Point(461, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Login.Properties.Resources.Name_2490F1;
            this.pictureBox2.Location = new System.Drawing.Point(387, 205);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(276, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // lblLoadingMessage
            // 
            this.lblLoadingMessage.AutoSize = true;
            this.lblLoadingMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(241)))));
            this.lblLoadingMessage.Location = new System.Drawing.Point(418, 275);
            this.lblLoadingMessage.Name = "lblLoadingMessage";
            this.lblLoadingMessage.Size = new System.Drawing.Size(222, 46);
            this.lblLoadingMessage.TabIndex = 12;
            this.lblLoadingMessage.Text = "Coocking...";
            // 
            // rjProgressBar
            // 
            this.rjProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.rjProgressBar.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.rjProgressBar.ChannelHeight = 25;
            this.rjProgressBar.ForeBackColor = System.Drawing.Color.Transparent;
            this.rjProgressBar.ForeColor = System.Drawing.Color.White;
            this.rjProgressBar.Location = new System.Drawing.Point(241, 346);
            this.rjProgressBar.Name = "rjProgressBar";
            this.rjProgressBar.ShowMaximun = false;
            this.rjProgressBar.ShowValue = CustomControls.TextPosition.Right;
            this.rjProgressBar.Size = new System.Drawing.Size(552, 21);
            this.rjProgressBar.SliderColor = System.Drawing.Color.RoyalBlue;
            this.rjProgressBar.SliderHeight = 25;
            this.rjProgressBar.SymbolAfter = "";
            this.rjProgressBar.SymbolBefore = "";
            this.rjProgressBar.TabIndex = 13;
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.BackgroundImage = global::Login.Properties.Resources._9496304;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 545);
            this.Controls.Add(this.rjProgressBar);
            this.Controls.Add(this.lblLoadingMessage);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Blue;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblLoadingMessage;
        private CustomControls.RJProgressBar rjProgressBar;
    }
}