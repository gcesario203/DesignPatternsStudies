using Implementation;

namespace UnitTests
{
    public class BuilderTests
    {
        [Fact]
        public void ShoudBuildAMainBrazilianLunch()
        {
            var BrazilianLunch = new Dish();

            BrazilianLunch.BuildMeal(new Rice("Arroz integral", 20M),
                                     new Beans("Feijão carioquinha", 30M),
                                     new Meat("Bife", 50M));

            BrazilianLunch.BuildBeverage(new Beverage("Suco de laranja", 5M));

            Assert.Equal(BrazilianLunch.GetPrice(), 282.50M);
        }
    }
}