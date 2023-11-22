using NeedForSpeed.Models.Abstracts;
using NeedForSpeed.Visions;

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
        Thread.Sleep(500);
        Console.WriteLine(" steady ");
        Thread.Sleep(500);
        Console.WriteLine("  GOOOOOOOOOOOO!");
        Thread.Sleep(1500);
        Console.Clear();
        TextPrinter.TypewriterLine("Старт гонки, победителю всё, проигравшему ничего...");
        RaceAnimation.AnimateRace(_distance, _vehicles);
        //Console.WriteLine("————————————————————————");
        var raceResult = _vehicles.OrderBy(vehicle =>
        {
            var timeResult = vehicle.Go(_distance);
            
            TextPrinter.Typewriter($"{vehicle.Name}: ");
            Thread.Sleep(500);
            Console.WriteLine($"{timeResult} секунд");
            Thread.Sleep(500);
            return timeResult;
            
        });
        Console.WriteLine("////////////////////////");

        var winner = raceResult.First();
        Result(winner);
        Thread.Sleep(1000);
        Console.WriteLine("Нажмите любую клавишу для выхода в главное меню...");
        Console.ReadKey();
        Console.Clear();
        Logo.PrintLogo();
        Menu.Start(); ;
    }

    private static void Result(Vehicle winner)
    {
        Console.WriteLine("————————————————————————");
        Thread.Sleep(1000);
        Console.Write($"Чемпион гонки: ");
        Thread.Sleep(1500);
        TextPrinter.TypewriterLine($"{winner.Name}");
        Console.WriteLine("————————————————————————");
        Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");

    }
}