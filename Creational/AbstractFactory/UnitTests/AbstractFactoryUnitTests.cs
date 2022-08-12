using Implementation.Factories;
using Implementation.Models;

namespace UnitTests
{
    public class AbstractFactoryUnitTests
    {
        [Fact]
        public void ShouldCreateIndividualCar()
        {
            var individualCustomerFactory = new IndividualCustomerFactory();

            var vehicle = individualCustomerFactory.CreateVehicle("Corsa Sedan", "Alberto");

            Assert.IsType(typeof(IndividualCar), vehicle);
        }
        [Fact]
        public void ShouldCreateEnterpriseCar()
        {
            var EnterpriseCustomerFactory = new EnterpriseCustomerFactory();

            var vehicle = EnterpriseCustomerFactory.CreateVehicle("Civic Type R", "Fernanda");

            Assert.IsType(typeof(EnterpriseCar), vehicle);
        }
    }
}