
namespace Login
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login = new System.Windows.Forms.Label();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Error_label = new System.Windows.Forms.Label();
            this.Vision_button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.Black;
            this.Login.Location = new System.Drawing.Point(139, 220);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(129, 39);
            this.Login.TabIndex = 1;
            this.Login.Text = "LOGIN";
            // 
            // textBox_user
            // 
            this.textBox_user.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_user.Location = new System.Drawing.Point(146, 296);
            this.textBox_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(269, 36);
            this.textBox_user.TabIndex = 2;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(146, 360);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(269, 36);
            this.textBox_password.TabIndex = 3;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_login.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_login.Location = new System.Drawing.Point(125, 429);
            this.button_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(309, 49);
            this.button_login.TabIndex = 4;
            this.button_login.Text = "Log in";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(142, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(142, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // Error_label
            // 
            this.Error_label.AutoSize = true;
            this.Error_label.ForeColor = System.Drawing.Color.Red;
            this.Error_label.Location = new System.Drawing.Point(142, 396);
            this.Error_label.Name = "Error_label";
            this.Error_label.Size = new System.Drawing.Size(163, 17);
            this.Error_label.TabIndex = 8;
            this.Error_label.Text = "Wrong password or user";
            this.Error_label.Visible = false;
            // 
            // Vision_button
            // 
            this.Vision_button.BackColor = System.Drawing.Color.Transparent;
            this.Vision_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Vision_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Vision_button.FlatAppearance.BorderSize = 0;
            this.Vision_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Vision_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Vision_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vision_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vision_button.Location = new System.Drawing.Point(373, 363);
            this.Vision_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Vision_button.Name = "Vision_button";
            this.Vision_button.Size = new System.Drawing.Size(28, 29);
            this.Vision_button.TabIndex = 7;
            this.Vision_button.Text = "👁";
            this.Vision_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Vision_button.UseVisualStyleBackColor = false;
            this.Vision_button.Click += new System.EventHandler(this.Visible_button);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Login.Properties.Resources.Name_2490F1;
            this.pictureBox2.Location = new System.Drawing.Point(169, 164);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.Only_logo_2490F1;
            this.pictureBox1.Location = new System.Drawing.Point(238, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(481, 296);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(269, 36);
            this.txtNewPassword.TabIndex = 10;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(481, 356);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(269, 36);
            this.txtConfirmPassword.TabIndex = 11;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btnChangePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnChangePassword.Location = new System.Drawing.Point(471, 429);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(309, 49);
            this.btnChangePassword.TabIndex = 12;
            this.btnChangePassword.Text = "Chage password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPassword.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNewPassword.Location = new System.Drawing.Point(478, 277);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(100, 17);
            this.lblNewPassword.TabIndex = 13;
            this.lblNewPassword.Text = "New Password";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPassword.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblConfirmPassword.Location = new System.Drawing.Point(478, 337);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(121, 17);
            this.lblConfirmPassword.TabIndex = 14;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 520);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Error_label);
            this.Controls.Add(this.Vision_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Vision_button;
        private System.Windows.Forms.Label Error_label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
    }
}

