namespace AutoPartsStore;

public class PartPrinter
{
    public static void PrintParts(List<Part> partsList, string? userInput)
    {
        if (partsList.Count != 0 && !string.IsNullOrEmpty(userInput))
        {
            var partCategory = partsList.Where(p => p.Category == userInput);
            foreach (var part in partCategory)
            {
                ConsoleHighlighter.ColorPrint($"Id: {part.Id}; Name: {part.Name}; Price: {part.Price};", ConsoleColor.Cyan);
            }
        } else Console.WriteLine("There is no parts to display.");
    }
    
    public static void PrintPartCategories(List<Part> partsList)
    {
        if (partsList.Count != 0)
        {
            var partCategories = partsList.Select(p => p.Category).Distinct().ToArray();
            foreach (var category in partCategories)
            {
                ConsoleHighlighter.ColorPrint($"{category}\n", ConsoleColor.Cyan);
            }
        } else Console.WriteLine("There is no parts to display.");
    }
}