
namespace MenuOptions
{
    partial class frmMenuOptions
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
            this.pictureBox_icono = new System.Windows.Forms.PictureBox();
            this.lblUserRank = new System.Windows.Forms.Label();
            this.label_clase = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_color = new System.Windows.Forms.Label();
            this.label_ICONO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.swTextbox_Name = new CustomControls.SWTextbox();
            this.swTextbox_Form = new CustomControls.SWTextbox();
            this.swTextbox_Classe = new CustomControls.SWTextbox();
            this.swTextbox_Color = new CustomControls.SWTextbox();
            this.swtxtImagen = new CustomControls.SWTextbox();
            this.rjbtnImagen = new CustomControls.RJControls.RJButton();
            this.cmbUserRanks = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icono)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_icono
            // 
            this.pictureBox_icono.Location = new System.Drawing.Point(42, 42);
            this.pictureBox_icono.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox_icono.Name = "pictureBox_icono";
            this.pictureBox_icono.Size = new System.Drawing.Size(119, 108);
            this.pictureBox_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_icono.TabIndex = 7;
            this.pictureBox_icono.TabStop = false;
            // 
            // lblUserRank
            // 
            this.lblUserRank.AutoSize = true;
            this.lblUserRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRank.Location = new System.Drawing.Point(211, 133);
            this.lblUserRank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserRank.Name = "lblUserRank";
            this.lblUserRank.Size = new System.Drawing.Size(75, 17);
            this.lblUserRank.TabIndex = 12;
            this.lblUserRank.Text = "User Rank";
            // 
            // label_clase
            // 
            this.label_clase.AutoSize = true;
            this.label_clase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_clase.Location = new System.Drawing.Point(233, 57);
            this.label_clase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_clase.Name = "label_clase";
            this.label_clase.Size = new System.Drawing.Size(50, 17);
            this.label_clase.TabIndex = 14;
            this.label_clase.Text = "Classe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Form";
            // 
            // label_color
            // 
            this.label_color.AutoSize = true;
            this.label_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_color.Location = new System.Drawing.Point(241, 106);
            this.label_color.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_color.Name = "label_color";
            this.label_color.Size = new System.Drawing.Size(41, 17);
            this.label_color.TabIndex = 18;
            this.label_color.Text = "Color";
            // 
            // label_ICONO
            // 
            this.label_ICONO.AutoSize = true;
            this.label_ICONO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ICONO.Location = new System.Drawing.Point(71, 24);
            this.label_ICONO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ICONO.Name = "label_ICONO";
            this.label_ICONO.Size = new System.Drawing.Size(52, 17);
            this.label_ICONO.TabIndex = 21;
            this.label_ICONO.Text = "ICONO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Name";
            // 
            // swTextbox_Name
            // 
            this.swTextbox_Name.EsForanea = false;
            this.swTextbox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.swTextbox_Name.Location = new System.Drawing.Point(285, 29);
            this.swTextbox_Name.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.swTextbox_Name.Name = "swTextbox_Name";
            this.swTextbox_Name.NomCampBBDD = "Texto";
            this.swTextbox_Name.PermetreBuit = true;
            this.swTextbox_Name.Size = new System.Drawing.Size(155, 23);
            this.swTextbox_Name.TabIndex = 1;
            this.swTextbox_Name.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // swTextbox_Form
            // 
            this.swTextbox_Form.EsForanea = false;
            this.swTextbox_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.swTextbox_Form.Location = new System.Drawing.Point(285, 81);
            this.swTextbox_Form.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.swTextbox_Form.Name = "swTextbox_Form";
            this.swTextbox_Form.NomCampBBDD = "Form";
            this.swTextbox_Form.PermetreBuit = true;
            this.swTextbox_Form.Size = new System.Drawing.Size(155, 23);
            this.swTextbox_Form.TabIndex = 3;
            this.swTextbox_Form.TipusDada = CustomControls.SWTextbox.Tipus_Dada.All;
            // 
            // swTextbox_Classe
            // 
            this.swTextbox_Classe.EsForanea = false;
            this.swTextbox_Classe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.swTextbox_Classe.Location = new System.Drawing.Point(285, 55);
            this.swTextbox_Classe.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.swTextbox_Classe.Name = "swTextbox_Classe";
            this.swTextbox_Classe.NomCampBBDD = "Clase";
            this.swTextbox_Classe.PermetreBuit = true;
            this.swTextbox_Classe.Size = new System.Drawing.Size(155, 23);
            this.swTextbox_Classe.TabIndex = 2;
            this.swTextbox_Classe.TipusDada = CustomControls.SWTextbox.Tipus_Dada.All;
            // 
            // swTextbox_Color
            // 
            this.swTextbox_Color.EsForanea = false;
            this.swTextbox_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.swTextbox_Color.Location = new System.Drawing.Point(285, 106);
            this.swTextbox_Color.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.swTextbox_Color.Name = "swTextbox_Color";
            this.swTextbox_Color.NomCampBBDD = "Color";
            this.swTextbox_Color.PermetreBuit = true;
            this.swTextbox_Color.Size = new System.Drawing.Size(155, 23);
            this.swTextbox_Color.TabIndex = 4;
            this.swTextbox_Color.TipusDada = CustomControls.SWTextbox.Tipus_Dada.All;
            // 
            // swtxtImagen
            // 
            this.swtxtImagen.EsForanea = false;
            this.swtxtImagen.Location = new System.Drawing.Point(42, 74);
            this.swtxtImagen.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.swtxtImagen.Name = "swtxtImagen";
            this.swtxtImagen.NomCampBBDD = "Icono";
            this.swtxtImagen.PermetreBuit = true;
            this.swtxtImagen.Size = new System.Drawing.Size(68, 20);
            this.swtxtImagen.TabIndex = 34;
            this.swtxtImagen.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Number;
            this.swtxtImagen.TextChanged += new System.EventHandler(this.swtxtImagen_TextChanged);
            // 
            // rjbtnImagen
            // 
            this.rjbtnImagen.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rjbtnImagen.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.rjbtnImagen.BorderColor = System.Drawing.Color.Blue;
            this.rjbtnImagen.BorderRadius = 10;
            this.rjbtnImagen.BorderSize = 1;
            this.rjbtnImagen.FlatAppearance.BorderSize = 0;
            this.rjbtnImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnImagen.ForeColor = System.Drawing.Color.White;
            this.rjbtnImagen.Location = new System.Drawing.Point(42, 153);
            this.rjbtnImagen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rjbtnImagen.Name = "rjbtnImagen";
            this.rjbtnImagen.Size = new System.Drawing.Size(119, 26);
            this.rjbtnImagen.TabIndex = 6;
            this.rjbtnImagen.Text = "Cambiar Imagen";
            this.rjbtnImagen.TextColor = System.Drawing.Color.White;
            this.rjbtnImagen.UseVisualStyleBackColor = false;
            this.rjbtnImagen.Click += new System.EventHandler(this.rjbtnImagen_Click);
            // 
            // cmbUserRanks
            // 
            this.cmbUserRanks.FormattingEnabled = true;
            this.cmbUserRanks.Location = new System.Drawing.Point(285, 133);
            this.cmbUserRanks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUserRanks.Name = "cmbUserRanks";
            this.cmbUserRanks.Size = new System.Drawing.Size(155, 21);
            this.cmbUserRanks.TabIndex = 5;
            // 
            // frmMenuOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(699, 408);
            this.Controls.Add(this.cmbUserRanks);
            this.Controls.Add(this.rjbtnImagen);
            this.Controls.Add(this.swTextbox_Color);
            this.Controls.Add(this.swTextbox_Form);
            this.Controls.Add(this.swTextbox_Classe);
            this.Controls.Add(this.swTextbox_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_ICONO);
            this.Controls.Add(this.label_color);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_clase);
            this.Controls.Add(this.lblUserRank);
            this.Controls.Add(this.pictureBox_icono);
            this.Controls.Add(this.swtxtImagen);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "frmMenuOptions";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabIndexActualitzarBtn = 8;
            this.TabIndexAgregarBtn = 7;
            this.Text = "¡¡";
            this.Load += new System.EventHandler(this.frmMenuOptions_Load);
            this.Controls.SetChildIndex(this.swtxtImagen, 0);
            this.Controls.SetChildIndex(this.pictureBox_icono, 0);
            this.Controls.SetChildIndex(this.lblUserRank, 0);
            this.Controls.SetChildIndex(this.label_clase, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label_color, 0);
            this.Controls.SetChildIndex(this.label_ICONO, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.swTextbox_Name, 0);
            this.Controls.SetChildIndex(this.swTextbox_Classe, 0);
            this.Controls.SetChildIndex(this.swTextbox_Form, 0);
            this.Controls.SetChildIndex(this.swTextbox_Color, 0);
            this.Controls.SetChildIndex(this.rjbtnImagen, 0);
            this.Controls.SetChildIndex(this.cmbUserRanks, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_icono;
        private System.Windows.Forms.Label lblUserRank;
        private System.Windows.Forms.Label label_clase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_color;
        private System.Windows.Forms.Label label_ICONO;
        private System.Windows.Forms.Label label1;
        private CustomControls.SWTextbox swTextbox_Name;
        private CustomControls.SWTextbox swTextbox_Form;
        private CustomControls.SWTextbox swTextbox_Classe;
        private CustomControls.SWTextbox swTextbox_Color;
        private CustomControls.SWTextbox swtxtImagen;
        private CustomControls.RJControls.RJButton rjbtnImagen;
        private System.Windows.Forms.ComboBox cmbUserRanks;
    }
}