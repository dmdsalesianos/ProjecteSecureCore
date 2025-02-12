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

            //AL HACER NEW Y UPDATE HACE DOS VECES LA NUEVA FILA, EL BOTON DE NEW Y UPDATE FUNCIONAN PERO HACEN COSAS RARAS
            //HAY QUE CAMBIAR ESTO Y QUE LO HAGA PARA LOS CAMPOS QUE NO TENGAN TAG O OTRA MANERA QUE NO SEA ESCRIBIR EL NOMBRE DEL CAMPO
            if (dtgFactories.Columns.Contains("idFactory"))
            {
                dtgFactories.Columns["idFactory"].Visible = false;
            }
        }

        private void ActivarBinding()
        {
            foreach (Control ct in this.Controls)
            {
                if (ct is TextBox )
                {
                    TextBox txt = (TextBox)ct;
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
                if (ct is TextBox)
                {
                    TextBox txt = (TextBox)ct;
                    txt.Clear();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (esNou)
            {
                Factory fac = new Factory();
                {
                    fac.codeFactory = txtCodeFactory.Text;
                    fac.DescFactory = txtDescFactory.Text;
                }
                db.Factories.Add(fac);
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
