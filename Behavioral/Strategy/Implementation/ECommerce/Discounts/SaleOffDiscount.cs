using Implementation.ECommerce.Abstractions;

namespace Implementation.ECommerce.Discounts
{
    public class SaleOffDiscount : DiscountStrategy
    {
        public override decimal GetDiscount(ShoppingCart cart)
        {
            var total = cart.GetTotalPrice();
            Discount = 50M;

            return total - total * ( Discount / 100 );
        }
    }
}