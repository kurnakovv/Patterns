using FactoryMethod.Products.Abstract;

namespace FactoryMethod.Products
{
    // For simplicity, I did not implement products in different ways.
    public class Fish : IProduct
    {
        public string Name { get; set; }

        public Fish(string name = "Fish")
        {
            Name = name;
        }

        public string GetProduct()
        {
            return Name;
        }
    }
}
