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

namespace Users
{
    public partial class frmUser : prueba_txtBox.baseForm
    {
        public frmUser()
        {
            InitializeComponent();
            TableName = "Users";
            FKTableName = "UserCategories";
            querySelect = $"SELECT * FROM {TableName}";
            comboBox1.DisplayMember = "DescCategory";
            comboBox1.ValueMember = "idUserCategory";

        }

        protected override void BaseForm_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);
            
            comboBox1.DataSource = dsFK.Tables[FKTableName];
            

        }
    }
}
