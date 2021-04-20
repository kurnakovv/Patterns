using Proxy.Models;
using Proxy.Models.Contexts;
using Proxy.Services.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace Proxy.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductDbContext _productDbContext 
                                                = new ProductDbContext();
        public ICollection<Product> GetAll()
        {
            return _productDbContext.Products.ToList();
        }

        public Product GetById(int id)
        {
            var product = _productDbContext.Products.Find(id);

            return product;
        }
    }
}
