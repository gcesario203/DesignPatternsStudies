using Implementation.DataObjects;

namespace UnitTests;

public class UnitTest1
{
    [Fact]
    public void ShouldTheNewsletterHasTreeSubs()
    {
        var jornalLiberal = new NewsLetter();

        var client1 = new Customer("Alberto", "alcantra@xxx.com");
        var client2 = new Customer("Marileuza", "mari1988@xxx.com");
        var client3 = new Customer("Luaba", "lulum7@xxx.com");

        jornalLiberal.Subscribe(client1, client2, client3, client1);

        Assert.Equal(jornalLiberal.GetTotalSubscribers(), 3);
    }

    [Fact]
    public void ShouldTheNewsletterHasTwoSubs()
    {
        var jornalLiberal = new NewsLetter();

        var client1 = new Customer("Alberto", "alcantra@xxx.com");
        var client2 = new Customer("Marileuza", "mari1988@xxx.com");
        var client3 = new Customer("Luaba", "lulum7@xxx.com");

        jornalLiberal.Subscribe(client1, client2, client3, client1);

        jornalLiberal.AddBulletins(new Bulletin("Chupa cu é avistado em Americana", "Grandes conteúdos da noticia sendo escrito em forma de epopéia"));

        jornalLiberal.Unsubscribe(client2);

        Assert.Equal(jornalLiberal.GetTotalSubscribers(), 2);
    }

    [Fact]
    public void ShouldUnsubscribeAndNotSendingNewsToOldClients()
    {
        var jornalLiberal = new NewsLetter();

        var client1 = new Customer("Alberto", "alcantra@xxx.com");
        var client2 = new Customer("Marileuza", "mari1988@xxx.com");
        var client3 = new Customer("Luaba", "lulum7@xxx.com");

        jornalLiberal.Subscribe(client1, client2, client3, client1);

        var breakingNews = new Bulletin("Chupa cu é avistado em Americana", "Grandes conteúdos da noticia sendo escrito em forma de epopéia");

        var article = new Bulletin("Homem é encontrado morto após tentar chupar o proprio pau", "é");

        jornalLiberal.AddBulletins(breakingNews, breakingNews);

        jornalLiberal.Unsubscribe(client2, client3);

        jornalLiberal.AddBulletins(article);

        Assert.False(client1.Bulletins.Count() == client2.Bulletins.Count() ||- client1.Bulletins.Count() == client3.Bulletins.Count());
    }
}