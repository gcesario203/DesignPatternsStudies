using Implementation.Device;

namespace Implementation.RemoteControl
{
    public class RemoteControlWithVolume : RemoteControl
    {
        public RemoteControlWithVolume(IDevice device) : base(device)
        {
        }

        public void VolumeUp()
        {
            var newVolume = Device.GetVolume() + 1;
            
            Device.SetVolume(newVolume);
        }

        public void VolumeDown()
        {
            var newVolume = Device.GetVolume() - 1;

            Device.SetVolume(newVolume);
        }
    }
}