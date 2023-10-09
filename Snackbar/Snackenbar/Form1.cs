using System;
using System.Windows.Forms;

namespace Snackenbar
{
    public partial class Form1 : Form
    {
        private SnackInventory snackInventory = new SnackInventory();

        private int orderTotal = 0;
        private int revenue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateOrderTotal();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            UpdateOrderTotal();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            UpdateOrderTotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int chipsOrder = (int)numericUpDown1.Value;
            int donutsOrder = (int)numericUpDown2.Value;
            int sodaOrder = (int)numericUpDown3.Value;

            if (snackInventory.CheckStock(chipsOrder, donutsOrder, sodaOrder))
            {
                int orderPrice = snackInventory.GetOrderPrice(chipsOrder, donutsOrder, sodaOrder);
                revenue += orderPrice;

                snackInventory.UpdateStock(chipsOrder, donutsOrder, sodaOrder);

                UpdateOrderTotal();
                label5.Text = $"Total revenue: {revenue} Euro"; ;

                // Reset the current order displayed in label4 to 0
                label4.Text = "Current Order: 0 Euro";
            }
            else
            {
                MessageBox.Show("Out of stock!");
            }
        }
        private void UpdateOrderTotal()
        {
            int chipsOrder = (int)numericUpDown1.Value;
            int donutsOrder = (int)numericUpDown2.Value;
            int sodaOrder = (int)numericUpDown3.Value;

            int orderPrice = snackInventory.GetOrderPrice(chipsOrder, donutsOrder, sodaOrder);
            label4.Text = $"Current order: {orderPrice} Euro";

            if (orderPrice == 0)
            {
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                numericUpDown3.Value = 0;
            }
        }
    }
}