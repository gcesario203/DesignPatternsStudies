namespace Implementation.Products
{
    public class ProductLeaf : ProductComponent
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ProductLeaf(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override decimal GetPrice()
        {
            return Price;
        }
    }
}