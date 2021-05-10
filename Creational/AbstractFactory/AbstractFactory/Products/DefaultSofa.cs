using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products
{
    public class DefaultSofa : ISofa
    {
        public string Name => "Default sofa";

        public string Purpose()
        {
            return "To lay";
        }
    }
}
