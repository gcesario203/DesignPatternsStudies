using Implementation.Interfaces;

namespace Implementation.Orders
{
    public class Rejected : IShoppingOrderState
    {
        private string Name = "Pedido reprovado";

        private ShoppingOrder _shoppingOrder;

        public Rejected(ShoppingOrder shoppingOrder)
        {
            _shoppingOrder = shoppingOrder;
        }

        public string GetName()
        {
            return Name;
        }

        public void WaitPayment()
        {
            _shoppingOrder.State = new Pending(_shoppingOrder);
        }

        public void ApprovePayment()
        {
            _shoppingOrder.State = new Approved(_shoppingOrder);
        }

        public void RejectPayment()
        {
            System.Console.WriteLine("Pedido já reprovado");
        }

        public void ShipOrder()
        {
            System.Console.WriteLine("Pedido NEGADO!!!!!");
        }
    }
}