using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuOptions
{
    public partial class frmMenuOptions : prueba_txtBox.baseForm
    {

        public DataSet dsFK;

        public frmMenuOptions()
        {
            InitializeComponent();
            TableName = "Menuoptions";
            querySelect = $"SELECT * FROM {TableName}";

            swTextbox_Rank.Tag = "Acceslevel";

            swTextbox_Rank.Tag = "Rank";
        }

        

        protected override void BaseForm_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);

            dsFK = dataAccess.PortarTaula(swTextbox_Rank.Tag.ToString());

            dsFK = dataAccess.PortarTaula(swTextbox_Rank.Tag.ToString());

        }

        //        using System;
        //using System.Drawing;
        //using System.Windows.Forms;

        //namespace MenuOptions
        //    {
        //        public partial class frmMenuOptions : prueba_txtBox.baseForm
        //        {
        //            public frmMenuOptions()
        //            {
        //                InitializeComponent();
        //                TableName = "MenuOptions"; // Nombre de la tabla en la base de datos
        //                querySelect = "SELECT * FROM MenuOptions"; // Consulta SELECT para inicializar
        //            }

        //            protected override void BaseForm_Load(object sender, EventArgs e)
        //            {
        //                base.BaseForm_Load(sender, e); // Llama a la lógica de carga del formulario base
        //                ConfigureCustomControls();
        //            }

        //            / <summary>
        //            / Configura los controles personalizados específicos de este formulario.
        //            / </summary>
        //            private void ConfigureCustomControls()
        //            {
        //                Asignar los campos de la base de datos a los controles
        //                txtName.NomCampBBDD = "Texto"; // Asignación al campo Texto
        //                txtAccessLevel.NomCampBBDD = "AccessLevel"; // Asignación al campo AccessLevel
        //                txtClasse.NomCampBBDD = "Clase"; // Asignación al campo Clase
        //                txtForm.NomCampBBDD = "Form"; // Asignación al campo Form
        //                txtTaula.NomCampBBDD = "Taula"; // Asignación al campo Taula
        //                txtColor.NomCampBBDD = "Color"; // Asignación al campo Color

        //                Asignar el PictureBox al campo Icono
        //                picIcono.Tag = "Icono"; // Utiliza Tag para almacenar el nombre del campo asociado
        //            }

        //            / <summary>
        //            / Guarda la imagen seleccionada y devuelve la ruta relativa para almacenarla en la base de datos.
        //            / </summary>
        //            private string SaveIcon()
        //            {
        //                if (picIcono.Image != null)
        //                {
        //                    string iconPath = Path.Combine(Application.StartupPath, "icons", $"{Guid.NewGuid()}.png");
        //                    picIcono.Image.Save(iconPath, System.Drawing.Imaging.ImageFormat.Png);
        //                    return iconPath;
        //                }
        //                return string.Empty;
        //            }

        //            / <summary>
        //            / Sobrescribe la lógica para guardar los datos y actualiza el campo Icono con el PictureBox.
        //            / </summary>
        //            protected override void btnActualizar_Click(object sender, EventArgs e)
        //            {
        //                if (esNuevo)
        //                {
        //                    AddNewRow();
        //                }

        //                Sobreescribe el valor del campo Icono antes de guardar
        //                if (picIcono.Tag != null)
        //                {
        //                    DataRow currentRow = ((DataRowView)bindingSource.Current).Row;
        //                    currentRow["Icono"] = SaveIcon(); // Actualiza la ruta del ícono
        //                }

        //                base.btnActualizar_Click(sender, e); // Llama al método del formulario base para guardar
        //            }

        //            / <summary>
        //            / Método para cargar una imagen en el PictureBox desde el sistema de archivos.
        //            / </summary>
        //            private void btnCargarIcono_Click(object sender, EventArgs e)
        //            {
        //                OpenFileDialog openFileDialog = new OpenFileDialog
        //                {
        //                    Filter = "Archivos de imagen (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg"
        //                };

        //                if (openFileDialog.ShowDialog() == DialogResult.OK)
        //                {
        //                    picIcono.Image = Image.FromFile(openFileDialog.FileName);
        //                }
        //            }
        //        }


    }

}

