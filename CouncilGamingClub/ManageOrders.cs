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
            FillTable();
        }

        private void FillTable()
        {
            var order = cgcDB.OrdersTables.Select(o => new
            {
                o.ID,
                o.Product_Name,
                o.Cust_ID,
                o.Amount,
                o.TotalCost
            }).ToList();
            gvOrders.DataSource = order;
        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ordersPage = new OrdersWindow();
            ordersPage.MdiParent = MainInterface.ActiveForm;
            ordersPage.Show();
        }
    }
}
