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
    public partial class MainPage : Form
    {
        private LoginPage _login;
        public string _RoleName;
        public Login_Page _user;
        public MainPage()
        {
            InitializeComponent();
        }
        public MainPage(LoginPage login, Login_Page user)
        {
            InitializeComponent();
            _login = login;
            _user = user;
            _RoleName = user.UserRoles.FirstOrDefault().Role.name;
        }
        

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage login = new LoginPage();
            login.Show();
        }

        //private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    _login.Close();
        //}
                
        private void OrdersButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Orders OrdersForm = new Orders();
            OrdersForm.Show();
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Inventory InventoryForm = new Inventory();
            InventoryForm.Show();
        }

        private void CustomerInfoButton_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerInfoPage CustomerForm = new CustomerInfoPage();
            CustomerForm.Show();
        }

        private void SuppliersButton_Click(object sender, EventArgs e)
        {
            this.Close();
            SuppliersForm SuppliesForm = new SuppliersForm();
            SuppliesForm.Show();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            if(_user.Password == Utils.DefaultHashpassword())
            {
                var resetPassword = new ResetPassword(_user);
                resetPassword.Show();
            }
            if(_RoleName != "Manager")
            {
                btnManage.Visible = false;
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            this.Close();
           UserManagement UserManagementForm = new UserManagement();
            UserManagementForm.Show();
        }
    }
}
