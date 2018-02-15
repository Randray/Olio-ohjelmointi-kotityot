using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week1_task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalseconds=0;
            int hours = totalseconds / 3600;
            int min = (totalseconds % 3600) / 60;
            int sec = (totalseconds % 3600) % 60; 
            string line;

            Console.Write("Give me seconds: ");
            line = Console.ReadLine();

            int.TryParse(line, out totalseconds);

           
            Console.WriteLine("That was {0} hours {1} minutes {2} seconds", hours,min,sec);
            Console.Read();

        }
    }
}
