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

namespace SpaceshipsCategories
{
    public partial class frmSpaceshipsCategories : baseForm
    {
        public frmSpaceshipsCategories()
        {
            InitializeComponent();
            TableName = "SpaceShipCategories";
            querySelect = $"SELECT * FROM {TableName}";
        }
    }
}
