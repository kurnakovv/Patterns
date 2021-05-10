using FactoryMethod.Creators;
using FactoryMethod.Creators.Abstract;

namespace FactoryMethod.Clients
{
    class Client
    {
        public void Main()
        {
            System.Console.WriteLine("Petrol in transit...");
            ClientMethod(new Truck());

            System.Console.WriteLine("Fish in transit...");
            ClientMethod(new Ship());
        }

        public void ClientMethod(TransportBase transportBase)
        {
            System.Console.WriteLine(transportBase.PrintMessageAboutDelive());
        }
    }
}
