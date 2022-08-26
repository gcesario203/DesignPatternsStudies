using System.Diagnostics.CodeAnalysis;

namespace Implementation.DataObjects
{
    public class Product : IEqualityComparer<Product>
    {
        public Guid Id { get; private set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Id = Guid.NewGuid();

            Name = name;

            Price = price;
        }
        public bool Equals(Product? x, Product? y) => x?.Id == y?.Id;

        public int GetHashCode([DisallowNull] Product obj) => obj.Id.GetHashCode();
    }
}