using System;

namespace NeedForSpeed.Visions
{
    public class Logo
    {
        public static void PrintLogo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  _   _     ______    _____ ");
            Thread.Sleep(150);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" | \\ | |  |  ____|  / ____| ");
            Thread.Sleep(150);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" |  \\| |  | |___   | (___ ");
            Thread.Sleep(150);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" | . ` |   |  ___|   \\___ \\");
            Thread.Sleep(150);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" | |\\  |  | |       ____) | ");
            Thread.Sleep(150);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" |_| \\_|  |_|      |_____/ ");
            Thread.Sleep(150);

            Console.ResetColor(); // Сброс цвета на стандартный
            Console.WriteLine("      Russian Edition");
        }
    }
}