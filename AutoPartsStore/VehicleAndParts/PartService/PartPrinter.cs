namespace AutoPartsStore;

public class PartPrinter
{
    public static void PrintParts(List<Part>? partsList)
    {
        if (partsList != null)
        {
            foreach (var part in partsList)
            {
                Console.WriteLine($"{part.Id} {part.Name} {part.Category} {part.Price}");
            }
        }else Console.WriteLine("There is no parts to display.");
    }
}