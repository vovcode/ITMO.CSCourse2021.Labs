using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07.Ex3__CopyFileUpper
{
    class CopyFileUpper
    {
        static void Main()
        {
            string sFrom, sTo;
            StreamReader srFrom;
            StreamWriter swTo;

            // Prompt for input file name
            Console.Write("Copy from:");
            sFrom = Console.ReadLine();

            // Prompt for output file name
            Console.Write("Copy to:");
            sTo = Console.ReadLine();

            Console.WriteLine("Copy from {0} to {1}", sFrom, sTo);
            try
            {
                srFrom = new StreamReader(sFrom);
                swTo = new StreamWriter(sTo);

                while (srFrom.Peek() != -1)
                {
                    string sBuffer = srFrom.ReadLine();
                    sBuffer = sBuffer.ToUpper();
                    swTo.WriteLine(sBuffer);
                }
                swTo.Close();
                srFrom.Close();

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Input file not found");
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception");
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();

            //Результатом выполнения программы в случае отсутствия ошибок является создание файла в папке нахождения Lab07.Ex3_ CopyFileUpper.exe.
            //Файл имеет указанное пользователем имя и формат. Содержимым выходного (нового) файла является содержимое файла, путь к которому был указан, переведенное в верхний регистр.
        }
    }

}
