using FactoryMethod.Products.Abstract;

namespace FactoryMethod.Creators.Abstract
{
    public interface ITransport
    {
        IProduct DeliveProduct();
        string PrintMessageAboutDelive();
    }
}
