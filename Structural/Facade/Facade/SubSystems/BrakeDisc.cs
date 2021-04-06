using System;

namespace Facade.SubSystems
{
    public class BrakeDisc
    {
        public void CreateFriction()
        {
            Console.WriteLine("Brake disc create friction...");
        }

        public void DissipateHeat()
        {
            Console.WriteLine("The brake disc dissipates the generated heat...");
        }
    }
}
