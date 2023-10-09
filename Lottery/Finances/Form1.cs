namespace Finances
{
    public partial class Form1 : Form
    {
        private Lottery currentLottery;

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateLottery_Click(object sender, EventArgs e)
        {
            // Create a new lottery based on user input
            int maxValue, nrOfWantedNumbers;

            if (int.TryParse(textBox1.Text, out maxValue) && int.TryParse(textBox2.Text, out nrOfWantedNumbers))
            {
                currentLottery = new Lottery(maxValue, nrOfWantedNumbers);
                MessageBox.Show("Lottery created successfully!");
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.");
            }
        }

        private void DrawNextNumber_Click(object sender, EventArgs e)
        {
            // Draw the next number in the current lottery and display it
            if (currentLottery == null)
            {
                MessageBox.Show("No lottery created yet. Please create a lottery first.");
                return;
            }

            try
            {
                int nextNumber = currentLottery.DrawNextNumber();
                listBox1.Items.Add(nextNumber.ToString());
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            // Draw all numbers in the current lottery and display them
            if (currentLottery == null)
            {
                MessageBox.Show("No lottery created yet. Please create a lottery first.");
                return;
            }

            currentLottery.DrawAllNumbers();

            foreach (int drawnNumber in currentLottery.GetDrawnNumbers())
            {
                listBox1.Items.Add(drawnNumber.ToString());
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            // Reset the current lottery and clear the displayed numbers
            currentLottery = null;
            listBox1.Items.Clear();
            MessageBox.Show("Lottery reset successfully!");
        }
    }
}
