
namespace FrmProductes
{
    partial class frmProduct
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
            this.dtb_products = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_relacional = new System.Windows.Forms.ComboBox();
            this.Factory = new System.Windows.Forms.Label();
            this.swTb_Price = new CustomControls.SWTextbox();
            this.swTb_Name = new CustomControls.SWTextbox();
            this.btnNew = new CustomControls.RJControls.RJButton();
            this.btnUpdate = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtb_products)).BeginInit();
            this.SuspendLayout();
            // 
            // dtb_products
            // 
            this.dtb_products.AllowDrop = true;
            this.dtb_products.AllowUserToAddRows = false;
            this.dtb_products.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtb_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtb_products.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dtb_products.Location = new System.Drawing.Point(84, 175);
            this.dtb_products.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtb_products.Name = "dtb_products";
            this.dtb_products.ReadOnly = true;
            this.dtb_products.RowHeadersWidth = 62;
            this.dtb_products.RowTemplate.Height = 28;
            this.dtb_products.Size = new System.Drawing.Size(961, 380);
            this.dtb_products.TabIndex = 0;
            this.dtb_products.TabStop = false;
            this.dtb_products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtProducts_CellClick);
            this.dtb_products.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DtProducts_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // comboBox_relacional
            // 
            this.comboBox_relacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_relacional.FormattingEnabled = true;
            this.comboBox_relacional.Location = new System.Drawing.Point(507, 42);
            this.comboBox_relacional.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_relacional.Name = "comboBox_relacional";
            this.comboBox_relacional.Size = new System.Drawing.Size(190, 33);
            this.comboBox_relacional.TabIndex = 2;
            this.comboBox_relacional.Tag = "Fábrica";
            // 
            // Factory
            // 
            this.Factory.AutoSize = true;
            this.Factory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Factory.Location = new System.Drawing.Point(419, 44);
            this.Factory.Name = "Factory";
            this.Factory.Size = new System.Drawing.Size(77, 25);
            this.Factory.TabIndex = 12;
            this.Factory.Text = "Factory";
            // 
            // swTb_Price
            // 
            this.swTb_Price.BackColor = System.Drawing.SystemColors.Window;
            this.swTb_Price.EsForanea = false;
            this.swTb_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTb_Price.Location = new System.Drawing.Point(167, 94);
            this.swTb_Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swTb_Price.Name = "swTb_Price";
            this.swTb_Price.NomCampBBDD = null;
            this.swTb_Price.PermetreBuit = true;
            this.swTb_Price.Size = new System.Drawing.Size(224, 30);
            this.swTb_Price.TabIndex = 1;
            this.swTb_Price.Tag = "Price";
            this.swTb_Price.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Number;
            // 
            // swTb_Name
            // 
            this.swTb_Name.BackColor = System.Drawing.SystemColors.Window;
            this.swTb_Name.EsForanea = false;
            this.swTb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTb_Name.Location = new System.Drawing.Point(167, 41);
            this.swTb_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swTb_Name.Name = "swTb_Name";
            this.swTb_Name.NomCampBBDD = null;
            this.swTb_Name.PermetreBuit = true;
            this.swTb_Name.Size = new System.Drawing.Size(224, 30);
            this.swTb_Name.TabIndex = 0;
            this.swTb_Name.Tag = "Name";
            this.swTb_Name.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.btnNew.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.btnNew.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNew.BorderRadius = 0;
            this.btnNew.BorderSize = 0;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(802, 124);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(111, 29);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "New";
            this.btnNew.TextColor = System.Drawing.Color.White;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.button_new_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.btnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(934, 124);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 29);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.BackgroundImage = global::FrmProductes.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1063, 644);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.swTb_Price);
            this.Controls.Add(this.Factory);
            this.Controls.Add(this.swTb_Name);
            this.Controls.Add(this.comboBox_relacional);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtb_products);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProduct";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtb_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtb_products;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_relacional;
        private CustomControls.SWTextbox swTb_Name;
        private System.Windows.Forms.Label Factory;
        private CustomControls.SWTextbox swTb_Price;
        private CustomControls.RJControls.RJButton btnNew;
        private CustomControls.RJControls.RJButton btnUpdate;
    }
}

