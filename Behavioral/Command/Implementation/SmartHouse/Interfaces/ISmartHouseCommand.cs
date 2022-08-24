namespace Implementation.SmartHouse.Interfaces
{
    public interface ISmartHouseCommand
    {
        void Execute();

        void Undo();
    }
}