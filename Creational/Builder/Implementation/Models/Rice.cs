using Implementation.Models.Base;

namespace Implementation.Models
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