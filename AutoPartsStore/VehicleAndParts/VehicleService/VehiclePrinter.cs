namespace AutoPartsStore.VehicleAndParts;

public class VehiclePrinter
{
    public static void PrintVehicle(List<Vehicle>? vehicleList)
    {
        if (vehicleList != null)
        {
            foreach (var vehicle in vehicleList)
            {
                Console.WriteLine($"{vehicle.Id} {vehicle.Brand} {vehicle.Model} {vehicle.Year} {vehicle.Vin}");
            }
        } else Console.WriteLine("There are no vehicles");
    }
}