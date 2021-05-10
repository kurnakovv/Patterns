using Prototype.PrototypeRobots.ImplementWithoutPrototype;
using Prototype.PrototypeRobots.ImplementWithPrototype;
using Prototype.PrototypeRobots.ImplementWithPrototype.Abstract;
using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Implement witout prototype
            // There will be the same result because we point to the same link.
            var robotArtooDetooWithoutPrototype = new ArtooDetooWP("R2-D2");
            var robotArtooDetooWithoutPrototypeClone = robotArtooDetooWithoutPrototype;
            robotArtooDetooWithoutPrototypeClone.Number = "RD-D2 2.0";
            Console.WriteLine(robotArtooDetooWithoutPrototype);
            Console.WriteLine(robotArtooDetooWithoutPrototypeClone);

            // Here too.
            var robotC3POWithoutPrototype = new C3PO_WP("C-3PO", false);
            var robotC3POWithoutPrototypeClone = robotC3POWithoutPrototype;
            robotC3POWithoutPrototypeClone.Number = "C-3PO";
            robotC3POWithoutPrototypeClone.GoldPlating = true;

            Console.WriteLine(robotC3POWithoutPrototype);
            Console.WriteLine(robotC3POWithoutPrototypeClone);

            Console.ReadLine();
            #endregion

            #region Implement with prototype
            // Pay attention! The result will be different, because we created a clone of the robot, and did not specify a link to the object.
            IRobot robotArtooDetoo = new ArtooDetoo("R2-D2");
            var robotArtooDetooClone = robotArtooDetoo.Clone();
            robotArtooDetooClone.Number = "R2-D2 2.0";
            Console.WriteLine(robotArtooDetoo.Number);
            Console.WriteLine(robotArtooDetooClone.Number);

            // Here too.
            var robotC3PO = new C3PO("C-3PO", false);
            var robotC3PO_Clone = robotC3PO.Clone();
            Console.WriteLine(robotC3PO.Number);
            Console.WriteLine(robotC3PO.GoldPlating);
            Console.WriteLine(robotC3PO_Clone.Number);
            Console.ReadLine();
            #endregion
        }
    }
}
