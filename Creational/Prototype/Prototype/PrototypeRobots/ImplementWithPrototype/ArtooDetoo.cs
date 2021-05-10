using Prototype.PrototypeRobots.ImplementWithPrototype.Abstract;

namespace Prototype.PrototypeRobots.ImplementWithPrototype
{
    public class ArtooDetoo : IRobot
    {
        public string Number { get; set; }

        public ArtooDetoo(string number)
        {
            Number = number;
        }

        public IRobot Clone()
        {
            return new ArtooDetoo(Number);
        }
    }
}
