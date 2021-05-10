using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products
{
    public class VictorianSofa : ISofa
    {
        public string Name => "Victorian sofa";

        public string Purpose()
        {
            return "To lay";
        }
    }
}
