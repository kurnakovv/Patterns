using FactoryMethod.Creators.Abstract;
using FactoryMethod.Products;
using FactoryMethod.Products.Abstract;

namespace FactoryMethod.Creators
{
    public class Ship : TransportBase
    {
        public override IProduct DeliveProduct()
        {
            return new Fish();
        }
    }
}
