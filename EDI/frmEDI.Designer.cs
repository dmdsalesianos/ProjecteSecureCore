
namespace EDI
{
    partial class frmEDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEDI));
            this.rtbDoc = new System.Windows.Forms.RichTextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnMakeOrder = new CustomControls.RJControls.RJButton();
            this.btnSelectFile = new CustomControls.RJControls.RJButton();
            this.txtArxiu = new CustomControls.SWTextbox();
            this.SuspendLayout();
            // 
            // rtbDoc
            // 
            this.rtbDoc.Enabled = false;
            this.rtbDoc.Location = new System.Drawing.Point(38, 158);
            this.rtbDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbDoc.Name = "rtbDoc";
            this.rtbDoc.ReadOnly = true;
            this.rtbDoc.Size = new System.Drawing.Size(669, 472);
            this.rtbDoc.TabIndex = 0;
            this.rtbDoc.TabStop = false;
            this.rtbDoc.Text = "";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(34, 62);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(161, 20);
            this.lblFile.TabIndex = 2;
            this.lblFile.Text = "Archivo Seleccionado";
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.btnMakeOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.btnMakeOrder.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMakeOrder.BorderRadius = 0;
            this.btnMakeOrder.BorderSize = 0;
            this.btnMakeOrder.FlatAppearance.BorderSize = 0;
            this.btnMakeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeOrder.ForeColor = System.Drawing.Color.White;
            this.btnMakeOrder.Location = new System.Drawing.Point(594, 119);
            this.btnMakeOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(114, 32);
            this.btnMakeOrder.TabIndex = 1;
            this.btnMakeOrder.Text = "Make Order";
            this.btnMakeOrder.TextColor = System.Drawing.Color.White;
            this.btnMakeOrder.UseVisualStyleBackColor = false;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.btnSelectFile.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.btnSelectFile.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSelectFile.BorderRadius = 0;
            this.btnSelectFile.BorderSize = 0;
            this.btnSelectFile.FlatAppearance.BorderSize = 0;
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.ForeColor = System.Drawing.Color.White;
            this.btnSelectFile.Location = new System.Drawing.Point(428, 82);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(114, 32);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Select FIle";
            this.btnSelectFile.TextColor = System.Drawing.Color.White;
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtArxiu
            // 
            this.txtArxiu.BackColor = System.Drawing.SystemColors.Control;
            this.txtArxiu.Enabled = false;
            this.txtArxiu.EsForanea = false;
            this.txtArxiu.Location = new System.Drawing.Point(38, 85);
            this.txtArxiu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArxiu.Name = "txtArxiu";
            this.txtArxiu.NomCampBBDD = null;
            this.txtArxiu.PermetreBuit = true;
            this.txtArxiu.Size = new System.Drawing.Size(382, 26);
            this.txtArxiu.TabIndex = 11;
            this.txtArxiu.TipusDada = CustomControls.SWTextbox.Tipus_Dada.All;
            // 
            // frmEDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 658);
            this.Controls.Add(this.btnMakeOrder);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtArxiu);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.rtbDoc);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEDI";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDoc;
        private System.Windows.Forms.Label lblFile;
        private CustomControls.SWTextbox txtArxiu;
        private CustomControls.RJControls.RJButton btnSelectFile;
        private CustomControls.RJControls.RJButton btnMakeOrder;
    }
}

