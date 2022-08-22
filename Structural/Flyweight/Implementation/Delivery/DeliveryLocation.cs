using Implementation.Delivery.DataObjects;
using Implementation.Delivery.Interfaces;

namespace Implementation.Delivery
{
    public class DeliveryLocation : IDeliveryFlyweight
    {
        private readonly LocationData _intrinsicState;

        public DeliveryLocation(LocationData intrinsicState)
        {
            _intrinsicState = intrinsicState;
        }
        public void Deliver(string name, string number)
        {
            System.Console.WriteLine($"Entrega para {name}");

            System.Console.WriteLine($"Em {_intrinsicState.Street} - {_intrinsicState.City}, número: {number}");
        }
    }
}