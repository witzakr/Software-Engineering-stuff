namespace CARPROJECT
{
    public partial class Form1 : Form
    {
        private List<Car> cars;

        public Form1()
        {
            InitializeComponent();
            cars = new List<Car>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create instances of the Car class
            Car bmw = new Car("BMW", 280);
            Car mercedes = new Car("Mercedes", 250);
            Car audi = new Car("Audi", 270);

            // Add the cars to the list
            cars.Add(bmw);
            cars.Add(mercedes);
            cars.Add(audi);

            // Add the cars to the ComboBox 
            comboBox1.Items.AddRange(cars.ToArray());
            comboBox1.DisplayMember = "Name";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the current speed label when a car is selected
            Car selectedCar = (Car)comboBox1.SelectedItem;
            label1.Text = $"Current Speed: {selectedCar.CurrentSpeed} km/h\nMax Speed: {selectedCar.MaxSpeed} km/h";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car selectedCar = (Car)comboBox1.SelectedItem;
            int currentSpeed = selectedCar.CurrentSpeed + 10;
            if (currentSpeed > selectedCar.MaxSpeed)
            {
                selectedCar.CurrentSpeed = selectedCar.MaxSpeed;
            }
            else
            {
                selectedCar.CurrentSpeed = currentSpeed;
            }
            label1.Text = $"Current Speed: {selectedCar.CurrentSpeed} km/h, Max Speed: {selectedCar.MaxSpeed} km/h";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Car selectedCar = (Car)comboBox1.SelectedItem;
            if (selectedCar.CurrentSpeed > 0)
            {
                selectedCar.CurrentSpeed -= 10;
                if (selectedCar.CurrentSpeed < 0)
                {
                    selectedCar.CurrentSpeed = 0;
                }
                label1.Text = $"Current Speed: {selectedCar.CurrentSpeed} km/h, Max Speed: {selectedCar.MaxSpeed} km/h";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    public class Car
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public int CurrentSpeed { get; set; }

        public Car(string name, int maxSpeed)
        {
            Name = name;
            MaxSpeed = maxSpeed;
            CurrentSpeed = 0; // Set current speed to 0 by default
        }


    }
}
