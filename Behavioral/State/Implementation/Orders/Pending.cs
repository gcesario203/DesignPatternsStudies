using Implementation.Interfaces;

namespace Implementation.Orders
{
    public class Pending : IShoppingOrderState
    {
        private string Name = "Pedido pendente";

        private ShoppingOrder _shoppingOrder;

        public Pending(ShoppingOrder shoppingOrder)
        {
            _shoppingOrder = shoppingOrder;
        }

        public string GetName()
        {
            return Name;
        }

        public void WaitPayment()
        {
            System.Console.WriteLine("Pedido já se encontra pendente");
        }

        public void ApprovePayment()
        {
            _shoppingOrder.State = new Approved(_shoppingOrder);
        }

        public void RejectPayment()
        {
            _shoppingOrder.State = new Rejected(_shoppingOrder);
        }

        public void ShipOrder()
        {
            System.Console.WriteLine("Pedido pendente e sem pagamento");
        }
    }
}