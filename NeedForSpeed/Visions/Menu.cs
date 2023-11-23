using NeedForSpeed.Models;
using NeedForSpeed.Models.Abstracts;
using NeedForSpeed.Models.Vehicles.Earth;


namespace NeedForSpeed.Visions;

public static partial class Menu
{
    private static int GetRaceTypeFromConsole()
    {
        int raceType;
        bool isRaceTypeValid;
        do
        {
            Console.Clear();
            Console.WriteLine("На чем сегодня погоняешь? (цифру):\n   1) Тачки отечественные\n           Самолеты забугорные (2\n3) Я псих, обгоню самолет на велосипеде");
            isRaceTypeValid = int.TryParse(Console.ReadLine(), out raceType);
            //TODO сделать ошибку если выбираешь неправильно при этом выбрать все равно будет можно
            if (!Enum.IsDefined(typeof(RaceEnum), raceType) || !isRaceTypeValid)
            {
                isRaceTypeValid = false;
                Console.WriteLine("Такую гонку еще не завезли, дружище, заходи позже!");
            }
        } while (!isRaceTypeValid);

        return raceType;
    }
    
    private static int GetDistanceFromConsole()
    {
        int distance;
        bool isParseDistanceValid;

        do
        {
            Console.Clear();
            Console.WriteLine("Сколько метров будем ехать:");
            isParseDistanceValid = int.TryParse(Console.ReadLine(), out distance);
            if (!isParseDistanceValid)
            {
                Console.WriteLine("Эээ гонщик остынь ты столько не проедешь!");
            }
        } while (!isParseDistanceValid);

        return distance;
    }
    
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
}