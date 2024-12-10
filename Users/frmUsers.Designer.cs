
namespace Users
{
    partial class frmUser
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
            this.swTextbox1 = new CustomControls.SWTextbox();
            this.swTextbox2 = new CustomControls.SWTextbox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // swTextbox1
            // 
            this.swTextbox1.EsForanea = false;
            this.swTextbox1.Location = new System.Drawing.Point(134, 40);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.NomCampBBDD = "CodeUser";
            this.swTextbox1.PermetreBuit = true;
            this.swTextbox1.Size = new System.Drawing.Size(280, 22);
            this.swTextbox1.TabIndex = 5;
            this.swTextbox1.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Number;
            // 
            // swTextbox2
            // 
            this.swTextbox2.EsForanea = false;
            this.swTextbox2.Location = new System.Drawing.Point(134, 96);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.NomCampBBDD = "UserName";
            this.swTextbox2.PermetreBuit = true;
            this.swTextbox2.Size = new System.Drawing.Size(280, 22);
            this.swTextbox2.TabIndex = 6;
            this.swTextbox2.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Number;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 223);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(185, 24);
            this.comboBox2.TabIndex = 8;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(58, 301);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 9;
            this.btnMostrar.Text = "button1";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // frmUser
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 472);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swTextbox1);
            this.Name = "frmUser";
            this.Text = "frmUsers";
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.comboBox2, 0);
            this.Controls.SetChildIndex(this.btnMostrar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextbox swTextbox1;
        private CustomControls.SWTextbox swTextbox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnMostrar;
    }
}