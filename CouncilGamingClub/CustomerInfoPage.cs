﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CouncilGamingClub
{
    public partial class CustomerInfoPage : Form
    {
        public CustomerInfoPage()
        {
            InitializeComponent();
        }

        private void CHomeButton_Click(object sender, EventArgs e)
        {
            MainPage MainForm = new MainPage();
            MainForm.Show();
            this.Hide();
        }
    }
}
