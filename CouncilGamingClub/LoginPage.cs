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

                byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder sbuilder = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    sbuilder.Append(data[i].ToString("x2"));
                }
                var hashed_password = sbuilder.ToString();

                var user = _db.Login_Pages.FirstOrDefault(Queryable=>Queryable.Username == username && Queryable.Password == hashed_password); 
                if(user == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }
                else
                {
                    var mainPage = new MainPage(this);
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
