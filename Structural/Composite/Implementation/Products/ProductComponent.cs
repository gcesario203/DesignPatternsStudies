namespace Implementation.Products
{
    public abstract class ProductComponent
    {
        public abstract decimal GetPrice();

        public virtual void Add(params ProductComponent[] products)
        {}
        public virtual void Remove(params ProductComponent[] products)
        {}
    }
}