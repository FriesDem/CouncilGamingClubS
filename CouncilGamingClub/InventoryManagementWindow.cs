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
    public partial class InventoryManagementWindow : Form
    {
        private readonly CGCAppDatabaseEntities cgcDB;
        private readonly InventoryTable inventory;
        public InventoryManagementWindow()
        {
            InitializeComponent();
            inventory = new InventoryTable();
            cgcDB = new CGCAppDatabaseEntities();

        }

        private void InventoryManagementWindow_Load(object sender, EventArgs e)
        {
            try
            {
                var inventory = cgcDB.InventoryTables.Select(inv => new
                {
                    inv.ID,
                    inv.ItemID,
                    inv.ItemName,
                    inv.Type_Of_Item,
                    inv.Amount,
                    inv.SupplierID
                }).ToList();
                gvInventory.DataSource = inventory;
                gvInventory.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred");
            }
        }
        public void FillTable()
        {
            try
            {
                var inventory = cgcDB.InventoryTables.Select(inv => new
                {
                    inv.ID,
                    inv.ItemID,
                    inv.ItemName,
                    inv.Type_Of_Item,
                    inv.Amount,
                    inv.SupplierID
                }).ToList();
                gvInventory.DataSource = inventory;
                gvInventory.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred");
            }
           
        }
        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            try
            {
                //get ID of selected row
                var ID = (int)gvInventory.SelectedRows[0].Cells["ID"].Value;

                //query Database 
                var inventoryInfo = cgcDB.InventoryTables.FirstOrDefault(dt => dt.ID == ID);

                var existingInfo = new frmEditInventory(inventoryInfo);
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

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            var addInventory = new Inventory();
            addInventory.MdiParent = MainInterface.ActiveForm;
            addInventory.Show();
            this.Close();
            FillTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //get ID of selected row
                var ID = (int)gvInventory.SelectedRows[0].Cells["ID"].Value;

                //query Database 
                var inventory = cgcDB.InventoryTables.FirstOrDefault(dt => dt.ID == ID);

                //Remove
                cgcDB.InventoryTables.Remove(inventory);
                cgcDB.SaveChanges();
                MessageBox.Show("Your Record Has Been Deleted Successfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            FillTable();
        }
    }

       
        
}
    

