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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void OHomeButton_Click(object sender, EventArgs e)
        {
            MainPage MainForm = new MainPage();
            MainForm.Show();
            this.Hide();
        }
    }
}
