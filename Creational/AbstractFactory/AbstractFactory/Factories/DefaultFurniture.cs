using AbstractFactory.Factories.Abstract;
using AbstractFactory.Products;
using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Factories
{
    public class DefaultFurniture : IFurniture
    {
        public IArmchair CreateArmchair()
        {
            return new DefaultArmchair();
        }

        public ISofa CreateSofa()
        {
            return new DefaultSofa();
        }

        public ITable CreateTable()
        {
            return new DefaultTable();
        }
    }
}
