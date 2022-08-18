using Implementation.Product;
using Implementation.Product.Decorator;

namespace UnitTests;

public class DecoratorUnitTests
{
    [Fact]
    public void TShirtShouldHaveDifferentPriceFromStampTShirt()
    {
        var tShirt = new TShirt();

        var stampTShirt = new ProductStampDecorator(tShirt);

        Assert.NotEqual(tShirt.GetPrice(), stampTShirt.GetPrice());
    }
}