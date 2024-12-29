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
        private DataSet dsFK;

        public frmSpaceShipsTypes()
        {
            InitializeComponent();
            TableName = "SpaceShipTypes";
            querySelect = $"SELECT * FROM {TableName}";

            filiationCmb.Tag = "Filiations"; //Tabla foranea
            filiationCmb.DisplayMember = "DescFiliations";//desc foranea a mostrar en vez de id
            filiationCmb.ValueMember = "idFiliation";//id foranea

            categoryCmb.Tag = "SpaceShipCategories";
            categoryCmb.DisplayMember = "DescSpaceShipCategory";
            categoryCmb.ValueMember = "idSpaceShipCategory";
        }

        protected override void BaseForm_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);

            dsFK = dataAccess.PortarTaula("SpaceShipCategories");
            categoryCmb.DataSource = dsFK.Tables["SpaceShipCategories"];

            dsFK = dataAccess.PortarTaula("Filiations");
            filiationCmb.DataSource = dsFK.Tables["Filiations"];



        }
    }
}