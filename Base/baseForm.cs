using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using DataAccess;
using CustomControls;
using System.IO;
using System.Drawing;
using System.Collections.Generic;

namespace Base
{
    public partial class baseForm : Form
    {
        public DataSet ds;
        public bool esNuevo = false;
        public MantenimentDades dataAccess;
        public string TableName;
        public List<string> TablesFK;
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
                    comboBox.DataBindings.Clear();
                    comboBox.DataBindings.Add("SelectedValue", table, comboBox.Tag.ToString());

                    //MakeRelations(comboBox);
                }
            }
        }

        private void CargarDatos()
        {
            ds = dataAccess.PortarTaula(TableName);
            DataTable table = ds.Tables[TableName];

            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Visible = false;

            // Cargar las tablas relacionadas
            foreach (string Table in TablesFK)
            {
                ds = dataAccess.PortarTaula(Table);
            }

            // Crear relaciones
            ds.Relations.Add("Planets_Sectors", ds.Tables["Sectors"].Columns["idSector"], ds.Tables["Planets"].Columns["idSector"]);
            ds.Relations.Add("Planets_Species", ds.Tables["Species"].Columns["idSpecie"], ds.Tables["Planets"].Columns["idNatives"]);
            ds.Relations.Add("Planets_Filiations", ds.Tables["Filiations"].Columns["idFiliation"], ds.Tables["Planets"].Columns["idFiliation"]);

            // Ocultar las columnas de los IDs en el DataGridView
            dataGridView1.Columns["idSector"].Visible = false;
            dataGridView1.Columns["idNatives"].Visible = false;
            dataGridView1.Columns["idFiliation"].Visible = false;

            // Crear y agregar ComboBoxColumn para Sector
            DataGridViewComboBoxColumn sectorColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Sector",
                Name = "DescSector",
                DataSource = ds.Tables["Sectors"],
                DisplayMember = "DescSector",  // El campo a mostrar
                ValueMember = "idSector",      // El valor que se almacena en el modelo
                DataPropertyName = "idSector", // El campo del modelo que se vincula
                DisplayStyleForCurrentCellOnly = true
            };
            dataGridView1.Columns.Add(sectorColumn);

            // Crear y agregar ComboBoxColumn para Specie
            DataGridViewComboBoxColumn speciesColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Natives",
                Name = "DescSpecie",
                DataSource = ds.Tables["Species"],
                DisplayMember = "DescSpecie", // El campo a mostrar
                ValueMember = "idSpecie",    // El valor que se almacena en el modelo
                DataPropertyName = "idNatives", // El campo del modelo que se vincula
                DisplayStyleForCurrentCellOnly = true
            };
            dataGridView1.Columns.Add(speciesColumn);

            // Crear y agregar ComboBoxColumn para Filiation
            DataGridViewComboBoxColumn filiationColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Filiation",
                Name = "DescFiliation",
                DataSource = ds.Tables["Filiations"],
                DisplayMember = "DescFiliations", // El campo a mostrar
                ValueMember = "idFiliation",     // El valor que se almacena en el modelo
                DataPropertyName = "idFiliation", // El campo del modelo que se vincula
                DisplayStyleForCurrentCellOnly = true
            };
            dataGridView1.Columns.Add(filiationColumn);

            // Rellenar las celdas de las nuevas columnas con la descripción
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.DataBoundItem is DataRowView rowView)
                {
                    DataRow dataRow = rowView.Row;

                    // Asignar los valores de los IDs a las celdas de las columnas de descripción
                    row.Cells["DescSector"].Value = dataRow["idSector"];
                    row.Cells["DescSpecie"].Value = dataRow["idNatives"];
                    row.Cells["DescFiliation"].Value = dataRow["idFiliation"];
                }
            }
        }


        private void MakeRelations(ComboBox comboBox)
        {
            string Table = comboBox.ValueMember;
            DataTable table = ds.Tables[TableName];

            if (comboBox.ValueMember.StartsWith("id"))
            {
                Table = Table.Substring(2); // Elimina los dos primeros caracteres
            }
            if (!comboBox.ValueMember.EndsWith("s"))
            {
                Table = $"{Table}s";
            }

            ds.Relations.Add($"{TableName}_{Table}", ds.Tables[Table].Columns[comboBox.ValueMember], ds.Tables[TableName].Columns[comboBox.Tag.ToString()]);

            table.Columns.Add("DescSector", typeof(string), "Parent(Planets_Sectors).DescSector");
            table.Columns.Add("DescSpecie", typeof(string), "Parent(Planets_Species).DescSpecie");
            table.Columns.Add("DescFiliation", typeof(string), "Parent(Planets_Filiations).DescFiliations");

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
