
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
            this.button_arrow = new CustomControls.RJButton();
            this.btnSavePassword = new CustomControls.RJButton();
            this.Button_Close = new CustomControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Login.Properties.Resources.Name_2490F1;
            this.pictureBox2.Location = new System.Drawing.Point(228, 197);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(276, 50);
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
            this.Login.Location = new System.Drawing.Point(249, 264);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(235, 46);
            this.Login.TabIndex = 11;
            this.Login.Text = "NEW PASS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.Only_logo_2490F1;
            this.pictureBox1.Location = new System.Drawing.Point(300, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 187);
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
            this.btnShowNewPassword.Location = new System.Drawing.Point(506, 355);
            this.btnShowNewPassword.Name = "btnShowNewPassword";
            this.btnShowNewPassword.Size = new System.Drawing.Size(31, 36);
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
            this.lblConfirmPassword.Font = new System.Drawing.Font("Arial Nova", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblConfirmPassword.Location = new System.Drawing.Point(190, 401);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(129, 25);
            this.lblConfirmPassword.TabIndex = 16;
            this.lblConfirmPassword.Text = "Confirm Pass";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Arial", 16F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(189, 429);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(361, 44);
            this.txtConfirmPassword.TabIndex = 14;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfirmPassword_KeyDown);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Arial", 16F);
            this.txtNewPassword.Location = new System.Drawing.Point(189, 349);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(361, 44);
            this.txtNewPassword.TabIndex = 13;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(185, 483);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(243, 20);
            this.lblErrorMessage.TabIndex = 19;
            this.lblErrorMessage.Text = "Wrong password or Confirm pass";
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
            this.btnShowConfirmPassword.Location = new System.Drawing.Point(506, 435);
            this.btnShowConfirmPassword.Name = "btnShowConfirmPassword";
            this.btnShowConfirmPassword.Size = new System.Drawing.Size(31, 36);
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
            this.label1.Font = new System.Drawing.Font("Arial Nova", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(190, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "New Pass";
            // 
            // button_arrow
            // 
            this.button_arrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.button_arrow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.button_arrow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(68)))), ((int)(((byte)(153)))));
            this.button_arrow.BorderRadius = 20;
            this.button_arrow.BorderSize = 5;
            this.button_arrow.FlatAppearance.BorderSize = 0;
            this.button_arrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_arrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_arrow.ForeColor = System.Drawing.Color.White;
            this.button_arrow.Location = new System.Drawing.Point(12, 12);
            this.button_arrow.Name = "button_arrow";
            this.button_arrow.Size = new System.Drawing.Size(57, 55);
            this.button_arrow.TabIndex = 23;
            this.button_arrow.Text = "🡨";
            this.button_arrow.TextColor = System.Drawing.Color.White;
            this.button_arrow.UseVisualStyleBackColor = false;
            this.button_arrow.Click += new System.EventHandler(this.button_arrow_Click);
            // 
            // btnSavePassword
            // 
            this.btnSavePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(241)))));
            this.btnSavePassword.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(241)))));
            this.btnSavePassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.btnSavePassword.BorderRadius = 20;
            this.btnSavePassword.BorderSize = 5;
            this.btnSavePassword.FlatAppearance.BorderSize = 0;
            this.btnSavePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSavePassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePassword.ForeColor = System.Drawing.Color.White;
            this.btnSavePassword.Location = new System.Drawing.Point(189, 537);
            this.btnSavePassword.Name = "btnSavePassword";
            this.btnSavePassword.Size = new System.Drawing.Size(361, 60);
            this.btnSavePassword.TabIndex = 24;
            this.btnSavePassword.Text = "SAVE";
            this.btnSavePassword.TextColor = System.Drawing.Color.White;
            this.btnSavePassword.UseVisualStyleBackColor = false;
            this.btnSavePassword.Click += new System.EventHandler(this.btnSavePassword_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Button_Close.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Button_Close.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Close.BorderRadius = 10;
            this.Button_Close.BorderSize = 5;
            this.Button_Close.FlatAppearance.BorderSize = 0;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Close.ForeColor = System.Drawing.Color.White;
            this.Button_Close.Location = new System.Drawing.Point(711, 12);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(38, 36);
            this.Button_Close.TabIndex = 25;
            this.Button_Close.Text = "❌";
            this.Button_Close.TextColor = System.Drawing.Color.White;
            this.Button_Close.UseVisualStyleBackColor = false;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.BackgroundImage = global::Login.Properties.Resources._94963041;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 670);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.btnSavePassword);
            this.Controls.Add(this.button_arrow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowConfirmPassword);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnShowNewPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "frmChangePassword";
            this.Text = "frmChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private CustomControls.RJButton button_arrow;
        private CustomControls.RJButton btnSavePassword;
        private CustomControls.RJButton Button_Close;
    }
}