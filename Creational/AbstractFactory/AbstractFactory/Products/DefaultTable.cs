using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products
{
    class DefaultTable : ITable
    {
        public string Name => "Default table";

        public string Purpose()
        {
            return "To put";
        }
    }
}
