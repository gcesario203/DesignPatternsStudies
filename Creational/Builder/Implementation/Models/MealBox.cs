using Implementation.Models.Interface;

namespace Implementation.Models
{
    public class MealBox : IMealBox
    {
        private readonly List<IMealComposite> _children = new List<IMealComposite>();

        public void Add(params IMealComposite[] meals)
        {
            _children.AddRange(meals);
        }

        public decimal GetPrice()
        {
            if(_children?.Count() == 0)
                return 0M;

            return _children.Sum(x => x.GetPrice());
        }

        public override string ToString()
        {
            return String.Join(", ", _children.Select(x => x.ToString()));
        }
    }
}