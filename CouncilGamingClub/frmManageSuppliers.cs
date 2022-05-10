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
    public partial class frmManageSuppliers : Form
    {
        private readonly CGCAppDatabaseEntities cgcDB;
        private readonly SupplierTable supplier = new SupplierTable();
        public frmManageSuppliers()
        {
            InitializeComponent();
            cgcDB = new CGCAppDatabaseEntities();
            FillTable();
        }
       
        public void FillTable()
        {
            var suppliers = cgcDB.SupplierTables.Select(sp => new
            {
                sp.ID,
                sp.SupplierID,
                sp.SupplierName,
                sp.Address
            }).ToList();
            gvSuppliers.DataSource = suppliers;
            gvSuppliers.Columns[0].Visible = false;

        }


        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            this.Close();
            var addSupplier = new SuppliersForm();
            addSupplier.MdiParent = MainInterface.ActiveForm;
            addSupplier.Show();

        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                //get ID of selected row
                var ID = (int)gvSuppliers.SelectedRows[0].Cells["ID"].Value;

                //query Database 
                var supplier = cgcDB.SupplierTables.FirstOrDefault(dt => dt.ID == ID);
                
                var existingInfo = new frmEditSupplier(supplier);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //get ID of selected row
                var ID = (int)gvSuppliers.SelectedRows[0].Cells["ID"].Value;

                //query Database 
                var supplier = cgcDB.SupplierTables.FirstOrDefault(dt => dt.ID == ID);

                //Remove
                cgcDB.SupplierTables.Remove(supplier);
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
