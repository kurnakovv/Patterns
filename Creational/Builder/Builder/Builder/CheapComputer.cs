using Builder.Builder.Abstract;
using Builder.Product;
using Builder.Product.Components;

namespace Builder.Builder
{
    class CheapComputer : IComputerBuilder
    {
        private Computer _computer;

        public CheapComputer()
        {
            CreateComputer();
        }

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
            _computer.CPU = new CPU { Power = 500 };
        }

        public void SetDVD_ROM()
        {
            _computer.DVD_ROM = new DVD_ROM { Name = "Cheap DVD_ROM" };
        }

        public void SetGraphicsCard()
        {
            _computer.GraphicsCard = new GraphicsCard { FPS = 30 };
        }

        public void SetMotherboard()
        {
            _computer.Motherboard = new Motherboard { Author = "Amd :)" };
        }

        public void SetRAM()
        {
            _computer.RAM = new RAM { MemoryCount = 4 };
        }
    }
}