using System;
using System.Data;
using Base;

namespace UserCategories
{
    public partial class frmUserCategories : baseForm
    {
        public DataSet dsFK;
        public frmUserCategories()
        {
            InitializeComponent();
            TableName = "UserCategories";
            querySelect = $"SELECT * FROM {TableName}";
        }

        private void frmUserCategories_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);
        }
    }
}
