using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreExample.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }

        public Product()
        {
        }

        public Product(string name, decimal price, int quantityInStock)
        {
            Name = name;
            Price = price;
            QuantityInStock = quantityInStock;
        }
    }
}
