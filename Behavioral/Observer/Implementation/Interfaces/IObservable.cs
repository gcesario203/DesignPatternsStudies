namespace Implementation.Interfaces
{
    public interface IObservable
    {
        void Subscribe(params IObserver[] observers);

        void Unsubscribe(params IObserver[] observers);

        void Notify();
    }
}