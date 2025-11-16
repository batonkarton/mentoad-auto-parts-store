using AutoPartsStore.Interfaces;
using AutoPartsStore.Repositories;

namespace AutoPartsStore.VehicleAndParts;

public class VehicleAndPartSelector
{
    private readonly IRepository<Part> _partRepository = new PartRepository();
    private readonly IRepository<Vehicle> _vehicleRepository = new VehicleRepository();

    public Vehicle? SelectVehicle()
    {
        var vehicles = _vehicleRepository.ReadAll();
        
        VehiclePrinter.PrintVehicle(vehicles);
        
        return vehicles.Count != 0 ? VehicleSelection(vehicles) : null;
    }

    public Part? SelectPart()
    {
        var parts = _partRepository.ReadAll();
        
        ConsoleHighlighter.ColorPrint("Choose category, please enter full name:", ConsoleColor.Yellow);
        ConsoleHighlighter.ColorSearch();
        PartPrinter.PrintPartCategories(parts);
        
        var userInput = Console.ReadLine()?.ToLower();
        PartPrinter.PrintParts(parts, userInput);
        
        return parts.Count != 0 ? PartSelection(parts) : null;
    }

    private static Vehicle? VehicleSelection(List<Vehicle> vehicles)
    {
        ConsoleHighlighter.ColorPrint("Choose a vehicle id:", ConsoleColor.Yellow);

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