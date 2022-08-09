
using Implementation.Base;

namespace Implementation
{
    public class Beans : AbstractMeal
    {
        public Beans(string name, decimal price) : base(name, price)
        {   
        }
        public override decimal GetPrice()
        {
            return Price * 2M;
        }
    }
}