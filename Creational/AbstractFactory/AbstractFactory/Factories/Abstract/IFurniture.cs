using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Factories.Abstract
{
    public interface IFurniture
    {
        IArmchair CreateArmchair();
        ITable CreateTable();
        ISofa CreateSofa();
    }
}
