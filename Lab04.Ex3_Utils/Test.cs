namespace Utils
{
    using System;

    /// <summary>
    ///   This is the test harness
    /// </summary>

    public class Test
    {
        public static void Main()
        {
            int x;// Значение первого вводимого числа
            int y;// Значение первого вводимого числа
            int greater;// Результат из метода Greater()

            Console.WriteLine("Enter the first integer:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second integer:");
            y = int.Parse(Console.ReadLine());
            greater = Utils.Greater(x, y);

            Console.WriteLine("The greater value is " + greater);
            Console.ReadKey();


            // Проверка работы метода Swap()
            Console.WriteLine("Before swap: " + x + "," + y);

            Utils.Swap(ref x, ref y);
            Console.WriteLine("After swap: " + x + "," + y);
            Console.ReadKey(); // Для удобства проверки вывода

            // Все что ниже относится к Упражнение 3

            int f; // Factorial result
            bool ok; // Factorial success or failure

            Console.WriteLine("Number for factorial:");
            x = int.Parse(Console.ReadLine());

            // Test the factorial function
            ok = Utils.Factorial(x, out f);
            // Output factorial results
            if (ok)
                Console.WriteLine("Factorial(" + x + ") = " + f);
            else
                Console.WriteLine("Cannot compute this factorial");
            Console.ReadKey();
        }
    }
}
