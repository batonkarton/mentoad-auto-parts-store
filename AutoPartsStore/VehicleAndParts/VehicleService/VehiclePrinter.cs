namespace AutoPartsStore.VehicleAndParts;

public class VehiclePrinter
{
    public static void PrintVehicle(List<Vehicle>? vehicleList)
    {
        if (vehicleList != null)
        {for (int i = 0; i < vehicleList.Count; i++)
            {
                var v = vehicleList[i];
                Console.WriteLine($"{i} {v.Brand} {v.Model} ({v.Year}) VIN: {v.Vin}");
            }
        } else Console.WriteLine("There are no vehicles");
    }
}