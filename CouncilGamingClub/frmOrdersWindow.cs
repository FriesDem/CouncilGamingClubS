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
    public partial class OrdersWindow : Form
    {
        private readonly CGCAppDatabaseEntities cgcDB;
        private readonly OrdersTable ordersTable;
        public OrdersWindow()
        {
            InitializeComponent();
            cgcDB = new CGCAppDatabaseEntities();
            ordersTable = new OrdersTable(); 
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int orderID = Convert.ToInt32(tbOrderID.Text);
                string orderType = tbOrderType.Text;
                int orderAmount = Convert.ToInt32(tbItemAmount.Text);

                ordersTable.ID = orderID;
                ordersTable.Product_Name = orderType;
                ordersTable.Amount = orderAmount; 
                cgcDB.OrdersTables.Add(ordersTable);
                cgcDB.SaveChanges();

                MessageBox.Show("Your Order Information is Saved Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred");
                
            }
        }
    }
}
