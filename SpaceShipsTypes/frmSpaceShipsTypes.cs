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

namespace SpaceShipsTypes
{
    public partial class frmSpaceShipsTypes : Base.baseForm
    {
      

        public frmSpaceShipsTypes()
        {
            InitializeComponent();
            TableName = "SpaceShipTypes";
            TablesFK = new List<string> { "SpaceShipCategories", "Filiations" };
            querySelect = $"SELECT * FROM {TableName}";

            filiationCmb.Tag = "idFiliation"; //Tabla foranea
            filiationCmb.DisplayMember = "DescFiliations";//desc foranea a mostrar en vez de id
            filiationCmb.ValueMember = "idFiliation";//id foranea

            categoryCmb.Tag = "idSpaceShipCategory";
            categoryCmb.DisplayMember = "DescSpaceShipCategory";
            categoryCmb.ValueMember = "idSpaceShipCategory";
        }

        protected override void BaseForm_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);

            categoryCmb.DataSource = ds.Tables["SpaceShipCategories"];
            filiationCmb.DataSource = ds.Tables["Filiations"];
        }
    }
}