using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutSystem.Models.OfferTypes
{
    public class Free : IOffer
    {
        public string Name { get ; set; }

        public int NumberOfItemsToBuy { get; set; }
        public int NumberOfItemsFree { get; set; }

        public int GetBillableCountAfterOffer(int count)
        {
            int reminder;
            int billableCount = (Math.DivRem(count, (NumberOfItemsToBuy + NumberOfItemsFree), out reminder))* NumberOfItemsToBuy;

            if(reminder > NumberOfItemsToBuy)
            {
                billableCount += NumberOfItemsToBuy;
            }
            else
            {
                billableCount += reminder;
            }
            return billableCount;
        }
    }
}
