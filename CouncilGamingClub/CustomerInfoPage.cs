using System;
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
        private readonly CGCAppDatabaseEntities cgcDB;

       
        public CustomerInfoPage()
        {
            InitializeComponent();
            cgcDB = new CGCAppDatabaseEntities();
        }

        private void CHomeButton_Click(object sender, EventArgs e)
        {
            MainPage MainForm = new MainPage();
            MainForm.Show();
            this.Hide();
        }

        private void CAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string custName = txtCustAdd.Text;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
