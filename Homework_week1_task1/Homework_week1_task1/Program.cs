using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week1_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string line;

            Console.Write("Give number (1-3): ");
            line = Console.ReadLine();

            int.TryParse(line, out number);


            if (number == 1)
            {
                Console.WriteLine("Number is one");
            }
            else if (number == 2)
            {
                Console.WriteLine("Number is two");
            }
            else if (number == 3)
            {
                Console.WriteLine("Number is three");
            }
            else
            {
                Console.WriteLine("Unknow command");

            }
            Console.Read();
        }
    }
}
