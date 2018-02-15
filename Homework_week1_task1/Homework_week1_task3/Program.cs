using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week1_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1=0;
            int n2=0;
            int n3=0;
            float sum=0;
            float avr=0;
            string line;


            Console.Write("Give me nro: ");
            line = Console.ReadLine();

            int.TryParse(line, out n1 );

            Console.Write("Give me second nro: ");
            line = Console.ReadLine();

            int.TryParse(line, out n2);

            Console.Write("Give me thrid nro: ");
            line = Console.ReadLine();

            int.TryParse(line, out n3);


            sum = n1 + n2 + n3;

            avr = sum/3;

            Console.WriteLine("You number sum is {0} and average is {1} ",sum ,avr);
            Console.Read();






        }
    }
}
