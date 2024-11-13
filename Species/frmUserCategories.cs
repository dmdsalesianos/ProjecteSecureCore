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

namespace Species
{
    public partial class frmUserCategories : prueba_txtBox.baseForm
    {
        public frmUserCategories()
        {
            InitializeComponent();
            TableName = "UserCategories";
            querySelect = $"SELECT * FROM {TableName}";

            comboBox = comboBox1;  
        }

        protected override void BaseForm_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);
            comboBox1.DataSource = ds.Tables[TableName];
        }
    }
}
