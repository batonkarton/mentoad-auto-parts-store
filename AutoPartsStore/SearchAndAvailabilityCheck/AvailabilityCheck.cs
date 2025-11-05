using AutoPartsStore.VehicleAndParts;

namespace AutoPartsStore.SearchAndAvailabilityCheck;

public static class AvailabilityCheck
{
    public static bool IsVinMatch(string vinInput, Vehicle vehicle)
    {
        return !string.IsNullOrWhiteSpace(vinInput) &&
               vinInput.ToLower() == vehicle.Vin.ToLower();
    }

    public static bool IsYearMatch(int yearInput, Vehicle vehicle)
    {
        return yearInput == vehicle.Year;
    }
}
