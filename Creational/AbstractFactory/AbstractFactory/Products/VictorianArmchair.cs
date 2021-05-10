using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products
{
    public class VictorianArmchair : IArmchair
    {
        public string Name => "Victorian armchair";

        public string Purpose()
        {
            return "To sit";
        }
    }
}
