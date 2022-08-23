using Implementation.ECommerce;
using Implementation.ECommerce.Discounts;

namespace UnitTests;

public class StrategyUnitTests
{
    [Fact]
    public void ShouldCreateAShoppingCartWithDefaultStrategy()
    {
        var shoppingCart = new ShoppingCart();

        shoppingCart.AddProducts(new Product("Arroz", 20), new Product("Feijão", 10), new Product("Contra-filé", 70));

        Assert.Equal(shoppingCart.GetTotalPriceWithDiscount(), 90M);
    }
    [Fact]
    public void ShouldCreateAShoppingCartWithSaleOffStrategy()
    {
        var shoppingCart = new ShoppingCart(new SaleOffDiscount());

        shoppingCart.AddProducts(new Product("Arroz", 20), new Product("Feijão", 10), new Product("Contra-filé", 70));

        Assert.Equal(shoppingCart.GetTotalPriceWithDiscount(), 50M);
    }
}