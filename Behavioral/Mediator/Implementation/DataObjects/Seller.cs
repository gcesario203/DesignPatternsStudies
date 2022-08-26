using System.Text.RegularExpressions;

namespace Implementation.DataObjects
{
    public class Seller
    {
        public List<Product> Products { get; private set; } = new List<Product>();

        private Mediator _mediator;

        public void AddProducts(params Product[] products) => Products.AddRange(products);

        public void RemoveProducts(params Product[] products) => Products.RemoveAll(productOnList => products.Contains(productOnList));

        public Product? Sell(string productName)
        {
            var regexPattern = $"(?i)\\b{productName}\\b";

            var soldProduct = Products.FirstOrDefault(product => Regex.IsMatch(product.Name, regexPattern));

            if(soldProduct != null)
                RemoveProducts(soldProduct);
            
            return soldProduct;
        }

        public void SetMediator(Mediator mediator)
        {
            _mediator = mediator;
        }

        public override string ToString() => String.Join(", ", Products.Select(product => $"{product.Name} - {product.Price.ToString("C2")}"));
    }
}