using System;
using DeliveryExample.MailTypes;

namespace DeliveryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Address origin = new Address("123 Origin St", "R3A2B9", "Winnipeg");
            Address destination = new Address("456 Destination St", "V3N5P8", "Vancouver");
            
            Package package = new Package(origin, destination);

            package.Products.Add(new Product("Chair"));
            package.Products.Add(new Product("Pillow"));
            package.Products.Add(new Product("Blanket"));

            Console.WriteLine(package.GetInformation());

            Console.WriteLine();
            Console.WriteLine(package.GetProductInformation());
            
            Console.ReadKey();
        }
    }
}
