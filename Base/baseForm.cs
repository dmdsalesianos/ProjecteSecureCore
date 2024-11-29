using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using DataAccess;
using DataBindingLibrary;
using Sprint53_G4;

namespace prueba_txtBox
{
    public partial class baseForm : Form
    {
        public DataSet ds;
        public DataSet dsFK;
        public bool esNuevo = false;
        public MantenimentDades dataAccess;
        public string TableName;
        public string FKTableName;
        public string querySelect;
        private BindingSource bindingSource = new BindingSource();


        public baseForm()
        {
            InitializeComponent();
        }

        protected virtual void BaseForm_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            string connectionString = ConfigurationManager.ConnectionStrings["ConexioStr"].ConnectionString;
            dataAccess = new MantenimentDades(connectionString);

            ds = dataAccess.PortarTaula(TableName);
            dsFK = dataAccess.PortarTaula(FKTableName);
                        

            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Validated += ValidarTextBox;
                }
            }

            CargarDatos();
        }

        protected void CargarDatos()
        {
            DataBindingHelper.ClearDataBindings(this.Controls);
            UpdateTable();

            bindingSource.DataSource = ds.Tables[TableName];
            dataGridView1.DataSource = bindingSource;
            BindToData();         
        }

        private void comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is ComboBox comboBox)
                {
                    if (comboBox.SelectedValue != null)
                    {
                        string selectedValue = comboBox.SelectedValue.ToString();

                        bindingSource.Filter = $"{comboBox.ValueMember} = {selectedValue}";

                        if (dataGridView1.Rows.Count > 0)
                        {
                            dataGridView1.Rows[0].Selected = true;
                        }
                    }
                }
            }
            
        }

        private void BindToData()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    SWTextbox txtSW = (SWTextbox)control;

                    var nomCampBBDD = txtSW.NomCampBBDD;

                    if (!string.IsNullOrEmpty(nomCampBBDD))
                    {
                        txtSW.DataBindings.Clear();
                        txtSW.DataBindings.Add("Text", bindingSource, nomCampBBDD);
                    }
                }
            }

            foreach (Control control in Controls)
            {

                if (control is ComboBox comboBox)
                {
                    comboBox.SelectedValueChanged += comboBox_SelectedValueChanged;

                    if (comboBox != null)
                    {
                        comboBox.DataSource = dsFK.Tables[FKTableName];                        

                        comboBox.DataBindings.Clear();
                        comboBox.DataBindings.Add("SelectedValue", ds.Tables[TableName], comboBox.ValueMember);
                        
                    }
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

            dataAccess.Actualitzar(querySelect, ds, TableName);
            ds = dataAccess.PortarTaula(TableName);
            CargarDatos();
        }

        protected void AddNewRow()
        {
            DataRow newRow = ds.Tables[TableName].NewRow();

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    SWTextbox txtSW = (SWTextbox)control;

                    var nomCampBBDD = txtSW.NomCampBBDD;

                    //var nomCampBBDD = textBox.GetType().GetProperty("NomCampBBDD").GetValue(textBox, null) as string;

                    if (!string.IsNullOrEmpty(nomCampBBDD))
                    {
                        newRow[nomCampBBDD] = txtSW.Text;
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
