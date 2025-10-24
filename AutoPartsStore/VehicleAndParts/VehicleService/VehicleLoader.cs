using System.Text.Json;

namespace AutoPartsStore.VehicleAndParts;

public class VehicleLoader
{
    public static List<Vehicle>? GetVehicles()
    {
        var jsonText = File.ReadAllText(Constans.JsonVehicle);
        
        return JsonSerializer.Deserialize<List<Vehicle>>(jsonText);
    }
}