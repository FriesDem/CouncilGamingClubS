﻿using System;
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
    public partial class frmEditSupplier : Form
    {
        private readonly CGCAppDatabaseEntities cgcDB = new CGCAppDatabaseEntities();
        private readonly SupplierTable supplier = new SupplierTable();
        public frmEditSupplier(SupplierTable supplier)
        {
            InitializeComponent();
            FillTable(supplier);
        }
        public void FillTable(SupplierTable supplier)
        {
            tbSupplierID.Text = supplier.SupplierID.ToString();
            tbSupplierName.Text = supplier.SupplierName.ToString();
            tbSupplierAddress.Text = supplier.Address.ToString();

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            var ID = int.Parse(lblID.Text);
            var supplier = cgcDB.SupplierTables.FirstOrDefault(dt => dt.ID == ID);

            supplier.SupplierID = tbSupplierID.Text;
            supplier.SupplierName = tbSupplierName.Text;
            supplier.Address = tbSupplierAddress.Text;

            cgcDB.SupplierTables.Add(supplier);
            cgcDB.SaveChanges();
            MessageBox.Show("Your Supplier Info has been saved successfully");
        }
    }
}
