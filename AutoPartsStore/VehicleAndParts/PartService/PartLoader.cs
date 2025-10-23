using System.Text.Json;

namespace AutoPartsStore;

public class PartLoader
{
    public static List<Part>? GetPart(string jsonPath)
    {
        var jsonText = File.ReadAllText(jsonPath);
        return JsonSerializer.Deserialize<List<Part>>(jsonText);
    }
}