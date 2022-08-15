namespace Implementation.Products
{
    public class ProductComposer : ProductComponent
    {

        public List<ProductLeaf> Children { get; private set; } = new List<ProductLeaf>();

        public override void Add(params ProductComponent[] products)
        {
            Children.AddRange(products.Select(x => (ProductLeaf)x));
        }

        public override void Remove(params ProductComponent[] products)
        {
            var productsList = products.Select(x => (ProductLeaf)x).ToArray();

            Children.RemoveAll(x => productsList.Select(x => x.Name).Contains(x.Name));
        }
        public override decimal GetPrice()
        {
            return Children.Sum(x => x.GetPrice());
        }
    }
}