using System.Text.Json;

namespace AutoPartsStore;

public class PartLoader
{
    public static List<Part>? GetPart()
    {
        var jsonText = File.ReadAllText(Constants.JsonParts);
        
        return JsonSerializer.Deserialize<List<Part>>(jsonText);
    }
}