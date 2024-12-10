using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Users
{
    public partial class Form1 : Form
    {
        private int idUserDG;
        

        public int IdUserDG
        {
            get { return idUserDG; }
            set { idUserDG = value; }
        }


        public Form1(int idPersona)
        {
            InitializeComponent();
            this.idUserDG = idPersona;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Carga y configura el informe
            MostrarInforme(idUserDG);
        }

        private void MostrarInforme(int idPersona)
        {
            string rutaInforme = @"..\App";
            ReportDocument informe = new ReportDocument();
            informe.Load(rutaInforme);

            // Configura el parámetro
            ParameterFieldDefinitions parametros = informe.DataDefinition.ParameterFields;
            ParameterFieldDefinition parametroPersonaId = parametros["idUser"];
            ParameterDiscreteValue valorParametro = new ParameterDiscreteValue
            {
                Value = idPersona
            };

            parametroPersonaId.CurrentValues.Clear();
            parametroPersonaId.CurrentValues.Add(valorParametro);
            parametroPersonaId.ApplyCurrentValues(parametroPersonaId.CurrentValues);

            crystalReportViewer1.ReportSource = informe;
            crystalReportViewer1.Refresh();
        }

    }
}
