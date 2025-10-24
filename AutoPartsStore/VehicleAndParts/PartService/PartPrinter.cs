namespace AutoPartsStore;

public class PartPrinter
{
    public static void PrintParts(List<Part>? partsList)
    {
        if (partsList != null)
        {
            for (int i = 0; i < partsList.Count; i++)
            {
                var v = partsList[i];
                Console.WriteLine($"{i} {v.Name} {v.Category} {v.Price}");
            }
        }else Console.WriteLine("There is no parts to display.");
    }
}