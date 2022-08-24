using Implementation.SmartHouse.Interfaces;

namespace Implementation.SmartHouse.Light.Commands
{
    public class PowerCommand : ISmartHouseCommand
    {
        private readonly Light _light;

        public PowerCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            if (_light.GetPowerStatus())
                return;

            _light.ToggleLight();
        }

        public void Undo()
        {
            if (!_light.GetPowerStatus())
                return;

            _light.ToggleLight();
        }
    }
}