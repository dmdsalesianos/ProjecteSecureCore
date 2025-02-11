
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
            this.lblCode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgFactories = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtDescFactory = new CustomControls.SWTextbox();
            this.txtCodeFactory = new CustomControls.SWTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFactories)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(46, 46);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(96, 17);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Factory Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Factory Description";
            // 
            // dtgFactories
            // 
            this.dtgFactories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFactories.Location = new System.Drawing.Point(49, 94);
            this.dtgFactories.Name = "dtgFactories";
            this.dtgFactories.RowHeadersWidth = 51;
            this.dtgFactories.RowTemplate.Height = 24;
            this.dtgFactories.Size = new System.Drawing.Size(705, 269);
            this.dtgFactories.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(598, 43);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(679, 43);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 32);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // txtDescFactory
            // 
            this.txtDescFactory.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescFactory.EsForanea = false;
            this.txtDescFactory.Location = new System.Drawing.Point(390, 43);
            this.txtDescFactory.Name = "txtDescFactory";
            this.txtDescFactory.NomCampBBDD = null;
            this.txtDescFactory.PermetreBuit = true;
            this.txtDescFactory.Size = new System.Drawing.Size(100, 22);
            this.txtDescFactory.TabIndex = 3;
            this.txtDescFactory.TipusDada = CustomControls.SWTextbox.Tipus_Dada.All;
            // 
            // txtCodeFactory
            // 
            this.txtCodeFactory.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodeFactory.EsForanea = false;
            this.txtCodeFactory.Location = new System.Drawing.Point(148, 43);
            this.txtCodeFactory.Name = "txtCodeFactory";
            this.txtCodeFactory.NomCampBBDD = null;
            this.txtCodeFactory.PermetreBuit = true;
            this.txtCodeFactory.Size = new System.Drawing.Size(100, 22);
            this.txtCodeFactory.TabIndex = 2;
            this.txtCodeFactory.TipusDada = CustomControls.SWTextbox.Tipus_Dada.All;
            // 
            // FrmFactories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dtgFactories);
            this.Controls.Add(this.txtDescFactory);
            this.Controls.Add(this.txtCodeFactory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCode);
            this.Name = "FrmFactories";
            this.Text = "FrmFactories";
            ((System.ComponentModel.ISupportInitialize)(this.dtgFactories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label2;
        private CustomControls.SWTextbox txtCodeFactory;
        private CustomControls.SWTextbox txtDescFactory;
        private System.Windows.Forms.DataGridView dtgFactories;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
    }
}

