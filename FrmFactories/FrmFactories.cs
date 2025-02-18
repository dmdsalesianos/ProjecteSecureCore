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
            foreach(Control ct in this.Controls)
            {
                if(ct is TextBox txt)
                {
                    txt.DataBindings.Clear();
                    txt.Clear();

                    if(!string.IsNullOrEmpty(txt.Tag?.ToString()))
                    {
                        txt.DataBindings.Add("Text", bindingSource, txt.Tag.ToString());
                    }
                }
            }
        }

        private void DesactivarBinding()
        {
            foreach(Control ct in this.Controls)
            {
                if(ct is TextBox txt)
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

            foreach(DataGridViewColumn col in dtgFactories.Columns)
            {
                if(!camposVinculados.Contains(col.DataPropertyName))
                {
                    col.Visible = false;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(esNou)
                {
                    esNou = false;
                    Factory fac = new Factory { codeFactory = txtCodeFactory.Text, DescFactory = txtDescFactory.Text };
                    db.Factories.Add(fac);
                }
                db.SaveChanges();
                RellenarDTG();
            } catch(Exception ex)
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
    }
}
