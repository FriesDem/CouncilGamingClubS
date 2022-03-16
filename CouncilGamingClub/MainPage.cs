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
        private LoginPage _login;
        
        public MainPage()
        {
            InitializeComponent();
        }
        public MainPage(LoginPage login)
        {
            InitializeComponent();
            _login = login;
        }
        private void OrdersButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Orders OrdersForm = new Orders();
            OrdersForm.Show();
            
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Inventory InventoryForm = new Inventory();
            InventoryForm.Show();
            
        }

        private void CustomerInfoButton_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerInfoPage CustomerForm = new CustomerInfoPage();
            CustomerForm.Show();
           
        }

        private void SuppliersButton_Click(object sender, EventArgs e)
        {
            this.Close();
            SuppliersForm SuppliesForm = new SuppliersForm();
            SuppliesForm.Show();
            
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage login = new LoginPage();
            login.Show();
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }
    }
}
