﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Base;

namespace SpaceShipCategories
{
    public partial class frmSpaceShipCategories : baseForm
    {
        public frmSpaceShipCategories()
        {
            InitializeComponent();
            TableName = "SpaceShipCategories";
            querySelect = $"SELECT * FROM {TableName}";
        }

        private void frmSpaceshipsCategories_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);
        }
    }
}
