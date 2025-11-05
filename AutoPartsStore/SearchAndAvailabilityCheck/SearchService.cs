using AutoPartsStore.VehicleAndParts;

namespace AutoPartsStore.SearchAndAvailabilityCheck;

public static class SearchService
{
    public static void Search()
    {
        var vehicleSearch = VehicleAndPartSelector.SelectVehicle();
        var partSearch = VehicleAndPartSelector.SelectPart();

        var vinInput = string.Empty;
        var yearInput = 0;
        ConsoleKey key;
        
        do
        {
            ConsoleHighlighter.ColorPrint("\nDo you want find the car by VIN number?(Please enter Y/N)", ConsoleColor.Yellow);
            Console.WriteLine("Do you want find the car by VIN number?(Please enter Y/N)");
            
            var input = Console.ReadKey();
            key = input.Key;
            
            switch (key)
            {
                case ConsoleKey.Y:
                    ConsoleHighlighter.ColorPrint("Please,enter Vin number: ", ConsoleColor.Yellow);
                    vinInput = Console.ReadLine().ToLower();
                    break;
                case ConsoleKey.N:
                    ConsoleHighlighter.ColorPrint("Please, enter year: ", ConsoleColor.Yellow);
                    yearInput = Convert.ToInt32(Console.ReadLine());
                    break;
                default:

                    Console.WriteLine("Please,enter Y or N");
                    break;
            }
        } while (key != ConsoleKey.N && key != ConsoleKey.Y);
        
        ConsoleHighlighter.ColorSearch();

        if (AvailabilityCheck.IsVinMatch(vinInput, vehicleSearch) ||
            AvailabilityCheck.IsYearMatch(yearInput, vehicleSearch))
        {
            Console.WriteLine($"for this car {vehicleSearch.Brand} {vehicleSearch.Vin} {vehicleSearch.Year} we have : {partSearch.Name}, price: {partSearch.Price} ");
        }else Console.WriteLine("Error,the car is not found");
    }
}