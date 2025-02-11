
namespace FrmGestioDadesSimple
{
    partial class FrmGestioDadesSimple
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgNewContacts = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtBirth = new CustomControls.SWTextbox();
            this.txtName = new CustomControls.SWTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNewContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "BirthDate";
            // 
            // dtgNewContacts
            // 
            this.dtgNewContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNewContacts.Location = new System.Drawing.Point(70, 125);
            this.dtgNewContacts.Name = "dtgNewContacts";
            this.dtgNewContacts.RowHeadersWidth = 51;
            this.dtgNewContacts.RowTemplate.Height = 24;
            this.dtgNewContacts.Size = new System.Drawing.Size(812, 360);
            this.dtgNewContacts.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(726, 68);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(807, 68);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 33);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtBirth
            // 
            this.txtBirth.BackColor = System.Drawing.SystemColors.Window;
            this.txtBirth.EsForanea = false;
            this.txtBirth.Location = new System.Drawing.Point(347, 73);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.NomCampBBDD = null;
            this.txtBirth.PermetreBuit = true;
            this.txtBirth.Size = new System.Drawing.Size(100, 22);
            this.txtBirth.TabIndex = 3;
            this.txtBirth.Tag = "BirthDate";
            this.txtBirth.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Date;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.EsForanea = false;
            this.txtName.Location = new System.Drawing.Point(134, 74);
            this.txtName.Name = "txtName";
            this.txtName.NomCampBBDD = null;
            this.txtName.PermetreBuit = true;
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 2;
            this.txtName.Tag = "Name";
            this.txtName.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // FrmGestioDadesSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 541);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dtgNewContacts);
            this.Controls.Add(this.txtBirth);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmGestioDadesSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGestioDadesSimple";
            this.Load += new System.EventHandler(this.FrmGestioDadesSimple_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNewContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomControls.SWTextbox txtName;
        private CustomControls.SWTextbox txtBirth;
        private System.Windows.Forms.DataGridView dtgNewContacts;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
    }
}

