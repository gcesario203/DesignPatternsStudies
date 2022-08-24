namespace Implementation.SmartHouse.Light
{
    public class Light
    {
        public string Name { get; private set; }
        private bool IsOn;

        private int Intensity = 50;

        public Light(string name)
        {
            Name = name;
        }

        public bool GetPowerStatus()
        {
            return IsOn;
        }
        public int GetIntensity()
        {
            return Intensity;
        }

        public bool ToggleLight()
        {
            IsOn = !GetPowerStatus();

            return IsOn;
        }

        public int IncreaseIntensity()
        {
            if (!GetPowerStatus())
            {
                System.Console.WriteLine($"{Name} Desligada!");

                return Intensity;
            }

            if (Intensity >= 100)
                return Intensity;

            Intensity += 1;

            return Intensity;
        }
        public int DecreaseIntensity()
        {
            if (!GetPowerStatus())
            {
                System.Console.WriteLine($"{Name} Desligada!");

                return Intensity;
            }

            if (Intensity <= 0)
                return Intensity;

            Intensity -= 1;

            return Intensity;
        }
    }
}