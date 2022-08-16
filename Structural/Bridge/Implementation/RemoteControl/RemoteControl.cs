using Implementation.Device;

namespace Implementation.RemoteControl
{
    public class RemoteControl
    {
        protected IDevice Device {get;set;}

        public RemoteControl(IDevice device)
        {
            Device = device;
        }

        public void TogglePower()
        {
            Device.SetPower(!Device.GetPower());
        }
    }
}