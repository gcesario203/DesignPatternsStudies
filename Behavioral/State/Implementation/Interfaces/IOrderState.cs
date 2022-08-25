namespace Implementation.Interfaces
{
    public interface IOrderState
    {
        void ApprovePayment();
        void RejectPayment();
        void WaitPayment();
        void ShipOrder();
    }
}