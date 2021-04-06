using Facade.Facades;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var carFacade = new CarFacade();
            carFacade.Start();
            carFacade.Stop();
        }
    }
}
