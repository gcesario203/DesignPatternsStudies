namespace Implementation.Interfaces
{
    public interface IVehicleFactory
    {
        IVehicle GetVehicle(string vehicleName);

        IVehicle PickUp(string customerName, string vehicleName);
    }
}