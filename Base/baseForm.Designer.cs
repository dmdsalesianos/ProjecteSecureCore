﻿
namespace Base
{
    partial class baseForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rjbtnActualitzar = new CustomControls.RJControls.RJButton();
            this.rjbtnAgregar = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(335, 328);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1941, 896);
            this.dataGridView1.TabIndex = 4;
            // 
            // rjbtnActualitzar
            // 
            this.rjbtnActualitzar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.rjbtnActualitzar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.rjbtnActualitzar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnActualitzar.BorderRadius = 0;
            this.rjbtnActualitzar.BorderSize = 0;
            this.rjbtnActualitzar.FlatAppearance.BorderSize = 0;
            this.rjbtnActualitzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnActualitzar.ForeColor = System.Drawing.Color.White;
            this.rjbtnActualitzar.Location = new System.Drawing.Point(2153, 270);
            this.rjbtnActualitzar.Name = "rjbtnActualitzar";
            this.rjbtnActualitzar.Size = new System.Drawing.Size(123, 40);
            this.rjbtnActualitzar.TabIndex = 6;
            this.rjbtnActualitzar.Text = "Actualitzar";
            this.rjbtnActualitzar.TextColor = System.Drawing.Color.White;
            this.rjbtnActualitzar.UseVisualStyleBackColor = false;
            this.rjbtnActualitzar.Click += new System.EventHandler(this.rjbtnActualitzar_Click);
            // 
            // rjbtnAgregar
            // 
            this.rjbtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.rjbtnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.rjbtnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnAgregar.BorderRadius = 0;
            this.rjbtnAgregar.BorderSize = 0;
            this.rjbtnAgregar.FlatAppearance.BorderSize = 0;
            this.rjbtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnAgregar.ForeColor = System.Drawing.Color.White;
            this.rjbtnAgregar.Location = new System.Drawing.Point(2024, 270);
            this.rjbtnAgregar.Name = "rjbtnAgregar";
            this.rjbtnAgregar.Size = new System.Drawing.Size(123, 40);
            this.rjbtnAgregar.TabIndex = 5;
            this.rjbtnAgregar.Text = "Agregar";
            this.rjbtnAgregar.TextColor = System.Drawing.Color.White;
            this.rjbtnAgregar.UseVisualStyleBackColor = false;
            this.rjbtnAgregar.Click += new System.EventHandler(this.rjbtnAgregar_Click);
            // 
            // baseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(2411, 1258);
            this.Controls.Add(this.rjbtnActualitzar);
            this.Controls.Add(this.rjbtnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "baseForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.DataGridView dataGridView1;
        private CustomControls.RJControls.RJButton rjbtnAgregar;
        private CustomControls.RJControls.RJButton rjbtnActualitzar;
    }
}

