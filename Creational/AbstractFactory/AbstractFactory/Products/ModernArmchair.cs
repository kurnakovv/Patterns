using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products
{
    public class ModernArmchair : IArmchair
    {
        public string Name => "Modern armchair";

        public string Purpose()
        {
            return "To sit";
        }
    }
}
