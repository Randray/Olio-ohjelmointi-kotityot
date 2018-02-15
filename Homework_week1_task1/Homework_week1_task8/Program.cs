using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week1_task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            string line;


            Console.Write("Give me nro: ");
            line = Console.ReadLine();

            int.TryParse(line, out n1);

            Console.Write("Give me second nro: ");
            line = Console.ReadLine();

            int.TryParse(line, out n2);

            Console.Write("Give me thrid nro: ");
            line = Console.ReadLine();

            int.TryParse(line, out n3);



            if (n1>n2 && n1>n3)
            {
                Console.WriteLine("Number is the biggest: " +n1);
            }
            else if (n2>n1 && n2>n3)
            {
                Console.WriteLine("Number is the biggest: " + n2);
            }
            else if (n3 > n1 && n3 > n2)
            {
                Console.WriteLine("Number is the biggest: " + n3);
            }

            Console.Read();


        }
    }
}
