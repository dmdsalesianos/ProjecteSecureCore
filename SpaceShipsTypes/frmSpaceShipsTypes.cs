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

namespace SpaceShipsTypes
{
    public partial class frmSpaceShipsTypes : baseForm
    {
        public frmSpaceShipsTypes()
        {
            InitializeComponent();
            TableName = "SpaceShipTypes";
            querySelect = $"SELECT * FROM {TableName}";

            comboBox = descCmb;
        }

        protected override void BaseForm_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);
            descCmb.DataSource = ds.Tables[TableName];
        }
    }
}
