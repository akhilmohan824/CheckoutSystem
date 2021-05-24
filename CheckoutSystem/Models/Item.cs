using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutSystem.Models
{
    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public IOffer Offer { get; set; }

        public double calculatePriceForAmount(int count)
        {
            int billableCount = count;
            if (Offer != null)
            {
                billableCount = Offer.GetBillableCountAfterOffer(count);
            }

            return billableCount * Price;
        }
    }
}
