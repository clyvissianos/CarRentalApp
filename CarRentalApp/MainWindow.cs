using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class MainWindow : Form
    {
        private Login _login;
        public User _user;
        public string _roleName;
        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(Login login, User user)
        {
            InitializeComponent();
            _login = login;
            _user = user;
            _roleName = user.UsersRoles.FirstOrDefault().Role.shortname;
        }

        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddEditRentalRecord();
            addRentalRecord.ShowDialog(); // Nullifies the MDIParent but allows only one instance of the form to be active 
            addRentalRecord.MdiParent = this;
            
        }

        private void manageVehicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms.Cast<Form>(); //Create a list of all the open forms in the application
            var isOpen = openForms.Any(q => q.Name == "ManageVehicleListing"); //Check if any form named as - is opened
            if (!isOpen)
            {
                var vehicleListing = new ManageVehicleListing();
                vehicleListing.MdiParent = this;
                vehicleListing.Show();
            }
            
        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("ManageRentalRecords"))
            {
                var manageRentalRecords = new ManageRentalRecords();
                manageRentalRecords.MdiParent = this;
                manageRentalRecords.Show();
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("ManageUsers")) // Custom made Utils class and FormIsOpen method
            {
                var manageUsers = new ManageUsers();
                manageUsers.MdiParent = this;
                manageUsers.Show();
            }
            
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (_user.password == Utils.DefaultHashPassword())
            {
                var resetPassword = new ResetPassword(_user);
                resetPassword.ShowDialog();
            }

                var username = _user.username;
                tsiLoginText.Text = $"Logged in as: {username}";
                if (_roleName != "admin")
                {
                    manageUsersToolStripMenuItem.Visible = false;
                }

        }
    }
}
