using Implementation.Base;

namespace Implementation
{
    public class Dessert : AbstractMeal
    {
        public Dessert(string name, decimal price) : base(name, price)
        {
        }

        public override decimal GetPrice()
        {
            return Price * 1.5M;
        }
    }
}