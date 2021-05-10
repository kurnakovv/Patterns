using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products
{
    public class DefaultArmchair : IArmchair
    {
        public string Name => "Default armchair";

        public string Purpose()
        {
            return "To sit";
        }
    }
}
