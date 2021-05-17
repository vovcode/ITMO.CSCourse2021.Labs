using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07.Ex4_InterfaceTest
{
    /// <summary>
    ///   This the test harness
    /// </summary>

    public class Test
    {
        static void Main()
        {
            int i = 0;
            ulong ul = 0;
            string s = "Test";

            Console.WriteLine("int: {0}", Utils.IsItFormattable(i));
            Console.WriteLine("ulong: {0}", Utils.IsItFormattable(ul));
            Console.WriteLine("String: {0}", Utils.IsItFormattable(s));

            Console.ReadLine(); // Для удобства проверки
        }
        
    }
   

}
