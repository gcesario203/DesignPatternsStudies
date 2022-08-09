using Implementation.Models.Base;

namespace Implementation.Models
{
    public class Meat : AbstractMeal
    {
        public Meat(string name, decimal price) : base(name, price)
        {   
        }

        public override decimal GetPrice()
        {
            return Price * 4M;
        }
    }
}