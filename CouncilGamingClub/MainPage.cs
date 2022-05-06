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
           
            this.Close();
            var OrdersForm = new OrdersWindow();
            OrdersForm.MdiParent = MainInterface.ActiveForm;
            OrdersForm.Show();
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            this.Close();
            var InventoryForm = new Inventory();
            InventoryForm.MdiParent = MainInterface.ActiveForm;
            InventoryForm.Show();
        }

        private void CustomerInfoButton_Click(object sender, EventArgs e)
        {
            this.Close();
            var CustomerForm = new CustomerInfoPage();
            CustomerForm.MdiParent = MainInterface.ActiveForm;
            CustomerForm.Show();
        }

        private void SuppliersButton_Click(object sender, EventArgs e)
        {
            this.Close();
            var SuppliesForm = new SuppliersForm();
            SuppliesForm.MdiParent = MainInterface.ActiveForm;
            SuppliesForm.Show();
        }

      

       
    }
}
