using FactoryMethod.Creators.Abstract;
using FactoryMethod.Products;
using FactoryMethod.Products.Abstract;

namespace FactoryMethod.Creators
{
    public class Truck : TransportBase
    {
        public override IProduct DeliveProduct()
        {
            return new Petrol();
        }
    }
}
