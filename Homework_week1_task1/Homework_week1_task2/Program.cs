using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week1_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string line;

            Console.Write("Give me your test ponts: ");
            line = Console.ReadLine();

            int.TryParse(line, out number);


            if (number >= 0 && number <=1)
            {
                Console.WriteLine("School number: 0");
            }
            else if (number >=2  && number <= 3)
            {
                Console.WriteLine("School number: 1");
            }
            else if (number >= 4 && number <= 5)
            {
                Console.WriteLine("School number: 2");
            }
            else if (number >= 6 && number <= 7)
            {
                Console.WriteLine("School number: 3");
            }
            else if (number >= 8 && number <= 9)
            {
                Console.WriteLine("School number: 4");
            }
            else if (number >= 10 && number <= 12)
            {
                Console.WriteLine("School number: 5");
            }
            else
            {
                Console.WriteLine("Unknow command");

            }
            Console.Read();











        }
    }
}
