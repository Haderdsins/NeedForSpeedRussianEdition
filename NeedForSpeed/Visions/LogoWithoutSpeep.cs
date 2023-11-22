using System;

namespace NeedForSpeed.Visions
{
    public class LogoWithoutSleep
    {
        public static void PrintLogo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  _   _     ______    _____ ");
            

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" | \\ | |  |  ____|  / ____| ");
            

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" |  \\| |  | |___   | (___ ");
            

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" | . ` |   |  ___|   \\___ \\");
            

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" | |\\  |  | |       ____) | ");
            

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" |_| \\_|  |_|      |_____/ ");
            

            Console.ResetColor(); // Сброс цвета на стандартный
            
        }
    }
}