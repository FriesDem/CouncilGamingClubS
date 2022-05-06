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
    public partial class Inventory : Form
    {
        private readonly CGCAppDatabaseEntities cgcDB = new CGCAppDatabaseEntities();
        private readonly InventoryTable inventory = new InventoryTable();
        public Inventory()
        {
            InitializeComponent();
        }



        private void OHomeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage MainForm = new MainPage();
            MainForm.MdiParent = MainInterface.ActiveForm;
            MainForm.Show();

        }

        private void viewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            var manageInventory = new InventoryManagementWindow();
            manageInventory.MdiParent = MainInterface.ActiveForm;
            manageInventory.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string invID = tbItemID.Text;
                string itemName = tbItemName.Text;
                int invAmount = Convert.ToInt32(tbItemAmount.Text);
                string invType = tbItemName.Text;
                string supplierID = tbSupplierID.Text;

                inventory.ItemID = invID;
                inventory.SupplierID = supplierID;
                inventory.Amount = invAmount;
                inventory.Type_Of_Item = invType;
                inventory.ItemName = itemName;

                cgcDB.InventoryTables.Add(inventory);
                cgcDB.SaveChanges();

                MessageBox.Show("The Inventory has been updated");
            }
            catch (Exception)
            {

                MessageBox.Show("An Error Occured");
            }
        }
    }
}
