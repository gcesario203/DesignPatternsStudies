using Implementation.Device;
using Implementation.RemoteControl;

namespace UnitTests;

public class BridgeUnitTests
{
    [Fact]
    public void ShouldIncreaseTVVolume()
    {
        var tv = new TV();

        var tvRemoteControl = new RemoteControlWithVolume(tv);
        
        tvRemoteControl.VolumeUp();

        Assert.Equal(tv.GetVolume(), 1);
    }

    [Fact]
    public void ShouldTurnOnTheRadio()
    {
        var radio = new Radio();

        var radioRemoteControl = new RemoteControl(radio);
        
        radioRemoteControl.TogglePower();

        Assert.Equal(radio.GetPower(), true);
    }
}