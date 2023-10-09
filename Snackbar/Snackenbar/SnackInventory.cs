using System;

namespace Snackenbar
{
    public class SnackInventory
    {
        private int chipsPrice = 9;
        private int donutsPrice = 6;
        private int sodaPrice = 3;

        private int chipsQuantity = 10;
        private int donutsQuantity = 10;
        private int sodaQuantity = 10;

        public bool CheckStock(int chipsOrder, int donutsOrder, int sodaOrder)
        {
            return chipsOrder <= chipsQuantity && donutsOrder <= donutsQuantity && sodaOrder <= sodaQuantity;
        }

        public int GetOrderPrice(int chipsOrder, int donutsOrder, int sodaOrder)
        {
            int orderPrice = (chipsOrder * chipsPrice) + (donutsOrder * donutsPrice) + (sodaOrder * sodaPrice);
            return orderPrice;
        }

        public void UpdateStock(int chipsOrder, int donutsOrder, int sodaOrder)
        {
            chipsQuantity -= chipsOrder;
            donutsQuantity -= donutsOrder;
            sodaQuantity -= sodaOrder;
     
        }


    }

}

