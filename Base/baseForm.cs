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
        protected MantenimentDades dataAccess;
        protected DataSet ds;
        protected string TableName;
        protected List<string> TablesFK;
        protected string querySelect;
        private bool tablasCargadas = false;

        public int TabIndexAgregarBtn
        {
            get { return rjbtnAgregar.TabIndex; }
            set { rjbtnAgregar.TabIndex = value; }
        }

        public int TabIndexActualitzarBtn
        {
            get { return rjbtnActualitzar.TabIndex; }
            set { rjbtnActualitzar.TabIndex = value; }
        }


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
                else if (control is Label label)
                {
                    label.BackColor = Color.Transparent;
                    label.ForeColor = Color.Black;
                }
            }

            ds = new DataSet();

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

                    MakeRelations(comboBox);
                }
            }
        }

        protected void CargarDatos()
        {
            // Cargar la tabla principal
            ds = dataAccess.PortarTaula(TableName);
            DataTable table = ds.Tables[TableName];

            dataGridView1.DataSource = table;

            // Cargar las tablas foráneas solo una vez
            if (TablesFK != null && !tablasCargadas)
            {
                foreach (string tableFK in TablesFK)
                {
                    dataAccess.PortarTaula(tableFK);
                }
                tablasCargadas = true;
            }

            dataGridView1.Columns[0].Visible = false; //Hago invisible la columna idPK
        }


        private void MakeRelations(ComboBox comboBox)
        {
            string tablestr = comboBox.ValueMember;
            DataTable table = ds.Tables[TableName];

            //Como 'comboBox.ValueMember' es siempre 'id<nombreTabla>' y yo lo que quiero es el <nombreTabla>, le elimino el 'id' del principio
            if (comboBox.ValueMember.StartsWith("id"))
            {
                tablestr = tablestr.Substring(2); // Elimina los dos primeros caracteres
            }

            if (comboBox.ValueMember.EndsWith("y"))
            {
                tablestr = tablestr.Substring(0, tablestr.Length - 1) + "ie";
            }

            if (!comboBox.ValueMember.EndsWith("s"))
            {
                tablestr = $"{tablestr}s";
            }
            
            string relationName = $"{TableName}_{tablestr}"; //Defino el nombre de la relacion

            //Hago la relacion y añado las nuevas columnas de Descripcion a la tabla
            if (!ds.Relations.Contains(relationName))
            {
                ds.Relations.Add(relationName, ds.Tables[tablestr].Columns[comboBox.ValueMember], ds.Tables[TableName].Columns[comboBox.Tag.ToString()]);
                table.Columns.Add(comboBox.DisplayMember.ToString(), typeof(string), $"Parent({relationName}).{comboBox.DisplayMember}");
                dataGridView1.Columns[comboBox.DisplayMember].HeaderText = tablestr;
            }

            dataGridView1.Columns[comboBox.Tag.ToString()].Visible = false; //Hago invisible la columna de las idsFK
        }


        //*****AÑADE UNA ROW VACIA*****//
        private void rjbtnAgregar_Click(object sender, EventArgs e)
        {
            DataTable table = ds.Tables[TableName];
            DataRow newRow = table.NewRow();

            if (TableName == "Users")
            {
                newRow["Password"] = "12345aA";
            }

            ds.Tables[TableName].Rows.Add(newRow);

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


        protected void rjbtnActualitzar_Click(object sender, EventArgs e)
        {
            int result = dataAccess.Actualitzar(querySelect, ref ds, TableName);
            if (result >= 0)
            {
                CargarDatos(); // Recarga los datos después de la actualización
                MakeDataBindigs(); // Vuelve a establecer los bindings
            }
        }
    }
}
