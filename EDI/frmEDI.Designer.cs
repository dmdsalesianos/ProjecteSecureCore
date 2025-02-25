
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbDoc
            // 
            this.rtbDoc.Location = new System.Drawing.Point(34, 126);
            this.rtbDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbDoc.Name = "rtbDoc";
            this.rtbDoc.ReadOnly = true;
            this.rtbDoc.Size = new System.Drawing.Size(595, 378);
            this.rtbDoc.TabIndex = 0;
            this.rtbDoc.TabStop = false;
            this.rtbDoc.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 69);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(339, 22);
            this.textBox1.TabIndex = 1;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(30, 50);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(144, 17);
            this.lblFile.TabIndex = 2;
            this.lblFile.Text = "Archivo Seleccionado";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(378, 66);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(101, 27);
            this.btnSelectFile.TabIndex = 3;
            this.btnSelectFile.Text = "SelectFIle";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Location = new System.Drawing.Point(527, 94);
            this.btnMakeOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(101, 27);
            this.btnMakeOrder.TabIndex = 4;
            this.btnMakeOrder.Text = "Make Order";
            this.btnMakeOrder.UseVisualStyleBackColor = true;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // frmEDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 526);
            this.Controls.Add(this.btnMakeOrder);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnMakeOrder;
    }
}

