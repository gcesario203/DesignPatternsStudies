namespace Implementation.Device
{
    public class TV : IDevice
    {
        private int Volume;
        private string Name;
        private bool Power;

        public TV()
        {
            Name = "TV";
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
            if(value < 0 || value > 100)
                return;
            
            Volume = value;
        }
    }
}