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
    public partial class AddUser : Form
    {
        private readonly CGCAppDatabaseEntities _db;
        private UserManagement _userManagement;
        public AddUser(UserManagement userManagement)
        {
            InitializeComponent();
            _db = new CGCAppDatabaseEntities();
            _userManagement = userManagement;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var roles = _db.Roles.ToList();
            cbrole.DataSource = roles;
            cbrole.ValueMember = "id";
            cbrole.DisplayMember = "name";

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            
            try
            {
                var username = tbusername.Text;
                var RoleId = (int)cbrole.SelectedValue;
                var password = Utils.DefaultHashpassword();
                var USER = new Login_Page
                {
                    Username = username,
                    Password = password,
                    isActive = true
                };
                _db.Login_Pages.Add(USER);
                _db.SaveChanges();
                var userid = USER.ID;

                var userRole = new UserRole
                {
                    roleid = RoleId,
                    userid = userid
                };

                _db.UserRoles.Add(userRole);
                _db.SaveChanges();
                MessageBox.Show("New User Added Succesfully");
                _userManagement.PopulateGrid();
                Close();
            }
            catch (Exception)
            {

                MessageBox.Show("An Error Has Occured");
            }
        }
    }
}
