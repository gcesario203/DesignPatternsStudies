using Implementation.Product.Interface;

namespace Implementation.Product.Decorator
{
    public class ProductStampDecorator : ProductDecorator
    {
        public ProductStampDecorator(IProduct product) : base(product)
        {
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() + 10M;
        }
    }
}