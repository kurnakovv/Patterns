using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton1 = SingletonLazyGovernmentDecree.SingleInstance;
            var singleton2 = SingletonLazyGovernmentDecree.SingleInstance;

            // No conflict
            singleton1.MakeGovernmentDecree("Decree 1 Repair Roads");
            singleton2.MakeGovernmentDecree("Decree 2 Build a Bridge");
        }
    }
}
