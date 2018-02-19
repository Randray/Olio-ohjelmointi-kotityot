using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week2_lab2_task3
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> points = new List<int>();
            string line;
            int n;

            int howm = 0;


            while (howm < 5)
            {
                Console.Write("Give me a ´number:");
                line = Console.ReadLine();
                int.TryParse(line, out n);
                points.Add(n);
                howm++;


            }

            points.Remove(points.Max());
            points.Remove(points.Min());

            Console.WriteLine("Here is the score: " + points.Sum());


            Console.Read();


        }
    }
}
