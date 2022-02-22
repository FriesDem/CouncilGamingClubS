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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            Orders OrdersForm = new Orders();
            OrdersForm.Show();
            this.Hide();
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            Inventory InventoryForm = new Inventory();
            InventoryForm.Show();
            this.Hide();
        }

        private void CustomerInfoButton_Click(object sender, EventArgs e)
        {
            CustomerInfoPage CustomerForm = new CustomerInfoPage();
            CustomerForm.Show();
            this.Hide();
        }

        private void SuppliersButton_Click(object sender, EventArgs e)
        {
            SuppliersForm SuppliesForm = new SuppliersForm();
            SuppliesForm.Show();
            this.Hide();
        }
    }
}
