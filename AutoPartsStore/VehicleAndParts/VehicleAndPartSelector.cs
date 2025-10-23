namespace AutoPartsStore.VehicleAndParts;

public static class VehicleAndPartSelector
{
    public static void VehicleSelector()
    {
        var vehicles = VehicleLoader.GetVehicles("Data/vehicles.json");
        VehiclePrinter.PrintVehicle(vehicles);
        if (vehicles != null) Choose1(vehicles);
    }

    public static void PartSelector()
    {
        var part = PartLoader.GetPart("Data/parts.json");
        PartPrinter.PrintParts(part);
        if (part != null) Choose2(part);
    }

    private static void Choose1(List<Vehicle> vehicles)
    {
        Console.WriteLine("Choose a vehicle:");
        if (int.TryParse(Console.ReadLine(), out var index) && index >= 0 && index < vehicles.Count)
        {
            ConsoleHighlighter.Highlight(vehicles, index, v => $"Your choice: {v.Brand} {v.Model} {v.Year} {v.Vin}");
        }

        Console.WriteLine("Please enter a valid number");
    }

    private static void Choose2(List<Part> part)
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