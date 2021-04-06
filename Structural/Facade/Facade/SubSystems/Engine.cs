using System;

namespace Facade.SubSystems
{
    public class Engine
    {
        public void Start()
        {
            Console.WriteLine("Engine starts and heats up...");
        }

        public void Stop()
        {
            Console.WriteLine("The engine stops and cools down...");
        }
    }
}
