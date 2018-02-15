using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week1_task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            string line;
            int sum = 0;

            do
            {
                Console.Write("Give me nro: ");
                line = Console.ReadLine();
                int.TryParse(line, out n);

                sum += n;


            } while (n != 0);

            Console.WriteLine("Sum is "+sum);

            Console.Read();

        }
    }
}
