using Implementation.Interfaces;

namespace Implementation.DataObjects
{
    public class NewsLetter : IObservable
    {
        private HashSet<IObserver> Subscribers = new HashSet<IObserver>();

        public HashSet<Bulletin> Bulletins { get; private set; } = new HashSet<Bulletin>();

        public void Subscribe(params IObserver[] subscribers)
        {
            foreach (var subscriber in subscribers)
                Subscribers.Add(subscriber);
        }

        public void Unsubscribe(params IObserver[] subscribers)
        {
            foreach (var subscriber in subscribers)
                Subscribers.Remove(subscriber);
        }

        public int GetTotalSubscribers() => Subscribers.Count();

        public void Notify()
        {
            foreach (var subscriber in Subscribers)
                subscriber.Update(Bulletins);
        }

        public void AddBulletins(params Bulletin[] bulletins)
        {
            foreach (var bulletin in bulletins)
                Bulletins.Add(bulletin);

            Notify();
        }

        public void RemoveBulletins(params Bulletin[] bulletins)
        {
            foreach (var bulletin in bulletins)
                Bulletins.Remove(bulletin);

            Notify();
        }
    }
}