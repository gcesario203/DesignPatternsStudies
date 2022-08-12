using Implementation.Interfaces;

namespace Implementation.Models
{
    public class IndividualCar : IVehicle
    {
        public string Name { get; set; }
        private ICustomer Customer { get; set; }

        public IndividualCar(string name, ICustomer customer)
        {
            Name = name;

            Customer = customer;
        }
        public void PickUp()
        {
            System.Console.WriteLine($"{Name} - {this.GetType().Name} está buscando {Customer.Name} do tipo: {Customer.GetType().Name}");
        }
    }
}