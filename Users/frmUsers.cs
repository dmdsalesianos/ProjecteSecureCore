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
using CrystalDecisions.CrystalReports.Engine;


namespace Users
{
    public partial class frmUser : baseForm
    {
        public DataSet dsFK;
        protected int idUserDG;

        public frmUser()
        {
            InitializeComponent();
            TableName = "Users";
            querySelect = $"SELECT * FROM {TableName}";

            comboBox1.Tag = "UserCategories";
            comboBox1.DisplayMember = "DescCategory";
            comboBox1.ValueMember = "idUserCategory";
            
            comboBox2.Tag = "UserRanks";
            comboBox2.DisplayMember = "DescRank";
            comboBox2.ValueMember = "idUserRank";

        }

        protected override void BaseForm_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);

            dsFK = dataAccess.PortarTaula(comboBox2.Tag.ToString());

            comboBox2.DataSource = dsFK.Tables[comboBox2.Tag.ToString()];
            dsFK = dataAccess.PortarTaula(comboBox1.Tag.ToString());

            comboBox1.DataSource = dsFK.Tables[comboBox1.Tag.ToString()];
            
            

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGrid.SelectedRows[0];

                idUserDG = Convert.ToInt32(selectedRow.Cells[0].Value);

            }
            Form1 frmCrystal = new Form1(idUserDG);
            frmCrystal.Show();


        }
    }
}
