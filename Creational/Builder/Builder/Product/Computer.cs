using Builder.Product.Components;

namespace Builder.Product
{
    public class Computer
    {
        public CPU CPU { get; set; }
        public DVD_ROM DVD_ROM { get; set; }
        public GraphicsCard GraphicsCard { get; set; }
        public Motherboard Motherboard { get; set; }
        public RAM RAM { get; set; }
    }
}
