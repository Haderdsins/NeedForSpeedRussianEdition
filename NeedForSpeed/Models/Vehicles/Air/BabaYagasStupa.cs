using NeedForSpeed.Models.Abstracts;
namespace NeedForSpeed.Models.Vehicles.Air;

internal class BabaYagasStupa: AirVehicle
{
    public BabaYagasStupa(int distance)
    {
        // TODO разобраться со свойствами
        Name = "Баба Ягиная Тапочка в пол";
        Speed = 2;
        KoefOfAcceleration = 2;
    }
   

    public override int Go(int distance)
    {
        throw new NotImplementedException();
    }

}