using Implementation.SmartHouse.Interfaces;

namespace Implementation.SmartHouse.Light.Commands
{
    public class IntensityCommand : ISmartHouseCommand
    {
        private readonly Light _light;

        public IntensityCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.IncreaseIntensity();
        }

        public void Undo()
        {
            _light.DecreaseIntensity();
        }
    }
}