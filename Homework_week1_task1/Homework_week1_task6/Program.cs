using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_week1_task6
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance;
            double liters;
            double money;
            string line;

            Console.Write("Give me distance: ");
            line = Console.ReadLine();

            double.TryParse(line, out distance);

            liters = distance / 100 * 7.02;
            money = liters * 1.595;

            Console.Write("Comsumes {0} liter of casolines and would cost {1} euro.", liters,money);
            Console.Read();







        }
    }
}
