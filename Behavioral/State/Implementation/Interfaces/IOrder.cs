namespace Implementation.Interfaces
{
    public interface IOrder
    {
        public IOrderState State { get; set; }
        void ApprovePayment();
        void RejectPayment();
        void WaitPayment();
        void ShipOrder();
    }
}