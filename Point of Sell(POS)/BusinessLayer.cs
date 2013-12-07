using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Point_of_Sell_POS_
{
    class BusinessLayer
    {

    }

    public class Item{
        public string Name { get; set;}
        public decimal Price { get; set;}

}

    public class Cart{
        public List<Item> Items { get; set; }
      //   List<Item> Items = new List<Item>();
        public void AddItem(Item item)
    {
        Items.Add(item);
}

        public decimal ComputeTotal()
        {
            decimal total = 0;
            foreach (Item k in Items)
                total += k.Price;
            return total;
        }

    }
    }


