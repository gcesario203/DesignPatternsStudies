using Implementation.Models.Interface;

namespace Implementation.Models
{
    public class Dish : IMealDish
    {
        public MealBox Meal{ get; private set;} = new MealBox();

        public void BuildMeal(params IMealComposite[] components)
        {
            Meal.Add(components.ToArray());
        }
        public void BuildBeverage(params IMealComposite[] components)
        {
            Meal.Add(components.ToArray());
        }

        public void BuildDessert(params IMealComposite[] components)
        {
            Meal.Add(components.ToArray());
        }

        private void Reset()
        {
            Meal = new MealBox();
        }

        public decimal GetPrice()
        {
            return Meal.GetPrice();
        }

        public override string ToString()
        {
            var returnString = "Seu prato contém:\n";

            returnString += Meal.ToString() + $"Valor total: {GetPrice().ToString("C2")}";
            return returnString;
        }
    }
}