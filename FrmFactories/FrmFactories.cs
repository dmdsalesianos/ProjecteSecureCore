using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BBDD_Factories;

namespace FrmFactories
{
    public partial class FrmFactories : Form
    {
        private BBDD_Factories.SecureCoreG4Entities db;
        private List<BBDD_Factories.Factory> factories;
        private bool esNou = false;

        public FrmFactories()
        {
            InitializeComponent();
        }

        private void FrmFactories_Load(object sender, EventArgs e)
        {
            RellenarDTG();
        }

        private void RellenarDTG()
        {
            db = new BBDD_Factories.SecureCoreG4Entities();
            factories = db.Factories.ToList();
            dtgFactories.DataSource = factories;
            ActivarBinding();

            if (dtgFactories.Columns.Contains("idFactory"))
            {
                dtgFactories.Columns["idFactory"].Visible = false;
            }
        }

        private void ActivarBinding()
        {
            foreach (Control ct in this.Controls)
            {
                if (ct is TextBox txt)
                {
                    txt.DataBindings.Clear();
                    txt.Clear();
                    txt.DataBindings.Add("Text", factories, txt.Tag.ToString());
                }
            }
        }

        private void DesactivarBinding()
        {
            foreach (Control ct in this.Controls)
            {
                if (ct is TextBox txt)
                {
                    txt.Clear();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (esNou)
            {
                Factory factory = new Factory
                {
                    codeFactory = txtCodeFactory.Text,
                    DescFactory = txtDescFactory.Text
                };
                db.Factories.Add(factory);
            }
            db.SaveChanges();
            RellenarDTG();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            esNou = true;
            DesactivarBinding();
        }
    }
}
