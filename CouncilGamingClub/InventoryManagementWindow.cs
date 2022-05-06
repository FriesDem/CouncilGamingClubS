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
        private readonly Inventory inventory;
        public InventoryManagementWindow()
        {
            InitializeComponent();
            inventory = new Inventory();
            cgcDB = new CGCAppDatabaseEntities();
        }

    }
}
