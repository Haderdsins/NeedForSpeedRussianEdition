namespace NeedForSpeed.Visions

{
    public class Loading
    {
        public static void Start()
        {
            Console.Clear();
            Console.WriteLine($"Need For Speed Russian Edition");
            Thread.Sleep(2000);
            Console.WriteLine($"   By Maxytko Corporation");
            
            Thread.Sleep(2000);
            
            
            for (int i = 0; i < 30; i++)
            {
                
                char[] spinner = { '|', '/', '-', '\\' };
                char currentSpinner = spinner[i % spinner.Length];

                
                
                Console.Write($"Загрузка... {currentSpinner}\r");

                
                Thread.Sleep(100);
            }

            // Очищаем строку после завершения анимации
            Console.WriteLine("Загрузка завершена!");
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}