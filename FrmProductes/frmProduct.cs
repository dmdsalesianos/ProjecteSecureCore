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
using System.Data.Entity;


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
            dtb_products.AllowUserToDeleteRows = true;
        }

        private void RellenarDTG()
        {
            products = db.Products.Include("Factories").ToList();

            dtb_products.DataSource = products;

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


            foreach (DataGridViewColumn col in dtb_products.Columns)
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
            foreach (Control cotl in this.Controls)
            {
                if (cotl is TextBox text)
                {
                    text.DataBindings.Clear();
                    text.DataBindings.Add("Text", products, text.Tag.ToString());
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

            swTb_Name.Text = "";
            swTb_Price.Text = "";
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
                        Name = swTb_Name.Text,
                        Price = decimal.Parse(swTb_Price.Text),
                        idFactory = (short)comboBox_relacional.SelectedValue
                    };

                    db.Products.Add(nuevoProducto);
                }
                else
                {
                    int selectedProductId = (int)dtb_products.CurrentRow.Cells["idProduct"].Value;
                    Products productoParaActualizar = db.Products.FirstOrDefault(p => p.idProduct == selectedProductId);

                    if (productoParaActualizar != null)
                    {
                        productoParaActualizar.Name = swTb_Name.Text;
                        productoParaActualizar.Price = decimal.Parse(swTb_Price.Text);
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

        private void EliminarProducto(int productId)
        {
                var productoParaEliminar = db.Products.FirstOrDefault(p => p.idProduct == productId);

                if (productoParaEliminar != null)
                {
                    products.Remove(productoParaEliminar);
                    db.Products.Remove(productoParaEliminar);

                    db.SaveChanges();
                    RellenarDTG();
                }
                else
                {
                    MessageBox.Show("No Producto");
                }
        }
        private void DtProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                dtb_products.Rows[e.RowIndex].Selected = true;
            }
        }
       
        private void DtProducts_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Delete && dtb_products.SelectedRows.Count == 1)
            {
                
                int selectedProductId = (int)dtb_products.SelectedRows[0].Cells["idProduct"].Value;
                                
                EliminarProducto(selectedProductId);
            }
        }
    }
}
