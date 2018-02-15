using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week1_task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string line;

            Console.Write("Give me your test ponts: ");
            line = Console.ReadLine();

            int.TryParse(line, out age);


            if (age < 18)
            {
                Console.WriteLine("Under age");
            }
            else if (age >= 18 && age <= 65 )
            {
                Console.WriteLine("Adult");
            }
            else if ( age > 65)
            {
                Console.WriteLine("Senior");
            }
        }
    }
}
