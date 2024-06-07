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
    public partial class AddEditVehicle : Form
    {
        private bool isEditMode;
        private ManageVehicleListing _manageVehicleListing;
        private readonly CarRentalEntities _db;
        public AddEditVehicle(ManageVehicleListing manageVehicleListing = null)
        {
            InitializeComponent();
            lblTitle.Text = "Add New Vehicle";
            this.Text = "Add Vehicle";
            isEditMode = false;
            _manageVehicleListing = manageVehicleListing;
            _db = new CarRentalEntities();
        }

        public AddEditVehicle(TypeOfCar carToEdit, ManageVehicleListing manageVehicleListing = null)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Vehicle";
            this.Text = "Edit Vehicle";
            _manageVehicleListing = manageVehicleListing;
            if (carToEdit == null)
            {
                MessageBox.Show("Please ensure that you selected a valid record to edit");
                Close();
            }
            else
            {
                isEditMode = true;
                _db = new CarRentalEntities();
                PopulateFields(carToEdit);
            }
        }

        private void PopulateFields(TypeOfCar car)
        {
            lblId.Text = car.Id.ToString();
            tbMake.Text = car.Make;
            tbModel.Text = car.Model;
            tbVin.Text = car.VIN;
            tbYear.Text = car.Year.ToString();
            tbLicenseNumber.Text = car.LicencePlateNumber;
        }


        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbMake.Text) || string.IsNullOrWhiteSpace(tbModel.Text))
                {
                    MessageBox.Show("Please provide car Make and Model info.");
                }
                else
                {
                    if (isEditMode)
                    {
                        var id = int.Parse(lblId.Text);
                        var car = _db.TypeOfCars.FirstOrDefault(q => q.Id == id);
                        car.Make = tbMake.Text;
                        car.Model = tbModel.Text;
                        car.VIN = tbVin.Text;
                        car.Year = int.Parse(tbYear.Text);
                        car.LicencePlateNumber = tbLicenseNumber.Text;

                    }
                    else
                    {
                        var newCar = new TypeOfCar
                        {
                            Make = tbMake.Text,
                            Model = tbModel.Text,
                            VIN = tbVin.Text,
                            Year = int.Parse(tbYear.Text),
                            LicencePlateNumber = tbLicenseNumber.Text
                        };

                        _db.TypeOfCars.Add(newCar);
                    }

                    _db.SaveChanges();
                    _manageVehicleListing.RefreshGrid();
                    MessageBox.Show($"The operation was completed successfully.");
                    Close();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Year field must be an integer number");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
