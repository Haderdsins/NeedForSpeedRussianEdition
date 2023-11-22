using NeedForSpeed.Models.Abstracts;

namespace NeedForSpeed.Models.Vehicles.Earth;

public class Centaur: EarthVehicle
{
    public Centaur()
    {
        Name = "Кентавр";
        Speed = 10;
        TimeOfMoveToChill = 2;// время движения до необходимого отдыха
        TimeOfChill = 4;// длительность отдыха, которая зависит от порядкового номера остановки
    }
    // TODO сделать просчеты для всех наземных разными
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
