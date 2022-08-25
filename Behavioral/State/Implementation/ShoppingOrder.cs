using Implementation.Interfaces;
using Implementation.Orders;

namespace Implementation
{
    public class ShoppingOrder : IOrder
    {
        private IOrderState _state;

        public IOrderState State
        {
            get { return _state; }
            set
            {
                if (value is IOrderState)
                    _state = value;
            }
        }

        public ShoppingOrder()
        {
            _state = new Pending(this);
        }

        public string GetStateName()
        {
            if(!(State is IShoppingOrderState))
                return "";

            var iShoppingOrderState = State as IShoppingOrderState;

            return iShoppingOrderState.GetName();
        }

        public void ApprovePayment()
        {
            State.ApprovePayment();
        }

        public void RejectPayment()
        {
            State.RejectPayment();
        }

        public void WaitPayment()
        {
            State.WaitPayment();
        }

        public void ShipOrder()
        {
            State.ShipOrder();
        }
    }
}