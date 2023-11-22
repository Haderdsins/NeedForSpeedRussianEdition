
using NeedForSpeed.Models.Abstracts;

namespace NeedForSpeed.Models.Vehicles.Air;

public class FlyingShip: AirVehicle
{
    public FlyingShip(int distance)
    {
        // TODO разобраться со свойствами
        Name = "Летучий корабль Капитана Джека Воробья(да в бутылке и что)";
        Speed = 10;
        KoefOfAcceleration = 2;
    }
    // TODO сделать просчеты для всех воздушных транспортов разными
    public override int Go(int distance)
    {
        throw new NotImplementedException();
    }

}