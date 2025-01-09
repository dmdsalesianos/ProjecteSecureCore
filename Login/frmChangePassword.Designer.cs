
namespace Login
{
    partial class frmChangePassword
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Login = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnShowNewPassword = new System.Windows.Forms.Button();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.btnShowConfirmPassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPass = new System.Windows.Forms.Panel();
            this.rjbtnBack = new CustomControls.RJControls.RJButton();
            this.rjbtnSave = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Login.Properties.Resources.Name_FFFFFF;
            this.pictureBox2.Location = new System.Drawing.Point(48, 197);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(276, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.Black;
            this.Login.Location = new System.Drawing.Point(69, 265);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(235, 46);
            this.Login.TabIndex = 11;
            this.Login.Text = "NEW PASS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.Only_logo_FFFFFF;
            this.pictureBox1.Location = new System.Drawing.Point(120, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnShowNewPassword
            // 
            this.btnShowNewPassword.BackColor = System.Drawing.Color.White;
            this.btnShowNewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShowNewPassword.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShowNewPassword.FlatAppearance.BorderSize = 0;
            this.btnShowNewPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnShowNewPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnShowNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowNewPassword.ForeColor = System.Drawing.Color.Black;
            this.btnShowNewPassword.Location = new System.Drawing.Point(326, 355);
            this.btnShowNewPassword.Name = "btnShowNewPassword";
            this.btnShowNewPassword.Size = new System.Drawing.Size(32, 35);
            this.btnShowNewPassword.TabIndex = 17;
            this.btnShowNewPassword.Text = "👁";
            this.btnShowNewPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowNewPassword.UseVisualStyleBackColor = false;
            this.btnShowNewPassword.Click += new System.EventHandler(this.btnShowNewPassword_Click);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.lblConfirmPassword.Location = new System.Drawing.Point(4, 402);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(129, 25);
            this.lblConfirmPassword.TabIndex = 16;
            this.lblConfirmPassword.Text = "Confirm Pass";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Arial", 16F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(9, 429);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(361, 44);
            this.txtConfirmPassword.TabIndex = 14;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfirmPassword_KeyDown);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Arial", 16F);
            this.txtNewPassword.Location = new System.Drawing.Point(9, 349);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(361, 44);
            this.txtNewPassword.TabIndex = 13;
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewPassword_KeyDown);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(4, 483);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(175, 20);
            this.lblErrorMessage.TabIndex = 19;
            this.lblErrorMessage.Text = "Put the same password";
            this.lblErrorMessage.Visible = false;
            // 
            // btnShowConfirmPassword
            // 
            this.btnShowConfirmPassword.BackColor = System.Drawing.Color.White;
            this.btnShowConfirmPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShowConfirmPassword.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShowConfirmPassword.FlatAppearance.BorderSize = 0;
            this.btnShowConfirmPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnShowConfirmPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnShowConfirmPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowConfirmPassword.Location = new System.Drawing.Point(326, 435);
            this.btnShowConfirmPassword.Name = "btnShowConfirmPassword";
            this.btnShowConfirmPassword.Size = new System.Drawing.Size(32, 35);
            this.btnShowConfirmPassword.TabIndex = 20;
            this.btnShowConfirmPassword.Text = "👁";
            this.btnShowConfirmPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowConfirmPassword.UseVisualStyleBackColor = false;
            this.btnShowConfirmPassword.Click += new System.EventHandler(this.btnShowConfirmPassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "New Pass";
            // 
            // pnlPass
            // 
            this.pnlPass.BackColor = System.Drawing.Color.Transparent;
            this.pnlPass.Controls.Add(this.rjbtnBack);
            this.pnlPass.Controls.Add(this.rjbtnSave);
            this.pnlPass.Controls.Add(this.pictureBox1);
            this.pnlPass.Controls.Add(this.Login);
            this.pnlPass.Controls.Add(this.pictureBox2);
            this.pnlPass.Controls.Add(this.label1);
            this.pnlPass.Controls.Add(this.btnShowConfirmPassword);
            this.pnlPass.Controls.Add(this.txtConfirmPassword);
            this.pnlPass.Controls.Add(this.lblErrorMessage);
            this.pnlPass.Controls.Add(this.lblConfirmPassword);
            this.pnlPass.Controls.Add(this.btnShowNewPassword);
            this.pnlPass.Controls.Add(this.txtNewPassword);
            this.pnlPass.Location = new System.Drawing.Point(352, 40);
            this.pnlPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPass.Name = "pnlPass";
            this.pnlPass.Size = new System.Drawing.Size(392, 588);
            this.pnlPass.TabIndex = 27;
            // 
            // rjbtnBack
            // 
            this.rjbtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rjbtnBack.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rjbtnBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rjbtnBack.BorderRadius = 10;
            this.rjbtnBack.BorderSize = 2;
            this.rjbtnBack.FlatAppearance.BorderSize = 0;
            this.rjbtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.rjbtnBack.ForeColor = System.Drawing.Color.White;
            this.rjbtnBack.Location = new System.Drawing.Point(198, 508);
            this.rjbtnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjbtnBack.Name = "rjbtnBack";
            this.rjbtnBack.Size = new System.Drawing.Size(174, 62);
            this.rjbtnBack.TabIndex = 29;
            this.rjbtnBack.Text = "BACK";
            this.rjbtnBack.TextColor = System.Drawing.Color.White;
            this.rjbtnBack.UseVisualStyleBackColor = false;
            this.rjbtnBack.Click += new System.EventHandler(this.rjbtnBack_Click);
            // 
            // rjbtnSave
            // 
            this.rjbtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(241)))));
            this.rjbtnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(241)))));
            this.rjbtnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.rjbtnSave.BorderRadius = 10;
            this.rjbtnSave.BorderSize = 2;
            this.rjbtnSave.FlatAppearance.BorderSize = 0;
            this.rjbtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.rjbtnSave.ForeColor = System.Drawing.Color.White;
            this.rjbtnSave.Location = new System.Drawing.Point(9, 508);
            this.rjbtnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjbtnSave.Name = "rjbtnSave";
            this.rjbtnSave.Size = new System.Drawing.Size(174, 62);
            this.rjbtnSave.TabIndex = 28;
            this.rjbtnSave.Text = "SAVE";
            this.rjbtnSave.TextColor = System.Drawing.Color.White;
            this.rjbtnSave.UseVisualStyleBackColor = false;
            this.rjbtnSave.Click += new System.EventHandler(this.rjbtnSave_Click);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.BackgroundImage = global::Login.Properties.Resources.fondo_chat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 934);
            this.ControlBox = false;
            this.Controls.Add(this.pnlPass);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePassword";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlPass.ResumeLayout(false);
            this.pnlPass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnShowNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Button btnShowConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPass;
        private CustomControls.RJControls.RJButton rjbtnSave;
        private CustomControls.RJControls.RJButton rjbtnBack;
    }
}