using CheckoutSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckoutSystem
{
    public class CheckOut
    {

        public static void CalculateBillAmount(List<string> itemsBought)
        {
            var itemsGroup = itemsBought.GroupBy(item => item);

            double totalPrice = 0;

            foreach(var item in itemsGroup)
            {
                totalPrice += Store.Items[item.Key].calculatePriceForAmount(item.Count());
            }

            Console.WriteLine($"Total Bill Amount: ${String.Format("{0:0.00}", totalPrice)}");
        }
    }
}
