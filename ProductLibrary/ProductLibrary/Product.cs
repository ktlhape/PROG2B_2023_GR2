using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary
{
    /// <summary>
    /// Product class to store product information
    /// </summary>
    public class Product
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        private static List<Product> productList = new List<Product>();
        /// <summary>
        /// Create a Product object with the Code, Description and the Price
        /// </summary>
        /// <param name="code">Product Code</param>
        /// <param name="desc">Product Description</param>
        /// <param name="price">Product Price</param>
        public Product(string code, string desc, double price)
        {
            Code = code;
            Description = desc;
            Price = price;
        }
        /// <summary>
        /// Add Product to a collection
        /// </summary>
        /// <param name="p">Product to be added</param>
        public static void AddProduct(Product p)
        {
            productList.Add(p);
        }
        /// <summary>
        /// Get all the products from a collection
        /// </summary>
        /// <returns>All products</returns>
        public static List<Product> GetProducts() => productList;
        /// <summary>
        /// Get product information or details
        /// </summary>
        /// <returns>Product details</returns>
        public override string ToString() =>
            $"({Code}) {Description} - {Price.ToString("C2")}";
        
    }
}
