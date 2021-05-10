using AbstractFactory.Factories.Abstract;
using AbstractFactory.Products;
using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Factories
{
    public class ModernFurniture : IFurniture
    {
        public IArmchair CreateArmchair()
        {
            return new ModernArmchair();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }

        public ITable CreateTable()
        {
            return new ModernTable();
        }
    }
}
