using System.Diagnostics.CodeAnalysis;

namespace Implementation.DataObjects
{
    public class Customer : IEqualityComparer<Customer>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Cpf { get; set; }

        public Customer(string name, int age, string cpf)
        {
            Name = name;
            Age = age;
            Cpf = cpf;
        }

        public bool Equals(Customer? x, Customer? y)
        {
            return x.Cpf == y.Cpf;
        }

        public int GetHashCode([DisallowNull] Customer obj)
        {
            return base.GetHashCode();
        }
    }
}