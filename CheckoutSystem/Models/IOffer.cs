using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutSystem.Models
{
    public interface IOffer
    {
        string Name { get; set; }

        int GetBillableCountAfterOffer(int count);
    }
}
