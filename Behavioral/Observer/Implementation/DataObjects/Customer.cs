using System.Diagnostics.CodeAnalysis;
using Implementation.Interfaces;

namespace Implementation.DataObjects
{
    public class Customer : IObserver, IEqualityComparer<Customer>
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; private set; }

        public string Email { get; private set; }

        public HashSet<Bulletin> Bulletins { get; set; } = new HashSet<Bulletin>();

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }
        public void Update(IEnumerable<object> args) =>            
            Bulletins = new HashSet<Bulletin>(args.Select(x => (Bulletin)x));

        public bool Equals(Customer? x, Customer? y)
        {
            return x.Email == y.Email;
        }

        public int GetHashCode([DisallowNull] Customer obj)
        {
            return base.GetHashCode();
        }
    }
}