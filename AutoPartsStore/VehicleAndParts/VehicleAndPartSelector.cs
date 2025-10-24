namespace AutoPartsStore.VehicleAndParts;

public static class VehicleAndPartSelector
{
    public static void SelectVehicle()
    {
        var vehicles = VehicleLoader.GetVehicles();
        VehiclePrinter.PrintVehicle(vehicles);
        if (vehicles != null) VehicleSelection(vehicles);
    }

    public static void SelectPart()
    {
        var part = PartLoader.GetPart();
        PartPrinter.PrintParts(part);
        if (part != null) PartSelection(part);
    }

    private static void VehicleSelection(List<Vehicle> vehicles)
    {
        Console.WriteLine("Choose a vehicle:");
        
        if (int.TryParse(Console.ReadLine(), out var index) && index >= 0 && index < vehicles.Count)
        {
            ConsoleHighlighter.Highlight(vehicles, index, v => $"Your choice: {v.Brand} {v.Model} year: {v.Year} Vin: {v.Vin}");
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }
    }

    private static void PartSelection(List<Part> part)
    {
        Console.WriteLine("Choose a vehicle:");
        
        if (int.TryParse(Console.ReadLine(), out var index) && index >= 0 && index < part.Count)
        {
            ConsoleHighlighter.Highlight(part, index, v => $"Your choice: {v.Category} {v.Name} price: {v.Price}");
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }
    }
}