using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prueba_txtBox;

namespace Species
{
    public partial class frmSpecies : prueba_txtBox.baseForm
    {
        public frmSpecies()
        {
            InitializeComponent();
            TableName = "Species";
            querySelect = "SELECT * FROM Species";
            swTextBox1.Tag = swTextBox1.nombreColumna;
            swTextBox2.Tag = swTextBox2.nombreColumna;

            // Asigna el ComboBox en el formulario derivado al ComboBox en la clase base
            comboBox = comboBox1;  // Asignamos comboBox1 de frmSpecies a la propiedad comboBox de baseForm
        }


        protected override void BaseForm_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);
            comboBox1.DataSource = ds.Tables[TableName];
        }
    }
}
