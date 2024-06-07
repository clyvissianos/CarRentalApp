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
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalEntities _db;
        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            //Select * from TypeOfCar
            //var cars = _db.TypeOfCar.ToList();

            //Select Id as CarId , name as CarName from TypeOfCar
            //var cars = _db.TypeOfCars
            //    .Select(q => new { CarId = q.Id, CarName = q.Make })
            //    .ToList();

            var cars = _db.TypeOfCars
                .Select(q => new
                {
                    Make = q.Make,
                    Model = q.Model,
                    VIN = q.VIN,
                    Year = q.Year,
                    LicencePlateNumber = q.LicencePlateNumber,
                    q.Id
                })
                .ToList();
            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[4].HeaderText = "License Plate Number";
            gvVehicleList.Columns[5].Visible = false;
            //gvVehicleList.Columns[0].HeaderText = "ID";
            //gvVehicleList.Columns[1].HeaderText = "NAME";
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            var addEditVehicle = new AddEditVehicle(this);
            addEditVehicle.MdiParent = this.MdiParent;
            addEditVehicle.Show();
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row
                var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;
                //query database for record
                var car = _db.TypeOfCars.FirstOrDefault(q => q.Id == id);
                //launch AddEditVehicle with data
                var addEditVehicle = new AddEditVehicle(car, this);
                addEditVehicle.MdiParent = this.MdiParent;
                addEditVehicle.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error Editing entry: {ex.Message}");
            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row
                var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;
                //query database for record
                var car = _db.TypeOfCars.FirstOrDefault(q => q.Id == id);

                DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?",
                    "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); 
                
                if (dr == DialogResult.Yes)
                {
                    //delete vehicle from table
                    _db.TypeOfCars.Remove(car);
                    _db.SaveChanges();
                }

                RefreshGrid();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Deleting entry: {ex.Message}");
            }
        }

        private void btnRefreshGrid_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            var cars = _db.TypeOfCars
                .Select(q => new
                {
                    Make = q.Make,
                    Model = q.Model,
                    VIN = q.VIN,
                    Year = q.Year,
                    LicencePlateNumber = q.LicencePlateNumber,
                    q.Id
                })
                .ToList();
            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[4].HeaderText = "License Plate Number";
            gvVehicleList.Columns[5].Visible = false;
        }
    }
}
