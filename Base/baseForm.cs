using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using DataSetLibrary;
using DataBindingLibrary;

namespace prueba_txtBox
{
    public partial class baseForm : Form
    {
        public DataSet ds;
        public bool esNuevo = false;
        public BaseDataAccess dataAccess;
        public string TableName;
        public string querySelect;
        public ComboBox comboBox;

        public baseForm()
        {
            InitializeComponent();
        }

        protected virtual void BaseForm_Load(object sender, EventArgs e)
        {

            if (DesignMode) return;

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            dataAccess = new BaseDataAccess(connectionString);

            ds = dataAccess.PortarTaula(TableName);

            comboBox.DataSource = ds.Tables[TableName];
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;

            CargarDatos();

            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Validated += ValidarTextBox;
                }
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCode = comboBox.SelectedValue.ToString();

            if (!string.IsNullOrEmpty(selectedCode))
            {
                querySelect = $"SELECT * FROM {TableName} WHERE {comboBox.ValueMember} = '{selectedCode}'";

                ds = dataAccess.PortarTaula(TableName);
                CargarDatos(); 
            }
        }



        protected void CargarDatos()
        {
            DataBindingHelper.ClearDataBindings(this.Controls); 
            UpdateTable(); 

            BindTextBoxesToData();
        }

        private void BindTextBoxesToData()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox && textBox.Tag != null)
                {
                    textBox.DataBindings.Clear();
                    textBox.DataBindings.Add("Text", ds.Tables[TableName], textBox.Tag.ToString());
                }
            }
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            DataBindingHelper.ClearDataBindings(this.Controls);
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                AddNewRow();
                DataBindingHelper.BindControlsToData(this.Controls, ds.Tables[TableName]);
                esNuevo = false;
            }

            dataAccess.Actualitzar(ds, querySelect, TableName);
            ds = dataAccess.PortarTaula(TableName);
            CargarDatos();
        }

        protected void AddNewRow()
        {
            DataRow newRow = ds.Tables[TableName].NewRow();

            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    newRow[textBox.Tag.ToString()] = textBox.Text;
                }
            }

            ds.Tables[TableName].Rows.Add(newRow);
        }

        protected void UpdateTable()
        {
            dataGridView1.DataSource = ds.Tables[TableName];
            dataGridView1.Columns[0].Visible = false;
        }

        protected void ValidarTextBox(object sender, EventArgs e)
        {
            if (!esNuevo)
            {
                ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }
    }
}   