using Implementation.SmartHouse;
using Implementation.SmartHouse.Light;
using Implementation.SmartHouse.Light.Commands;

namespace UnitTests;

public class CommandUnitTests
{
    [Fact]
    public void ShouldTurnOnTheLight()
    {
        var smartHouse = new SmartHouse();

        var light = new Light("Luz da sala");

        var lightPowerCommand = new PowerCommand(light);

        smartHouse.AddCommand(lightPowerCommand);

        smartHouse.ExecuteCommand(lightPowerCommand);

        Assert.Equal(light.GetPowerStatus(), true);
    }

    [Fact]
    public void ShouldExecuteLightPowerCommandTwiceAndNotTurnOffTheLight()
    {
        var smartHouse = new SmartHouse();

        var light = new Light("Luz da cozinha");

        var lightPowerCommand = new PowerCommand(light);

        smartHouse.AddCommand(lightPowerCommand);

        smartHouse.ExecuteCommand(lightPowerCommand);

        smartHouse.ExecuteCommand(lightPowerCommand);

        Assert.NotEqual(light.GetPowerStatus(), false);
    }

    [Fact]
    public void ShouldNotChangeIntensityWhileLightIsOff()
    {
        var smartHouse = new SmartHouse();

        var light = new Light("Luz do banheiro");

        var lightPowerCommand = new PowerCommand(light);

        var lightIntensityCommand = new IntensityCommand(light);

        smartHouse.AddCommand(lightPowerCommand);

        smartHouse.AddCommand(lightIntensityCommand);

        smartHouse.ExecuteCommand(lightPowerCommand);

        smartHouse.UndoCommand(lightPowerCommand);

        smartHouse.ExecuteCommand(lightIntensityCommand);

        Assert.NotEqual(light.GetIntensity(), 51);
    }

    [Fact]
    public void ShouldIncreaseTheIntensityOfLight()
    {
        var smartHouse = new SmartHouse();

        var light = new Light("Luz do banheiro");

        var lightPowerCommand = new PowerCommand(light);

        var lightIntensityCommand = new IntensityCommand(light);

        smartHouse.AddCommand(lightPowerCommand);

        smartHouse.AddCommand(lightIntensityCommand);

        smartHouse.ExecuteCommand(lightPowerCommand);

        smartHouse.ExecuteCommand(lightIntensityCommand);

        Assert.Equal(light.GetIntensity(), 51);
    }

    [Fact]
    public void ShouldLightIntensityNotSurpassOneHundred()
    {
        var smartHouse = new SmartHouse();

        var light = new Light("Luz do banheiro");

        var lightPowerCommand = new PowerCommand(light);

        var lightIntensityCommand = new IntensityCommand(light);

        smartHouse.AddCommand(lightPowerCommand);

        smartHouse.AddCommand(lightIntensityCommand);

        smartHouse.ExecuteCommand(lightPowerCommand);

        for(var i = 0; i < 300; i++)
            smartHouse.ExecuteCommand(lightIntensityCommand);

        Assert.Equal(light.GetIntensity(), 100);
    }
}