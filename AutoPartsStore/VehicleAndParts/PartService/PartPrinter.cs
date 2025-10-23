namespace AutoPartsStore;

public class PartPrinter
{
    public static void PrintParts(List<Part>? partsList)
    {
        if (partsList != null)
        {
            foreach (var v in partsList)
            {
                Console.WriteLine($"{v.Name} {v.Category} {v.Price}");
            }
        }
        else
        {
            Console.WriteLine("Invalid JSON");
        }
    }
}