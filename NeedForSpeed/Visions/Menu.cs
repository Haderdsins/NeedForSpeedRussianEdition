using NeedForSpeed.Models;
using NeedForSpeed.Models.Abstracts;


namespace NeedForSpeed.Visions;

public static partial class Menu
{
    public static void Start()
    {
        
        Console.WriteLine("Добро пожаловать в NeedForSpeed RE!");
        Thread.Sleep(1000);
        Console.WriteLine("");
        Console.WriteLine("В игре ты можешь гонять без всяких правил,\nно в жизни будь внимателен на дороге...");
        Thread.Sleep(1000);
        Console.WriteLine("");
        Console.WriteLine("Нажмите любую клавишу для продолжения...");
        Console.ReadKey();
        var raceType = GetRaceTypeFromConsole();
        
        var distance = GetDistanceFromConsole();

        var vehicles = raceType switch
        {
            1 => PrepareToStartGroundRace(),
            2 => PrepareStartAirRace(),
            3 => PrepareStartCommonRace(),
            _ => throw new ArgumentException("Тип гонки не найден!")
        };

        var race = new Race(vehicles, distance);
        race.Simulate();
    }

    private static IEnumerable<EarthVehicle> PrepareToStartGroundRace()
    {
        var vehicles = new List<EarthVehicle>();
        var freeVehicles = InitGroundVehicles();

        while (true)
        {
            freeVehicles = freeVehicles
                .Except(vehicles.Select(x => x))
                .ToList();

            bool isInputValid;
            do
            {
                DisplayAvailableVehicles(freeVehicles);

                Console.WriteLine("Введи номер тачки, чтобы пригласить его в гонку:");
                var input = Console.ReadLine();
                if (input?.ToLower() is "ready")
                {

                    if (vehicles.Count is not 0)
                    {
                        return vehicles;
                    }
                    Console.Clear();
                    Console.WriteLine("Ты че, серезно? Гонка без тачек это не гонка, это анекдот!");
                    TextPrinter.TypewriterLine("В Африке, если человек на 80% состоит из воды, то считается, что он из благополучной семьи.");
                    Thread.Sleep(2000);
                    isInputValid = false;
                    continue;
                }

                isInputValid = int.TryParse(input, out var vehicleIndex);

                if (isInputValid && vehicleIndex < freeVehicles.Count)
                {
                    vehicles.Add(freeVehicles[vehicleIndex]);
                    freeVehicles.RemoveAt(vehicleIndex);
                }
                else
                {
                    isInputValid = false;
                    Console.WriteLine("Данный ТС не найден!");
                }

                if (freeVehicles.Count is 0)
                {
                    return vehicles;
                }
            } while (!isInputValid);
        }
    }

    private static IEnumerable<AirVehicle> PrepareStartAirRace()
    {
        throw new NotImplementedException();
    }

    private static IEnumerable<Vehicle> PrepareStartCommonRace()
    {
        throw new NotImplementedException();
    }
}