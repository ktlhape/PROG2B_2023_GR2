using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductLibrary;

namespace TestingProductLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product.AddProduct(new Product("P1", "Coke", 18.00));
            Product.AddProduct(new Product("P2", "Fanta", 19.00));
            Product.AddProduct(new Product("P3", "Milk", 27.00));
            Product.AddProduct(new Product("P4", "Maize", 32.99));
            Product.AddProduct(new Product("P5", "Sprite", 19.50));
            Product.AddProduct(new Product("P6", "Mango", 9.50));
            Product.AddProduct(new Product("P7", "Berries", 53.89));

            foreach (Product p in Product.GetProducts())
            {
                Console.WriteLine($"{p.ToString()}");
            }
            Console.ReadLine();
           



        }
    }
}
