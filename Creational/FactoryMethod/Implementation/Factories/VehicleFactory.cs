using Implementation.Interfaces;

namespace Implementation.Factories
{
    public abstract class VehicleFactory : IVehicleFactory
    {
        public abstract IVehicle GetVehicle(string vehicleName);

        public IVehicle PickUp(string customerName, string vehicleName)
        {
            IVehicle vehicle = GetVehicle(vehicleName);

            vehicle.PickUp(customerName);

            return vehicle;
        }
    }
}