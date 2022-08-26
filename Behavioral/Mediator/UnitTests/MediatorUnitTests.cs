using Implementation.DataObjects;

namespace UnitTests;

public class MediatorUnitTests
{
    [Fact]
    public void ShoudCreateAndRemoveProductsFromSeller()
    {
        var seller = new Seller();

        var products = new List<Product>{
            new Product("Alface", 3M),
            new Product("Leite", 5M),
        };

        seller.AddProducts(products.ToArray());

        seller.RemoveProducts(products.FirstOrDefault());

        Assert.Equal(seller.Products.Count, 1);
    }

    [Fact]
    public void ShouldReturnProductMilkByNameFromSeller()
    {
        var seller = new Seller();

        var products = new List<Product>{
            new Product("Alface", 3M),
            new Product("Leite", 5M),
        };

        seller.AddProducts(products.ToArray());

        var soldProduct = seller.Sell("leite");

        Assert.NotEqual(soldProduct, null);
    }

    [Fact]
    public void ShouldClientBuyAProductFromSellerByMediator()
    {
        var casasBahia = new Mediator();

        var firstSeller = new Seller();

        firstSeller.AddProducts(new []{
            new Product("Fogao", 700M),
            new Product("Microondas", 300M),
        });

        var secondSeller = new Seller();

        secondSeller.AddProducts(new []{
            new Product("PC Positivo", 2M),
            new Product("Smartphone", 500M),
        });

        casasBahia.AddSellers(firstSeller, secondSeller);

        var carlinhos = new Client(casasBahia);

        var soldProduct = carlinhos.Buy("microondas");

        Assert.NotEqual(soldProduct, null);
    }
}