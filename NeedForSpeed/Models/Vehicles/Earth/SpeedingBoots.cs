using NeedForSpeed.Models.Abstracts;

namespace NeedForSpeed.Models.Vehicles.Earth;

public class SpeedingBoots: EarthVehicle
{
    public SpeedingBoots()
    {
        Name = "Vans Mn Range Exp Hi Максима";
        Speed = 1000;
        TimeOfMoveToChill = 10; // время движения до необходимого отдыха
        TimeOfChill = 400;      // длительность отдыха, которая зависит от порядкового номера остановки
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