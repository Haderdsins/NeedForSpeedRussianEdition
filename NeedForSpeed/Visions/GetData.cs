using NeedForSpeed.Models.Abstracts;
using NeedForSpeed.Models.Vehicles.Earth;

namespace NeedForSpeed.Visions;

public partial class Menu
{
    private static void DisplayAvailableVehicles(IReadOnlyList<Vehicle> vehicles)
    {
        Console.WriteLine("------------------------");
        Console.WriteLine("Доступные ТС для заезда:");
        for (var i = 0; i < vehicles.Count; i++)
        {
            Console.WriteLine($"{i}. {vehicles[i].Name}");
        }

        Console.WriteLine("Для начала гонки введите: поехали");
        Console.WriteLine("------------------------");
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