using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products
{
    public class VictorianTable : ITable
    {
        public string Name => "Victorian table";

        public string Purpose()
        {
            return "To put";
        }
    }
}
