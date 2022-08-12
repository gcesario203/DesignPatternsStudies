using Implementation.Interfaces;
using Implementation.Models;

namespace Implementation.Factories
{
    public class EnterpriseCustomerFactory : ICustomerVehicleFactory
    {
        public ICustomer CreateCustomer(string customerName)
        {
            return new EnterpriseCustomer(customerName);
        }

        public IVehicle CreateVehicle(string vehicleName, string customerName)
        {
            var customer = CreateCustomer(customerName);

            var vehicle = new EnterpriseCar(vehicleName, customer);

            vehicle.PickUp();

            return vehicle;
        }
    }
}