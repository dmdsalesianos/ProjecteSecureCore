
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
            this.components = new System.ComponentModel.Container();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Login = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.Vision_button = new System.Windows.Forms.Button();
            this.Error_label = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.pnlLoading = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblLoadingMessage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rjProgressBar = new CustomControls.RJProgressBar();
            this.btnClose = new CustomControls.RJControls.RJButton();
            this.rjbtnLogin = new CustomControls.RJControls.RJButton();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.Controls.Add(this.lblChangePassword);
            this.pnlLogin.Controls.Add(this.btnClose);
            this.pnlLogin.Controls.Add(this.rjbtnLogin);
            this.pnlLogin.Controls.Add(this.pictureBox1);
            this.pnlLogin.Controls.Add(this.Login);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.pictureBox2);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.textBox_user);
            this.pnlLogin.Controls.Add(this.Vision_button);
            this.pnlLogin.Controls.Add(this.Error_label);
            this.pnlLogin.Controls.Add(this.textBox_password);
            this.pnlLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(241)))));
            this.pnlLogin.Location = new System.Drawing.Point(816, 163);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(316, 654);
            this.pnlLogin.TabIndex = 12;
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePassword.Location = new System.Drawing.Point(84, 589);
            this.lblChangePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(158, 20);
            this.lblChangePassword.TabIndex = 16;
            this.lblChangePassword.Text = "Change Password";
            this.lblChangePassword.Visible = false;
            this.lblChangePassword.Click += new System.EventHandler(this.lblChangePassword_Click);
            this.lblChangePassword.MouseEnter += new System.EventHandler(this.lblChangePassword_MouseEnter);
            this.lblChangePassword.MouseLeave += new System.EventHandler(this.lblChangePassword_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.Only_logo_FFFFFF;
            this.pictureBox1.Location = new System.Drawing.Point(102, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.Black;
            this.Login.Location = new System.Drawing.Point(0, 265);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(151, 46);
            this.Login.TabIndex = 1;
            this.Login.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Login.Properties.Resources.Name_FFFFFF;
            this.pictureBox2.Location = new System.Drawing.Point(34, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(276, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "User";
            // 
            // textBox_user
            // 
            this.textBox_user.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_user.Location = new System.Drawing.Point(9, 358);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(302, 42);
            this.textBox_user.TabIndex = 2;
            this.textBox_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_user_KeyDown);
            // 
            // Vision_button
            // 
            this.Vision_button.BackColor = System.Drawing.Color.White;
            this.Vision_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Vision_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Vision_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Vision_button.FlatAppearance.BorderSize = 0;
            this.Vision_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Vision_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Vision_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vision_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vision_button.ForeColor = System.Drawing.Color.Black;
            this.Vision_button.Location = new System.Drawing.Point(279, 443);
            this.Vision_button.Name = "Vision_button";
            this.Vision_button.Size = new System.Drawing.Size(32, 35);
            this.Vision_button.TabIndex = 7;
            this.Vision_button.Text = "👁";
            this.Vision_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Vision_button.UseVisualStyleBackColor = false;
            this.Vision_button.Click += new System.EventHandler(this.Visible_button);
            // 
            // Error_label
            // 
            this.Error_label.AutoSize = true;
            this.Error_label.ForeColor = System.Drawing.Color.Red;
            this.Error_label.Location = new System.Drawing.Point(4, 485);
            this.Error_label.Name = "Error_label";
            this.Error_label.Size = new System.Drawing.Size(181, 20);
            this.Error_label.TabIndex = 8;
            this.Error_label.Text = "Wrong user or password";
            this.Error_label.Visible = false;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(9, 438);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(302, 42);
            this.textBox_password.TabIndex = 3;
            this.textBox_password.UseSystemPasswordChar = true;
            this.textBox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_password_KeyDown);
            // 
            // pnlLoading
            // 
            this.pnlLoading.BackColor = System.Drawing.Color.Transparent;
            this.pnlLoading.Controls.Add(this.pictureBox3);
            this.pnlLoading.Controls.Add(this.rjProgressBar);
            this.pnlLoading.Controls.Add(this.pictureBox4);
            this.pnlLoading.Controls.Add(this.lblLoadingMessage);
            this.pnlLoading.Location = new System.Drawing.Point(75, 195);
            this.pnlLoading.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLoading.Name = "pnlLoading";
            this.pnlLoading.Size = new System.Drawing.Size(648, 408);
            this.pnlLoading.TabIndex = 15;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Login.Properties.Resources.Only_logo_FFFFFF;
            this.pictureBox3.Location = new System.Drawing.Point(268, 22);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(140, 188);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Login.Properties.Resources.Name_FFFFFF;
            this.pictureBox4.Location = new System.Drawing.Point(195, 214);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(276, 49);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // lblLoadingMessage
            // 
            this.lblLoadingMessage.AutoSize = true;
            this.lblLoadingMessage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingMessage.ForeColor = System.Drawing.Color.White;
            this.lblLoadingMessage.Location = new System.Drawing.Point(228, 280);
            this.lblLoadingMessage.Name = "lblLoadingMessage";
            this.lblLoadingMessage.Size = new System.Drawing.Size(249, 48);
            this.lblLoadingMessage.TabIndex = 12;
            this.lblLoadingMessage.Text = "Coocking...";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rjProgressBar
            // 
            this.rjProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.rjProgressBar.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.rjProgressBar.ChannelHeight = 25;
            this.rjProgressBar.ForeBackColor = System.Drawing.Color.Transparent;
            this.rjProgressBar.ForeColor = System.Drawing.Color.White;
            this.rjProgressBar.Location = new System.Drawing.Point(42, 355);
            this.rjProgressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjProgressBar.Name = "rjProgressBar";
            this.rjProgressBar.ShowMaximun = false;
            this.rjProgressBar.ShowValue = CustomControls.TextPosition.Right;
            this.rjProgressBar.Size = new System.Drawing.Size(552, 22);
            this.rjProgressBar.SliderColor = System.Drawing.Color.White;
            this.rjProgressBar.SliderHeight = 25;
            this.rjProgressBar.SymbolAfter = "";
            this.rjProgressBar.SymbolBefore = "";
            this.rjProgressBar.TabIndex = 13;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.BorderRadius = 10;
            this.btnClose.BorderSize = 2;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(160, 509);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 62);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "EXIT";
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rjbtnLogin
            // 
            this.rjbtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(241)))));
            this.rjbtnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(241)))));
            this.rjbtnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.rjbtnLogin.BorderRadius = 10;
            this.rjbtnLogin.BorderSize = 2;
            this.rjbtnLogin.FlatAppearance.BorderSize = 0;
            this.rjbtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.rjbtnLogin.ForeColor = System.Drawing.Color.White;
            this.rjbtnLogin.Location = new System.Drawing.Point(9, 509);
            this.rjbtnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjbtnLogin.Name = "rjbtnLogin";
            this.rjbtnLogin.Size = new System.Drawing.Size(144, 62);
            this.rjbtnLogin.TabIndex = 16;
            this.rjbtnLogin.Text = "LOGIN";
            this.rjbtnLogin.TextColor = System.Drawing.Color.White;
            this.rjbtnLogin.UseVisualStyleBackColor = false;
            this.rjbtnLogin.Click += new System.EventHandler(this.rjbtnLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.BackgroundImage = global::Login.Properties.Resources.fondo_chat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1940, 1094);
            this.Controls.Add(this.pnlLoading);
            this.Controls.Add(this.pnlLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.SizeChanged += new System.EventHandler(this.frmLogin_SizeChanged);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlLoading.ResumeLayout(false);
            this.pnlLoading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.Button Vision_button;
        private System.Windows.Forms.Label Error_label;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Panel pnlLoading;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CustomControls.RJProgressBar rjProgressBar;
        private System.Windows.Forms.Label lblLoadingMessage;
        private System.Windows.Forms.Timer timer1;
        private CustomControls.RJControls.RJButton rjbtnLogin;
        private CustomControls.RJControls.RJButton btnClose;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblChangePassword;
    }
}

