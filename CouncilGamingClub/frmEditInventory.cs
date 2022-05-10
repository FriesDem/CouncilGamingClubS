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
    public partial class frmEditInventory : Form
    {
        private readonly InventoryTable inventory = new InventoryTable();
        private readonly CGCAppDatabaseEntities cgcDB;

        public int ID { get; private set; }

        public frmEditInventory(InventoryTable inventory)
        {
            InitializeComponent();
            cgcDB = new CGCAppDatabaseEntities();
            FillTable(inventory);
        }
       

        public void FillTable(InventoryTable inventory)
        {
            try
            {
                tbItemID.Text = inventory.ItemID;
                tbItemName.Text = inventory.ItemName;
                tbAmount.Text = inventory.Amount.ToString();
                tbTypeOfItem.Text = inventory.Type_Of_Item;
                tbSupplierID.Text = inventory.SupplierID.ToString();
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
                var inventory = cgcDB.InventoryTables.FirstOrDefault(dt => dt.ID == ID);
                inventory.ItemID = tbItemID.Text;
                inventory.ItemName = tbItemName.Text;
                inventory.Amount = int.Parse(tbAmount.Text);
                inventory.Type_Of_Item = tbTypeOfItem.Text;
                inventory.SupplierID = tbSupplierID.Text;

                cgcDB.InventoryTables.Add(inventory);
                cgcDB.SaveChanges();

                MessageBox.Show("Your Inventory has been saved Successfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void btnCancelChanges_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Process will be Terminated");
            this.Close();
        }
    }
}
