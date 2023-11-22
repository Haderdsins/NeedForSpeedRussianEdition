using NeedForSpeed.Models.Abstracts;
using NeedForSpeed.Models.Vehicles.Earth;

namespace NeedForSpeed.Visions;

public partial class Menu
{
    private static void DisplayAvailableVehicles(IReadOnlyList<Vehicle> vehicles)
    {
        Console.Clear();
        Console.WriteLine("————————————————————————");
        Console.WriteLine("Выбирай тачки для заезда:");
        for (var i = 0; i < vehicles.Count; i++)
        {
            Console.WriteLine($"{i}. {vehicles[i].Name}");
        }

        Console.WriteLine("Для начала гонки введи: ready");
        Console.WriteLine("————————————————————————");
    }

    private static List<EarthVehicle> InitGroundVehicles()
    {
        return new List<EarthVehicle>
        {
            new Centaur(),
            new HutOnChickenLegs(),
            new PumpkinCarriage(),
            new SpeedingBoots()
        };
    }
}