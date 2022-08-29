namespace Implementation.Interfaces
{
    public interface IObserver
    {
        void Update(IEnumerable<object> args);
    }
}