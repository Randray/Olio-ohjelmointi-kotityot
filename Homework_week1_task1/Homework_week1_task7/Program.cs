using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week1_task7
{
    class Program
    {
        static void Main(string[] args)
        {

            string line;
            int y;


            Console.Write("Give me seconds: ");
            line = Console.ReadLine();

            int.TryParse(line, out y);








            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))

            {

                Console.WriteLine("{0} is a Leap Year", y);

            }

            else

            {

                Console.WriteLine("{0} is not a Leap Year", y);

            }

            Console.ReadLine();
        }
    }
}
