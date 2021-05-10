using FactoryMethod.Clients;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
            Console.ReadLine();
        }
    }
}
