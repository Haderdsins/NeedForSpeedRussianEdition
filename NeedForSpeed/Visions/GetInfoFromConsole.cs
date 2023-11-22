using NeedForSpeed.Models;

namespace NeedForSpeed.Visions;

public static partial  class Menu
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
            Console.WriteLine("Введите дистанцию гонки:");
            isParseDistanceValid = int.TryParse(Console.ReadLine(), out distance);
            if (!isParseDistanceValid)
            {
                Console.WriteLine("Неверно указана дистанция!");
            }
        } while (!isParseDistanceValid);

        return distance;
    }
}