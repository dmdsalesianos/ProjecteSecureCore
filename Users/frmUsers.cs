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

            comboBox1.Tag = "idUserCategory";
            comboBox1.DisplayMember = "DescCategory";
            comboBox1.ValueMember = "idUserCategory";
            
            comboBox2.Tag = "idUserRank";
            comboBox2.DisplayMember = "DescRank";   
            comboBox2.ValueMember = "idUserRank";

        }

        protected override void BaseForm_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);

            dsFK = dataAccess.PortarTaula("UserCategories");
            comboBox1.DataSource = dsFK.Tables["UserCategories"];
            
            dsFK = dataAccess.PortarTaula("UserRanks");
            comboBox2.DataSource = dsFK.Tables["UserRanks"];
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                idUserDG = Convert.ToInt32(selectedRow.Cells[0].Value);

            }
            Form1 frmCrystal = new Form1(idUserDG);
            frmCrystal.Show();


        }
    }
}
