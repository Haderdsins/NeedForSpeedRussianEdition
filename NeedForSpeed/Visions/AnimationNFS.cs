using System;
using System.Threading;
using NeedForSpeed.Models.Abstracts;

namespace NeedForSpeed.Visions
{
    public static class RaceAnimation
    {
        public static void AnimateRace(int trackLength, List<Vehicle> vehicles)
        {
            int countOfCars = vehicles.Count;
            int[] carPositions = new int[countOfCars];
            int[] carSpeeds = new int[countOfCars];
            int[] carTimes = new int[countOfCars];
            Random random = new Random();

            // Инициализируем начальные позиции машин
            for (int i = 0; i < countOfCars; i++)
            {
                carPositions[i] = 0;
                carSpeeds[i] = random.Next(1, 5); // Скорость от 1 до 4
            }

            // Визуализация гонки
            while (true)
            {
                Console.Clear();
                DrawTrack(trackLength, carPositions);
                //LogoWithoutSleep.PrintLogo();

                // Обновляем позиции машин
                for (int i = 0; i < countOfCars; i++)
                {
                    carPositions[i] += carSpeeds[i];
                    carTimes[i]++;

                    // Проверяем, достигла ли машина финиша
                    if (carPositions[i] >= trackLength)
                    {
                        return;
                    }
                }

                Thread.Sleep(10); // Задержка для анимации
            }
        }

        private static void DrawTrack(int trackLength, int[] carPositions)
        {
            for (int i = 0; i < carPositions.Length; i++)
            {
                for (int j = 0; j < trackLength; j++)
                {
                    if (j == carPositions[i])
                        Console.Write((i + 1).ToString()); // Номер машины
                    else
                        Console.Write("-"); // Дорога
                }
                Console.WriteLine(); // Переход на новую строку для следующей машины
            }
        }
    }
}
