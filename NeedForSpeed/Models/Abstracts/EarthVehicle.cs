namespace NeedForSpeed.Models.Abstracts;

public abstract class EarthVehicle: Vehicle
{
    protected int TimeOfMoveToChill { get; init;}
    protected int TimeOfChill { get; init; }
}