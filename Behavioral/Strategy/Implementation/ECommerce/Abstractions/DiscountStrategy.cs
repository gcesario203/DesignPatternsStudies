namespace Implementation.ECommerce.Abstractions
{
    public abstract class DiscountStrategy
    {
        protected decimal Discount = 0M;

        public abstract decimal GetDiscount(ShoppingCart cart);
    }
}