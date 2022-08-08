using Implementation.Db;

namespace UnitTests;

public class SingletonDbClassic
{
    [Fact]
    public void ShoudHaveSameId()
    {
        var firstInstance = DatabaseClassic.Instance;
        var secondInstance = DatabaseClassic.Instance;

        System.Console.WriteLine($"Id da variavel firstInstance: {firstInstance.Id}");
        System.Console.WriteLine($"Id da variavel secondInstance: {secondInstance.Id}");
        Assert.Equal(firstInstance.Id, secondInstance.Id);
    }

    [Fact]
    public void ShouldHaveSameElements()
    {
        var firstInstance = DatabaseClassic.Instance;
        var secondInstance = DatabaseClassic.Instance;

        Assert.Equal(firstInstance.Users, secondInstance.Users);
    }
    [Fact]
    public void ShouldHaveSameElementsAfterAddInOneInstance()
    {
        var firstInstance = DatabaseClassic.Instance;
        var secondInstance = DatabaseClassic.Instance;

        firstInstance.AddUser(new Implementation.Models.User("Michael","Jackson"));

        Assert.Equal(firstInstance.Users, secondInstance.Users);
    }

    [Fact]
    public void ShouldHaveSameElementsAfterRemoveInOneInstance()
    {
        var firstInstance = DatabaseClassic.Instance;
        var secondInstance = DatabaseClassic.Instance;

        secondInstance.RemoveRandomUser();

        Assert.Equal(firstInstance.Users, secondInstance.Users);
    }
}