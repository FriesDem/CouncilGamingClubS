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
    public partial class UserManagement : Form
    {
        private readonly CGCAppDatabaseEntities _db;
        public UserManagement()
        {
            InitializeComponent();
            _db = new CGCAppDatabaseEntities();
            
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
           if (!Utils.FormIsOpen("AddUser"))
            {
               var addUser = new AddUser(this);
                addUser.MdiParent = this.MdiParent;
                addUser.Show();
                
            }
           

        }

        private void btnresetpassword_Click(object sender, EventArgs e)
        {
            try
            {
                //get ID of selected row
                var ID = (int)gvUserList.SelectedRows[0].Cells["id"].Value;

                //query Database 
                var user = _db.Login_Page.FirstOrDefault(Queryable => Queryable.ID == ID);
                var hashed_password = Utils.DefaultHashpassword();
                user.Password = hashed_password;
                _db.SaveChanges();

                MessageBox.Show($"{user.Username}'s Password has been reset");
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroor:{ ex.Message}");
            }
        }

        private void btnDeactivateStaff_Click(object sender, EventArgs e)
        {
            try
            {
                //get ID of selected row
                var ID = (int)gvUserList.SelectedRows[0].Cells["id"].Value;

                //query Database 
                var user = _db.Login_Page.FirstOrDefault(Queryable => Queryable.ID == ID);
                
                user.isActive = user.isActive == true ? false : true;
                _db.SaveChanges();

                MessageBox.Show($"{user.Username}'s Active Status Has Changed!!");
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroor:{ ex.Message}");
            }
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }
        public void PopulateGrid()
        {
            var Cgc = _db.Login_Page
            .Select(q => new
            {
               q.ID ,
               q.Username ,
               q.UserRoles.FirstOrDefault().Role.name,
               q.isActive
            })
            .ToList();
            gvUserList.DataSource = Cgc;
            gvUserList.Columns["Username"].HeaderText = "Username";
            gvUserList.Columns["name"].HeaderText = "Name";
            gvUserList.Columns["isActive"].HeaderText = "Active";


            gvUserList.Columns["ID"].Visible = false;
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage main = new MainPage();
            main.Show();
        }
    }

}
