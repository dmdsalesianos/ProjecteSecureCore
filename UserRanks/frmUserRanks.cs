using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prueba_txtBox;

namespace UserRanks
{
    public partial class frmUserRanks : baseForm
    {
        public frmUserRanks()
        {
            InitializeComponent();
            TableName = "UserRanks";
            querySelect = $"SELECT * FROM {TableName}";

            comboBox = rankCmb;
        }

        protected override void BaseForm_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);
            rankCmb.DataSource = ds.Tables[TableName];
        }
    }
}
