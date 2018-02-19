using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworl_week2_lab2_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = new List<string>();
            
            int howm=0;


            while (howm < 5)
            {
                Console.Write("Give me a ´number:");
                numbers.Add(Console.ReadLine());


                howm++;




            }

            numbers.Reverse();

            Console.Write("Here are the numbers in reverse: ");

            foreach (string number in numbers)
            {
                Console.Write(number);
            }


            Console.Read();


        }
    }
}
