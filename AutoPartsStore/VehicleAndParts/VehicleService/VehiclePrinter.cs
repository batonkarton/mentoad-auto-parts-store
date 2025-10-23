namespace AutoPartsStore.VehicleAndParts;

public class VehiclePrinter
{
    public static void PrintVehicle(List<Vehicle>? vehicleList)
    {
        if (vehicleList != null)
        {
            foreach (var v in vehicleList)
            {
                Console.WriteLine($"{v.Brand} {v.Model} ({v.Year}) VIN: {v.Vin}");
            }
        }
        else
        {
            Console.WriteLine("Invalid JSON");
        }
    }
}