﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{

    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            timer1.Interval = 3100; 
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop(); 
            frmLogin loginForm = new frmLogin(); 
            loginForm.Show(); 
            this.Hide();
            
        }
    }

}
