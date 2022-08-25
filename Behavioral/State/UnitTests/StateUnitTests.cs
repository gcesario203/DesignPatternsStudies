using Implementation;
using Implementation.Orders;

namespace UnitTests;

public class UnitTest1
{
    [Fact]
    public void ShoudCreateShoppingOrderWithPendingState()
    {
        var shoppingOrder = new ShoppingOrder();

        Assert.Equal(shoppingOrder.State.GetType(), typeof(Pending));
    }
}