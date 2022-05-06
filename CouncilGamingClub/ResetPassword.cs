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
    public partial class ResetPassword : Form
    {
        private readonly CGCAppDatabaseEntities _db;
        private Login_Page _user;
        public ResetPassword(Login_Page user)
        {
            InitializeComponent();
            _db = new CGCAppDatabaseEntities();
            _user = user;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                var password = tbPassword.Text;
                var confirm_password = tbConfirmPassword.Text;
                var user = _db.Login_Pages.FirstOrDefault(q => q.ID == _user.ID);
                if (password != confirm_password)
                {
                    MessageBox.Show("Password do not match.Please try again!");
                }

                user.Password = Utils.Hashpassword(password);
                _db.SaveChanges();
                MessageBox.Show("Password Was Reset Succesfully");
                Close();
            }
            catch (Exception)
            {

                MessageBox.Show("An Error has occured.please try again!");
            }
        }
    }
}
