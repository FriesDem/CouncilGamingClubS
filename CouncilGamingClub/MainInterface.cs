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
    public partial class MainInterface: Form
    {
        private LoginPage _login;
        public string _RoleName;
        public Login_Page _user;
        public MainInterface()
        {
            InitializeComponent();
           
        }
        public MainInterface(LoginPage login, Login_Page user)
        {
            InitializeComponent();
            _login = login;
            _user = user;
            _RoleName = user.UserRoles.FirstOrDefault().Role.name;
        }

        private void MainInterface_Load(object sender, EventArgs e)
        {
            homeToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Visible = false;
            manageUsersToolStripMenuItem.Enabled=false;

            try
            {
                if (_user.Password == Utils.DefaultHashpassword())
                {
                    var resetPassword = new ResetPassword(_user);
                    resetPassword.ShowDialog();
                }
                var username = _user.Username;
                tsilogintext.Text = $"Logged In As:{username}";
                if (username != null )
                {
                    
                    logoutToolStripMenuItem.Visible = true;
                    
                    homeToolStripMenuItem.Enabled = true;
                    manageUsersToolStripMenuItem.Enabled = true;
                }
                
                if (_RoleName != "Manager")
                {
                    manageUsersToolStripMenuItem.Visible = false;
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ ex.Message}");
            }
        }

     
        
        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("UserManagement"))
            {
                var UserManagementForm = new UserManagement();
                UserManagementForm.MdiParent = this;
                UserManagementForm.Show();
            }
            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("MainPage"))
            {
                var Mainpage = new MainPage();
                Mainpage.MdiParent = this;
                Mainpage.Show();
               
            }
            
           
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            MainInterface MainInterface = new MainInterface();
            MainInterface.Show();

        }
    }
}
