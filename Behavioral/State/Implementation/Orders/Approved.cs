using Implementation.Interfaces;

namespace Implementation.Orders
{
    public class Approved : IShoppingOrderState
    {
        private string Name = "Pedido aprovado";

        private ShoppingOrder _shoppingOrder;

        public Approved(ShoppingOrder shoppingOrder)
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
            System.Console.WriteLine("Pedido já aprovado");
        }

        public void RejectPayment()
        {
            _shoppingOrder.State = new Rejected(_shoppingOrder);
        }

        public void ShipOrder()
        {
            System.Console.WriteLine("Pedido enviado para o cliente com sucesso");
        }
    }
}