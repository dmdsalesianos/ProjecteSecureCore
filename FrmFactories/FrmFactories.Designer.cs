
namespace FrmFactories
{
    partial class FrmFactories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFactories));
            this.lblCodeFactory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtDescFactory = new CustomControls.SWTextbox();
            this.txtCodeFactory = new CustomControls.SWTextbox();
            this.dtgFactories = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFactories)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodeFactory
            // 
            this.lblCodeFactory.AutoSize = true;
            this.lblCodeFactory.Location = new System.Drawing.Point(64, 68);
            this.lblCodeFactory.Name = "lblCodeFactory";
            this.lblCodeFactory.Size = new System.Drawing.Size(94, 17);
            this.lblCodeFactory.TabIndex = 0;
            this.lblCodeFactory.Text = "Factory code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Factory description:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(593, 62);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(674, 62);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 34);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDescFactory
            // 
            this.txtDescFactory.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescFactory.EsForanea = false;
            this.txtDescFactory.Location = new System.Drawing.Point(441, 68);
            this.txtDescFactory.Name = "txtDescFactory";
            this.txtDescFactory.NomCampBBDD = null;
            this.txtDescFactory.PermetreBuit = true;
            this.txtDescFactory.Size = new System.Drawing.Size(133, 22);
            this.txtDescFactory.TabIndex = 6;
            this.txtDescFactory.Tag = "DescFactory";
            this.txtDescFactory.TipusDada = CustomControls.SWTextbox.Tipus_Dada.All;
            // 
            // txtCodeFactory
            // 
            this.txtCodeFactory.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodeFactory.EsForanea = false;
            this.txtCodeFactory.Location = new System.Drawing.Point(164, 65);
            this.txtCodeFactory.Name = "txtCodeFactory";
            this.txtCodeFactory.NomCampBBDD = null;
            this.txtCodeFactory.PermetreBuit = true;
            this.txtCodeFactory.Size = new System.Drawing.Size(133, 22);
            this.txtCodeFactory.TabIndex = 5;
            this.txtCodeFactory.Tag = "codeFactory";
            this.txtCodeFactory.TipusDada = CustomControls.SWTextbox.Tipus_Dada.All;
            // 
            // dtgFactories
            // 
            this.dtgFactories.AllowUserToAddRows = false;
            this.dtgFactories.AllowUserToDeleteRows = false;
            this.dtgFactories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFactories.Location = new System.Drawing.Point(67, 141);
            this.dtgFactories.Name = "dtgFactories";
            this.dtgFactories.ReadOnly = true;
            this.dtgFactories.RowHeadersWidth = 51;
            this.dtgFactories.RowTemplate.Height = 24;
            this.dtgFactories.Size = new System.Drawing.Size(682, 288);
            this.dtgFactories.TabIndex = 7;
            // 
            // FrmFactories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgFactories);
            this.Controls.Add(this.txtDescFactory);
            this.Controls.Add(this.txtCodeFactory);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCodeFactory);
            this.DoubleBuffered = true;
            this.Name = "FrmFactories";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmFactories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFactories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeFactory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private CustomControls.SWTextbox txtCodeFactory;
        private CustomControls.SWTextbox txtDescFactory;
        private System.Windows.Forms.DataGridView dtgFactories;
    }
}

