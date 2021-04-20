using Proxy.Models;
using Proxy.Services;
using Proxy.Services.Abstract;
using System;
using System.Collections.Generic;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use db.
            IProductService productService = new ProductService();
            PrintProducts(productService.GetAll());

            // First appeal to the db.
            productService = new ProductServiceProxy(productService);
            PrintProducts(productService.GetAll());

            // Now appeal to the RAM.
            PrintProducts(productService.GetAll());

            // same with GetById...

            Console.ReadLine();
        }

        private static void PrintProducts(IEnumerable<Product> products)
        {
            foreach(Product product in products)
            {
                Console.WriteLine(product.Name);
            }
        }
    }
}
