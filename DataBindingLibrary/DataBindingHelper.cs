using CustomControls;
using System;
using System.Data;
using System.Windows.Forms;

namespace DataBindingLibrary
{
    public static class DataBindingHelper
    {
        public static void BindControlsToData(Control.ControlCollection controls, DataTable table)
        {
            foreach (Control control in controls)
            {
                if (control is SWTextbox textBox)
                {
                    SWTextbox SWControl = (SWTextbox)control;

                    textBox.DataBindings.Clear();
                    textBox.DataBindings.Add("Text", table, SWControl.NomCampBBDD.ToString()); ;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.DataBindings.Clear();
                    comboBox.DataBindings.Add("SelectedValue", table, control.Tag.ToString());
                }
            }
        }

        public static void ClearDataBindings(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox textBox) 
                {
                    textBox.Clear(); 
                    control.DataBindings.Clear(); 
                }
            }
        }

    }
}
