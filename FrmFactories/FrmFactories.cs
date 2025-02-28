using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BBDD_Factories;

namespace FrmFactories
{
    public partial class FrmFactories : Form
    {
        private SecureCoreG4Entities db;
        private List<Factory> factories;
        private BindingSource bindingSource;
        private bool esNou = false;

        public FrmFactories() { InitializeComponent(); }

        private void FrmFactories_Load(object sender, EventArgs e)
        {
            RellenarDTG();
            OcultarColumnasSinBinding();
        }

        private void RellenarDTG()
        {
            bindingSource = new BindingSource();
            db = new SecureCoreG4Entities();

            factories = db.Factories.ToList();
            bindingSource.DataSource = factories;
            dtgFactories.DataSource = bindingSource;

            ActivarBinding();
        }

        private void ActivarBinding()
        {
            foreach (Control ct in this.Controls)
            {
                if (ct is TextBox txt)
                {
                    txt.DataBindings.Clear();
                    txt.Clear();

                    if (!string.IsNullOrEmpty(txt.Tag?.ToString()))
                    {
                        txt.DataBindings.Add("Text", bindingSource, txt.Tag.ToString());
                    }
                }
            }
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
        }

        private void OcultarColumnasSinBinding()
        {
            var camposVinculados = this.Controls
                .OfType<TextBox>()
                .Where(txt => !string.IsNullOrEmpty(txt.Tag?.ToString()))
                .Select(txt => txt.Tag.ToString())
                .ToList();

            foreach (DataGridViewColumn col in dtgFactories.Columns)
            {
                if (!camposVinculados.Contains(col.DataPropertyName))
                {
                    col.Visible = false;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (esNou)
                {
                    esNou = false;
                    Factory fac = new Factory { codeFactory = txtCodeFactory.Text, DescFactory = txtDescFactory.Text };
                    db.Factories.Add(fac);
                }
                db.SaveChanges();
                RellenarDTG(); // Recargar datos después de actualizar
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al actualizar los datos: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            esNou = true;
            DesactivarBinding();
        }

        private void Eliminar(int Id)
        {
            var objetoParaEliminar = db.Factories.FirstOrDefault(p => p.idFactory == Id);

            if (objetoParaEliminar != null)
            {
                factories.Remove(objetoParaEliminar); // Elimina del BindingSource
                db.Factories.Remove(objetoParaEliminar); // Elimina de la base de datos
                db.SaveChanges(); // Guarda los cambios en la base de datos

                RellenarDTG(); // Recargar la DataGridView
            }
            else
            {
                MessageBox.Show("No se encontró el registro para eliminar.");
            }
        }

        private void dtgFactories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dtgFactories.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dtgFactories_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dtgFactories.SelectedRows.Count == 1)
            {
                var selectedRow = dtgFactories.SelectedRows[0];

                if (selectedRow.Cells["idFactory"].Value != null)
                {
                    int selectedObjectId = Convert.ToInt32(selectedRow.Cells["idFactory"].Value);
                    Eliminar(selectedObjectId);
                }
            }
        }
    }
}
