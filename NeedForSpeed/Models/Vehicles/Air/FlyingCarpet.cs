using NeedForSpeed.Models.Abstracts;

namespace NeedForSpeed.Models.Vehicles.Air;

public class FlyingCarpet: AirVehicle
{
    public FlyingCarpet()
    {
        // TODO разобраться со свойствами
        Name = "Летающий ковер из прихожей";
        Speed = 4;
        KoefOfAcceleration = 6;
    }
    // TODO сделать просчеты для всех воздушных транспортов разными
    public override int Go(int distance)
    {
        var totalTimeOfRace = (int)Formula.CalculateTimeOfRaceLogarithmic(Speed, KoefOfAcceleration, distance);
        return totalTimeOfRace;
    }

}