using NeedForSpeed.Models.Abstracts;

namespace NeedForSpeed.Models.Vehicles.Air;

public class Broom: AirVehicle
{
    public Broom()
    {
        // TODO разобраться со свойствами
        Name = "Метелочка, жаль что не Ёлочка";
        Speed = 5;
        KoefOfAcceleration = 10;
    }
    // TODO сделать просчеты для всех воздушных транспортов разными
    public override int Go(int distance)
    {
        var totalTimeOfRace = (int)Formula.CalculateTimeOfRaceSimple(Speed, KoefOfAcceleration, distance);
        return totalTimeOfRace;
    }

}