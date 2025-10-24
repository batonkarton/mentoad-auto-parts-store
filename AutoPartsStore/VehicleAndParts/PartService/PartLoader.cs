using System.Text.Json;

namespace AutoPartsStore;

public class PartLoader
{
    public static List<Part>? GetPart()
    {
        var jsonText = File.ReadAllText(Constans.JsonParts);
        
        return JsonSerializer.Deserialize<List<Part>>(jsonText);
    }
}