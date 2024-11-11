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
    public partial class frmSpecies : prueba_txtBox.baseForm
    {
        public frmSpecies()
        {
            TableName = "Species";
            querySelect = $"SELECT * FROM {TableName}";
            //swTextox.Tag = swTextox.nombreColumna;
            //swTextox2.Tag = swTextox2.nombreColumna;
            InitializeComponent();
        }
    }
}
