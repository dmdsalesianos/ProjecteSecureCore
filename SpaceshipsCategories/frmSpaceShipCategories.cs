using System;
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
