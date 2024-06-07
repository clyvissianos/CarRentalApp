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
    public partial class AddEditRentalRecord : Form
    {
        private bool isEditMode;
        private readonly CarRentalEntities _db;
        private ManageRentalRecords _manageRentalRecords;
        public AddEditRentalRecord(ManageRentalRecords records = null)
        {
            InitializeComponent();
            lblTitle.Text = "Add New Rental Record";
            this.Text = "Add Record";
            isEditMode = false;
            _db = new CarRentalEntities();
            _manageRentalRecords = records;
        }

        public AddEditRentalRecord(CarRentalRecord recordToEdit, ManageRentalRecords records = null)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Rental Record";
            this.Text = "Edit Record";
            _manageRentalRecords = records;
            if (recordToEdit == null)
            {
                MessageBox.Show("Please ensure that you selected a valid record to edit");
                Close();
            }
            else
            {
                isEditMode = true;
                _db = new CarRentalEntities();
                PopulateFields(recordToEdit);
            }
        }

        private void PopulateFields(CarRentalRecord recordToEdit)
        {
            txtCustomerName.Text = recordToEdit.CustomerName;
            dtRented.Value = (DateTime)recordToEdit.DateRented;
            dtReturned.Value = (DateTime)recordToEdit.DateReturned;
            txtCost.Text = recordToEdit.Cost.ToString();
            lblRecordId.Text = recordToEdit.ID.ToString();

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = txtCustomerName.Text;
                var dateOut = dtRented.Value;
                var dateIn = dtReturned.Value;
                double cost = Convert.ToDouble(txtCost.Text);

                var carType = cbTypeOfCar.Text; // SelectedIndex -1 if not selected
                var isValid = true;
                var errorMessage = string.Empty;

                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
                {
                    isValid = false;
                    errorMessage += "Error: Please enter missing data.\n\r";
                }

                if (dateOut > dateIn)
                {
                    isValid = false;
                    errorMessage += "Error: Illegal Date Selection.\n\r";
                }

                if (isValid)
                {
                    //Refactored Code
                    var rentalRecord = new CarRentalRecord(); //Instantiate an empty CarRentalRecord object
                    
                    if (isEditMode) //If edit record true, get the id and query the record from database
                    {
                        var id = int.Parse(lblRecordId.Text);
                        rentalRecord = _db.CarRentalRecords.FirstOrDefault(q => q.ID == id);
                    }

                    //Populate the form fields if edit record is true else they will be entered by user
                    rentalRecord.CustomerName = customerName;
                    rentalRecord.DateRented = dateOut;
                    rentalRecord.DateReturned = dateIn;
                    rentalRecord.Cost = (decimal)cost;
                    rentalRecord.TypeOfCar = (int)cbTypeOfCar.SelectedValue;

                    if (!isEditMode) //If edit record false, insert fields information as new record
                    {
                        _db.CarRentalRecords.Add(rentalRecord);
                    }

                    //Either way save changes to database
                    _db.SaveChanges();

                    ShowAddEditMessage(customerName,carType,dateOut,dateIn,cost);
                    _manageRentalRecords.PopulateGrid();
                    Close();
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
                      
        }

        private void ShowAddEditMessage(string Name,string type,DateTime dateOut, DateTime dateIn, double cost)
        {
            if (isEditMode)
            {
                MessageBox.Show($"Dear {Name}, your rental information is updated to:\n\r" +
                $"Car Rented {type}\n\r" +
                $"Date Rented {dateOut}\n\r" +
                $"Date Returned {dateIn}\n\r" +
                $"Cost {cost}\n\r" +
                "Thank you for renting with us!");
            }
            else
            {
                MessageBox.Show($"Dear {Name}, your rental information was added successfully:\n\r" +
                $"Car Rented {type}\n\r" +
                $"Date Rented {dateOut}\n\r" +
                $"Date Returned {dateIn}\n\r" +
                $"Cost {cost}\n\r" +
                "Thank you for renting with us!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Select * from TypeOfCar
            //var cars = _db.TypeOfCars.ToList();
            var cars = _db.TypeOfCars
                .Select(q => new
                {
                    Id = q.Id,
                    Name = q.Make + " " + q.Model
                })
                .ToList();

            cbTypeOfCar.DisplayMember = "Name";
            cbTypeOfCar.ValueMember = "Id";
            cbTypeOfCar.DataSource = cars;
        }

    }
}
