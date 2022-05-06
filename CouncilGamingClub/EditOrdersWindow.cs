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
    public partial class frmEditOrders : Form
    {
        
        private readonly CGCAppDatabaseEntities cgcDB;

        public frmEditOrders(OrdersTable orders)
        {
            InitializeComponent();
            cgcDB = new CGCAppDatabaseEntities();
            FillTable(orders);
        }
       
        private void FillTable(OrdersTable orders)
        {
            try
            {
                lblID.Text = orders.ID.ToString();
                txtUniqueID.Text = orders.OrderID.ToString();
                txtProductName.Text = orders.Product_Name.ToString();
                txtCustomerID.Text = orders.Cust_ID.ToString();
                txtAmount.Text = orders.Amount.ToString();
                txtTotalCost.Text = orders.TotalCost.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            
        }
       
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
           
            

            try
            {
                var ID = int.Parse(lblID.Text);
                var orderInfo = cgcDB.OrdersTables.FirstOrDefault(dt => dt.ID == ID);
                orderInfo.ID = ID;
                orderInfo.OrderID = txtUniqueID.Text;
                orderInfo.Product_Name = txtProductName.Text;
                orderInfo.Cust_ID = txtCustomerID.Text;
                orderInfo.Amount = int.Parse(txtAmount.Text);
                orderInfo.TotalCost = int.Parse(txtTotalCost.Text);


                cgcDB.SaveChanges();
                MessageBox.Show("Nice. Your Order Record Has Been Edited.");

                this.Close();
                
            }
            catch (Exception)
            {

                MessageBox.Show("An Error Occured");
            }
            
        }

        private void btnCancelChanges_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will cancel your progess. Refresh the table to make changes");
            this.Close();
        }

        
    }
}
