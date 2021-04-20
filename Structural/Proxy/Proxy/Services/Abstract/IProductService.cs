using Proxy.Models;
using System.Collections.Generic;

namespace Proxy.Services.Abstract
{
    public interface IProductService
    {
        ICollection<Product> GetAll();
        Product GetById(int id);
    }
}
