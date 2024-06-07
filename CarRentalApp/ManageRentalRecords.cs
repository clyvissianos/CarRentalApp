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
    public partial class ManageRentalRecords : Form
    {
        private readonly CarRentalEntities _db;
        public ManageRentalRecords()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void ManageRentalRecords_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void PopulateGrid()
        {
            var records = _db.CarRentalRecords.Select(q => new
            {
                Customer = q.CustomerName,
                DateOut = q.DateRented,
                DateIn = q.DateReturned,
                Id = q.ID,
                q.Cost,
                Car = q.TypeOfCar1.Make + " " + q.TypeOfCar1.Model
            })
            .ToList();

            gvRecordList.DataSource = records;
            gvRecordList.Columns["DateOut"].HeaderText = "Date Rented";
            gvRecordList.Columns["DateIn"].HeaderText = "Date Returned";
            gvRecordList.Columns["Id"].Visible = false;
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddEditRentalRecord(this)
            {
                MdiParent = this.MdiParent 
            };
            addRentalRecord.Show();
        }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row
                var id = (int)gvRecordList.SelectedRows[0].Cells["Id"].Value;
                //query database for record
                var record = _db.CarRentalRecords.FirstOrDefault(q => q.ID == id);

                //launch AddEditRecord with data
                var addEditRentalRecord = new AddEditRentalRecord(record, this);
                addEditRentalRecord.MdiParent = this.MdiParent;
                addEditRentalRecord.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Editing entry: {ex.Message}");
            }
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row
                var id = (int)gvRecordList.SelectedRows[0].Cells["Id"].Value;
                //query database for record
                var record = _db.CarRentalRecords.FirstOrDefault(q => q.ID == id);

                DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?",
                    "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    //delete vehicle from table
                    _db.CarRentalRecords.Remove(record);
                    _db.SaveChanges();

                    //Refresh gridView
                    PopulateGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Deleting entry: {ex.Message}");
            }
        }
    }
}
