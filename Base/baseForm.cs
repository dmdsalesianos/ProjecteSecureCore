using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using DataAccess;
using DataBindingLibrary;

namespace prueba_txtBox
{
    public partial class baseForm : Form
    {
        public DataSet ds;
        public bool esNuevo = false;
        public MantenimentDades dataAccess;
        public string TableName;
        public string FKTableName;
        public string querySelect;
        public ComboBox comboBox;

        public baseForm()
        {
            InitializeComponent();
        }

        protected virtual void BaseForm_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            string connectionString = ConfigurationManager.ConnectionStrings["ConexioStr"].ConnectionString;
            dataAccess = new MantenimentDades(connectionString);

            ds = new DataSet();

            DataSet tableDS = dataAccess.PortarTaula(TableName);
            DataTable Table = tableDS.Tables[TableName].Copy(); 
            Table.TableName = TableName; 
            ds.Tables.Add(Table);

            DataSet fkTableDS = dataAccess.PortarTaula(FKTableName);
            DataTable FKTable = fkTableDS.Tables[FKTableName].Copy(); 
            FKTable.TableName = FKTableName; 
            ds.Tables.Add(FKTable);

            ds.Relations.Add(
                "Table_FKTable",
                ds.Tables[FKTableName].Columns[comboBox.ValueMember],
                ds.Tables[TableName].Columns[comboBox.ValueMember]
            );

            comboBox.SelectedValueChanged += comboBox_SelectedValueChanged;

            CargarDatos();
        }



        protected void CargarDatos()
        {
            DataBindingHelper.ClearDataBindings(this.Controls);
            UpdateTable();

            BindTextBoxesToData();
            BindComboBoxToData();
        }
        private void comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedValue != null)
            {
                string selectedValue = comboBox.SelectedValue.ToString();

                DataView dv = new DataView(ds.Tables[TableName]);
                dv.RowFilter = $"{comboBox.ValueMember} = {selectedValue}";

                dataGridView1.DataSource = dv;
            }
        }


        private void BindTextBoxesToData()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    var nomCampBBDD = textBox.GetType().GetProperty("NomCampBBDD").GetValue(textBox, null) as string;

                    if (!string.IsNullOrEmpty(nomCampBBDD))
                    {
                        textBox.DataBindings.Clear();
                        textBox.DataBindings.Add("Text", ds.Tables[TableName], nomCampBBDD);
                    }
                }
            }
        }

        private void BindComboBoxToData()
        {
            if (comboBox != null)
            {
                comboBox.DataSource = ds.Tables[FKTableName];
                comboBox.DisplayMember = comboBox.DisplayMember;
                comboBox.ValueMember = comboBox.ValueMember;

                comboBox.DataBindings.Clear();
                comboBox.DataBindings.Add("SelectedValue", ds.Tables[TableName], comboBox.ValueMember);
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

            dataAccess.Actualitzar(querySelect, ds, TableName);
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
                    var nomCampBBDD = textBox.GetType().GetProperty("NomCampBBDD").GetValue(textBox, null) as string;

                    if (!string.IsNullOrEmpty(nomCampBBDD))
                    {
                        newRow[nomCampBBDD] = textBox.Text;
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
            try
            {
                 if (!esNuevo)
            {
                ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
            }
            catch (Exception)
            {
               throw;
            }
           
        }
    }
}
