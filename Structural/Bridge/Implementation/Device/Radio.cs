namespace Implementation.Device
{
    public class Radio : IDevice
    {
        private int Volume;
        private string Name;
        private bool Power;

        public Radio()
        {
            Name = "Radio";
        }
        public string GetName()
        {
            return Name;
        }

        public bool GetPower()
        {
            return Power;
        }

        public int GetVolume()
        {
            return Volume;
        }

        public void SetPower(bool powerStatus)
        {
            Power = powerStatus;
        }

        public void SetVolume(int value)
        {
            Volume = value;
        }
    }
}