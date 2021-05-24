using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CheckoutSystem
{
    public class ItemsBought
    {
        public static List<string> GetListOfItemsBought()
        {
            string _itemsBought = File.ReadAllText("./../../../BoughtItems.txt");
            List<string> itemsBought = new List<string>(_itemsBought.Substring(1, _itemsBought.Length - 2).Split(','));
            
            for(int i=0; i<itemsBought.Count; i++)
            {
                itemsBought[i] = itemsBought[i].Trim();
            }

            return itemsBought;
        }
    }
}
