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
        private readonly CustomerInfo customerInfo;
        

        public CustomerInfoPage()
        {
            InitializeComponent();
            cgcDB = new CGCAppDatabaseEntities();
            customerInfo = new CustomerInfo();
           
        }
       
        private void CHomeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage MainForm = new MainPage();
            MainForm.MdiParent = MainInterface.ActiveForm;
            MainForm.Show();
            
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
            try
            {
                string uniqueID = txtUniqueID.Text;
                string custFName = txtcustFName.Text;
                string custLName = txtcustLName.Text;
                string custAddress = txtAddress.Text;
                int quan = Convert.ToInt32(txtQuantity.Text);
                bool isVal = true;
                string errMessage = "";

                if (string.IsNullOrWhiteSpace(uniqueID))
                {
                    errMessage += "The Customer must have a unique ID";
                    isVal = false;
                   
                }
                if (string.IsNullOrWhiteSpace(custLName) || string.IsNullOrWhiteSpace(custFName))
                {
                    errMessage += "Please Enter your full name";
                    isVal = false;
                   
                }
                if (string.IsNullOrWhiteSpace(custAddress))
                {
                    errMessage += "Please enter your address";
                    isVal = false;
                    
                   
                }
                if (int.Equals(quan, 0) || txtQuantity.Text == null)
                {
                    errMessage += "Enter the correct quantity amount";
                   
                    isVal=false;
                }

                if (isVal == true)
                {
                    MessageBox.Show("The Customer's Data has been logged successfully");
                }
                else
                {
                    MessageBox.Show(errMessage);
                }

                customerInfo.CustomerFname = custFName;
                customerInfo.CustomerLname = custLName;
                customerInfo.Address = custAddress;
                customerInfo.UniqueID = uniqueID;
                cgcDB.CustomerInfoes.Add(customerInfo);
                cgcDB.SaveChanges();



            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }
                    
        private void viewCurrentDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var viewData = new frmExistingData();
            viewData.MdiParent = MainInterface.ActiveForm;
            viewData.Show();
            this.Hide();
        }
    }
}
