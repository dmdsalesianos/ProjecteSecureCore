
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
            this.rjBut_update = new CustomControls.RJControls.RJButton();
            this.swTb_Name = new CustomControls.SWTextbox();
            this.rjBut_Nuevo = new CustomControls.RJControls.RJButton();
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
            this.dtb_products.Location = new System.Drawing.Point(94, 219);
            this.dtb_products.Name = "dtb_products";
            this.dtb_products.RowHeadersWidth = 62;
            this.dtb_products.RowTemplate.Height = 28;
            this.dtb_products.Size = new System.Drawing.Size(1081, 475);
            this.dtb_products.TabIndex = 0;
            this.dtb_products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtProducts_CellClick);
            this.dtb_products.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DtProducts_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // comboBox_relacional
            // 
            this.comboBox_relacional.Font = new System.Drawing.Font("Arial Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_relacional.FormattingEnabled = true;
            this.comboBox_relacional.Location = new System.Drawing.Point(570, 52);
            this.comboBox_relacional.Name = "comboBox_relacional";
            this.comboBox_relacional.Size = new System.Drawing.Size(213, 37);
            this.comboBox_relacional.TabIndex = 8;
            this.comboBox_relacional.Tag = "Fábrica";
            // 
            // Factory
            // 
            this.Factory.AutoSize = true;
            this.Factory.Font = new System.Drawing.Font("Arial Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Factory.Location = new System.Drawing.Point(471, 55);
            this.Factory.Name = "Factory";
            this.Factory.Size = new System.Drawing.Size(93, 29);
            this.Factory.TabIndex = 12;
            this.Factory.Text = "Factory";
            // 
            // swTb_Price
            // 
            this.swTb_Price.BackColor = System.Drawing.SystemColors.Window;
            this.swTb_Price.EsForanea = false;
            this.swTb_Price.Font = new System.Drawing.Font("Arial Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTb_Price.Location = new System.Drawing.Point(188, 118);
            this.swTb_Price.Name = "swTb_Price";
            this.swTb_Price.NomCampBBDD = null;
            this.swTb_Price.PermetreBuit = true;
            this.swTb_Price.Size = new System.Drawing.Size(251, 37);
            this.swTb_Price.TabIndex = 13;
            this.swTb_Price.Tag = "Price";
            this.swTb_Price.TipusDada = CustomControls.SWTextbox.Tipus_Dada.All;
            // 
            // rjBut_update
            // 
            this.rjBut_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(241)))));
            this.rjBut_update.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(241)))));
            this.rjBut_update.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.rjBut_update.BorderRadius = 10;
            this.rjBut_update.BorderSize = 2;
            this.rjBut_update.FlatAppearance.BorderSize = 0;
            this.rjBut_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjBut_update.Font = new System.Drawing.Font("Arial Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjBut_update.ForeColor = System.Drawing.Color.White;
            this.rjBut_update.Location = new System.Drawing.Point(1034, 143);
            this.rjBut_update.Name = "rjBut_update";
            this.rjBut_update.Size = new System.Drawing.Size(141, 53);
            this.rjBut_update.TabIndex = 11;
            this.rjBut_update.Text = "Update";
            this.rjBut_update.TextColor = System.Drawing.Color.White;
            this.rjBut_update.UseVisualStyleBackColor = false;
            this.rjBut_update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // swTb_Name
            // 
            this.swTb_Name.BackColor = System.Drawing.SystemColors.Window;
            this.swTb_Name.EsForanea = false;
            this.swTb_Name.Font = new System.Drawing.Font("Arial Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTb_Name.Location = new System.Drawing.Point(188, 51);
            this.swTb_Name.Name = "swTb_Name";
            this.swTb_Name.NomCampBBDD = null;
            this.swTb_Name.PermetreBuit = true;
            this.swTb_Name.Size = new System.Drawing.Size(251, 37);
            this.swTb_Name.TabIndex = 10;
            this.swTb_Name.Tag = "Name";
            this.swTb_Name.TipusDada = CustomControls.SWTextbox.Tipus_Dada.Text;
            // 
            // rjBut_Nuevo
            // 
            this.rjBut_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(241)))));
            this.rjBut_Nuevo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(241)))));
            this.rjBut_Nuevo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.rjBut_Nuevo.BorderRadius = 10;
            this.rjBut_Nuevo.BorderSize = 2;
            this.rjBut_Nuevo.FlatAppearance.BorderSize = 0;
            this.rjBut_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjBut_Nuevo.Font = new System.Drawing.Font("Arial Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjBut_Nuevo.ForeColor = System.Drawing.Color.White;
            this.rjBut_Nuevo.Location = new System.Drawing.Point(903, 143);
            this.rjBut_Nuevo.Name = "rjBut_Nuevo";
            this.rjBut_Nuevo.Size = new System.Drawing.Size(125, 53);
            this.rjBut_Nuevo.TabIndex = 9;
            this.rjBut_Nuevo.Text = "Nuevo";
            this.rjBut_Nuevo.TextColor = System.Drawing.Color.White;
            this.rjBut_Nuevo.UseVisualStyleBackColor = false;
            this.rjBut_Nuevo.Click += new System.EventHandler(this.button_new_Click);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.BackgroundImage = global::FrmProductes.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1196, 805);
            this.Controls.Add(this.swTb_Price);
            this.Controls.Add(this.Factory);
            this.Controls.Add(this.rjBut_update);
            this.Controls.Add(this.swTb_Name);
            this.Controls.Add(this.rjBut_Nuevo);
            this.Controls.Add(this.comboBox_relacional);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtb_products);
            this.DoubleBuffered = true;
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
        private CustomControls.RJControls.RJButton rjBut_Nuevo;
        private CustomControls.SWTextbox swTb_Name;
        private CustomControls.RJControls.RJButton rjBut_update;
        private System.Windows.Forms.Label Factory;
        private CustomControls.SWTextbox swTb_Price;
    }
}

