using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Best_Oil
{
    public class FastFood
    {
        public string? Name { get; set; }
        public int Price { get; set; }


        public FastFood(string? name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
