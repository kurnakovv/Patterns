using Builder.Builder.Abstract;

namespace Builder.Director
{
    public class Manager
    {
        private IComputerBuilder _computerBuilder;

        public IComputerBuilder ComputerBuilder { set { _computerBuilder = value; } }

        public void SellComputerWithoutDVD_ROM()
        {
            _computerBuilder.CreateComputer();
            _computerBuilder.SetCPU();
            _computerBuilder.SetGraphicsCard();
            _computerBuilder.SetMotherboard();
            _computerBuilder.SetRAM();
            _computerBuilder.GetComputer();
        }

        public void SellFullComputer()
        {
            _computerBuilder.CreateComputer();
            _computerBuilder.SetCPU();
            _computerBuilder.SetGraphicsCard();
            _computerBuilder.SetMotherboard();
            _computerBuilder.SetRAM();
            _computerBuilder.SetDVD_ROM();
            _computerBuilder.GetComputer();
        }
    }
}
