using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9Group5MVVM
{
    class RetailItem
    {
        public string Description { get; set; }
        public int UnitOnHand { get; set; }
        public double Price { get; set; }

        public RetailItem(string description, int unitOnHand, double price)
        {
            Description = description;
            UnitOnHand = unitOnHand;
            Price = price;
        }
    }
}
