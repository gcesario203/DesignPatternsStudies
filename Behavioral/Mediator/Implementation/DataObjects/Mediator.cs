namespace Implementation.DataObjects
{
    public class Mediator
    {
        public List<Seller> Sellers { get; private set; } = new List<Seller>();

        public void AddSellers(params Seller[] sellers) => Sellers.AddRange(sellers.Select(x => { x.SetMediator(this); return x; }));
        public Product? Buy(string productName) => Sellers.Select(x => x.Sell(productName)).FirstOrDefault();

        public IEnumerable<Product> ShowProducts() => Sellers.SelectMany(x => x.Products);
    }
}