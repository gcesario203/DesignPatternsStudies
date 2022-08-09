using Implementation.Base;

namespace Implementation
{
    public class Rice : AbstractMeal
    {
        public Rice(string name, decimal price) : base(name, price)
        {
        }
        public override decimal GetPrice()
        {
            return Price;
        }
    }
}