using NeedForSpeed.Models.Abstracts;

namespace NeedForSpeed.Models;

public class Race
{
    private readonly List<Vehicle> _vehicles;
    private readonly int _distance;

    public Race(IEnumerable<Vehicle> vehicles, int distance)
    {
        _vehicles = new List<Vehicle>(vehicles);
        _distance = distance;
    }

    public void Simulate()
    {
        Console.WriteLine("------------------------");
        var raceResult = _vehicles.OrderBy(vehicle =>
        {
            var timeResult = vehicle.Go(_distance);
            Console.WriteLine($"{vehicle.Name}: {timeResult} секунд");
            return timeResult;
        });
        Console.WriteLine("------------------------");

        var winner = raceResult.First();
        Result(winner);
    }

    private static void Result(Vehicle winner)
    {
        Console.WriteLine("------------------------");
        Console.WriteLine($"Победитель: {winner.Name}");
        Console.WriteLine("------------------------");
    }
}