namespace NeedForSpeed.Visions;

public class TextPrinter
{
    public static void Typewriter(string words)
    {
        foreach (char letter in words)
        {
            Console.Write(letter);
            Thread.Sleep(100); // Измените задержку, если нужно
        }
    }
    public static void TypewriterLine(string words)
    {
        foreach (char letter in words)
        {
            Console.Write(letter);
            Thread.Sleep(100); // Измените задержку, если нужно
        }
        Console.WriteLine("");
    }
}