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

            filiationCmb.Tag = "idFiliation";
            filiationCmb.DisplayMember = "DescFiliations";
            filiationCmb.ValueMember = "idFiliation";

            categoryCmb.Tag = "idSpaceShipCategory";
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