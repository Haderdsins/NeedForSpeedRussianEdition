using NeedForSpeed.Models.Abstracts;

namespace NeedForSpeed.Models.Vehicles.Earth;

public class PumpkinCarriage: EarthVehicle
{
    public PumpkinCarriage()
    {
        Name = "Тыквенный кортеж";
        Speed = 23;
        TimeOfMoveToChill = 7;// время движения до необходимого отдыха
        TimeOfChill = 6;// длительность отдыха, которая зависит от порядкового номера остановки
    }
    
    public override int Go(int distance)
    {
        //Количество остановок
        var CountOfStop = distance / Speed / TimeOfMoveToChill;
        var TotalChill = 0;
        //Всего отдыха
        for (int i = 1; i < CountOfStop; i++)
        {
            TotalChill += TimeOfChill * i;
        }

        var totalTimeOfRace = (distance / Speed + 1)+TotalChill;

        return totalTimeOfRace;
    }
}