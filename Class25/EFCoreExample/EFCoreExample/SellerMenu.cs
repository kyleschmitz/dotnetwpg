using System;
using System.Linq;
using EFCoreExample.Data;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExample
{
    public static class SellerMenu
    {
        private const int GET_ALL_SELLERS = 1;
        private const int GET_SELLER_BY_ID = 2;
        private const int CREATE_SELLER = 3;
        private const int ADD_PRODUCT_TO_SELLER = 4;
        private const int DELETE_SELLER = 5;
        private const int RETURN = 6;

        public static void Run()
        {
            bool quit = false;

            while (!quit)
            {
                int menuOption = GetMenuOption();

                switch (menuOption)
                {
                    case GET_ALL_SELLERS:
                        GetAllSellers();
                        break;
                    case GET_SELLER_BY_ID:
                        GetSellerById();
                        break;
                    case CREATE_SELLER:
                        CreateSeller();
                        break;
                    case ADD_PRODUCT_TO_SELLER:
                        AddProductToSeller();
                        break;
                    case DELETE_SELLER:
                        DeleteSeller();
                        break;
                    case RETURN:
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option selected!");
                        break;
                }

                Console.WriteLine();
            }
        }

        private static void GetAllSellers()
        {
            Console.WriteLine();
            using (var context = new ProductContext())
            {
                foreach (var seller in context.Sellers.Include(x => x.Products))
                {
                    Console.WriteLine(seller);
                }
            }
        }

        private static void GetSellerById()
        {
            int sellerId = -1;

            Console.WriteLine();
            Console.Write("Please enter the ID of the seller: ");
            while (!Int32.TryParse(Console.ReadLine(), out sellerId))
            {
                Console.Write("Please enter a valid number: ");
            }

            using (var context = new ProductContext())
            {
                foreach (var seller in context.Sellers.Include(x => x.Products).Where(x => x.Id == sellerId))
                {
                    Console.WriteLine(seller);
                }
            }
        }

        private static void CreateSeller()
        {
            string name;

            Console.WriteLine();
            Console.Write("Enter the name of the seller: ");
            name = Console.ReadLine();
            
            Seller newSeller = new Seller(name);

            using (var context = new ProductContext())
            {
                context.Sellers.Add(newSeller);
                context.SaveChanges();
            }
        }

        private static void AddProductToSeller()
        {
            int sellerId;
            int productId;

            Console.WriteLine();
            Console.Write("Enter the ID of the seller to update: ");
            while (!Int32.TryParse(Console.ReadLine(), out sellerId))
            {
                Console.Write("Please enter a valid id: ");
            }

            Console.Write("Enter the ID of the product to add to the seller: ");
            while (!Int32.TryParse(Console.ReadLine(), out productId))
            {
                Console.Write("Please enter a valid id: ");
            }

            using (var context = new ProductContext())
            {
                Seller seller = context.Sellers.FirstOrDefault(x => x.Id == sellerId);
                Product product = context.Products.FirstOrDefault(x => x.Id == productId);

                if (seller == null)
                {
                    Console.WriteLine("Seller not found!");
                }
                else
                {
                    seller.Products.Add(product);
                }

                context.SaveChanges();
            }
        }

        private static void DeleteSeller()
        {
            int id;

            Console.WriteLine();
            Console.Write("Enter the ID of the seller to delete: ");
            while (!Int32.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("Please enter a valid id: ");
            }

            using (var context = new ProductContext())
            {
                Seller seller = context.Sellers.FirstOrDefault(x => x.Id == id);

                if (seller == null)
                {
                    Console.WriteLine("Seller not found!");
                }
                else
                {
                    context.Sellers.Remove(seller);
                }

                context.SaveChanges();
            }
        }

        static int GetMenuOption()
        {
            int menuOption = -1;

            Console.WriteLine("Select one of the following options:");
            Console.WriteLine($"{GET_ALL_SELLERS} - Get all sellers");
            Console.WriteLine($"{GET_SELLER_BY_ID} - Get seller by Id");
            Console.WriteLine($"{CREATE_SELLER} - Create a seller");
            Console.WriteLine($"{ADD_PRODUCT_TO_SELLER} - Add product to seller");
            Console.WriteLine($"{DELETE_SELLER} - Delete a seller");
            Console.WriteLine($"{RETURN} - Return to main menu");

            Console.Write("Please enter your selection: ");
            while (!Int32.TryParse(Console.ReadLine(), out menuOption))
            {
                Console.Write("Please enter a valid number: ");
            }

            return menuOption;
        }
    }
}
