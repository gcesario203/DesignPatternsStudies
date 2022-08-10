using Implementation.Interfaces;

namespace Implementation
{
    public class Car : IVehicle
    {
        public string Name { get;set; }

        public Car(string name)
        {
            Name = name;
        }

        public void PickUp(string customerName)
        {
            System.Console.WriteLine($"O carro {Name} está buscando o {customerName}");
        }

        public void Stop()
        {
            System.Console.WriteLine($"O carro {Name} parou");
        }
    }
}