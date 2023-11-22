using NeedForSpeed.Models.Abstracts;

namespace NeedForSpeed.Models.Vehicles.Air;

public class FlyingCarpet: AirVehicle
{
    public FlyingCarpet(int distance)
    {
        // TODO разобраться со свойствами
        Name = "Метелочка, жаль что не Ёлочка";
        Speed = 4;
        KoefOfAcceleration = 6;
    }
    // TODO сделать просчеты для всех воздушных транспортов разными
    public override int Go(int distance)
    {
        throw new NotImplementedException();
    }

}