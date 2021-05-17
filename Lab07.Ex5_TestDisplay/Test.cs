using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07.Ex5_TestDisplay
{
    /// <summary>
    ///   This the test harness
    /// </summary>

    public class Test
    {
        static void Main()
        {
            int num = 65;
            string msg = "A String";
            Coordinate c = new Coordinate(21.0, 68.0);

            Utils.Display(num);
            Utils.Display(msg);
            Utils.Display(c);

            Console.ReadLine();// Для удобства проверки
        }
    }

}


