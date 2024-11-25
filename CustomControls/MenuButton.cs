using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprint53_G4
{
    public partial class MenuButton : UserControl
    {
        public MenuButton()
        {
            InitializeComponent();
        }
        //EL BOTÓ ES UNA OPCIO DEL MENU, EXEMPLE MANTENIMENT USUARIS, FAREM CLICK, I EN LES PROPIETATS HAUREM 
        //DIT QUINA ES LA CLASE I EL FORMULARI QUE OBRA EL FORMULARI DE MANTENIMENT DE USUARIS, ALESHORES,
        //FAREM QUE AQUEST NOM I CLASE ES POSSI EN LES PROPIETATS CLASS Y FORM DEL LAUNCHFORM I DIREM
        //QUE AL FER CLICK AL BOTÓ BUTTON, EXECUTAR UN CLICK EN EL PANEL(SENSE QUE L'USUARI L'HAGI FET)
        //I LLAVORS S'OBRIRA EL FORM QUE VOLIEM EN EL PANEL
        private string form;
        private string clase;
        

        [Category("Custom Properties")]
        public string Clase
        {
            get => clase;
            set
            {
                clase = value;
            }
        }
        [Category("Custom Properties")]
        public string Form
        {
            get => form;
            set
            {
                form = value;
            }
        }
    }
}
