namespace AutoPartsStore.VehicleAndParts;

public static class VehicleAndPartSelector
{
    public static Vehicle? SelectVehicle()
    {
        var vehicles = VehicleLoader.GetVehicles();
        
        VehiclePrinter.PrintVehicle(vehicles);
        
        return vehicles != null ? VehicleSelection(vehicles) : null;
    }

    public static Part? SelectPart()
    {
        var part = PartLoader.GetPart();
        
        PartPrinter.PrintParts(part);
        
        return part != null ? PartSelection(part) : null;
    }

    private static Vehicle? VehicleSelection(List<Vehicle> vehicles)
    {
        ConsoleHighlighter.ColorPrint("Choose a vehicle:", ConsoleColor.Yellow);

        if (int.TryParse(Console.ReadLine(), out var input) && input >= 1 && input <= vehicles.Count)
        {
            var index = input - 1;
            var vehicle = vehicles[index];
            
            ConsoleHighlighter.Highlight(vehicles, index, v => $"Your choice: {v.Brand}");
            
            return vehicle;
        }

        Console.WriteLine("Please enter a valid number");

        return null;
    }

    private static Part? PartSelection(List<Part> part)
    {
        ConsoleHighlighter.ColorPrint("Choose a parts:", ConsoleColor.Yellow);

        if (int.TryParse(Console.ReadLine(), out var input) && input >= 1 && input <= part.Count)
        {
            var index = input - 1;
            var selectedPart = part[index];
            
            ConsoleHighlighter.Highlight(part, index, v => $"Your choice: {v.Id} {v.Name}");
            
            return selectedPart;
        }

        Console.WriteLine("Please enter a valid number");

        return null;
    }
}