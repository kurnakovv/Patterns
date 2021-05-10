using Builder.Builder.Abstract;
using Builder.Product;
using Builder.Product.Components;

namespace Builder.Builder
{
    public class ExprensiveComputer : IComputerBuilder
    {
        private Computer _computer;
        public Computer CreateComputer()
        {
            _computer = new Computer();
            return _computer;
        }

        public Computer GetComputer()
        {
            Computer result = CreateComputer();
            return result;
        }

        public void SetCPU()
        {
            _computer.CPU = new CPU { Power = 10000 };
        }

        public void SetDVD_ROM()
        {
            _computer.DVD_ROM = new DVD_ROM { Name = "Super exprensive DVD_ROM" };
        }

        public void SetGraphicsCard()
        {
            _computer.GraphicsCard = new GraphicsCard { FPS = 90 };
        }

        public void SetMotherboard()
        {
            _computer.Motherboard = new Motherboard { Author = "Intel" };
        }

        public void SetRAM()
        {
            _computer.RAM = new RAM { MemoryCount = 64 };
        }
    }
}
