using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Configuration;
using DataLibraryDMD;


namespace Sprint53_G4
{
    public partial class SWCodi : UserControl
    {
        public SWCodi()
        {
            InitializeComponent();

            codiTxt.Leave += Validacodi;
        }

        private string nomTaula;
        private string nomCodi;
        private string nomDesc;
        private string nomId;
        private string formCS;
        private string classeCS;
        private string controlID;

        public string ControlID { get { return controlID; } set { controlID = value; } }


        public string ClaseCS { get { return classeCS; } set { classeCS = value; } }


        public string FormCS { get { return formCS; } set { formCS = value; } }


        public string NomId { get { return nomId; } set { nomId = value; } }


        public string NomDesc { get { return nomDesc; } set { nomDesc = value; } }


        public string NomCodi { get { return nomCodi; } set { nomCodi = value; } }

        public string NomTaula { get { return nomTaula; } set { nomTaula = value; } }

        private void Validacodi(object sender, EventArgs e)
        {
            string codi = codiTxt.Text;

            MantenimentDades manteniment = new MantenimentDades(
                ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            string consulta = $"SELECT {NomId}, {NomDesc} FROM {NomTaula} WHERE {NomCodi} = '{codi}'";

            DataSet ds = manteniment.PortarPerConsulta(consulta);

            if(ds.Tables[0].Rows.Count > 0)
            {
                string id = ds.Tables[0].Rows[0][NomId].ToString();
                string desc = ds.Tables[0].Rows[0][NomDesc].ToString();

                descTxt.Text = desc;
                TextBox controlExterno = this.Parent.Controls[ControlID] as TextBox;
                if(controlExterno != null)
                {
                    controlExterno.Text = id;
                }
            } else
            {
                descTxt.Text = "Unknown data";
            }
        }

        private void ObreCS()
        {
            string claseForm = ClaseCS + "." + FormCS;

            try
            {
                Assembly ensamblat = Assembly.LoadFrom($"{ClaseCS}.dll");
                Type tipus = ensamblat.GetType(claseForm);

                if(tipus != null)
                {
                    Form frm = (Form)Activator.CreateInstance(tipus);
                    frm.ShowDialog();
                } else
                {
                    MessageBox.Show("La clase especificada no se encontró.");
                }
            } catch(Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario: {ex.Message}");
            }
        }

        private void codiTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                ObreCS();
            }
        }
    }
}
