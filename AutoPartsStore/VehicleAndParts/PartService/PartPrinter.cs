namespace AutoPartsStore;

public class PartPrinter
{
    public static void PrintParts(List<Part>? partsList)
    {
        ConsoleHighlighter.ColorPrint("choose category:", ConsoleColor.Yellow);
        ConsoleHighlighter.ColorSearch();
        ConsoleHighlighter.ColorPrint("Engine\nElectrical", ConsoleColor.Cyan);
        
        var userInput = Console.ReadLine()?.ToLower();
        if (partsList != null && !string.IsNullOrEmpty(userInput))
        {
            var partCategory = partsList.Where(p => p.Category == userInput);
            foreach (var part in partCategory)
            {
                ConsoleHighlighter.ColorPrint($"{part.Id} {part.Name}", ConsoleColor.Cyan);
            }
        } else Console.WriteLine("There is no parts to display.");
    }
}