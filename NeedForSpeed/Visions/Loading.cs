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
            // Задержка перед началом анимации
            Thread.Sleep(2000);
            
            // Основной цикл анимации
            for (int i = 0; i < 30; i++)
            {
                // Используйте модуль для определения символа для вывода
                char[] spinner = { '|', '/', '-', '\\' };
                char currentSpinner = spinner[i % spinner.Length];

                // Выводим символ и возвращаем каретку
                
                Console.Write($"Загрузка... {currentSpinner}\r");

                // Задержка между итерациями для создания эффекта анимации
                Thread.Sleep(100);
            }

            // Очищаем строку после завершения анимации
            Console.WriteLine("Загрузка завершена!");
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}