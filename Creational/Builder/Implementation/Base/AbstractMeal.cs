using Implementation.Interface;

namespace Implementation.Base
{
    public abstract class AbstractMeal : IMealComposite
    {
        public string Name { get; private set; }

        public decimal Price  { get; private set; }

        public AbstractMeal(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public abstract decimal GetPrice();

        public override string ToString()
        {
            return $"{Name} - {GetPrice().ToString("C2")}\n";
        }
    }
}