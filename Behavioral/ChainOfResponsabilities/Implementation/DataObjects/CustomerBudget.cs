namespace Implementation.DataObjects
{
    public class CustomerBudget
    {
        public bool Approved { get; set; }

        public decimal Price { get; set; }

        public CustomerBudget(decimal price)
        {
            Price = price;
        }
    }
}