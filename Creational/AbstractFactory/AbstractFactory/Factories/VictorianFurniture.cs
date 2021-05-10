using AbstractFactory.Factories.Abstract;
using AbstractFactory.Products;
using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Factories
{
    public class VictorianFurniture : IFurniture
    {
        public IArmchair CreateArmchair()
        {
            return new VictorianArmchair();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }

        public ITable CreateTable()
        {
            return new VictorianTable();
        }
    }
}
