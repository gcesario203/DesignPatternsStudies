using Implementation;
using Implementation.Factories;

namespace UnitTests
{
    public class FactoryMethodUnitTests
    {
        [Fact]
        public void ShouldCreateABycicle()
        {
            var bycicle = new BycicleFactory().PickUp("Alberto", "Monaco");

            Assert.Equal(bycicle.GetType(), typeof(Bycicle));
        }
        [Fact]
        public void ShouldCreateACar()
        {
            var car = new CarFactory().PickUp("Maria Luiza", "Civic");

            Assert.Equal(car.GetType(), typeof(Car));
        }
    }
}