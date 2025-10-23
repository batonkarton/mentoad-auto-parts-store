using System.Text.Json;

namespace AutoPartsStore.VehicleAndParts;

public class VehicleLoader
{
    public static List<Vehicle>? GetVehicles(string jsonPath)
    {
        var jsonText = File.ReadAllText(jsonPath);
        return JsonSerializer.Deserialize<List<Vehicle>>(jsonText);
    }
}