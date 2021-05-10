using FactoryMethod.Products.Abstract;

namespace FactoryMethod.Products
{
    // For simplicity, I did not implement products in different ways.
    class Petrol : IProduct
    {
        public string Name { get; set; }

        public Petrol(string name = "Petrol")
        {
            Name = name;
        }

        public string GetProduct()
        {
            return Name;
        }
    }
}
