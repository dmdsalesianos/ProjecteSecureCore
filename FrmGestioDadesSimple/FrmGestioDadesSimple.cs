using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BBDD_Dades;

namespace FrmGestioDadesSimple
{
    public partial class FrmGestioDadesSimple : Form
    {
        private BBDD_Dades.SecureCoreG4Entities db;
        List<BBDD_Dades.NewContact> newContacts;
        private bool esNou = false;

        public FrmGestioDadesSimple() { InitializeComponent(); }

        private void FrmGestioDadesSimple_Load(object sender, EventArgs e) { RellenarDTG(); }

        private void RellenarDTG()
        {
            db = new BBDD_Dades.SecureCoreG4Entities();
            newContacts = db.NewContacts.ToList();
            dtgNewContacts.DataSource = newContacts;
            ActivarBinding();

            if(dtgNewContacts.Columns.Contains("idContact"))
            {
                dtgNewContacts.Columns["idContact"].Visible = false;
            }
            if(dtgNewContacts.Columns.Contains("ContactSystems"))
            {
                dtgNewContacts.Columns["ContactSystems"].Visible = false;
            }
        }

        private void ActivarBinding()
        {
            foreach(Control ct in this.Controls)
            {
                if(ct is TextBox)
                {
                    TextBox txt = (TextBox)ct;
                    txt.DataBindings.Clear();
                    txt.Clear();
                    txt.DataBindings.Add("Text", newContacts, txt.Tag.ToString());
                }
            }
        }

        private void DesactivarBinding()
        {
            foreach(Control ct in this.Controls)
            {
                if(ct is TextBox)
                {
                    TextBox txt = (TextBox)ct;
                    txt.Clear();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(esNou)
            {
                NewContact con = new NewContact();
                {
                    con.Name = txtName.Text;
                    con.BirthDate = txtBirth.Text;
                }
                db.NewContacts.Add(con);
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
