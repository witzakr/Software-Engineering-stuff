using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FinalAssignment
{
    public partial class Form1 : Form
    {
        private string jsonFilePath = "carpool.json";
        private string jsonEmployeesFilePath = "employees.json";
        private string jsonTripsFilePath = "trips.json";
        private int tripLength;

        public Form1()
        {
            InitializeComponent();
            CarPool.InitializeCarPoolList();
            Employees.InitializeEmployeesList();
            Trip.InitializeTripList();

        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            string brand = brandTextBox.Text;
            string model = ModelTextBox.Text;
            int endOfLifeMileage = (int)EndOfLifeMileageNUD.Value;
            int maintenanceInterval = (int)MaintenanceIntervalNUD.Value;
            int currentMileage = (int)CurrentMileageNUD.Value;
            string registrationPlate = LicensePlateNumberTextBox.Text;

            CarPool car = new CarPool
            {
                Brand = brand,
                Model = model,
                EndOfLifeMileage = endOfLifeMileage,
                MaintenanceInterval = maintenanceInterval,
                CurrentMileage = currentMileage,
                RegistrationPlate = registrationPlate
            };

            try
            {
                car.AddToCarPool();
                CarListBox.Items.Add(car.GetCarDisplayName());
                SaveCarPoolData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void ShowCarInfo_Click(object sender, EventArgs e)
        {
            if (CarListBox.SelectedIndex != -1)
            {
                int selectedIndex = CarListBox.SelectedIndex;
                CarPool car = CarPool.GetCarFromCarPool(selectedIndex);
                string info = car.GetCarInfo();
                MessageBox.Show(info, "Car Info");
            }
        }

        private void RemoveCar_Click(object sender, EventArgs e)
        {
            if (CarListBox.SelectedIndex != -1)
            {
                int selectedIndex = CarListBox.SelectedIndex;
                CarPool car = CarPool.GetCarFromCarPool(selectedIndex);
                car.RemoveFromCarPool();
                CarListBox.Items.RemoveAt(selectedIndex);

                SaveCarPoolData();
            }
        }

        private void LoadCar_Click(object sender, EventArgs e)
        {
            LoadCarPoolData();
        }

        private void EmployeeAdd_Click(object sender, EventArgs e)
        {
            string first_name = EmployeeNameTextBox.Text;
            string last_name = EmployeeLastNameTextBox.Text;
            int age = (int)AgeNUD.Value;

            Employees employee = new Employees
            {
                FirstName = first_name,
                LastName = last_name,
                Age = age
            };

            employee.AddToEmployees();
            EmployeeListBox.Items.Add(employee.GetEmployeeDisplayName());
            SaveEmployeesData();
        }

        private void ShowEmployeeInfo_Click(object sender, EventArgs e)
        {
            if (EmployeeListBox.SelectedIndex != -1)
            {
                int selectedIndex = EmployeeListBox.SelectedIndex;
                Employees employees = Employees.GetEmployeeFromEmployees(selectedIndex);
                string info = employees.GetEmployeeInfo();
                MessageBox.Show(info, "Employee Info");
            }
        }

        private void EmployeeRemove_Click(object sender, EventArgs e)
        {
            if (EmployeeListBox.SelectedIndex != -1)
            {
                int selectedIndex = EmployeeListBox.SelectedIndex;
                Employees employees = Employees.GetEmployeeFromEmployees(selectedIndex);
                employees.RemoveFromEmployees();
                EmployeeListBox.Items.RemoveAt(selectedIndex);

                SaveEmployeesData();
            }
        }

        private void LoadEmployee_Click(object sender, EventArgs e)
        {
            LoadEmployeesData();
        }

        private void AddTrip_Click(object sender, EventArgs e)
        {
            if (CarsComboBox.SelectedIndex != -1 && EmployeesComboBox.SelectedIndex != -1)
            {
                CarPool selectedCar = CarPool.GetCarFromCarPool(CarsComboBox.SelectedIndex);
                Employees selectedEmployee = Employees.GetEmployeeFromEmployees(EmployeesComboBox.SelectedIndex);

                int tripLength = (int)LenghtOfATripNUD.Value;

                if (tripLength > selectedCar.EndOfLifeMileage - selectedCar.CurrentMileage)
                {
                    MessageBox.Show("This trip exceeds the mileage limit for the selected car. Please choose another car.");
                }
                else
                {
                    selectedCar.CurrentMileage += tripLength;

                    if (selectedCar.CurrentMileage > selectedCar.MaintenanceInterval &&
                        selectedCar.CurrentMileage % selectedCar.MaintenanceInterval <= tripLength)
                    {
                        MessageBox.Show("The car has crossed the maintenance interval. It may require maintenance.");
                    }

                    if (selectedCar.CurrentMileage >= selectedCar.EndOfLifeMileage)
                    {
                        selectedCar.RemoveFromCarPool();
                        CarListBox.Items.Remove(selectedCar.GetCarDisplayName());
                        MessageBox.Show("The car has exceeded its mileage limit and has been removed from the car pool.");
                        UpdateCarListBox();
                    }

                    Trip trip = new Trip
                    {
                        Car = selectedCar,
                        Employee = selectedEmployee,
                        Length = tripLength
                    };

                    trip.AddToTripList();
                    TripListBox.Items.Add(trip.GetTripDisplayName());

                    SaveTripsData();
                    SaveCarPoolData();
                }
            }
        }

        private void ShowTripInfo_Click(object sender, EventArgs e)
        {
            if (TripListBox.SelectedIndex != -1)
            {
                int selectedIndex = TripListBox.SelectedIndex;
                Trip trip = Trip.GetTripFromTripList(selectedIndex);
                string combinedInfo = $"Trip: {trip.GetTripDisplayName()}\n\n{trip.GetTripInfo()}\n\nLength of a trip: {trip.Length}";
                MessageBox.Show(combinedInfo, "Combined Info");
            }
        }

        private void RemoveTrip_Click(object sender, EventArgs e)
        {
            if (TripListBox.SelectedIndex != -1)
            {
                int selectedIndex = TripListBox.SelectedIndex;
                Trip trip = Trip.GetTripFromTripList(selectedIndex);
                trip.RemoveFromTripList();
                TripListBox.Items.RemoveAt(selectedIndex);

                SaveTripsData();
            }
        }

        private void LoadTrip_Click(object sender, EventArgs e)
        {
            LoadTripsData();
        }

        private void CarSearch_Click(object sender, EventArgs e)
        {
            string brand = BrandSearch.Text;
            string licensePlate = LicensePlateSearch.Text;

            CarPool foundCar = CarPool.GetCarPoolList().Find(car => car.Brand == brand && car.RegistrationPlate == licensePlate);

            if (foundCar != null)
            {
                int carIndex = CarPool.GetCarPoolList().IndexOf(foundCar);
                CarListBox.SelectedIndex = carIndex;
                MessageBox.Show($"Car found at index {carIndex}.", "Search Result");
            }
            else
            {
                CarListBox.ClearSelected();
                MessageBox.Show("Car not found.", "Search Result");
            }
        }

        private void EmployeeSearch_Click(object sender, EventArgs e)
        {
            string firstName = NameSearchTextBox.Text;
            string lastName = LastNameSearchTextBox.Text;

            Employees foundEmployee = Employees.GetEmployeesList().Find(employee => employee.FirstName == firstName && employee.LastName == lastName);

            if (foundEmployee != null)
            {
                int employeeIndex = Employees.GetEmployeesList().IndexOf(foundEmployee);
                EmployeeListBox.SelectedIndex = employeeIndex;
                MessageBox.Show($"Employee found at index {employeeIndex}.", "Search Result");
            }
            else
            {
                EmployeeListBox.ClearSelected();
                MessageBox.Show("Employee not found.", "Search Result");
            }
        }

        private void SaveCarPoolData()
        {
            string jsonData = JsonConvert.SerializeObject(CarPool.GetCarPoolList());
            File.WriteAllText(jsonFilePath, jsonData);
        }

        private void LoadCarPoolData()
        {
            if (File.Exists(jsonFilePath))
            {
                string jsonData = File.ReadAllText(jsonFilePath);
                List<CarPool> carPoolList = JsonConvert.DeserializeObject<List<CarPool>>(jsonData);

                CarPool.SetCarPoolList(carPoolList);

                CarsComboBox.Items.Clear();
                CarListBox.Items.Clear();

                foreach (CarPool car in carPoolList)
                {
                    string carDisplayName = car.GetCarDisplayName();
                    CarsComboBox.Items.Add(carDisplayName);
                    CarListBox.Items.Add(carDisplayName);
                }
            }
            else
            {
                MessageBox.Show("No car data found.", "Error");
            }
        }

        private void SaveEmployeesData()
        {
            string jsonData = JsonConvert.SerializeObject(Employees.GetEmployeesList());
            File.WriteAllText(jsonEmployeesFilePath, jsonData);
        }

        private void LoadEmployeesData()
        {
            if (File.Exists(jsonEmployeesFilePath))
            {
                string jsonData = File.ReadAllText(jsonEmployeesFilePath);
                List<Employees> employeeList = JsonConvert.DeserializeObject<List<Employees>>(jsonData);

                Employees.SetEmployeesList(employeeList);

                EmployeesComboBox.Items.Clear();
                EmployeeListBox.Items.Clear();

                foreach (Employees employee in employeeList)
                {
                    string employeeDisplayName = employee.GetEmployeeDisplayName();
                    EmployeesComboBox.Items.Add(employeeDisplayName);
                    EmployeeListBox.Items.Add(employeeDisplayName);
                }
            }
            else
            {
                MessageBox.Show("No employee data found.", "Error");
            }
        }

        private void SaveTripsData()
        {
            string jsonData = JsonConvert.SerializeObject(Trip.GetTripList());
            File.WriteAllText(jsonTripsFilePath, jsonData);
        }

        private void LoadTripsData()
        {
            if (File.Exists(jsonTripsFilePath))
            {
                string jsonData = File.ReadAllText(jsonTripsFilePath);
                List<Trip> tripList = JsonConvert.DeserializeObject<List<Trip>>(jsonData);

                Trip.SetTripList(tripList);

                TripListBox.Items.Clear();
                foreach (Trip trip in tripList)
                {
                    TripListBox.Items.Add(trip.GetTripDisplayName());
                }
            }
            else
            {
                MessageBox.Show("No trip data found.", "Error");
            }
        }

        private void UpdateCarListBox()
        {
            CarListBox.Items.Clear();
            List<CarPool> carPoolList = CarPool.GetCarPoolList();
            foreach (CarPool car in carPoolList)
            {
                CarListBox.Items.Add(car.GetCarDisplayName());
            }
        }
    }

}
