using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CouncilGamingClub
{
    public partial class LoginPage : Form
    {
        private readonly CGCAppDatabaseEntities _db;
        public LoginPage()
        {
            InitializeComponent();
            _db = new CGCAppDatabaseEntities();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();

                var username = tbUsername.Text.Trim();
                var password = tbPassword.Text;

                var hashed_password = Utils.Hashpassword(password);
               
                var user = _db.Login_Page.FirstOrDefault(Queryable=>Queryable.Username == username && Queryable.Password == hashed_password && Queryable.isActive == true);

                if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }
                else
                {
                    var mainPage = new MainPage(this,user);
                    mainPage.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something Went Wrong. Please Try Again");
            }
        }

      
    }
}
