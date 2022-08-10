using Implementation.Interfaces;

namespace Implementation.Factories
{
    public class BycicleFactory : VehicleFactory
    {
        public override IVehicle GetVehicle(string vehicleName)
        {
            return new Bycicle(vehicleName);
        }
    }
}