using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass232
{
    class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public int CompareTo(Product other)
        {
            //return this.Price - other.Price;
            //return this.Price.CompareTo(other.Price);
            return this.Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return this.Name + " : " + this.Price + " ¿ø";
        }
    }
}