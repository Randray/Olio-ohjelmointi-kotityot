using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week2_lab2_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            string line;

            Console.WriteLine("How many rows you want? ");
           line = Console.ReadLine();
            int.TryParse(line, out number);

            for ( int row=0 ; row < number; row++)
            {
                for (int column = 0; column < row + 1; column++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();


            }
        }
    }
}

    