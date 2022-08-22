using System.Diagnostics.CodeAnalysis;

namespace Implementation.Delivery.DataObjects
{
    public class LocationData : IEqualityComparer<LocationData>
    {
        public Guid Id {get; private set;}
        public string Street { get; set; }

        public string City { get; set; }

        public LocationData()
        {
            Id = Guid.NewGuid();
        }

        public LocationData(string street, string city)
        {
            Id = Guid.NewGuid();

            Street = street;

            City = city;
        }

        public bool Equals(LocationData? x, LocationData? y)
        {
            return x.City == y.City && x.Street == y.Street;
        }

        public int GetHashCode([DisallowNull] LocationData obj)
        {
            return Id.GetHashCode();
        }
    }
}