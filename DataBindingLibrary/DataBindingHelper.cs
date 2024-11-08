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
                if (control is TextBox textBox && table.Columns.Contains(control.Name))
                {
                    textBox.DataBindings.Clear();
                    textBox.DataBindings.Add("Text", table, control.Name);
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
