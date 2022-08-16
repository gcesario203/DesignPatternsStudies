namespace Implementation.Device
{
    public interface IDevice
    {
        string GetName();
        void SetPower(bool powerStatus);
        bool GetPower();
        int GetVolume();

        void SetVolume(int value);
    }
}