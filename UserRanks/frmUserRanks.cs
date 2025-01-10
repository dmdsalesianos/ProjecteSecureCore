using System;
using Base;

namespace UserRanks
{
    public partial class frmUserRanks : baseForm
    {
        public frmUserRanks()
        {
            InitializeComponent();
            TableName = "UserRanks";
            querySelect = $"SELECT * FROM {TableName}";

            //comboBox = rankCmb;
        }

        protected override void BaseForm_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);
        }
    }
}
