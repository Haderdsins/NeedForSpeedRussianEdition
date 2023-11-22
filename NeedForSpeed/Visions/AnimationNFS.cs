using System;
using System.Threading;

namespace NeedForSpeed.Visions
{
    public class AnimationNFS
    {
        public static void Animation()
        {
            Console.WriteLine("Гонка началась!");

            int trackLength = 30; // Длина трассы
            int car1Position = 0; // Позиция первой машинки
            int car2Position = 0; // Позиция второй машинки

            // Времена за один шаг для каждой машины (в миллисекундах)
            int car1StepTime = 200;
            int car2StepTime = 1200;

            // Основной цикл гонки
            while (car1Position < trackLength && car2Position < trackLength)
            {
                // Движение первой машинки
                car1Position += 1;

                // Движение второй машинки
                car2Position += 1;

                // Очищаем консоль перед каждым новым шагом
                Console.Clear();

                // Выводим трассу с машинками
                DrawTrack(trackLength, car1Position, car2Position);

                // Задержка перед следующим шагом
                Thread.Sleep(Math.Min(car1StepTime, car2StepTime));
            }

            // Определение победителя и вывод результата
            string winner = car1Position >= trackLength ? "1" : "2";
            Console.WriteLine($"Победитель: {winner}");
        }

        static void DrawTrack(int trackLength, int car1Position, int car2Position)
        {
            // Выводим трассу с машинками
            for (int i = 0; i < trackLength; i++)
            {
                if (i == car1Position)
                    Console.Write("1"); // Машинка 1
                else
                    Console.Write("-"); // Дорога
            }

            Console.WriteLine(); // Переход на новую строку для второй машинки

            for (int i = 0; i < trackLength; i++)
            {
                if (i == car2Position)
                    Console.Write("2"); // Машинка 2
                else
                    Console.Write("-"); // Дорога
            }

            Console.WriteLine(); // Переход на новую строку
        }
    }
}
