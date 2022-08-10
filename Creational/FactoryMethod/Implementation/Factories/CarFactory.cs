using Implementation.Interfaces;

namespace Implementation.Factories
{
    public class CarFactory : VehicleFactory
    {
        public override IVehicle GetVehicle(string vehicleName)
        {
            return new Car(vehicleName);
        }
    }
}