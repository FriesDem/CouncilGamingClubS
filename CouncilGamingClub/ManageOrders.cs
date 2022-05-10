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
    public partial class ManageOrders : Form
    {
        private readonly CGCAppDatabaseEntities cgcDB;
        private readonly OrdersTable order;
        public ManageOrders()
        {
            InitializeComponent();
            cgcDB = new CGCAppDatabaseEntities();
            order = new OrdersTable();
            
        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            var order = cgcDB.OrdersTables.Select(o => new
            {
                o.ID,
                o.OrderID,
                o.Product_Name,
                o.Cust_ID,
                o.Amount,
                o.TotalCost
            }).ToList();
            gvOrders.DataSource = order;
            gvOrders.Columns[0].Visible = false;
        }

        private void FillTable()
        {
            var order = cgcDB.OrdersTables.Select(o => new
            {
                o.ID,
                o.OrderID,
                o.Product_Name,
                o.Cust_ID,
                o.Amount,
                o.TotalCost
            }).ToList();
            gvOrders.DataSource = order;
            gvOrders.Columns[0].Visible = false;
        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ordersPage = new OrdersWindow();
            ordersPage.MdiParent = MainInterface.ActiveForm;
            ordersPage.Show();
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            try
            {
                //get ID of selected row
                var ID = (int)gvOrders.SelectedRows[0].Cells["ID"].Value;

                //query Database 
                var orderInfo = cgcDB.OrdersTables.FirstOrDefault(dt => dt.ID == ID);


                var existingInfo = new frmEditOrders(orderInfo);
                existingInfo.MdiParent = MainInterface.ActiveForm;
                existingInfo.Show();


            }

            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select a Record First");

            }

            catch (Exception)
            {
                MessageBox.Show("An Error Occurred. Please Try Again");
            }

            FillTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //get ID of selected row
                var ID = (int)gvOrders.SelectedRows[0].Cells["ID"].Value;

                //query Database 
                var orderInfo = cgcDB.OrdersTables.FirstOrDefault(dt => dt.ID == ID);

                //Remove
                cgcDB.OrdersTables.Remove(orderInfo);
                cgcDB.SaveChanges();
                MessageBox.Show("Your Record Has Been Deleted Successfull");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FillTable();
        }

        private void ManageOrders_Activated(object sender, EventArgs e)
        {
            MessageBox.Show("Select a record, then select an optin below");
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
            var ord = new OrdersWindow();
            ord.MdiParent = MainInterface.ActiveForm;
            ord.Show();
        }
    }
}
