using Implementation.Delivery.DataObjects;
using Implementation.Delivery.Interfaces;

namespace Implementation.Delivery.Factories
{
    public class DeliveryFactory
    {
        public IDictionary<Guid, DeliveryLocation> Locations {get; private set;}

        public DeliveryFactory()
        {
            Locations = new Dictionary<Guid, DeliveryLocation>();
        }
        public IDeliveryFlyweight MakeLocation(LocationData intrinsicState)
        {
            var existingDeliveryLocation = Locations.FirstOrDefault(x => x.Key == intrinsicState.Id).Value;

            if(existingDeliveryLocation == null)
            {
                var newDeliveryLocation = new DeliveryLocation(intrinsicState);

                Locations.Add(intrinsicState.Id, newDeliveryLocation);

                return newDeliveryLocation;
            }

            return existingDeliveryLocation;
        }
    }
}