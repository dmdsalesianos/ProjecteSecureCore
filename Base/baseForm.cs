using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using DataAccess;
using CustomControls;
using System.IO;
using System.Drawing;

namespace Base
{
    public partial class baseForm : Form
    {
        public DataSet ds;
        public bool esNuevo = false;
        public MantenimentDades dataAccess;
        public string TableName;
        public string querySelect;

        public baseForm()
        {
            InitializeComponent();
        }

        protected virtual void BaseForm_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            string connectionString = ConfigurationManager.ConnectionStrings["ConexioStr"].ConnectionString;
            dataAccess = new MantenimentDades(connectionString);

            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Validated += ValidarTextBox;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.Validated += ValidarCombobox;
                }
            }

            CargarDatos();
            MakeDataBindigs();
        }

        protected void ValidarTextBox(object sender, EventArgs e)
        {
            ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }

        protected void ValidarCombobox(object sender, EventArgs e)
        {
            ((ComboBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }

        private void MakeDataBindigs()
        {
            DataTable table = ds.Tables[TableName];

            //*****MAKE DATABINDINGS*****//
            foreach (Control control in this.Controls)
            {
                if (control is SWTextbox textBox)
                {
                    textBox.DataBindings.Clear();
                    textBox.DataBindings.Add("Text", table, textBox.NomCampBBDD);
                }
                else if (control is ComboBox comboBox)
                {
                    if (dataGridView1.Columns.Contains(comboBox.ValueMember))
                    {
                        dataGridView1.Columns.Remove(comboBox.ValueMember);
                    }

                    if (!dataGridView1.Columns.Contains(comboBox.DisplayMember.ToString()))
                    {
                        dataGridView1.Columns.Add(comboBox.DisplayMember.ToString(), comboBox.DisplayMember);
                    }

                    string tableName = comboBox.Tag.ToString();
                    string query = $"SELECT * FROM {tableName}";

                    DataSet dsComboBox = dataAccess.PortarPerConsulta(query);

                    if (dsComboBox != null && dsComboBox.Tables.Count > 0)
                    {
                        DataTable comboBoxDataSource = dsComboBox.Tables[0];

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.DataBoundItem is DataRowView dataRowView)
                            {
                                object value = dataRowView[comboBox.ValueMember];

                                var matchingRows = comboBoxDataSource.Select($"{comboBox.ValueMember} = '{value}'");

                                if (matchingRows != null && matchingRows.Length > 0)
                                {
                                    row.Cells[comboBox.DisplayMember.ToString()].Value = matchingRows[0][comboBox.DisplayMember];
                                }

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show($"No se pudieron cargar los datos para el ComboBox '{comboBox.Name}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    comboBox.DataBindings.Clear();
                    comboBox.DataBindings.Add("SelectedValue", table, comboBox.ValueMember.ToString());
                }
            }


        }

        private void CargarDatos()
        {
            ds = dataAccess.PortarTaula(TableName);
            DataTable table = ds.Tables[TableName];

            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.DataSource = ds.Tables[TableName];
        }

        //*****AÑADE UNA ROW VACIA*****//
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable table = ds.Tables[TableName];
            DataRow newRow = table.NewRow();

            ds.Tables[TableName].Rows.Add(newRow);
            dataGridView1.DataSource = table;
            int rowIndex = dataGridView1.Rows.Count - 1;

            // Buscar la primera columna visible
            int firstVisibleColumnIndex = -1;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Visible)
                {
                    firstVisibleColumnIndex = column.Index;
                    break;
                }
            }

            // Seleccionar la celda en la última fila y primera columna visible
            if (firstVisibleColumnIndex != -1)
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[rowIndex].Cells[firstVisibleColumnIndex];
                dataGridView1.Rows[rowIndex].Selected = true;
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            dataAccess.Actualitzar(querySelect, ds, TableName);
            CargarDatos();
            MakeDataBindigs();
        }

    }
}
