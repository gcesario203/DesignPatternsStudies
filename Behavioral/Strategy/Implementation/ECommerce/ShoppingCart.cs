using Implementation.ECommerce.Abstractions;
using Implementation.ECommerce.Discounts;
using Implementation.ECommerce.Interfaces;

namespace Implementation.ECommerce
{
    public class ShoppingCart
    {
        public List<IProduct> Products { get; private set; } = new List<IProduct>();

        private DiscountStrategy DiscountStrategy;

        public ShoppingCart()
        {
            DiscountStrategy = new DefaultDiscount(); 
        }

        public ShoppingCart(DiscountStrategy discountStrategy)
        {
            DiscountStrategy = discountStrategy;
        }

        public void AddProducts(params IProduct[] products)
        {
            Products.AddRange(products);
        }

        public decimal GetTotalPrice()
        {
            return Products.Sum(x => x.Price);
        }

        public Decimal GetTotalPriceWithDiscount()
        {
            return DiscountStrategy.GetDiscount(this);
        }
    }
}