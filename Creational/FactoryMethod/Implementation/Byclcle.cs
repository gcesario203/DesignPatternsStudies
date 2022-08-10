using Implementation.Interfaces;

namespace Implementation
{
    public class Bycicle : IVehicle
    {
        public string Name { get; set; }
        
        public Bycicle(string name)
        {
            Name = name;
        }

        public void PickUp(string customerName)
        {
            System.Console.WriteLine($"A bicicleta {Name} está buscando o {customerName}");
        }

        public void Stop()
        {
            System.Console.WriteLine($"A bicicleta {Name} parou");
        }
    }
}