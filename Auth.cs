﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTiPPO
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            Form Registry = new List();
            Registry.Show();
            this.Hide();
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
