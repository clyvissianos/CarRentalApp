using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class ManageUsers : Form
    {
        private readonly CarRentalEntities _db;
        public ManageUsers()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("AddUser"))
            {
                var addUser = new AddUser(this);
                addUser.MdiParent = this.MdiParent;
                addUser.Show();
            }
            
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvUsersList.SelectedRows[0].Cells["id"].Value;

                var user = _db.Users.FirstOrDefault(q => q.id == id);
                var hashed_password = Utils.DefaultHashPassword();

                user.password = hashed_password;
                _db.SaveChanges();

                MessageBox.Show($"{user.username}'s password has been reset!");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnDeactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvUsersList.SelectedRows[0].Cells["id"].Value;

                var user = _db.Users.FirstOrDefault(q => q.id == id);

                // if (user.isActive == true)
                //      user.isActive = false;
                // else
                //      user.isActive = true;
                user.isActive = user.isActive == true ? false : true;
                _db.SaveChanges();

                MessageBox.Show($"{user.username}'s active status changed!");
                
                PopulateGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        public void PopulateGrid()
        {
            var usersList = _db.Users
                .Select(q => new
                {
                    q.id,
                    q.username,
                    q.UsersRoles.FirstOrDefault().Role.name,
                    q.isActive
                })
                .ToList();
            gvUsersList.DataSource = usersList;
            gvUsersList.Columns["username"].HeaderText = "Username";
            gvUsersList.Columns["name"].HeaderText = "User Role";
            gvUsersList.Columns["isActive"].HeaderText = "Active";
            gvUsersList.Columns["id"].Visible = false;
        }

        private void btnRefreshGrid_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}
