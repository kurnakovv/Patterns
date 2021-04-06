using Facade.SubSystems;

namespace Facade.Facades
{
    public class CarFacade
    {
        public CarFacade()
        {
            _brakeDisc = new BrakeDisc();
            _engine = new Engine();
            _generator = new Generator();
        }

        private readonly BrakeDisc _brakeDisc;
        private readonly Engine _engine;
        private readonly Generator _generator;

        public void Start()
        {
            _engine.Start();
            _generator.ConvertEnergyToAmperage();
            _brakeDisc.CreateFriction();
        }

        public void Stop()
        {
            _brakeDisc.DissipateHeat();
            _engine.Stop();
        }
    }
}
