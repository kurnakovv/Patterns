using Builder.Product;

namespace Builder.Builder.Abstract
{
    public interface IComputerBuilder
    {
        Computer CreateComputer();
        void SetMotherboard();
        void SetCPU();
        void SetRAM();
        void SetGraphicsCard();
        void SetDVD_ROM();
        Computer GetComputer();
    }
}
