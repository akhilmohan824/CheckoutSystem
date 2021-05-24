using CheckoutSystem.Models.OfferTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutSystem.Models
{
    public static class Store
    {
        public static string Name { get; set; }

        public static Dictionary<string, Item> Items { get; set; } = new Dictionary<string, Item>();

        public static void Load()
        {
            Name = "ABC Store";
            LoadItems();
        }

        private static void LoadItems()
        {
            /**TODO: This should be loaded from XML**/
            Item item = new Item();
            item.Name = "Apple";
            item.Price = .25;
            Free free = new Free();
            free.NumberOfItemsFree = 2;
            free.NumberOfItemsToBuy = 3;
            free.Name = "Free";
            item.Offer = free;

            Items.Add("Apple", item);

            item = new Item();
            item.Name = "Avocado";
            item.Price = .10;
            item.Offer = null;

            Items.Add("Avocado", item);
        }

    }
}
