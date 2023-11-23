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
            Console.ForegroundColor = ConsoleColor.Cyan;
            TextPrinter.Typewriter($"{vehicle.Name}: ");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{timeResult} секунд");
            Thread.Sleep(500);
            Console.ResetColor();
            return timeResult;
            
        });
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("////////////////////////");
        Console.ResetColor();

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
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"Чемпион гонки: ");
        Thread.Sleep(1500);
        Console.ForegroundColor = ConsoleColor.Yellow;
        TextPrinter.TypewriterLine($"{winner.Name}");
        Console.ResetColor();
        Console.WriteLine("————————————————————————");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
        Console.ResetColor();

    }
}