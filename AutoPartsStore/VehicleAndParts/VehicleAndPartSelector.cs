namespace AutoPartsStore.VehicleAndParts;

public static class VehicleAndPartSelector
{
    public static void SelectorVehicle()
    {
        var vehicles = VehicleLoader.GetVehicles();
        VehiclePrinter.PrintVehicle(vehicles);
        if (vehicles != null) VehicleSelection(vehicles);
    }

    public static void SelectorPart()
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
            ConsoleHighlighter.Highlight(vehicles, index, v => $"Your choice: {v.Brand} {v.Model} {v.Year} {v.Vin}");
        }

        Console.WriteLine("Please enter a valid number");
    }

    private static void PartSelection(List<Part> part)
    {
        Console.WriteLine("Choose a vehicle:");
        
        if (int.TryParse(Console.ReadLine(), out var index) && index >= 0 && index < part.Count)
        {
            Console.WriteLine($"Your choice:{part[index]}");
            ConsoleHighlighter.Highlight(part, index, v => $"Your choice: {v.Category} {v.Name} {v.Price}");
        }

        Console.WriteLine("Please enter a valid number");
    }
}