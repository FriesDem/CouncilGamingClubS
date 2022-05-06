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
    public partial class SuppliersForm : Form
    {
        private readonly CGCAppDatabaseEntities cgcDB = new CGCAppDatabaseEntities();
        private readonly SupplierTable supplierTable = new SupplierTable();
        public SuppliersForm()
        {
            InitializeComponent();
        }

        private void SHomeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage MainForm = new MainPage();
            MainForm.MdiParent = MainInterface.ActiveForm;
            MainForm.Show();
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            try
            {

                supplierTable.SupplierID = tbSupplierID.Text;
                supplierTable.SupplierName = tbSupplierName.Text;
                supplierTable.Address = tbAddress.Text;

                
                cgcDB.SaveChanges();
                MessageBox.Show("Nice. Your Supplier Record Has Been Added.");

                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void viewSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            var manageSupplier = new frmManageSuppliers();
            manageSupplier.MdiParent = MainInterface.ActiveForm;
            manageSupplier.Show();
            
        }
    }
}
