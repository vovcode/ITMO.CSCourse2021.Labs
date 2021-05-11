using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.Ex1
{
    class Greeter
    {
        static void Main(string[] args)
        {
            string myName;
            Console.WriteLine("Please enter your name");
            myName = Console.ReadLine();
            Console.WriteLine("Hello, {0}", myName + "!");//Немножко проявил креативность :)
            Console.ReadKey();
        }
    }
}