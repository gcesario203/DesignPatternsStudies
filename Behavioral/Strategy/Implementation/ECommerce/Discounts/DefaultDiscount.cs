using Implementation.ECommerce.Abstractions;

namespace Implementation.ECommerce.Discounts
{
    public class DefaultDiscount : DiscountStrategy
    {
        public override decimal GetDiscount(ShoppingCart cart)
        {
            var total = cart.GetTotalPrice();

            Discount = GetDiscountPercentual(total);

            return total - total * (Discount / 100);
        }

        private decimal GetDiscountPercentual(decimal total)
        {
            if(total >= 100 && total < 200)
                return 10;

            if(total >= 200 && total < 300)
                return 20;

            if(total >= 300)
                return 30;

            return 0;
        }
    }
}