using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmProductes
{
    public partial class frmProduct : Form
    {
        private SecureCoreG4Entities1 db;
        private List<Products> products;
        private List<Factories> factories; // Lista de fábricas para el ComboBox
        private bool esNuevo = false;

        public frmProduct()
        {
            InitializeComponent();
            db = new SecureCoreG4Entities1();

        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            RellenarDTG();  // Rellenamos el DataGridView con los productos
            LlenarComboBoxFactories();
        }

        private void RellenarDTG()
        {
            products = db.Products
             .Where(p => p.idFactory != null)
             .ToList();



            dataGridView1.DataSource = products;

            // Ocultamos la columna idProduct, si está visible
            if (dataGridView1.Columns.Contains("idProduct"))
            {
                dataGridView1.Columns["idProduct"].Visible = false;
            }

            ActivarBinding();  // Activamos el binding de los controles
        }

        private void LlenarComboBoxFactories()
        {
            factories = db.Factories.ToList();  // Obtener todas las fábricas
            comboBox_relacional.DataSource = factories;
            comboBox_relacional.DisplayMember = "DescFactory";  // Mostrar la descripción de la fábrica
            comboBox_relacional.ValueMember = "idFactory";  // El valor asociado será el id de la fábrica
        }

        // Activar el binding en los controles del formulario
        private void ActivarBinding()
        {
            // Recorrer los controles de tipo TextBox y asignarles el binding
            foreach (Control ct in this.Controls)
            {
                if (ct is TextBox)
                {
                    TextBox txt = (TextBox)ct;
                    txt.DataBindings.Clear();
                    txt.Clear();
                    txt.DataBindings.Add("Text", products, txt.Tag.ToString());
                }
            }

            // Asignamos el ComboBox con el valor de la fábrica seleccionada
            comboBox_relacional.DataBindings.Clear();
            comboBox_relacional.DataBindings.Add("SelectedValue", products, "idFactory");
        }

        // Desactivar el binding (limpiar los controles)
        private void DesactivarBinding()
        {
            foreach (Control ct in this.Controls)
            {
                if (ct is TextBox)
                {
                    TextBox txt = (TextBox)ct;
                    txt.Clear();
                }
            }
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            DesactivarBinding();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                // Crear un nuevo producto
                Products nuevoProducto = new Products
                {
                    Name = textBox_name.Text,
                    Price = decimal.Parse(textBox_precio.Text),
                    idFactory = (short)comboBox_relacional.SelectedValue  // Asignar la fábrica seleccionada
                };
                db.Products.Add(nuevoProducto);  // Agregar el nuevo producto a la base de datos
            }
            else
            {
                // Actualizar un producto existente
                int selectedProductId = (int)dataGridView1.CurrentRow.Cells["idProduct"].Value;
                Products productoParaActualizar = db.Products.FirstOrDefault(p => p.idProduct == selectedProductId);
                if (productoParaActualizar != null)
                {
                    productoParaActualizar.Name = textBox_name.Text;
                    productoParaActualizar.Price = decimal.Parse(textBox_precio.Text);
                    productoParaActualizar.idFactory = (short)comboBox_relacional.SelectedValue;
                }
            }

            db.SaveChanges();  // Guardar los cambios en la base de datos
            RellenarDTG();  // Actualizar el DataGridView
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int selectedProductId = (int)dataGridView1.CurrentRow.Cells["idProduct"].Value;
            Products productoParaEliminar = db.Products.FirstOrDefault(p => p.idProduct == selectedProductId);
            if (productoParaEliminar != null)
            {
                db.Products.Remove(productoParaEliminar);  // Eliminar el producto de la base de datos
                db.SaveChanges();
                RellenarDTG();  // Actualizar el DataGridView
            }
        }
    }
}
