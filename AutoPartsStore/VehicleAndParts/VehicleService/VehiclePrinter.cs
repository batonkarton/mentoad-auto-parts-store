namespace AutoPartsStore.VehicleAndParts;

public class VehiclePrinter
{
    public static void PrintVehicle(List<Vehicle>? vehicleList)
    {
        ConsoleHighlighter.ColorPrint("choose a vehicle:" ,  ConsoleColor.Yellow);
        ConsoleHighlighter.ColorSearch();
        ConsoleHighlighter.ColorPrint("audi\nbmw\nopel\ntoyota\nford\nmercedes\nvolkswagen", ConsoleColor.Cyan);
        var userInput = Console.ReadLine()?.ToLower();
        if (vehicleList != null && !string.IsNullOrEmpty(userInput))
        {
            var vehicleCategory = vehicleList.Where(p => p.Brand == userInput).ToList();
            foreach (var vehicle in vehicleCategory)
            {
                ConsoleHighlighter.ColorPrint($" {vehicle.Id} {vehicle.Model}", ConsoleColor.Cyan);
            }
            
        } else Console.WriteLine("There are no vehicles");
    }
}