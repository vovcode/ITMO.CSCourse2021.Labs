using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07.Ex2_Utils
{
    public class Test
    {
        public static void Main()
        {
            string message;

            // Get an input string
            Console.WriteLine("Enter string to reverse:");
            message = Console.ReadLine();

            // Reverse the string
            Utils.Reverse(ref message);

            // Display the result
            Console.WriteLine(message);

            Console.ReadLine(); //Для удобства проверки

        }
    }

}
