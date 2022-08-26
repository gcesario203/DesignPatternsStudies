namespace Implementation.DataObjects
{
    public class Client
    {
        private Mediator _mediator;

        public Client(Mediator mediator)
        {
            _mediator = mediator;
        }

        public IEnumerable<Product> ViewProducts() => _mediator.ShowProducts();

        public Product? Buy(string productName) => _mediator.Buy(productName);
    }
}