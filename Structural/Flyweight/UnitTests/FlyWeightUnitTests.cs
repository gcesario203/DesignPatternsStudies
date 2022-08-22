using Implementation.Delivery.DataObjects;
using Implementation.Delivery.Factories;

namespace UnitTests;

public class FlyWeightUnitTests
{
    [Fact]
    public void ShoudCreateADeliveryLocations()
    {
        var deliveryFactory = new DeliveryFactory();

        var praiaAzulLocation = new LocationData("Rua do Linho", "Americana - SP");

        var santaBarbaraLocation = new LocationData("Rua do Bronze", "Santa Bárbara D' Oeste - SP");

        var praiaAzulDeliveryLocation = deliveryFactory.MakeLocation(praiaAzulLocation);

        var santaBarbarDeliveryLocation = deliveryFactory.MakeLocation(santaBarbaraLocation);
        var santaBarbarDeliveryLocationv2 = deliveryFactory.MakeLocation(santaBarbaraLocation);

        praiaAzulDeliveryLocation.Deliver("Mauricio Alberto", "78 K22");

        santaBarbarDeliveryLocation.Deliver("Fernanda de Souza", "45A");

        Assert.Equal(deliveryFactory.Locations.Count(), 2);
    }

    [Fact]
    public void ShoudDeliveryLocationBeTheSame()
    {
        var deliveryFactory = new DeliveryFactory();

        var praiaAzulLocation = new LocationData("Rua do Linho", "Americana - SP");

        var praiaAzulDeliveryLocation = deliveryFactory.MakeLocation(praiaAzulLocation);

        var praiaAzulDeliveryLocationV2 = deliveryFactory.MakeLocation(praiaAzulLocation);

        Assert.Equal(praiaAzulDeliveryLocation, praiaAzulDeliveryLocationV2);
    }


}