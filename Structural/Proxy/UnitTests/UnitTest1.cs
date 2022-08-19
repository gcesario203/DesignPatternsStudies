using Implementation.SystemUser;
using Implementation.SystemUser.DataObjects;

namespace UnitTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var proxy = new SystemUserProxy("Mauricio", "Cesar");

        var fromMemory = proxy.GetAddresses();

        var fromCache = proxy.GetAddresses();

        Assert.Equal(fromCache.GetType(), typeof(List<AdminAddress>));
    }
}