using System;
using System.Threading;
using Bridge.Abstractions.Abstract;

namespace Bridge.Abstractions
{
    public class MacOSAPI : IAPIFramework
    {
        public void Request()
        {
            Console.WriteLine("Process the request using Mac OS...");
            Thread.Sleep(1000);
        }
    }
}