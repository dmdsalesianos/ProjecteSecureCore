
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
            this.pictureBox2.Location = new System.Drawing.Point(32, 128);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(184, 32);
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
            this.Login.Location = new System.Drawing.Point(46, 172);
            this.Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(159, 32);
            this.Login.TabIndex = 11;
            this.Login.Text = "NEW PASS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.Only_logo_FFFFFF;
            this.pictureBox1.Location = new System.Drawing.Point(80, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 122);
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
            this.btnShowNewPassword.Location = new System.Drawing.Point(217, 231);
            this.btnShowNewPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowNewPassword.Name = "btnShowNewPassword";
            this.btnShowNewPassword.Size = new System.Drawing.Size(21, 23);
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
            this.lblConfirmPassword.Location = new System.Drawing.Point(3, 261);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(91, 17);
            this.lblConfirmPassword.TabIndex = 16;
            this.lblConfirmPassword.Text = "Confirm Pass";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Arial", 16F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(6, 279);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(242, 32);
            this.txtConfirmPassword.TabIndex = 14;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfirmPassword_KeyDown);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Arial", 16F);
            this.txtNewPassword.Location = new System.Drawing.Point(6, 227);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(242, 32);
            this.txtNewPassword.TabIndex = 13;
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewPassword_KeyDown);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(3, 314);
            this.lblErrorMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(117, 13);
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
            this.btnShowConfirmPassword.Location = new System.Drawing.Point(217, 283);
            this.btnShowConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowConfirmPassword.Name = "btnShowConfirmPassword";
            this.btnShowConfirmPassword.Size = new System.Drawing.Size(21, 23);
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
            this.label1.Location = new System.Drawing.Point(2, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
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
            this.pnlPass.Location = new System.Drawing.Point(235, 26);
            this.pnlPass.Name = "pnlPass";
            this.pnlPass.Size = new System.Drawing.Size(261, 382);
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
            this.rjbtnBack.Location = new System.Drawing.Point(132, 330);
            this.rjbtnBack.Name = "rjbtnBack";
            this.rjbtnBack.Size = new System.Drawing.Size(116, 40);
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
            this.rjbtnSave.Location = new System.Drawing.Point(6, 330);
            this.rjbtnSave.Name = "rjbtnSave";
            this.rjbtnSave.Size = new System.Drawing.Size(116, 40);
            this.rjbtnSave.TabIndex = 28;
            this.rjbtnSave.Text = "SAVE";
            this.rjbtnSave.TextColor = System.Drawing.Color.White;
            this.rjbtnSave.UseVisualStyleBackColor = false;
            this.rjbtnSave.Click += new System.EventHandler(this.rjbtnSave_Click);
            // 
            // frmChangePasswordd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.BackgroundImage = global::Login.Properties.Resources.fondo_chat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 607);
            this.ControlBox = false;
            this.Controls.Add(this.pnlPass);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmChangePasswordd";
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