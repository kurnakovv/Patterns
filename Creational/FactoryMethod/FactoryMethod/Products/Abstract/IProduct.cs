namespace FactoryMethod.Products.Abstract
{
    public interface IProduct
    {
        string Name { get; set; }
        string GetProduct();
    }
}
