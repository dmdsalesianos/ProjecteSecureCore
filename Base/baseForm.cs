using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using DataLibraryDMD;
using DataBindingLibrary;

namespace prueba_txtBox
{
    public partial class baseForm : Form
    {
        public DataSet ds;
        public bool esNuevo = false;
        public MantenimentDades dataAccess;
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
            dataAccess = new MantenimentDades(connectionString);

            ds = dataAccess.PortarTaula(TableName);

            comboBox.DataSource = ds.Tables[TableName];

            CargarDatos();

            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Validated += ValidarTextBox;
                }
            }
        }

        protected void CargarDatos()
        {
            DataBindingHelper.ClearDataBindings(this.Controls);
            UpdateTable();

            BindTextBoxesToData();
            BindComboBoxToData();
        }

        private void BindTextBoxesToData()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    var nombreColumna = textBox.GetType().GetProperty("nombreColumna").GetValue(textBox, null) as string;

                    if (!string.IsNullOrEmpty(nombreColumna))
                    {
                        textBox.DataBindings.Clear();
                        textBox.DataBindings.Add("Text", ds.Tables[TableName], nombreColumna);
                    }
                }
            }
        }

        private void BindComboBoxToData()
        {
            if (comboBox.DisplayMember != null)
            {
                comboBox.DataBindings.Clear();

                comboBox.DataBindings.Add("SelectedValue", ds.Tables[TableName], "idSpecie");
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
                    var nombreColumna = textBox.GetType().GetProperty("nombreColumna").GetValue(textBox, null) as string;

                    if (!string.IsNullOrEmpty(nombreColumna))
                    {
                        newRow[nombreColumna] = textBox.Text;
                    }
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
