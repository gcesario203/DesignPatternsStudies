using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Implementation.Interfaces;
using Implementation.Models;

namespace Implementation.Factories
{
    public class IndividualCustomerFactory : ICustomerVehicleFactory
    {
        public ICustomer CreateCustomer(string customerName)
        {
            return new IndividualCustomer(customerName);
        }

        public IVehicle CreateVehicle(string vehicleName, string customerName)
        {
            var customer = CreateCustomer(customerName);

            var vehicle = new IndividualCar(vehicleName, customer);

            vehicle.PickUp();

            return vehicle;
        }
    }
}