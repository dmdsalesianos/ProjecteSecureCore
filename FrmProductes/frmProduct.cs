using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace FrmProductes
{
    public partial class frmProduct : Form
    {
        private SecureCoreG4Entities1 db;
        private List<Products> products;
        private List<Factories> factories;
        private bool esNuevo = false;

        public frmProduct()
        {
            InitializeComponent();
            db = new SecureCoreG4Entities1();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {            
            RellenarDTG();
            LlenarComboBoxFactories();
        }

        private void RellenarDTG()
        {
            products = db.Products.Include("Factories").ToList();            
            dataGridView1.DataSource = products;
            ActivarBinding();
            OcultarColumnasSinBinding();
        }

        private void OcultarColumnasSinBinding()
        {
            var camposVinculados = this.Controls
            .OfType<Control>() 
            .Where(ct => ct is TextBox || ct is ComboBox) 
            .Where(ct => !string.IsNullOrEmpty(ct.Tag?.ToString())) 
            .Select(ct => ct.Tag.ToString()) 
            .ToList();


            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (!camposVinculados.Contains(col.DataPropertyName))
                {
                    col.Visible = false;
                }
            }

        }

        private void LlenarComboBoxFactories()
        {
            factories = db.Factories.ToList();
            comboBox_relacional.DataSource = factories;
            comboBox_relacional.DisplayMember = "DescFactory";
            comboBox_relacional.ValueMember = "idFactory";
        }

        private void ActivarBinding()
        {
            foreach (Control ct in this.Controls)
            {
                if (ct is TextBox txt)
                {
                    txt.DataBindings.Clear();
                    txt.DataBindings.Add("Text", products, txt.Tag.ToString());
                }
            }
            comboBox_relacional.DataBindings.Clear();
            comboBox_relacional.DataBindings.Add("SelectedValue", products, "idFactory");
        }

        private void DesactivarBinding()
        {
            foreach (Control ct in this.Controls)
            {
                if (ct is TextBox txt)
                {
                    txt.DataBindings.Clear();
                    txt.Clear();
                }
            }

            comboBox_relacional.DataBindings.Clear();
            comboBox_relacional.SelectedIndex = -1;
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            DesactivarBinding();

            textBox_name.Text = "";
            textBox_precio.Text = "";
            comboBox_relacional.SelectedIndex = -1;
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (esNuevo)
                {
                    Products nuevoProducto = new Products
                    {
                        Name = textBox_name.Text,
                        Price = decimal.Parse(textBox_precio.Text),
                        idFactory = (short)comboBox_relacional.SelectedValue
                    };

                    db.Products.Add(nuevoProducto);
                }
                else
                {
                    int selectedProductId = (int)dataGridView1.CurrentRow.Cells["idProduct"].Value;
                    Products productoParaActualizar = db.Products.FirstOrDefault(p => p.idProduct == selectedProductId);

                    if (productoParaActualizar != null)
                    {
                        productoParaActualizar.Name = textBox_name.Text;
                        productoParaActualizar.Price = decimal.Parse(textBox_precio.Text);
                        productoParaActualizar.idFactory = (short)comboBox_relacional.SelectedValue;
                    }
                }

                db.SaveChanges();
                esNuevo = false;
                RellenarDTG();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
