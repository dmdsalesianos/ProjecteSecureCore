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

namespace Pruebas
{
    public partial class frmSpecies : baseForm
    {
        public frmSpecies()
        {
            TableName = "Species";
            querySelect = $"SELECT * FROM {TableName}";

            InitializeComponent();
        }

        private void frmSpecies_Load(object sender, EventArgs e)
        {

        }
    }
}
