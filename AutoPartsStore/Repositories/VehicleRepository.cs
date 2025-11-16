using System.Text.Json;
using AutoPartsStore.Interfaces;
using AutoPartsStore.VehicleAndParts;

namespace AutoPartsStore.Repositories;

public class VehicleRepository : IRepository<Vehicle>
{
    private readonly List<Vehicle> _vehicles;

    public VehicleRepository()
    {
        var jsonText = File.ReadAllText(Constants.JsonVehicle);
        _vehicles = JsonSerializer.Deserialize<List<Vehicle>>(jsonText) ?? [];
    }
    
    public void Create(Vehicle item)
    {
        throw new NotImplementedException();
    }

    public Vehicle Read(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(Vehicle item)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Vehicle> ReadAll()
    {
        return _vehicles;
    }
}