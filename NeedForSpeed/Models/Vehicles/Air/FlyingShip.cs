
using NeedForSpeed.Models.Abstracts;

namespace NeedForSpeed.Models.Vehicles.Air;

public class FlyingShip: AirVehicle
{
    public FlyingShip()
    {
        // TODO разобраться со свойствами
        Name = "Летучий корабль Капитана Джека Воробья(да в бутылке и что)";
        Speed = 10;
        KoefOfAcceleration = 2;
    }
    // TODO сделать просчеты для всех воздушных транспортов разными
    public override int Go(int distance)
    {
        var totalTimeOfRace = (int)Formula.CalculateTimeOfRaceSquareRoot(Speed, KoefOfAcceleration, distance);
        return totalTimeOfRace;
    }

}