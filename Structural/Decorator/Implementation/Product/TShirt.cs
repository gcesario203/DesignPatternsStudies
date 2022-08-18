using Implementation.Product.Interface;

namespace Implementation.Product
{
    public class TShirt : IProduct
    {
        private string Name = "Camiseta";
        private decimal Price = 49.90M;
        public string GetName()
        {
            return Name;
        }

        public decimal GetPrice()
        {
            return Price;
        }
    }
}