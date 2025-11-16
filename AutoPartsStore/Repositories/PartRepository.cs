using System.Text.Json;
using AutoPartsStore.Interfaces;

namespace AutoPartsStore.Repositories;

public class PartRepository : IRepository<Part>
{
    private List<Part> _parts;

    public PartRepository()
    {
        var jsonText = File.ReadAllText(Constants.JsonParts);
        _parts = JsonSerializer.Deserialize<List<Part>>(jsonText) ?? [];
    }
    
    public void Create(Part item)
    {
        throw new NotImplementedException();
    }

    public Part Read(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(Part item)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Part> ReadAll()
    {
        return _parts;
    }
}