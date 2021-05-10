namespace Prototype.PrototypeRobots.ImplementWithPrototype.Abstract
{
    public interface IRobot
    {
        string Number { get; set; }
        IRobot Clone();
    }
}
