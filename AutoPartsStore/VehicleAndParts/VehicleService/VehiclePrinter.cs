namespace AutoPartsStore.VehicleAndParts;

public class VehiclePrinter
{
    public static void PrintVehicle(List<Vehicle> vehicles)
    {
        ConsoleHighlighter.ColorPrint("Choose a vehicle:" ,  ConsoleColor.Yellow);
        ConsoleHighlighter.ColorSearch();
        if (vehicles.Count == 0)
        {
            Console.WriteLine("There is no vehicles to display.");
            return;
        }
        
        foreach (var vehicle in vehicles)
        {
            ConsoleHighlighter.ColorPrint($"Id: {vehicle.Id}; Brand: {vehicle.Brand}; Model: {vehicle.Model};", ConsoleColor.Cyan);
        }
    }
}