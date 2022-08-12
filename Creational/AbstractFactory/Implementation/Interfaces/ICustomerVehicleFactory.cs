using Implementation.Interfaces;

namespace Implementation.Factories
{
    public interface ICustomerVehicleFactory
    {
        ICustomer CreateCustomer(string customerName);

        IVehicle CreateVehicle(string vehicleName, string customerName);
    }
}