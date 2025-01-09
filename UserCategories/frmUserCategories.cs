using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
