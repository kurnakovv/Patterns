using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products
{
    public class ModernSofa : ISofa
    {
        public string Name => "Modern sofa";

        public string Purpose()
        {
            return "To lay";
        }
    }
}
