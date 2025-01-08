using Base;
using System.Collections.Generic;

namespace SpaceShipsTypes
{
    public partial class frmSpaceShipsTypes : baseForm
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

        private void frmSpaceShipsTypes_Load(object sender, System.EventArgs e)
        {
            base.BaseForm_Load(sender, e);

            categoryCmb.DataSource = ds.Tables["SpaceShipCategories"];
            filiationCmb.DataSource = ds.Tables["Filiations"];

        }
    }
}
