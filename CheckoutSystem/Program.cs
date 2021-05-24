using CheckoutSystem.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace CheckoutSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Store.Load();

            List<string> itemsBought = ItemsBought.GetListOfItemsBought();

            CheckOut.CalculateBillAmount(itemsBought);

            Console.Read();
        }

    }
}
