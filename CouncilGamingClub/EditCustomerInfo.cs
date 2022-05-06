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
    public partial class frmEditCustomer : Form
    {
        private readonly CGCAppDatabaseEntities cgcDB;
        public frmEditCustomer(CustomerInfo CInfo)
        {       
            InitializeComponent();
            cgcDB = new CGCAppDatabaseEntities();
            FillTable(CInfo);
        }
        private void FillTable(CustomerInfo custInfo)
        {
            lblID.Text = custInfo.ID.ToString();
            txtUniqueID.Text = custInfo.UniqueID;
            txtFName.Text = custInfo.CustomerFname;
            txtLName.Text = custInfo.CustomerLname;
            txtAddress.Text = custInfo.Address;

           
        }
        

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                var ID = int.Parse(lblID.Text);
                var custInfo = cgcDB.CustomerInfoes.FirstOrDefault(dt => dt.ID == ID);
                custInfo.UniqueID = txtUniqueID.Text;
                custInfo.CustomerFname = txtFName.Text;
                custInfo.CustomerLname = txtLName.Text;
                custInfo.Address = txtAddress.Text;

                cgcDB.SaveChanges();
                MessageBox.Show("Nice. Your New Customer Record Has Been Added.");

                this.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("An Error Occured");
            }
        }

       
    }
}
