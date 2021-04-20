using Proxy.Models;
using Proxy.Services.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace Proxy.Services
{
    public class ProductServiceProxy : IProductService
    {
        public ProductServiceProxy(
            IProductService productService)
        {
            _products = new List<Product>();
            _productService = productService;
        }

        private ICollection<Product> _products;
        private readonly IProductService _productService;

        public ICollection<Product> GetAll()
        {
            ICollection<Product> products = _products.ToList();
            
            if(products.Count == 0)
            {
                _products = _productService.GetAll();
                products = _products;
            }

            return products;
        }

        public Product GetById(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);

            if(product == null)
            {
                product = _productService.GetById(id);

                _products.Add(product);
            }

            return product;
        }
    }
}
