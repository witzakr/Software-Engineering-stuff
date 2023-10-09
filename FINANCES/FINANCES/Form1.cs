using System.Windows.Forms;

namespace FINANCES
{
    public partial class Form1 : Form
    {
        private List<ListItem> items = new List<ListItem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new ListItem object with the name and amount entered
            var item = new ListItem
            {
                Name = textBox1.Text,
                Amount = numericUpDown1.Value
            };

            // Add the new item to the list
            items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the items in the list box
            listBox1.Items.Clear();

            // Add all the items in the list to the list box
            foreach (var item in items)
            {
                listBox1.Items.Add(item);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Clear the items in the list box
            listBox1.Items.Clear();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Get the amount to filter from the numeric up-down control
            var amountToFilter = numericUpDown2.Value;

            // Filter the items list to only include items with the specified amount
            var filteredItems = items.Where(item => item.Amount == amountToFilter);

            // Clear the items in the list box
            listBox1.Items.Clear();

            // Add the filtered items to the list box
            foreach (var item in filteredItems)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
