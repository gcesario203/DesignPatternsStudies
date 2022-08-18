using Implementation.Product.Interface;

namespace Implementation.Product.Decorator
{
    public class ProductDecorator : IProduct
    {
        public IProduct Product {get; private set;}

        public ProductDecorator(IProduct product)
        {
            Product = product;
        }
        public virtual string GetName()
        {
            return Product.GetName();
        }

        public virtual decimal GetPrice()
        {
            return Product.GetPrice();
        }
    }
}