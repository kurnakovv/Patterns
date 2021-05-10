namespace Prototype.PrototypeRobots.ImplementWithoutPrototype
{
    public class C3PO_WP
    {
        public string Number { get; set; }
        public bool GoldPlating { get; set; }

        public C3PO_WP(string number, bool goldPlating)
        {
            Number = number;
            GoldPlating = goldPlating;
        }

        public override string ToString()
        {
            return Number + " " + GoldPlating;
        }
    }
}
