using Implementation.Models.Base;

namespace Implementation.Models
{
    public class Beverage : AbstractMeal
    {
        public Beverage(string name, decimal price) : base(name, price)
        {
        }
        public override decimal GetPrice()
        {
            return Price * 0.5M;
        }
    }
}