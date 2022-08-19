using Implementation;

namespace FacadeImplementation
{
    public class MealFacade
    {
        private Dish dishBuilder = new Dish();

        public MealBox GetBrazilianMeal()
        {
            dishBuilder.Reset();
            
            dishBuilder.BuildMeal(new Rice("Arroz integral", 20M),
                         new Beans("Feijão carioquinha", 30M),
                         new Meat("Bife", 50M));

            dishBuilder.BuildBeverage(new Beverage("Suco de laranja", 5M));

            return dishBuilder.Meal;
        }
    }
}