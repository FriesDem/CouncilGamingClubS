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
    public partial class frmExistingData : Form
    {
        private readonly CGCAppDatabaseEntities cgcDB;
        public frmExistingData()
        {
            InitializeComponent();
            cgcDB = new CGCAppDatabaseEntities();
            
        }

       
        private void frmExistingData_Load(object sender, EventArgs e)

        {           
            var displayInfo = cgcDB.CustomerInfoes.Select(dt => new
            {
                dt.ID,
                UniqueID = dt.UniqueID,
                FirstName = dt.CustomerFname,
                LastName = dt.CustomerLname,
                Address = dt.Address

            }).ToList();
            gvCustInfo.DataSource = displayInfo;
            //gvCustInfo.Columns[1].HeaderText = "First Name";
            //gvCustInfo.Columns[2].HeaderText = "Last Name";
            gvCustInfo.Columns[0].Visible = false;

            
        }

        private void ShowMessage()
        {
            MessageBox.Show("Select A Record then Click an option below");
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            CustomerInfoPage customerInfo = new CustomerInfoPage();
            customerInfo.MdiParent = MainInterface.ActiveForm;
            customerInfo.Show();
            this.Hide();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                //get ID of selected row
                var ID = (int)gvCustInfo.SelectedRows[0].Cells["ID"].Value;

                //query Database 
                var custInfo = cgcDB.CustomerInfoes.FirstOrDefault(dt => dt.ID == ID);

                var existingInfo = new frmEditCustomer(custInfo);
                existingInfo.MdiParent = MainInterface.ActiveForm;
                existingInfo.Show();
            }

            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Select a Record First");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FillTable();
        }  

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {

            try
            {
                //get ID of selected row
                var ID = (int)gvCustInfo.SelectedRows[0].Cells["ID"].Value;

                //query Database 
                var custInfo = cgcDB.CustomerInfoes.FirstOrDefault(dt => dt.ID == ID);

                //Remove
                cgcDB.CustomerInfoes.Remove(custInfo);
                cgcDB.SaveChanges();
                MessageBox.Show("Your Record Has Been Deleted Successfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            FillTable();
        }

       
        private void FillTable()
        {
            var custInfo = cgcDB.CustomerInfoes.Select(cust => new
            {
                cust.ID,
                UniqueID = cust.UniqueID,
                CustomerFname = cust.CustomerFname,
                CustomerLname = cust.CustomerLname,
                Address = cust.Address
            }).ToList();

            gvCustInfo.DataSource = custInfo;
            

        }

        private void ReturnCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
            var Customer = new CustomerInfoPage();
            Customer.MdiParent = MainInterface.ActiveForm;
            Customer.Show();
        }

        private void frmExistingData_Activated(object sender, EventArgs e)
        {
            ShowMessage();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
            var cust = new CustomerInfoPage();
            cust.MdiParent = MainInterface.ActiveForm;
            cust.Show();
        }
    }
}
