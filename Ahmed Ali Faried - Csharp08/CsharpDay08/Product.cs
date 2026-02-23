using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay08
{
    #region Problem03
    internal class Product : IComparable<Product>
    {
        int Id { get; set; }
        string Name { get; set; }
        double Price { get; set; }
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int CompareTo(Product other)
        {
            if (other == null)
            {
                return 1;
            }

            return this.Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}";
        }
    } 

    #endregion
}
