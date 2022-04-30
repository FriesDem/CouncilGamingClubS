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
    }
}
