using AbstractFactory.Client;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            new Furniture().Main();
            Console.ReadLine();
        }
    }
}
