using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products
{
    public class ModernTable : ITable
    {
        public string Name => "Modern table";

        public string Purpose()
        {
            return "To put";
        }
    }
}
