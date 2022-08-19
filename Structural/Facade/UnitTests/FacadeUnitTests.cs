using FacadeImplementation;

namespace UnitTests;

public class FacadeUnitTests
{
    [Fact]
    public void ShoudBuildAMainBrazilianLunch()
    {
        var mealFacade = new MealFacade();

        var brazilianMealLunch = mealFacade.GetBrazilianMeal();

        Assert.Equal(brazilianMealLunch.GetPrice(), 282.50M);
    }
}